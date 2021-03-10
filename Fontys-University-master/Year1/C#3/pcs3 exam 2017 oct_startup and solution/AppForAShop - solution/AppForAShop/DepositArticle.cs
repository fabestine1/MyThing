using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class DepositArticle : Article
    {
        private double deposit; //the deposit for this article

        public DepositArticle(int id, String name, double basicPrice, int nrInStock, double deposit)
            : base(id, name, basicPrice, nrInStock)
        {
            this.deposit = deposit;
        }

        public override double getSellingPrice()
        {
            return this.getBasicPrice() + this.deposit;
        }

        public override String ToString()
        {
            String holder;
            holder = "DEP " + base.ToString();
            return holder;
        }
    }
}
