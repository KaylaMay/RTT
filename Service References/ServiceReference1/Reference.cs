﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTT.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfToDb")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/WcfToDb")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Cell_nrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cust_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Postal_AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Residential_AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Work_AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Work_nrField;
        
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
        public string Cell_nr {
            get {
                return this.Cell_nrField;
            }
            set {
                if ((object.ReferenceEquals(this.Cell_nrField, value) != true)) {
                    this.Cell_nrField = value;
                    this.RaisePropertyChanged("Cell_nr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cust_id {
            get {
                return this.Cust_idField;
            }
            set {
                if ((this.Cust_idField.Equals(value) != true)) {
                    this.Cust_idField = value;
                    this.RaisePropertyChanged("Cust_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Postal_Address {
            get {
                return this.Postal_AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.Postal_AddressField, value) != true)) {
                    this.Postal_AddressField = value;
                    this.RaisePropertyChanged("Postal_Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Residential_Address {
            get {
                return this.Residential_AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.Residential_AddressField, value) != true)) {
                    this.Residential_AddressField = value;
                    this.RaisePropertyChanged("Residential_Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Work_Address {
            get {
                return this.Work_AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.Work_AddressField, value) != true)) {
                    this.Work_AddressField = value;
                    this.RaisePropertyChanged("Work_Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Work_nr {
            get {
                return this.Work_nrField;
            }
            set {
                if ((object.ReferenceEquals(this.Work_nrField, value) != true)) {
                    this.Work_nrField = value;
                    this.RaisePropertyChanged("Work_nr");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        RTT.ServiceReference1.CompositeType GetDataUsingDataContract(RTT.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<RTT.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(RTT.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertClient", ReplyAction="http://tempuri.org/IService1/InsertClientResponse")]
        int InsertClient(RTT.ServiceReference1.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertClient", ReplyAction="http://tempuri.org/IService1/InsertClientResponse")]
        System.Threading.Tasks.Task<int> InsertClientAsync(RTT.ServiceReference1.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateClient", ReplyAction="http://tempuri.org/IService1/UpdateClientResponse")]
        int UpdateClient(RTT.ServiceReference1.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateClient", ReplyAction="http://tempuri.org/IService1/UpdateClientResponse")]
        System.Threading.Tasks.Task<int> UpdateClientAsync(RTT.ServiceReference1.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        int DeleteClient(RTT.ServiceReference1.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        System.Threading.Tasks.Task<int> DeleteClientAsync(RTT.ServiceReference1.Client c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        RTT.ServiceReference1.Client[] GetClient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        System.Threading.Tasks.Task<RTT.ServiceReference1.Client[]> GetClientAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RTT.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<RTT.ServiceReference1.IService1>, RTT.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public RTT.ServiceReference1.CompositeType GetDataUsingDataContract(RTT.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<RTT.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(RTT.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertClient(RTT.ServiceReference1.Client c) {
            return base.Channel.InsertClient(c);
        }
        
        public System.Threading.Tasks.Task<int> InsertClientAsync(RTT.ServiceReference1.Client c) {
            return base.Channel.InsertClientAsync(c);
        }
        
        public int UpdateClient(RTT.ServiceReference1.Client c) {
            return base.Channel.UpdateClient(c);
        }
        
        public System.Threading.Tasks.Task<int> UpdateClientAsync(RTT.ServiceReference1.Client c) {
            return base.Channel.UpdateClientAsync(c);
        }
        
        public int DeleteClient(RTT.ServiceReference1.Client c) {
            return base.Channel.DeleteClient(c);
        }
        
        public System.Threading.Tasks.Task<int> DeleteClientAsync(RTT.ServiceReference1.Client c) {
            return base.Channel.DeleteClientAsync(c);
        }
        
        public RTT.ServiceReference1.Client[] GetClient() {
            return base.Channel.GetClient();
        }
        
        public System.Threading.Tasks.Task<RTT.ServiceReference1.Client[]> GetClientAsync() {
            return base.Channel.GetClientAsync();
        }
    }
}