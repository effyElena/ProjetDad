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

            this.cmFile = new CL_CM_File();

            for (int i = 0; i < this.msg.data[0].Length; i++)
            {
                this.cmFile.saveFile((FILE)this.msg.data[0][i], this.msg.userId);
                this.cmFile.decrypt((FILE)this.msg.data[0][i]);
            }

            this.msg.statut_op = true;
            return this.msg;
        }


    }
}
