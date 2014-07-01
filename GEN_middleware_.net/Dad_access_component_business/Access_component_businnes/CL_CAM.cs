using Business.ServiceReference1;
using Business.Workflow_controller;
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
            objetCW = null;

            if (msg.tokenUser == null)
            {
                switch (msg.operationName)
                {
                    case "authenticate":
                        objetCW = new CL_CW_Auth();
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

            this.msg = objetCW.exec(msg);

            return this.msg;
        }

        private void instantAdmin(STG msg)
        {
            switch (msg.operationName)
            {
                
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
