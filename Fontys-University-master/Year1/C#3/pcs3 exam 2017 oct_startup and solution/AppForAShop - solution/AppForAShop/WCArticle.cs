using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class WCArticle : Article
    {
        private bool onDiscount; //if true, then this article will be sold cheaper.

        public WCArticle(int id, String name, double basicPrice, int nrInStock, bool onDiscount)
            : base(id, name, basicPrice, nrInStock)
        {
            this.onDiscount = onDiscount;
        }

        public override double getSellingPrice()
        {
            if(this.onDiscount)
            {
                return this.getBasicPrice();
            }
            else
            {
                return this.getBasicPrice() * 2;
            }
            
        }

        public override String ToString()
        {
            String holder;
            holder = "WCART " + base.ToString();
            if (this.onDiscount) { holder += " is on discount."; }
            return holder;
        }
    }
}
