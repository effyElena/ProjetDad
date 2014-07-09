using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class CL_EM_User
    {
        private string login;
        private string email;
        private int type;
        private int id;
        private List<CL_EM_File> listFileRun;
        private CL_CAD cad;

        public CL_EM_User()
        {
            this.cad = new CL_CAD();
        }

        internal CL_EM_File getFileByUser(string name, int userId)
        {
            CL_EM_File emFile = new CL_EM_File();
            object[][] data = this.cad.executeSql("SELECT [File_id], [File_name], [File_email], [File_code], [File_url], [File_date], [State] FROM [File] WHERE AppUser_id = '" + userId + "' AND [File_name] = '" + name + "';");

            if (data[0] != null)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != null)
                    {
                        emFile.File_Id = (int)data[i][0];
                        emFile.File_name = (string)data[i][1];
                        if ((int)data[i][6] != 0)
                        {
                            emFile.File_email = (string)data[i][2];
                            emFile.File_code = (string)data[i][3];
                            emFile.File_url = (string)data[i][4];
                            emFile.File_date = (DateTime)data[i][5];
                        }
                        emFile.State = (int)data[i][6];
                    }

                }

            }

            return emFile;
        }

        public CL_EM_User getUser(string login, string password)
        {
            object[][] data =  this.cad.executeSql("SELECT AppUser_login, AppUser_email, Type_id, AppUser_id FROM AppUser WHERE AppUser_login = '" + login + "' AND AppUser_password = '" + password +"';");
            
            if(data[0] != null){
                this.login = (string)data[0][0];
                this.email = (string)data[0][1];
                this.type = (int)data[0][2];
                this.id = (int)data[0][3];
            }

            data = null;
            data = this.cad.executeSql("SELECT [File_id], [File_name], [File_email], [File_code], [File_url], [File_date], [State] FROM [File] WHERE AppUser_id = '" + this.id + "' AND State = 0;");
            
            if (data[0] != null)
            {
                this.listFileRun = new List<CL_EM_File>();

                for (int i = 0; i < data.Length; i++ )
                {
                    if (data[i] != null)
                    {
                        CL_EM_File emFile = new CL_EM_File();
                        emFile.File_Id = (int)data[i][0];
                        emFile.File_name = (string)data[i][1];
                        emFile.State = (int)data[i][6];
                        listFileRun.Add(emFile);
                    }

                }

            }


            return this;
        }

        

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal List<CL_EM_File> ListFileRun
        {
            get { return listFileRun; }
            set { listFileRun = value; }
        }
    }
}
