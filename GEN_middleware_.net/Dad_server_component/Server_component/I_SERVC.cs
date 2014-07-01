using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dad_server_component.Server_component
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICL_SERVC" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface I_SERVC
    {
        [OperationContract]
        STG m_service(STG msg);
    }

    [DataContract(IsReference = true)]
    public class STG
    {
        [DataMember]
        public bool statut_op { get; set; }
        [DataMember]
        public string info { get; set; }
        [DataMember]
        public object[][] data { get; set; }
        [DataMember]
        public string operationName { get; set; }
        [DataMember]
        public string tokenApll { get; set; }
        [DataMember]
        public string tokenUser { get; set; }
    }
}
