using Business.Job_component;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workflow_controller.User
{
    public class CL_CW_HistoFile : I_CW
    {
        private STG msg;
        private CL_CM_User cmUser;
        public STG exec(STG msg)
        {
            this.cmUser = new CL_CM_User();
            this.msg = msg;

            this.msg.data = null;
            List<FILE> list = new List<FILE>();

            list = this.cmUser.getHistoFile((int)this.msg.userId);
            this.msg.data = new object[1][];
            this.msg.data[0] = new object[list.Count];

            int i = 0;
            foreach(FILE file in  list){
                this.msg.data[0][i] = file;
                i++;
            }

            return this.msg;
        }
    }
}
