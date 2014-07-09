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
        private CL_CM_User cmUser;
        public STG exec(STG msg)
        {
            this.msg = msg;
            this.cmUser = new CL_CM_User();
            string token = cmUser.login((string)this.msg.data[0][0], (string)this.msg.data[0][1]);
            if (token != null)
            {
                this.msg.statut_op = true;
                this.msg.tokenUser = token;
                this.msg.userId = this.cmUser.EmUser.Id;
                this.msg.data = null;

                if(this.cmUser.EmUser.ListFileRun != null){
                    this.msg.data = new object[1][];
                    this.msg.data[0] = new object[this.cmUser.EmUser.ListFileRun.Count];

                    int i = 0;
                    foreach (CL_EM_File emFile in this.cmUser.EmUser.ListFileRun)
                    {
                        FILE file = new FILE();
                        file.file_code = emFile.File_code;
                        file.file_name = emFile.File_name;
                        file.state = emFile.State;
                        file.file_email = emFile.File_email;
                        this.msg.data[0][i] = file;

                        i++;
                    }
                    
                }
            }
            else
            {
                this.msg.statut_op = false;
            }
            return this.msg;
        }
    }
}
