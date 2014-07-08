using GEN_client.CL_SERVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using GEN_client.Extend_service;
using System.Net.Sockets;
using GEN_client.Business.CUT;

namespace GEN_client.Business.SERVU
{
    public class CL_SERVU 

    {
        
        private STG msg;
        private CL_CUC cuc;

        public CL_SERVU()
        {
            this.cuc = new CL_CUC();
        }

        public async Task<STG> sendMessage(STG msg)
        {
           this.msg = msg;
           return await this.cuc.sendMsg(this.msg);
        }



    }
}
