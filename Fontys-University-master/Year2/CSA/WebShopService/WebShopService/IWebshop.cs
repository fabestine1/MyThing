namespace WebShopService
{
    using System;
    using System.ServiceModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    [ServiceContract(CallbackContract = typeof(IWebshopCallback))]
    public interface IWebshop
    {
        [OperationContract]
        string GetWebShopName();

        [OperationContract]
        List<Item> GetProductList();

        [OperationContract]
        string GetProductInfo(String ProductId);

        [OperationContract]
        bool BuyProduct(String ProductId);

        [OperationContract(IsOneWay = true)]
        void connectClient();
    }

    [DataContract]
    public class Item
    {
        [DataMember]
        public string ProductId { get; set; }

        public string ProductInfo { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int Stock { get; set; }

        public bool OnSale { get; set; }
    }

    public interface IWebshopCallback
    {
        [OperationContract(IsOneWay = true)]
        void newClientConnected(int numberOfConnectedClients);

        [OperationContract(IsOneWay = true)]
        void productSold(Item product);

        [OperationContract(IsOneWay = true)]
        void notifyOrderShipped(Order order); 
    }
}
