using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections.Generic;

namespace MyWebshopContract
{
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
        public double ProfitMargin { get; set; }
    }

    [ServiceContract(Namespace = "MyWebshopContract", CallbackContract = typeof(IWebshopCallback))]
    public interface IWebshop
    {
        [OperationContract(IsOneWay = true)]
        void connect();

        [OperationContract]
        string GetWebshopName();

        [OperationContract]
        List<Item> GetProductsList();

        [OperationContract]
        string GetProductInfo(string ProductId);

        [OperationContract(IsOneWay = true)]
        void BuyProduct(string ProductId);
    }

    public interface IWebshopCallback
    {
        [OperationContract(IsOneWay = true)]
        void newClientConnected(int numberOfConnectedClients);

        [OperationContract]
        void productSold(Item product);
    }
}
