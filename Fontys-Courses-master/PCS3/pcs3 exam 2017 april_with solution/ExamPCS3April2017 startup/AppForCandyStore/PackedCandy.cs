using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class PackedCandy : Candy
    {
        private String nameCandy;
        private double pricePerBag;
        private int nrSold;
        public PackedCandy(String nameSalesperson, String nameCandy, double pricePerBag, int nrSold) : base (nameSalesperson)
        {
            this.nameCandy = nameCandy;
            this.pricePerBag = pricePerBag;
            this.nrSold = nrSold;
        }
        public override double GetPrice()
        {
            return nrSold * pricePerBag;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + ", sold " + nrSold + " of product " + nameCandy;
        }
    }
}
