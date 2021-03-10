namespace AppForAShop
{
    using System;

    public class WCArt : Article
    {
        private bool onDiscount; //if true, then this article will be sold cheaper.

        public WCArt(int id, String name, double basicPrice, int nrInStock, bool onDiscount)
            : base(id, name, basicPrice, nrInStock)
        {
            this.onDiscount = onDiscount;
        }

        public override double getSellingPrice()
        {
            if (this.onDiscount)
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
