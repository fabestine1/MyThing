using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FastFoodService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class FastFood : IFoodOrder, IFoodAdmin
    {
        private int lastOrder = 0;
        private List<int> orders = new List<int>();
        private List<IFoodAdminCallback> admins = new List<IFoodAdminCallback>();
        private List<Product> products = new List<Product>()
        {
            new Product() { Name = "Chips", Price = 1.22, Stock = 10 },
            new Product() { Name = "Burger", Price = 2.10, Stock = 16 },
            new Product() { Name = "Cola", Price = 1.14, Stock = 6 }
        };

        public void Connect()
        {
            IFoodAdminCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodAdminCallback>();
            if (!admins.Exists(x => x == clientCallback))
            {
                admins.Add(clientCallback);
            }
        }

        public void CreateOrder(string[] list, int orderNr)
        {
            IFoodOrderCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodOrderCallback>();
            foreach (string item in list)
            {
                if (products.Single(x => x.Name == item).Stock < 1)
                {
                    clientCallback.OrderStatus(false, item + " is out of stock.");
                    return;
                }
            }

            foreach (string item in list)
            {
                products.Single(x => x.Name == item).Stock--;
            }
            clientCallback.OrderStatus(true, "Order " + orderNr + " is being prepared.");
            orders.Add(orderNr);

            foreach (IFoodAdminCallback admin in admins)
            {
                admin.NewOrder(orderNr);
            }
        }

        public void DeliverOrder(int orderNr)
        {
            orders.Remove(orderNr);
            foreach (IFoodAdminCallback admin in admins)
            {
                admin.OrderDelivered(orderNr);
            }
        }

        public void Disconnect()
        {
            IFoodAdminCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodAdminCallback>();
            admins.Remove(clientCallback);
        }

        public int GetOrderNumber()
        {
            return ++lastOrder;
        }

        public List<int> GetOrders()
        {
            return orders;
        }

        public List<Product> GetProductList()
        {
            return products.Where(x => x.Stock > 0).ToList();
        }
    }
}
