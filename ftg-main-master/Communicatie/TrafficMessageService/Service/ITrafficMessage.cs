using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MessageService
{
    [ServiceContract(Namespace = "MessageService")]
    public interface ITrafficMessage
    {
        [OperationContract]
        string Handshake(int step, string givenvalue);

        [OperationContract]
        void SendMessage(string message);

        [OperationContract]
        string RetrieveMessage(int deviceID);

        [OperationContract]
        void Exit(int deviceID);
    }
        
}
