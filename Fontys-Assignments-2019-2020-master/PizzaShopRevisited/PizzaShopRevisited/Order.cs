using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopRevisited
{
    public class Order
    {
        private Customer customer;
        private string timestamp;
        private string rawTimestamp;
        private List<Pizza> pizzas;
        private List<Drink> drinks;
        private int orderId;
        private double orderCost;
        private static int idSeeder = 100;

        public Order(Customer customer)
        {
            this.customer = customer;
            this.timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            this.rawTimestamp = DateTime.Now.ToString("MM/dd/yyyy");
            this.pizzas = new List<Pizza>();
            this.drinks = new List<Drink>();
            this.orderCost = 0.0;
            this.orderId = idSeeder;
            idSeeder++;
        }
        
        public void AddPizza(Pizza pizza)
        {
            this.pizzas.Add(pizza);
            orderCost += pizza.GetPrice();
        }
        public void AddDrink(Drink drink)
        {
            this.drinks.Add(drink);
            orderCost += drink.GetPrice();
        }
        public int GetOrderId()
        {
            return this.orderId;
        }
        public double GetOrderTotalCost()
        {
            return orderCost;
        }
        public void DeletePizza(string pizza)
        {
            pizzas.RemoveAt(pizzas.Count - 1);
        }
        public void DeleteDrink(string drink)
        {
            drinks.RemoveAt(drinks.Count - 1);
        }
        public string GetTimestamp()
        {
            return this.timestamp;
        }
        public string GetRawTime()
        {
            return this.rawTimestamp;
        }
        public string GetCustomerName()
        {
            return this.customer.GetCustomerName();
        }
    }
}
