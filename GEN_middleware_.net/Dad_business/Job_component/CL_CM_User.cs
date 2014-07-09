using Business.Mapping;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Job_component
{
    public class CL_CM_User
    {
        private CL_EM_User emUser;

        public CL_CM_User()
        {
            this.emUser = new CL_EM_User();
        }

        public string login(string login, string password)
        {
            this.emUser = this.emUser.getUser(login, password);
            string token = null;

            if(this.emUser.Login != null){
                switch (this.emUser.Type)
                {
                    case 1:
                        token = "XXXXXXXXXXXXXXXXXADMIN";
                        break;
                    default:
                        token =  null;
                        break;
                }
            }
            return token;

            
        }

        public CL_EM_User EmUser
        {
            get { return emUser; }
            set { emUser = value; }
        }

        internal FILE refresh(FILE file, int userId)
        {
            CL_EM_File emFile = this.emUser.getFileByUser(file.file_name, userId);

            file.file_email = emFile.File_email;
            file.file_code = emFile.File_code;
            file.state = emFile.State;
            file.file_date = emFile.File_date;

            

            return file;
        }
    }
}
