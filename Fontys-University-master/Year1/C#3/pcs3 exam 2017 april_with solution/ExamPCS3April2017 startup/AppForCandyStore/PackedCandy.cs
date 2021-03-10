namespace AppForCandyStore
{
    using System;

    public class PackedCandy : Candy
    {
        private String nameCandy;
        private double pricePerBag;
        private int nrSold;

        public PackedCandy(String nameSalesperson, String nameCandy, double pricePerBag, int nrSold)
            : base(nameSalesperson)
        {
            this.nameCandy = nameCandy;
            this.pricePerBag = pricePerBag;
            this.nrSold = nrSold;
        }

        public override double GetPrice()
        {
            return this.nrSold * pricePerBag;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   ", sold " + this.nrSold.ToString() +
                   " of product " + this.nameCandy;
        }
    }
}
