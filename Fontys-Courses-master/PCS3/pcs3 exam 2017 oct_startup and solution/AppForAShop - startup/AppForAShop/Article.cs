using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    abstract class Article : IArticle
    {
        private int id;            //the unique id-number of this article
        private String name;       //the name of this article
        private double basicPrice; //the basic price of this article
        private int nrInStock;     //the number in stock of this article

        public Article(int id, String name, double basicPrice, int nrInStock)
        {   //constructor for wc-art
            this.id = id;
            this.name = name;
            this.basicPrice = basicPrice;
            this.nrInStock = nrInStock;
        }

        public int getID() { return this.id;  }

        public double getBasicPrice() { return this.basicPrice; }

        public abstract double getSellingPrice();
        public void sellSome(int amount)
        {
            if (amount < 1) throw new InsufficientStockException("Amount should be positive.");
            if (nrInStock < amount) throw new InsufficientStockException("Insufficient available stock.");

            this.nrInStock -= amount;
        }

        public override String ToString()
        {
            String holder = this.name + " (" + this.id + ") in stock: " + this.nrInStock  + " selling price: " + this.getSellingPrice().ToString("0.00");
            return holder;    
        }

    }
}
