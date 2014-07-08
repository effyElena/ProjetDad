
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

       public async Task<STG> uploadFiles(List<FILE> files, STG msg)
       {
           CL_SERVU cl_servu = new CL_SERVU();
           CL_CUT cl_cut = new CL_CUT();
          msg = cl_cut.uploadFile(files, msg);


          return await cl_servu.sendMessage(msg);
       }



      
    }
}
