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

        public CL_EM_User()
        {

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
    }
}
