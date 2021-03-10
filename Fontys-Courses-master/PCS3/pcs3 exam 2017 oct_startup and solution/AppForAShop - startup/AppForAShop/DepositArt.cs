using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class DepositArt : Article
    {
        private double deposit; //the deposit for this article

        public DepositArt(int id, String name, double basicPrice, int nrInStock, double deposit) : base(id, name, basicPrice, nrInStock)
        {   //constructor for a deposit article
            this.deposit = deposit;
        }

        public override double getSellingPrice()
        {
            return this.getBasicPrice() + deposit;
        }

        public override String ToString()
        {
            String holder = "DEP" + base.ToString();
            return holder;
        }
    }
}
