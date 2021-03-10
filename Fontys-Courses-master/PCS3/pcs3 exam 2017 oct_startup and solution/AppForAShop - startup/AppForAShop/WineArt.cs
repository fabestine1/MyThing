using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class WineArt : Article
    {
        public int Year { get; } //only for wine: the year this wine was bottled

        public WineArt(int id, String name, double basicPrice, int nrInStock, int year) : base(id, name, basicPrice, nrInStock)
        {   //constructor for wine
            this.Year = year;
        }

        public override double getSellingPrice()
        {
            //it is about wine, selling price is basic price + 2.00 for every year of age
            return this.getBasicPrice() + (DateTime.Now.Year - this.Year) * 2.0;
        }

        public override String ToString()
        {

            String holder
                = "WINE " + base.ToString()
                    + " year: " + this.Year;
            return holder;
        }
    }
}
