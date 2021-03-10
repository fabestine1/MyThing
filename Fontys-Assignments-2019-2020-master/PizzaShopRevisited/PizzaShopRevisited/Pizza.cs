using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopRevisited
{
    public class Pizza: Product
    {

        private PizzaType type;

        public Pizza(PizzaType type, string topping)
        {
            this.price = 5.99;
            this.name = "Pizza margherita";
            this.type = type;
            switch (type)
            {
                case PizzaType.QuattroFormaggi:
                    this.price += 2;
                    this.name = "Pizza quattro formaggi";
                    break;
                case PizzaType.QuattroStagioni:
                    this.name = "Pizza quattro stagioni";
                    this.price += 1.50;
                    break;
                case PizzaType.Pepperoni:
                    this.name = "Pizza pepperoni";
                    this.price += 1;
                    break;
                case PizzaType.BbqChicken:
                    this.name = "Pizza BBQ chicken";
                    this.price += 1;
                    break;
                default:
                    break;
            }

            switch (topping)
            {
                case "thick":
                    this.name += " - thick";
                    this.price += 0.51;
                    break;
                case "filled":
                    this.name += " - filled";
                    this.price += 1.96;
                    break;

                default:
                    break;
            }

        }
        public string GetName()
        {
            return this.name;
        }
        public double GetPrice()
        {
            return this.price;
        }

    }
}
