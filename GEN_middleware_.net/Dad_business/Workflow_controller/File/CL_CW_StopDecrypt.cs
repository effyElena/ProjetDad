using Business.Job_component;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workflow_controller.File
{
    public class CL_CW_StopDecrypt : I_CW
    {
        private STG msg;
        public STG exec(STG msg)
        {
            this.msg = msg;

            string email = this.msg.dataJ2ee[0];
            string stat = this.msg.dataJ2ee[1];
            string name = this.msg.dataJ2ee[2];
            string content = this.msg.dataJ2ee[3];
            string key = this.msg.dataJ2ee[4];

            CL_CM_Pdf cmPdf = new CL_CM_Pdf();
            cmPdf.createPdf(name, content, key, DateTime.Now, stat, email);

            CL_CM_File cmFile = new CL_CM_File();
            FILE file = new FILE();
            file.state = 1;
            file.file_name = name;
            file.file_email = email;
            file.file_code = key;
            file.file_url = "http://David-pc/rapport-pdf/" + name + ".pdf";
            cmFile.updateFile(file, this.msg.userId);




            this.msg.statut_op = true;
            return this.msg;
        }
    }
}
