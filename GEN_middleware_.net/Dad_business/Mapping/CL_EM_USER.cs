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
        private CL_CAD cad;

        public CL_EM_User()
        {

        }

        public CL_EM_User getUser(string login, string password)
        {
            this.cad = new CL_CAD();
            object[][] data =  this.cad.executeSql("SELECT AppUser_login, AppUser_email, Type_id FROM AppUser WHERE AppUser_login = '" + login + "' AND AppUser_password = '" + password +"';");
            
            if(data[0] != null){
                this.login = (string)data[0][0];
                this.email = (string)data[0][1];
                this.type = (int)data[0][2];
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
    }
}
