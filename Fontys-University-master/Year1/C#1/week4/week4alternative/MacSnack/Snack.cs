using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSnack
{
    class Snack
    {
        private int _numberInStock;
        private double _costPrice;
        private double _sellingPrice;

        public Snack(String name, bool isVegetarian, int numberInStock, double costPrice)
        {
            this.Name = name;
            this.IsVegetarian = isVegetarian;
            this.NumberInStock = numberInStock;
            this.CostPrice = costPrice;
        }

        public String Name { get; set; }

        public bool IsVegetarian { get; set; }

        public int NumberInStock
        {
            get
            {
                return this._numberInStock;
            }
            private set
            {
                if(value < 0)
                {
                    value = 0;
                }
                this._numberInStock = value;
            }
        }
        public double CostPrice
        {
            get
            {
                return this._costPrice;
            }
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this._costPrice = value;
            }
        }
        public double SellingPrice
        {
            get
            {
                return this._sellingPrice = this.CostPrice * 1.5; 
            }
        }
        public String Info()
        {
            String temp;

            if(IsVegetarian == true)
            {
                temp = Name + ", vegetarian, " + NumberInStock + " in stock, selling price: " + SellingPrice;
            }
            else
            {
                temp = Name + ", NOT vegetarian, " + NumberInStock + " in stock, selling price: " + SellingPrice;
            }
            return temp;
        }
        public int Bought(int bought)
        {
            this.NumberInStock -= bought;

            return this.NumberInStock;
        }
        public double Price(double bought)
        {
            double price;

            price = bought * SellingPrice;

            return price;
        }
    }
}
