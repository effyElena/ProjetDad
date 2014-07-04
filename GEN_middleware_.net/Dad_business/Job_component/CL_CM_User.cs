using Business.Mapping;
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

        public string login(string login, string password)
        {
            this.emUser = new CL_EM_User();
            this.emUser = this.emUser.getUser(login, password);
            string token = null;

            if(this.emUser.Login != null){
                switch (this.emUser.Type)
                {
                    case 1:
                        token =  "XXXXXXXXXXXXXXXXXADMIN";
                        break;
                    default:
                        token =  null;
                        break;
                }
            }
            return token;

            
        }
    }
}
