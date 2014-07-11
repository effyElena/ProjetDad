using Business.CL_WS_ReceptionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Business.Job_component
{
    public class CL_CM_J2ee
    {
        private EndpointAddress endPoint;
        private BasicHttpBinding binding;

        public CL_CM_J2ee()
        {
            this.getEndPoint();
        }

        public string sendFileJ2ee(string name, Byte[] content, string key)
        {
            WSReceptionClient objectJee = new WSReceptionClient(this.binding, this.endPoint);
            string result = objectJee.MessageJMS(name, content, key);
            objectJee.Close();
            return result;
            
        }

        private void getEndPoint()
        {
            this.binding = new BasicHttpBinding();
            this.binding.Name = "CL_WS_ReceptionPortBinding";
            this.binding.CloseTimeout = System.TimeSpan.Parse("00:30:00");

            this.binding.OpenTimeout = System.TimeSpan.Parse("00:30:00");
            this.binding.ReceiveTimeout = System.TimeSpan.Parse("00:30:00");
            this.binding.SendTimeout = System.TimeSpan.Parse("00:01:00");

            this.binding.AllowCookies = false;
            this.binding.BypassProxyOnLocal = false;
            this.binding.HostNameComparisonMode = System.ServiceModel.HostNameComparisonMode.StrongWildcard;

            this.binding.MaxBufferSize = 65536;
            this.binding.MaxBufferPoolSize = 524288;
            this.binding.MaxReceivedMessageSize = 65536;

            this.binding.MessageEncoding = System.ServiceModel.WSMessageEncoding.Text;
            this.binding.TextEncoding = System.Text.Encoding.UTF8;
            this.binding.TransferMode = System.ServiceModel.TransferMode.Buffered;

            this.binding.UseDefaultWebProxy = true;
            this.binding.ReaderQuotas.MaxDepth = 32;
            this.binding.ReaderQuotas.MaxStringContentLength = 8192;

            this.binding.ReaderQuotas.MaxArrayLength = 16384;
            this.binding.ReaderQuotas.MaxBytesPerRead = 4096;
            this.binding.ReaderQuotas.MaxNameTableCharCount = 16384;

            this.binding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.None;
            this.binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            this.binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;

            this.binding.Security.Transport.Realm = "";
            this.binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            this.binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Default;


            this.endPoint = new EndpointAddress("http://vm-reception:8080/reception_web/reception?wsdl");

           

        }


    }
}
