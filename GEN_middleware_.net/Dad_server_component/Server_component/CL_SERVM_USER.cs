using Access_component_business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Dad_server_component.Server_component
{
    public class CL_SERVM_User:I_SERVM
    {
        private CL_CAM cam;
        private delegate STG SimpleDelegate(STG msg);

        public CL_SERVM_User()
        {
            this.cam = new CL_CAM();
        }
       
        public STG exec(STG msg)
        {
            MethodInfo methodeInfo = this.GetType().GetMethod(msg.operationName);
            SimpleDelegate del = (SimpleDelegate)Delegate.CreateDelegate(typeof(SimpleDelegate), this, methodeInfo);
            return del(msg);
        }
        public STG login(STG msg)
        {
            return this.cam.redirection(msg);
        }
        public STG histoFile(STG msg)
        {
            return this.cam.redirection(msg);
        }
        public STG refresh(STG msg)
        {
            return this.cam.redirection(msg);
        }
       

        
    }
}