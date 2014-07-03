using Business.Workflow_controller;
using Business.Workflow_controller.File;
using Business.Workflow_controller.User;
using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
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
                        this.objetCW = new CL_CW_Auth();
                        break;
                    default:
                        this.msg.statut_op = false;
                        break;
                }
            }
            else if (msg.tokenUser == "XXXXXXXXXXXXXXXXXADMIN")
            {
                this.instantAdmin(msg);
            }
            else if (msg.tokenUser == "XXXXXXXXXXXXXXXXXUSER")
            {
                this.instantUser(msg);
            }

            this.msg = this.objetCW.exec(msg);

            return this.msg;
        }

        private void instantAdmin(STG msg)
        {
            switch (msg.operationName)
            {
                case "decrypt":
                    this.objetCW = new CL_CW_Decrypt();
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


    }
}
