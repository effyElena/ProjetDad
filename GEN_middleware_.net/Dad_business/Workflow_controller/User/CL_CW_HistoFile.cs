﻿using Dad_server_component.Server_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workflow_controller.User
{
    public class CL_CW_HistoFile : I_CW
    {
        private STG msg;
        public STG exec(STG msg)
        {
            this.msg = msg;

            //this.msg.data[0];







            return this.msg;
        }
    }
}
