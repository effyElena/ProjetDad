﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="STG", Namespace="http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[][]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial class STG : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[][] dataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string infoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string operationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool statut_opField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenApllField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenUserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[][] data {
            get {
                return this.dataField;
            }
            set {
                if ((object.ReferenceEquals(this.dataField, value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string info {
            get {
                return this.infoField;
            }
            set {
                if ((object.ReferenceEquals(this.infoField, value) != true)) {
                    this.infoField = value;
                    this.RaisePropertyChanged("info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operationName {
            get {
                return this.operationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.operationNameField, value) != true)) {
                    this.operationNameField = value;
                    this.RaisePropertyChanged("operationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool statut_op {
            get {
                return this.statut_opField;
            }
            set {
                if ((this.statut_opField.Equals(value) != true)) {
                    this.statut_opField = value;
                    this.RaisePropertyChanged("statut_op");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tokenApll {
            get {
                return this.tokenApllField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenApllField, value) != true)) {
                    this.tokenApllField = value;
                    this.RaisePropertyChanged("tokenApll");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tokenUser {
            get {
                return this.tokenUserField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenUserField, value) != true)) {
                    this.tokenUserField = value;
                    this.RaisePropertyChanged("tokenUser");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.I_SERVC")]
    public interface I_SERVC {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_SERVC/m_service", ReplyAction="http://tempuri.org/I_SERVC/m_serviceResponse")]
        Business.ServiceReference1.STG m_service(Business.ServiceReference1.STG msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/I_SERVC/m_service", ReplyAction="http://tempuri.org/I_SERVC/m_serviceResponse")]
        System.Threading.Tasks.Task<Business.ServiceReference1.STG> m_serviceAsync(Business.ServiceReference1.STG msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface I_SERVCChannel : Business.ServiceReference1.I_SERVC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class I_SERVCClient : System.ServiceModel.ClientBase<Business.ServiceReference1.I_SERVC>, Business.ServiceReference1.I_SERVC {
        
        public I_SERVCClient() {
        }
        
        public I_SERVCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public I_SERVCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public I_SERVCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public I_SERVCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Business.ServiceReference1.STG m_service(Business.ServiceReference1.STG msg) {
            return base.Channel.m_service(msg);
        }
        
        public System.Threading.Tasks.Task<Business.ServiceReference1.STG> m_serviceAsync(Business.ServiceReference1.STG msg) {
            return base.Channel.m_serviceAsync(msg);
        }
    }
}
