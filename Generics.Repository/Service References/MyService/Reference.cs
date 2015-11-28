﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Generics.Repository.MyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        Generics.Common.Person[] GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        Generics.Common.Person GetPerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        void AddPerson(Generics.Common.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        void UpdatePerson(string lastName, Generics.Common.Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        void DeletePerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePeople", ReplyAction="http://tempuri.org/IPersonService/UpdatePeopleResponse")]
        void UpdatePeople(Generics.Common.Person[] updatedPeople);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : Generics.Repository.MyService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<Generics.Repository.MyService.IPersonService>, Generics.Repository.MyService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Generics.Common.Person[] GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public Generics.Common.Person GetPerson(string lastName) {
            return base.Channel.GetPerson(lastName);
        }
        
        public void AddPerson(Generics.Common.Person newPerson) {
            base.Channel.AddPerson(newPerson);
        }
        
        public void UpdatePerson(string lastName, Generics.Common.Person updatedPerson) {
            base.Channel.UpdatePerson(lastName, updatedPerson);
        }
        
        public void DeletePerson(string lastName) {
            base.Channel.DeletePerson(lastName);
        }
        
        public void UpdatePeople(Generics.Common.Person[] updatedPeople) {
            base.Channel.UpdatePeople(updatedPeople);
        }
    }
}
