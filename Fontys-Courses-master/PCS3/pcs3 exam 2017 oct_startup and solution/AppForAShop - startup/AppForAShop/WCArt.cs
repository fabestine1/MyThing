using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class WCArt : Article
    {
        private bool onDiscount; //only for wc-art: if true, then this article will be sold cheaper.

        public WCArt(int id, String name, double basicPrice, int nrInStock, bool onDiscount) : base(id, name, basicPrice, nrInStock)
        {   //constructor for wc-art
            this.onDiscount = onDiscount;
        }

        public override double getSellingPrice()
        {
            //it is about wc-art, if on discount, selling price is equal to basic price
            //else selling price is 2 * basic price 
            if (this.onDiscount)
            {
                return this.getBasicPrice();
            }
            else
            {
                return 2 * this.getBasicPrice();
            }
         }

        public override String ToString()
        {
            String holder = "WCART " + base.ToString();
            if (this.onDiscount) { holder += " is on discount."; }
            return holder;
        }
    }
}
