using Access_component_business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.ServiceReference1;

namespace Dad_server_component.Server_component
{
    public class CL_SERVM_Auth
    {
        private CL_CAM cam;

        public CL_SERVM_Auth()
        {
            cam = new CL_CAM();
        }

        public Business.ServiceReference1.STG auth(Business.ServiceReference1.STG msg)
        {
            return cam.redirection(msg);
        }
    }
}