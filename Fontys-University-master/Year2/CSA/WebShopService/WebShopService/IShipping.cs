namespace WebShopService
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    [ServiceContract(CallbackContract = typeof(IShippingCallback))]
    public interface IShipping
    {
        [OperationContract]
        List<Order> GetOrderList();

        [OperationContract]
        bool ShipOrder(string OrderId);

        [OperationContract(IsOneWay = true)]
        void RegisterShippingClent();

        [OperationContract(IsOneWay = true)]
        void DeRegisterShippingClent();
    }

    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public DateTime Moment { get; set; }

        public IWebshopCallback WebshopCallback { get; set; }
    }

    public interface IShippingCallback
    {
        [OperationContract(IsOneWay = true)]
        void orderCreated(Order order);
    }
}
