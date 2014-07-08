using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEN_client.CL_SERVC;
using GEN_client.Business.CUT;
using GEN_client.Business.SERVU;

namespace GEN_client.Business.CUP
{
    public class CL_CUP_Identity
    {
        private CL_SERVU servu;
        private CL_CUT cut;
        private STG msg;
        
        public CL_CUP_Identity()
        {
             this.servu = new CL_SERVU();
             this.cut = new CL_CUT();
        }
      

        public async Task<STG> login(string login, string password)
        {
            
            this.msg = this.cut.login(login, password);

            return await this.servu.sendMessage(this.msg);
        }
    }
}
