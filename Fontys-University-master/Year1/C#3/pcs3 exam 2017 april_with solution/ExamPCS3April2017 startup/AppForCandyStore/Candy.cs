namespace AppForCandyStore
{
    using System;

    public abstract class Candy : IPricable
    {
        private String nameSalesperson; //the name of the salesperson
        private DateTime sellingMoment; //the moment it was sold

        public Candy(String nameSalesperson)
        {
            this.nameSalesperson = nameSalesperson;
            this.sellingMoment = DateTime.Now;
        }

       
        public virtual String GetInfo()
        {
            return this.sellingMoment.ToString() + " : " + this.nameSalesperson + " sold " +
                " for price " + this.GetPrice().ToString("F2");//the format "F2" displays 2 decimals
        }

        public abstract double GetPrice();
    }
}
