using Access_component_business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dad_server_component.Server_component
{
    public class CL_SERVM_FILE
    {
        private CL_CAM cam;

        public CL_SERVM_FILE()
        {
            cam = new CL_CAM();
        }

        public STG decrypt(STG msg)
        {
           return cam.redirection(msg);
        }
    }
}