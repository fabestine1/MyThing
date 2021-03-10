namespace WebShopService
{
    using System;
    using System.Linq;
    using System.ServiceModel;
    using System.Collections.Generic;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Cwebshop : IWebshop, IShipping    
    {
        private List<IWebshopCallback> connectedClients = new List<IWebshopCallback>();

        private readonly List<Item> productItems = new List<Item>(
        ){
            new Item() { ProductId = "id1", OnSale = false, Price = 123, ProductInfo = "Very Good", Stock = 12},
            new Item() { ProductId = "id2", OnSale = true, Price = 333, ProductInfo = "Very Bad", Stock = 2}
        };

        private List<Order> orderList = new List<Order>();

        private Action<Order> newOrderEvent = delegate { };

        public string GetWebShopName()
        {
            return "Kaloyan's WebShop";
        }

        public List<Item> GetProductList()
        {
            return this.productItems;
        }

        public string GetProductInfo(string ProductId)
        {
            foreach (var productsItem in this.productItems)
            {
                if (productsItem.ProductId == ProductId)
                {
                    return productsItem.ProductInfo;
                }
            }

            return "";
        }

        public bool BuyProduct(string ProductId)
        {
            IWebshopCallback clientCallback = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();

            foreach (var productsItem in this.productItems)
            {
                if (productsItem.ProductId == ProductId)
                {
                    if (productsItem.Stock > 0)
                    {
                        productsItem.Stock--;
                        foreach (var client in this.connectedClients)
                        {
                            if (client != clientCallback)
                            {
                                client.productSold(productsItem);
                            }
                        }

                        Order order = new Order
                        {
                            ProductId = productsItem.ProductId,
                            Moment = DateTime.Now,
                            WebshopCallback = clientCallback
                        };

                        this.orderList.Add(order);
                        // send this order to all shipping clients
                        this.newOrderEvent(order);

                        return true;
                    }
                }
            }

            return false;
        }

        public void connectClient()
        {
            IWebshopCallback clientCallback = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
            this.connectedClients.Add(clientCallback);

            foreach (var client in this.connectedClients)
            {
                client.newClientConnected(this.connectedClients.Count);
            }
        }

        public List<Order> GetOrderList()
        {
            return this.orderList;
        }

        public bool ShipOrder(string orderId)
        {
            var order = this.orderList.SingleOrDefault(x => x.ProductId == orderId);

            if (order != null)
            {
                this.orderList.Remove(order);
                // inform a client who created that order that his order is shipped
                order.WebshopCallback.notifyOrderShipped(order);
                return true;
            }

            return false;
        }

        public void RegisterShippingClent()
        {
            this.newOrderEvent += OperationContext.Current.GetCallbackChannel<IShippingCallback>().orderCreated;
        }

        public void DeRegisterShippingClent()
        {
            this.newOrderEvent -= OperationContext.Current.GetCallbackChannel<IShippingCallback>().orderCreated;
        }
    }
}
