﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Garagemanagement.GarageServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MessageService", ConfigurationName="GarageServer.ITrafficMessage")]
    public interface ITrafficMessage {
        
        [System.ServiceModel.OperationContractAttribute(Action="MessageService/ITrafficMessage/Handshake", ReplyAction="MessageService/ITrafficMessage/HandshakeResponse")]
        string Handshake(int step, string givenvalue);
        
        [System.ServiceModel.OperationContractAttribute(Action="MessageService/ITrafficMessage/SendMessage", ReplyAction="MessageService/ITrafficMessage/SendMessageResponse")]
        void SendMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="MessageService/ITrafficMessage/RetrieveMessage", ReplyAction="MessageService/ITrafficMessage/RetrieveMessageResponse")]
        string RetrieveMessage(int deviceID);
        
        [System.ServiceModel.OperationContractAttribute(Action="MessageService/ITrafficMessage/Exit", ReplyAction="MessageService/ITrafficMessage/ExitResponse")]
        void Exit(int deviceID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrafficMessageChannel : Garagemanagement.GarageServer.ITrafficMessage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrafficMessageClient : System.ServiceModel.ClientBase<Garagemanagement.GarageServer.ITrafficMessage>, Garagemanagement.GarageServer.ITrafficMessage {
        
        public TrafficMessageClient() {
        }
        
        public TrafficMessageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TrafficMessageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrafficMessageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrafficMessageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Handshake(int step, string givenvalue) {
            return base.Channel.Handshake(step, givenvalue);
        }
        
        public void SendMessage(string message) {
            base.Channel.SendMessage(message);
        }
        
        public string RetrieveMessage(int deviceID) {
            return base.Channel.RetrieveMessage(deviceID);
        }
        
        public void Exit(int deviceID) {
            try
            {
                base.Channel.Exit(deviceID);
            }
            catch
            {

            }
        }
    }
}
