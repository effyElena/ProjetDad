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
        public CL_CM_File()
        {

        }

        public void appelJ2ee(FILE file, StringBuilder tempFile, string tempString)
        {
            CL_CM_J2ee cmJ2ee = new CL_CM_J2ee();
           // string result = await cmJ2ee.sendFileJ2ee(file.file_name, tempFile.ToString(), tempString);
           
        }

        public void decrypt(FILE file){
             //int cle = 99999;
            int cle = 65000;
            string content = file.content;

            Parallel.For(64000, cle, i =>{
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

                //appel j2ee nom, content, cle,         nom du thread,  (besoin de l'id user pour le retour du j2ee dans stop decrypt)

            
                CL_CM_J2ee cmJ2ee = new CL_CM_J2ee();
                string result = cmJ2ee.sendFileJ2ee(file.file_name, Encoding.UTF8.GetBytes(tempFile.ToString()), tempString);



            //}
            });

            Console.WriteLine();
        }

        public void decrypt2(string f){
            String fi = f;
            FileInfo info = new FileInfo(fi);


            String subdir = Path.Combine(info.DirectoryName + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(info.Name));
            Console.WriteLine(subdir);
            if (!System.IO.Directory.Exists(subdir))
                System.IO.Directory.CreateDirectory(subdir);

            Console.WriteLine(Path.GetFileNameWithoutExtension(info.Name) + ": " + info.Extension);

            StreamReader file = new StreamReader(fi);
            String content = file.ReadToEnd();
            Console.WriteLine(content);

            file.Close();

            int cle = 99999;

            List<Char> printableChars = new List<char>();
            for (int i = 33; i <= 126; i++)
            {
                char c = Convert.ToChar(i);
                if (!char.IsControl(c))
                {
                    printableChars.Add(c);
                }
            }

            int length = 3;
            char[] tempString = new char[length];
            char[] repertoire = new char[length];
            Recursive(length, printableChars, repertoire, subdir, content, tempString);
            Console.WriteLine(@"c'est finit!!!");
            //Parallel.For(0, 4, i =>
            //{
        }

        private static void Recursive(int length, List<Char> carac, char[] repertoire, string subdir, string content, char[] tempString)
        {
            if (length > 1)
            {
                length--;
                foreach (char c in carac)
                {
                    repertoire[length] = c;
                    tempString[length] = c;

                    Recursive(length, carac, repertoire, subdir, content, tempString);

                    String file = "";
                    for (int i = repertoire.Length - 1; i >= 0; i--)
                    {
                        if (file == "")
                        {
                            file = (Convert.ToInt32(repertoire[i])).ToString();
                        }
                        else
                        {
                            file = (Convert.ToInt32(repertoire[i])).ToString() + "," + file;
                        }
                    }

                    StreamWriter file1 = new StreamWriter(subdir + Path.DirectorySeparatorChar + file + ".txt");
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

                    file1.Write(tempFile);
                    file1.Close();

                }

                Array.Resize(ref repertoire, repertoire.Length - 1);
                Array.Resize(ref tempString, tempString.Length - 1);
                Recursive(length, carac, repertoire, subdir, content, tempString);

            }
            else if (length == 1)
            {
                length--;
                foreach (char c in carac)
                {
                    repertoire[length] = c;
                    tempString[length] = c;

                    String file = "";
                    for (int i = repertoire.Length - 1; i >= 0; i--)
                    {
                        if (file == "")
                        {
                            file = (Convert.ToInt32(repertoire[i])).ToString();
                        }
                        else
                        {
                            file = (Convert.ToInt32(repertoire[i])).ToString() + "," + file;
                        }
                    }

                    StreamWriter file1 = new StreamWriter(subdir + Path.DirectorySeparatorChar + file + ".txt");
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

                    file1.Write(tempFile);
                    file1.Close();
                }
            }


        }

        
    }
}
