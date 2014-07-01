

using Business.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Workflow_controller
{
    public class CL_CW_Auth:I_CW
    {
        private STG msg;
        public STG exec(STG msg)
        {
            return this.msg;
        }
    }
}
