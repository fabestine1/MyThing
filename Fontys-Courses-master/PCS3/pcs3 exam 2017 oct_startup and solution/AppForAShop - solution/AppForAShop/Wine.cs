using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class Wine : Article
    {
        private int year; //the year this wine was bottled

        public Wine(int id, String name, double basicPrice, int nrInStock, int year)
            : base(id, name, basicPrice, nrInStock)
        {
            this.year = year;
        }

        public int Year { get { return this.year; } }

        public override double getSellingPrice()
        {
            return this.getBasicPrice() + (DateTime.Now.Year - this.year) * 2.0;
        }

        public override String ToString()
        {
            String holder;
            holder = "WINE "+ base.ToString() + " year: " + this.year;
            return holder;
        }
    }
}
