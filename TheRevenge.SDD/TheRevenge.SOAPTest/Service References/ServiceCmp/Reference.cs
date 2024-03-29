﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheRevenge.SOAPTest.ServiceCmp {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cmp", Namespace="http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cmp : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCmpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TxDescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TxDoc_IdentidadField;
        
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
        public int IdCmp {
            get {
                return this.IdCmpField;
            }
            set {
                if ((this.IdCmpField.Equals(value) != true)) {
                    this.IdCmpField = value;
                    this.RaisePropertyChanged("IdCmp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TxDescripcion {
            get {
                return this.TxDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.TxDescripcionField, value) != true)) {
                    this.TxDescripcionField = value;
                    this.RaisePropertyChanged("TxDescripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TxDoc_Identidad {
            get {
                return this.TxDoc_IdentidadField;
            }
            set {
                if ((object.ReferenceEquals(this.TxDoc_IdentidadField, value) != true)) {
                    this.TxDoc_IdentidadField = value;
                    this.RaisePropertyChanged("TxDoc_Identidad");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCmp.ICmpesService")]
    public interface ICmpesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICmpesService/crearCmp", ReplyAction="http://tempuri.org/ICmpesService/crearCmpResponse")]
        TheRevenge.SOAPTest.ServiceCmp.Cmp crearCmp(string strtxDescripcion, string strtxDoc_Identidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICmpesService/consultarCmp", ReplyAction="http://tempuri.org/ICmpesService/consultarCmpResponse")]
        TheRevenge.SOAPTest.ServiceCmp.Cmp consultarCmp(int intIdCMP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICmpesService/actualizarCmp", ReplyAction="http://tempuri.org/ICmpesService/actualizarCmpResponse")]
        TheRevenge.SOAPTest.ServiceCmp.Cmp actualizarCmp(int intIdCMP, string strtxDescripcion, string strtxDoc_Identidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICmpesService/eliminarCmp", ReplyAction="http://tempuri.org/ICmpesService/eliminarCmpResponse")]
        void eliminarCmp(int intIdCMP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICmpesService/listarCmp", ReplyAction="http://tempuri.org/ICmpesService/listarCmpResponse")]
        TheRevenge.SOAPTest.ServiceCmp.Cmp[] listarCmp();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICmpesServiceChannel : TheRevenge.SOAPTest.ServiceCmp.ICmpesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CmpesServiceClient : System.ServiceModel.ClientBase<TheRevenge.SOAPTest.ServiceCmp.ICmpesService>, TheRevenge.SOAPTest.ServiceCmp.ICmpesService {
        
        public CmpesServiceClient() {
        }
        
        public CmpesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CmpesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CmpesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CmpesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TheRevenge.SOAPTest.ServiceCmp.Cmp crearCmp(string strtxDescripcion, string strtxDoc_Identidad) {
            return base.Channel.crearCmp(strtxDescripcion, strtxDoc_Identidad);
        }
        
        public TheRevenge.SOAPTest.ServiceCmp.Cmp consultarCmp(int intIdCMP) {
            return base.Channel.consultarCmp(intIdCMP);
        }
        
        public TheRevenge.SOAPTest.ServiceCmp.Cmp actualizarCmp(int intIdCMP, string strtxDescripcion, string strtxDoc_Identidad) {
            return base.Channel.actualizarCmp(intIdCMP, strtxDescripcion, strtxDoc_Identidad);
        }
        
        public void eliminarCmp(int intIdCMP) {
            base.Channel.eliminarCmp(intIdCMP);
        }
        
        public TheRevenge.SOAPTest.ServiceCmp.Cmp[] listarCmp() {
            return base.Channel.listarCmp();
        }
    }
}
