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
        private int weightOfLollipops;
        private int weightOfChewingGums;
        private int weightOfGummyDrops;

        public int WeightOfLollipops { get { return this.weightOfLollipops; } }
        public int WeightOfChewingGums { get { return this.weightOfChewingGums; } }
        public int WeightOfGummyDrops { get { return this.weightOfGummyDrops; }
        }
        public MixedCandy(String nameSalesperson, double pricePerKilogram, int wLollipops, int wChewingGums, int wGummyDrops)
            :base(nameSalesperson)
        {
            this.pricePerKilogram = pricePerKilogram;
            this.weightOfLollipops = wLollipops;
            this.weightOfChewingGums = wChewingGums;
            this.weightOfGummyDrops = wGummyDrops;
        }

        public override double GetPrice()
        {
            return this.getTotalWeight() * this.pricePerKilogram / 1000;
        }

        private int getTotalWeight()
        {
            return this.weightOfLollipops + this.weightOfChewingGums + this.weightOfGummyDrops;
        }
        public override String GetInfo()
        {
            return base.GetInfo() +
                ", mixed candy with total weight " + this.getTotalWeight().ToString();
        }
    }
}
