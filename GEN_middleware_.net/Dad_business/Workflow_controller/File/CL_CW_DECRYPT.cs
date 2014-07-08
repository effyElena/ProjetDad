using Business.Job_component;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workflow_controller.File
{
    public class CL_CW_Decrypt : I_CW
    {
        private STG msg;
        private CL_CM_File cmFile;
        public STG exec(STG msg)
        {
            this.msg = msg;

           // string test = (string) this.msg.data[0][0];

            this.cmFile = new CL_CM_File();

            for (int i = 0; i < this.msg.data[0].Length; i++)
            {
                // thread cmfile
                this.cmFile.decrypt((FILE)this.msg.data[0][i]);
            }

                return this.msg;
        }
    }
}
