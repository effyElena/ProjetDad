using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEN_client.CL_SERVC;
using GEN_client.Extend_service;
using GEN_client.Business.SERVU;

namespace GEN_client.Business.CUT
{
    public class CL_CUT
    {

        private STG msg;

        public CL_CUT()
        {
            this.msg = new STG();
            this.msg.tokenApll = "Application_client";
            this.msg.tokenUser = null;
        }

        public STG login(string login, string password)
        {
            this.msg.statut_op = false;
            this.msg.operationName = "login";

            Console.WriteLine( password);
            this.msg.data = new object[10][];
            this.msg.data[0] = new object[10]; 
            this.msg.data[0][0] = new object();
            this.msg.data[0][0] = login;
            this.msg.data[0][1] = password;
            this.msg.info = "CL_SERVM_User";

            return this.msg;
        }

        public STG uploadFile(List<FILE> files, STG msg)
        {
            this.msg = msg;
            this.msg.statut_op = false;
            this.msg.operationName = "decrypt";

            this.msg.data = new object[10][];
            this.msg.data[0] = new object[files.Count];
            int i = 0;

            foreach(FILE file in files)
            {
                this.msg.data[0][i] = file;
                i++;
            }

            this.msg.info = "CL_SERVM_File";

      
            return this.msg;

        }

       
    }
}
