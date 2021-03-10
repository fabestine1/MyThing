using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopRevisited
{
    public class Drink: Product
    {
        private DrinkType type;

        public Drink(DrinkType type)
        {
            this.type = type;
            switch (type)
            {
                case DrinkType.FlatWater:
                    this.price = 2.50;
                    this.name = "Flat Water";
                    break;
                case DrinkType.SparklingWater:
                    this.price = 2.50;
                    this.name = "Sparkling Water";
                    break;
                case DrinkType.Cola:
                    this.price = 2.75;
                    this.name = "Cola";
                    break;
                case DrinkType.IceTea:
                    this.name = "Ice Tea";
                    this.price = 2.75;
                    break;
                case DrinkType.EnergyDrink:
                    this.name = "Energy Drink";
                    this.price = 3.75;
                    break;
                default:
                    break;
            }
        }
        public double GetPrice()
        {
            return this.price;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
