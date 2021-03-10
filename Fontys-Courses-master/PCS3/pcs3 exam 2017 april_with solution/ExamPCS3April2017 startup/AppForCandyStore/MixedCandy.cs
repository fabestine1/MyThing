using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class MixedCandy : Candy
    {
        private double pricePerKilogram;
        public int WeightLollipops { get; }
        public int WeightChewingGums { get; }
        public int WeightGummyDrops { get; }
        public MixedCandy(String nameSalesperson, double pricePerKilogram, int weightLollipops, int weightChewingGums, int weightGummyDrops) : base(nameSalesperson)
        {
            this.pricePerKilogram = pricePerKilogram;
            this.WeightLollipops = weightLollipops;
            this.WeightChewingGums = weightChewingGums;
            this.WeightGummyDrops = weightGummyDrops;
        }
        public override double GetPrice()
        {
            return (WeightLollipops + WeightChewingGums + WeightGummyDrops) * pricePerKilogram / 1000;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + ", mixed candy with total weight " + (WeightLollipops + WeightChewingGums + WeightGummyDrops);
        }
    }
}
