using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebshopContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Cwebshop : IWebshop
    {
        private List<Item> products = new List<Item>()
        {
            new Item() { ProductId = "Dracula", Price = 10.5, ProductInfo = "test", Stock = 5, OnSale = true },
            new Item() { ProductId = "A room witha a view", Price = 15, ProductInfo = "test", Stock = 9, OnSale = true },
            new Item() { ProductId = "Uncle Tom's Cabin", Price = 12.5, ProductInfo = "test", Stock = 54, OnSale = true }
        };
        private List<IWebshopCallback> clients = new List<IWebshopCallback>();

        public void connect()
        {
            IWebshopCallback clientCallback = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
            clients.Add(clientCallback);

            foreach(IWebshopCallback client in clients)
            {
                client.newClientConnected(clients.Count);
            }
        }

        //public bool BuyProduct(string ProductId)
        //{
        //    foreach (Item i in products)
        //    {
        //        if (i.ProductId == ProductId)
        //        {
        //            if (i.OnSale)
        //            {
        //                i.Stock -= 1;
        //                if (i.Stock == 0) i.OnSale = false;
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        public void BuyProduct(string ProductId)
        {
            foreach (Item i in products)
            {
                if (i.ProductId == ProductId)
                {
                    if (i.OnSale)
                    {
                        i.Stock -= 1;
                        if (i.Stock == 0) i.OnSale = false;

                        foreach(IWebshopCallback client in clients)
                        {
                            client.productSold(i);
                        }
                    }
                }
            }
        }

        public string GetProductInfo(string ProductId)
        {
            foreach(Item i in products)
            {
                if (i.ProductId == ProductId) return i.ProductInfo;
            }
            return "";
        }

        public List<Item> GetProductsList()
        {
            return products;
        }

        public string GetWebshopName()
        {
            return "Peter's Bookshop";
        }
    }
}
