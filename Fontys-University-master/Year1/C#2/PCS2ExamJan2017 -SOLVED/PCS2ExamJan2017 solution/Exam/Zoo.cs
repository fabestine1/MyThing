using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Zoo
    {
        // assignment 3a
        private List<Order> orders;
        public string Name { get; private set; }

        // assignment 3b
        public Zoo(string name)
        {
            this.orders = new List<Order>();
            this.Name = name;
        }

        // assignment 3c
        public void AddOrder(Order o)
        {        
                orders.Add(o);            
        }

        // assignment 3d
        public List<Order> GetAllOrders()
        {
            return this.orders;
        }

        // assignment 3e
        public List<Order> GetUncheckedOrders()
        {
            List<Order> temp = new List<Order>();
            foreach (Order o in this.orders)
            {
                if (o.IsCheckedIn == false)
                {
                    temp.Add(o);
                }
            }
            return temp;
        }

        // assignment 3f
        public Order GetOrder(int nr)
        {
            foreach (Order order in this.orders)
            {
                if (order.OrderNumber == nr)
                {
                    return order;
                }
            }
            return null;
        }
    }
}
