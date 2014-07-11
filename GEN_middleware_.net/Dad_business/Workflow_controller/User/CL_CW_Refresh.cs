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
                if(this.msg.data[0][i]!=null ){
                    FILE file = (FILE)this.msg.data[0][i];
                    if(file.state != 4){
                        this.msg.data[0][i] = this.cmUser.refresh(file, this.msg.userId);
                    }
                }
            }

            return this.msg;
        }
    }
}
