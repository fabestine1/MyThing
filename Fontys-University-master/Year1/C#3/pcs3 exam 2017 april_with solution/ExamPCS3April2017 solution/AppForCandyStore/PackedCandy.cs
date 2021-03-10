using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class PackedCandy : Candy
    {
        private String nameCandy; //the name of the sold candy
        private int numberSold;  //how much are sold
        private double pricePerBag;

        public PackedCandy(String nameSalesperson, String nameCandy, double pricePerBag,int nrSold)
            : base(nameSalesperson)
        {
            this.nameCandy = nameCandy;
            this.pricePerBag = pricePerBag;
            this.numberSold = nrSold;
        }
        public override double GetPrice()
        {
            return this.numberSold * this.pricePerBag;
        }

        public override String GetInfo()
        {
            return base.GetInfo() +
                ", sold " + this.numberSold.ToString() +
                " of product " + this.nameCandy ;
        }
    }
}
