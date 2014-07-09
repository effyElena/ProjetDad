using Business.Job_component;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workflow_controller.User
{
    public class CL_CW_Refresh:I_CW
    {
        private STG msg;
        private CL_CM_User cmUser;

        public STG exec(STG msg)
        {
            this.cmUser = new CL_CM_User();
            this.msg = msg;

            for (int i = 0; i < this.msg.data[0].Length; i++)
            {
                if(this.msg.data[0][i]!=null){
                    this.msg.data[0][i] = this.cmUser.refresh((FILE)this.msg.data[0][i], this.msg.userId);
                }
            }

            return this.msg;
        }
    }
}
