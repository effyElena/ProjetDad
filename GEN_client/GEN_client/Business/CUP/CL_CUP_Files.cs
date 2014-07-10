
using GEN_client.Business.CUT;
using GEN_client.Business.SERVU;
using GEN_client.CL_SERVC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEN_client.Business.CUP
{
    public class CL_CUP_Files
    {

        private CL_CUT cut;
        private CL_SERVU servc;
        public CL_CUP_Files()
        {
            this.cut = new CL_CUT();
            this.servc = new CL_SERVU();
        }   

        public async Task<STG> uploadFiles(List<FILE> files, STG msg)
        {
       
          
            msg = this.cut.uploadFile(files, msg);


            return await servc.sendMessage(msg);
        }


        public async Task<STG> refresh(List<FILE> files, STG msg)
        {
           

            msg = this.cut.refresh(files, msg);


            return await this.servc.sendMessage(msg);
        }

        public List<FILE> getListFile(STG msg)
        {
            return this.cut.getListFile(msg);
        }

        

        public async Task<List<FILE>> getListFileHisto(STG msg)
        {
            msg = this.cut.histoFile(msg);

            msg = await servc.sendMessage(msg);

            return this.cut.getListFile(msg);
        }

        public STG resetMsg(STG msg)
        {
            return this.cut.resetData(msg);
        }
    }
}
