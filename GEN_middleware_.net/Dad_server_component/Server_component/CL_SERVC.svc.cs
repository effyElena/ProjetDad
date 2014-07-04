using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        
        public STG m_service(STG msg)
        {
            this.msg = msg;
            if (this.secu_access_plateForme(this.msg) == true)
            {
                I_SERVM clServm = (I_SERVM)Activator.CreateInstance(StringToType(this.msg.info));
                this.msg = clServm.exec(this.msg);
                           }
            else
            {
                this.msg.statut_op = false;
            }

            return this.msg;
        }

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

        private Type StringToType(string typeName)
        {
            if (String.IsNullOrEmpty(typeName))
                throw new ArgumentException("typeName is null or empty", "typeName");

            typeName = typeName.Replace(" ", "");
            int indexOf = typeName.IndexOf("<");

            // S'il ne s'agit pas d'une classe générique
            if (indexOf < 0)
            {
                foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                    foreach (Type type in assembly.GetTypes())
                        if ((type.Name == typeName) || (type.FullName == typeName))
                            return type;
                throw new ArgumentException(String.Format("Type '{0}' unknown !", typeName), "typeName");
            }
            // sinon on détail l'interprétation du nom
            else
            {
                string typeBaseName = typeName.Substring(0, indexOf);
                string[] argumentsGeneric = typeName.Substring(indexOf + 1).Remove(typeName.Length - indexOf - 2).Split(',');
                List<Type> typeGenerics = new List<Type>();
                string currentArgument = "";
                int countLevelGeneric = 0;
                foreach (string argument in argumentsGeneric)
                {
                    foreach (char car in argument)
                        switch (car)
                        {
                            case '<': countLevelGeneric++; break;
                            case '>': countLevelGeneric--; break;
                        }
                    currentArgument += argument;
                    if (countLevelGeneric == 0)
                    {
                        typeGenerics.Add(StringToType(currentArgument));
                        currentArgument = "";
                    }
                }
                Type typeBase = StringToType(String.Format("{0}`{1}", typeBaseName, typeGenerics.Count));
                return typeBase.MakeGenericType(typeGenerics.ToArray());
            }
        }


    }
}
