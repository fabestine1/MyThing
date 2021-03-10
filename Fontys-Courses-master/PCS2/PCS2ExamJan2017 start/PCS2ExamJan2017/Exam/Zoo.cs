using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Zoo
    {
        private List<Order> orders;
        public string Name
        {
            get; set;
        }
        public Zoo(string nwName)
        {
            Name = nwName;
            orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public List<Order> GetAllOrders()
        {
            return orders;
        }
        public List<Order> GetUncheckedOrders()
        {
            List<Order> uncheckedOrders = new List<Order>();
            foreach(Order order in orders)
            {
                if (!order.IsCheckedIn)
                {
                    uncheckedOrders.Add(order);
                }
            }
            return uncheckedOrders;
        }
        public Order GetOrder(int OrderNumber)
        {
            foreach(Order order in orders)
            {
                if(OrderNumber == order.OrderNumber)
                {
                    return order;
                }
            }
            return null;
        }
    }
}
