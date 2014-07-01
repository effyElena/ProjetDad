using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEN_client.Business.CUP
{
    public class CL_CUP_Identity
    {
        public bool login(string login, string password)
        {
            string login1 = "caca";
            string password1 = "prout";

            if (login1 == login && password1 == password)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }
    }
}
