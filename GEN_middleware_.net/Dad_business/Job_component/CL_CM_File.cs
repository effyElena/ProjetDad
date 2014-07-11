using Business.Mapping;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Job_component
{
    public class CL_CM_File
    {
        private CL_EM_File emFile;

        public CL_CM_File()
        {
            this.emFile = new CL_EM_File();
        }

        public void updateFile(FILE file, int userId)
        {
            this.emFile.updateFile(file.file_name, file.file_email, file.file_url, file.file_code, userId);
        }

        public void saveFile(FILE file, int userId)
        {
            this.emFile.insertFile(file.file_name, 0, userId);
        }

        private void startThread(FILE file)
        {
            int cle = 99999;
            string content = file.content;

            Parallel.For(0, cle, i =>
            {
                //for (int i = 0; i < 99999; i++){
                String tempString = Convert.ToString(i);
                StringBuilder tempFile = new StringBuilder();

                int ind = 0;
                for (int j = 0; j < content.Length; j++)
                {
                    tempFile.Append(Convert.ToChar((uint)content[j] ^ (uint)tempString[ind]));
                    ind++;
                    if (ind == tempString.Length)
                    {
                        ind = 0;
                    }
                }

                int id = Thread.CurrentThread.ManagedThreadId;

                //appel j2ee nom, content, cle, nom du thread, (besoin de l'id user pour le retour du j2ee dans stop decrypt)
                CL_CM_J2ee cmJ2ee = new CL_CM_J2ee();
                string result = cmJ2ee.sendFileJ2ee(file.file_name, Encoding.UTF8.GetBytes(tempFile.ToString()), tempString);

                //}
            });

        }

        public void decrypt(FILE file){
            Thread t1 = new Thread(() => startThread(file));
            t1.Start();

            //Thread t2 = new Thread(() => decrypt2(file));
            //t2.Start();
        }

        public void decrypt2(FILE file){
            List<Char> printableChars = new List<char>();
            for (int i = 33; i <= 126; i++)
            {
                char c = Convert.ToChar(i);
                if (!char.IsControl(c))
                {
                    printableChars.Add(c);
                }
            }

            string content = file.content;



            foreach (char c in printableChars)
            {
                foreach (char d in printableChars)
                {
                    foreach (char e in printableChars)
                    {
                        foreach (char f in printableChars)
                        {
                            Parallel.ForEach(printableChars, g =>
                            {
                                string cle = c.ToString() + d.ToString() + e.ToString() + f.ToString() + g.ToString();

                                //for (int i = 0; i < 99999; i++){
                                String tempString = cle;
                                StringBuilder tempFile = new StringBuilder();

                                int ind = 0;
                                for (int j = 0; j < content.Length; j++)
                                {
                                    tempFile.Append(Convert.ToChar((uint)content[j] ^ (uint)tempString[ind]));
                                    ind++;
                                    if (ind == tempString.Length)
                                    {
                                        ind = 0;
                                    }
                                }

                                int id = Thread.CurrentThread.ManagedThreadId;

                                //appel j2ee nom, content, cle, nom du thread, (besoin de l'id user pour le retour du j2ee dans stop decrypt)
                                CL_CM_J2ee cmJ2ee = new CL_CM_J2ee();
                                string result = cmJ2ee.sendFileJ2ee(file.file_name, Encoding.UTF8.GetBytes(tempFile.ToString()), tempString);

                                //}


                            });
                        }
                    }
                }
            }






        }

        
    }
}
