using Business.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Workflow_controller
{
    public interface I_CW
    {
        STG exec(STG msg);
    }
}
