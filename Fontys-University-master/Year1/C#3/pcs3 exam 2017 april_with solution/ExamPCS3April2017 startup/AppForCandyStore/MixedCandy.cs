namespace AppForCandyStore
{
    using System;

    public class MixedCandy : Candy
    {
        private double pricePerKilogram;
        private int weightLollipops;
        private int weightChewingGums;
        private int weightGummyDrops;

        public int WeightLollipops { get => weightLollipops; set => weightLollipops = value; }
        public int WeightChewingGums { get => weightChewingGums; set => weightChewingGums = value; }
        public int WeightGummyDrops { get => weightGummyDrops; set => weightGummyDrops = value; }

        public MixedCandy(String nameSalesperson, double pricePerKilogram,
            int weightLollipops, int weightChewingGums, int weightGummyDrops)
            : base(nameSalesperson)
        {
            this.pricePerKilogram = pricePerKilogram;
            this.WeightLollipops = weightLollipops;
            this.WeightChewingGums = weightChewingGums;
            this.WeightGummyDrops = weightGummyDrops;
        }

        public override double GetPrice()
        {
            return (this.WeightLollipops + this.WeightChewingGums + this.WeightGummyDrops) * pricePerKilogram / 1000;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   ", mixed candy with total weight " + this.WeightLollipops + this.WeightChewingGums + this.WeightGummyDrops;
        }
    }
}
