﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheRevenge.SOAPTest.ServiceTipoDoc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tipo_Documento", Namespace="http://schemas.datacontract.org/2004/07/TheRevenge.Data.Dominio")]
    [System.SerializableAttribute()]
    public partial class Tipo_Documento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_Tipo_DocField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Tipo_Doc {
            get {
                return this.ID_Tipo_DocField;
            }
            set {
                if ((this.ID_Tipo_DocField.Equals(value) != true)) {
                    this.ID_Tipo_DocField = value;
                    this.RaisePropertyChanged("ID_Tipo_Doc");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTipoDoc.ITiposDocService")]
    public interface ITiposDocService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiposDocService/listarTipo_Documento", ReplyAction="http://tempuri.org/ITiposDocService/listarTipo_DocumentoResponse")]
        TheRevenge.SOAPTest.ServiceTipoDoc.Tipo_Documento[] listarTipo_Documento();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITiposDocServiceChannel : TheRevenge.SOAPTest.ServiceTipoDoc.ITiposDocService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TiposDocServiceClient : System.ServiceModel.ClientBase<TheRevenge.SOAPTest.ServiceTipoDoc.ITiposDocService>, TheRevenge.SOAPTest.ServiceTipoDoc.ITiposDocService {
        
        public TiposDocServiceClient() {
        }
        
        public TiposDocServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TiposDocServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TiposDocServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TiposDocServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TheRevenge.SOAPTest.ServiceTipoDoc.Tipo_Documento[] listarTipo_Documento() {
            return base.Channel.listarTipo_Documento();
        }
    }
}
