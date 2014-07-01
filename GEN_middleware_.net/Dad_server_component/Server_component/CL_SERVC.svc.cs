using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dad_server_component.Server_component
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CL_SERVC" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez CL_SERVC.svc ou CL_SERVC.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CL_SERVC : I_SERVC
    {
        private STG msg;
        private Boolean secu_access_plateForme(STG msg)
        {
            Boolean Boolean = false;

            switch (msg.tokenApll)
            {
                case "Application_client":
                    Boolean = true;
                    break;
                default:
                    Boolean = false;
                    break;
            }
            return Boolean;

        }

        public STG m_service(STG msg)
        {
            this.msg = msg;
            if (this.secu_access_plateForme(this.msg) == true)
            {
                switch (this.msg.operationName)
                {
                    case "authenticate":
                        // this.msg = 
                        break;
                    case "decrypt":
                        //
                        break;
                }
            }
            else
            {
                this.msg.statut_op = false;
            }

            return this.msg;
        }
    }
}
