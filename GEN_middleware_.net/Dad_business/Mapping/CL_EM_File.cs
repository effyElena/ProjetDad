using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    class CL_EM_File
    {
        private string file_name;
        private string file_email;
        private string file_code;
        private int file_Id;
        private string file_url;
        private DateTime file_date;
        private int state;
        private int user_id;
        private CL_CAD cad;

        public CL_EM_File()
        {
            this.cad = new CL_CAD();
        }

        public string File_name
        {
            get { return file_name; }
            set { file_name = value; }
        }

        public void insertFile(string name, int state, int userId)
        {
            object[][] data = this.cad.executeSql("INSERT INTO [ProjetDAD].[dbo].[File] ( [File_name], [File_date], [AppUser_id], [State]) VALUES ( '" + name + "','" + DateTime.Now + "','" + userId + "','" + state + "');");
        }

        public void updateFile(string name, string email, string url, string code, int userId)
        {
            object[][] data = this.cad.executeSql("UPDATE [ProjetDAD].[dbo].[File] SET  [File_email] = '" + email + "', [File_code] = '" + code + "',[File_url] = '" + url + "', [State] = 1 WHERE [File_name] = '" + name + "' ;");
        }

        public int File_Id
        {
            get { return file_Id; }
            set { file_Id = value; }
        }
        public string File_email
        {
            get { return file_email; }
            set { file_email = value; }
        }

        public string File_code
        {
            get { return file_code; }
            set { file_code = value; }
        }

        public string File_url
        {
            get { return file_url; }
            set { file_url = value; }
        }

        public DateTime File_date 
        {
            get { return file_date; }
            set { file_date = value; }
        }

        public int State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
