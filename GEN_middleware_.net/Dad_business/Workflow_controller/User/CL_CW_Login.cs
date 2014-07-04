using Business.Job_component;
using Business.Mapping;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Workflow_controller.User
{
    public class CL_CW_Login:I_CW
    {
        private STG msg;
        public STG exec(STG msg)
        {
            this.msg = msg;
            CL_CM_User cmUser = new CL_CM_User();
            string token = cmUser.login((string)this.msg.data[0][0], (string)this.msg.data[0][1]);
            if (token != null)
            {
                this.msg.statut_op = true;
                this.msg.tokenUser = token;
            }
            else
            {
                this.msg.statut_op = false;
            }
            return this.msg;
        }
    }
}
