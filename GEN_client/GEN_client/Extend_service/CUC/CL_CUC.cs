using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEN_client.CL_SERVC;
namespace GEN_client.Extend_service
{
    //composant utilisateur de communication
    public class CL_CUC
    {
        public async Task<STG> sendMsg(STG msg)
        {
           I_SERVCClient client = new I_SERVCClient();
           msg = await client.m_serviceAsync(msg);
           client.Close();
           return msg; 
        }

    }
}
