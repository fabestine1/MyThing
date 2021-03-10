using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessagingService
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Username { get; set; }
        public bool IsBlocked { get; internal set; }
        public IMessagerCallback UserChannel { get; internal set; }
    }

    [ServiceContract(CallbackContract = typeof(IMessagerCallback))]
    public interface IMessager
    {
        [OperationContract(IsOneWay = true)]
        void Connect(string username);

        [OperationContract(IsOneWay = true)]
        void Disconnect();

        [OperationContract]
        List<User> GetUsers();

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message, string username);

        [OperationContract(IsOneWay = true)]
        void SendPublicMessage(string message);
    }

    public interface IMessagerCallback
    {
        [OperationContract(IsOneWay = true)]
        void LoginStatus(bool isSuccessful, string message);

        [OperationContract(IsOneWay = true)]
        void ReceivedMessage(string message);

        [OperationContract(IsOneWay = true)]
        void Blocked(string message);
    }

    [ServiceContract]
    public interface IAdmin
    {
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract(IsOneWay = true)]
        void BlockUser(string username);
    }
}
