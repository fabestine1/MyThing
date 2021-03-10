using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopRevisited
{
    public class OrdersHandler
    {
        private List<Order> orders;
        private double revenue;

        public OrdersHandler()
        {
            this.orders = new List<Order>();
            this.revenue = 0.0;
        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public void DeleteOrder(int orderId)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orderId == orders[i].GetOrderId())
                {
                    orders.RemoveAt(i);
                }
            }
        }
        public Order GetOrder(int orderId)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].GetOrderId() == orderId)
                {
                    return orders[i];
                }
            }
            return null;
        }
        public void FinishOrder(int orderId)
        {
            var currentOrder = GetOrder(orderId);
            revenue += currentOrder.GetOrderTotalCost();
        }
        public void AddPizza(int orderId, Pizza pizza)
        {
            var currentOrder = GetOrder(orderId);
            currentOrder.AddPizza(pizza);
        }
        public void AddDrink(int orderId, Drink drink)
        {
            var currentOrder = GetOrder(orderId);
            currentOrder.AddDrink(drink);
        }
        public List<string> StartPrint()
        {
            List<String> firstRows = new List<string>();
            firstRows.Add(" ");
            firstRows.Add("Mario and Luigi Pizza shop !");
            firstRows.Add(" ");
            firstRows.Add(new string('-', 44));

            return firstRows;
        }
        public List<string> PizzaPrint(string pizzaName, int quantity, double totalPrice)
        {
            var list = new List<string>();
            list.Add(" ");
            list.Add(pizzaName);
            list.Add($"\t{quantity} x €{totalPrice / quantity:f2}\t     €{totalPrice}");
            return list;
        }
        public List<string> finishOrder(Customer customer, Order order)
        {
            var list = new List<string>();
            list.Add(" ");
            list.Add(new string('-', 44));
            list.Add($"TOTAL\t      €{order.GetOrderTotalCost():f2}");
            list.Add(new string('-', 44));
            list.Add($"ORDERED BY {customer.GetCustomerName()}");
            list.Add($"\tON {order.GetTimestamp()}");
            return list;
        }
        
        public List<Order> GetOrders()
        {
            return this.orders;
        }
        public void AddRevenue(double price)
        {
            this.revenue += price;
        }
        public double GetRevenue()
        {
            return this.revenue;
        }
        public void SetNewList(List<Order> list)
        {
            this.orders = list;
        }
    }
}
