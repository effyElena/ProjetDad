using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server_component.Server_component
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "SERVC" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez SERVC.svc ou SERVC.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CL_SERVC : I_SERVC
    {
        public void DoWork()
        {
        }
    }
}
