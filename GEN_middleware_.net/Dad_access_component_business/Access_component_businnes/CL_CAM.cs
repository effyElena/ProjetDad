using Business.Job_component;
using Business.Workflow_controller;
using Business.Workflow_controller.File;
using Business.Workflow_controller.User;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_component_business
{
    public class CL_CAM
    {
 

        private STG msg;
        private I_CW objetCW;

        public STG redirection(STG msg)
        {
            this.msg = msg;
            this.objetCW = null;

            if (msg.tokenUser == null)
            {
                switch (msg.operationName)
                {
                    case "login":
                        this.objetCW = new CL_CW_Login();
                        break;
                    default:
                        this.msg.statut_op = false;
                        break;
                }
            }
            else if (msg.tokenUser == "XXXXXXXXXXXXXXXXXADMIN")
            {
                this.instantAdmin(this.msg);
            }
            else if (msg.tokenUser == "XXXXXXXXXXXXXXXXXUSER")
            {
                this.instantUser(this.msg);
            }
            else if (msg.tokenUser == "XXXXXXXXXXXXXXXXXJ2EE")
            {
                this.instantJ2ee(this.msg);
            }

            System.Diagnostics.Trace.WriteLine(DateTime.Now +" : "+this.msg.tokenApll+" : "+this.msg.operationName+" : "+this.msg.tokenUser);
            CL_CM_Pdf cmPdf = new CL_CM_Pdf();
            cmPdf.createPdf();

            //this.msg = this.objetCW.exec(msg);

            return this.msg;
        }

        private void instantAdmin(STG msg)
        {
            switch (msg.operationName)
            {
                case "decrypt":
                    this.objetCW = new CL_CW_Decrypt();
                    break;
                case "refresh":
                    this.objetCW = new CL_CW_Refresh();
                    break;
                case "histoFile":
                    this.objetCW = new CL_CW_HistoFile();
                    break;
                default:
                    this.msg.statut_op = false;
                    break;
            }
        }

        private void instantUser(STG msg)
        {
            switch (msg.operationName)
            {

            }
        }

        private void instantJ2ee(STG msg)
        {
            switch (msg.operationName)
            {
                case "stopDecrypt":
                    this.objetCW = new CL_CW_StopDecrypt();
                    break;
                default:
                    this.msg.statut_op = false;
                    break;
            }
        }


    }
}
