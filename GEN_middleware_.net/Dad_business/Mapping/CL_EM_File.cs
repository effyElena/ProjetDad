using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    class CL_EM_File
    {
        private string file_name;
        private string file_email;
        private string file_code;
        private string file_url;
        private DateTime file_date;
        private Boolean state;
        private CL_CAD cad;

        public string File_name
        {
            get { return file_name; }
            set { file_name = value; }
        }
        public string File_email
        {
            get { return file_email; }
            set { file_email = value; }
        }

        public string File_code
        {
            get { return file_code; }
            set { file_code = value; }
        }

        public string File_url
        {
            get { return file_url; }
            set { file_url = value; }
        }

        public DateTime File_date 
        {
            get { return file_date; }
            set { file_date = value; }
        }

        public Boolean State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
