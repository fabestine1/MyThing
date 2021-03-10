using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForCandyStore
{
    class Store
    {
        private String name; //the name of this shop
        private List<Candy> soldCandy; //a list holding the sold candy

        public String Name { get { return this.name; } }

        public Store(String name)
        {
            this.name = name;
            this.soldCandy = new List<Candy>();
        }

        public void AddCandy(Candy c)
        {
            this.soldCandy.Add(c);
        }

        public List<Candy> GetAllSoldCandy()
        {
            return this.soldCandy;
        }

        public List<Candy> GetSoldMixedCandy()
        {
            List<Candy> temp = new List<Candy>();
            foreach (Candy c in this.soldCandy)
            {
                if (c is MixedCandy) { temp.Add(c); }
            }
            return temp;
        }
        /// <summary>
        /// returns an array with 3 numbers
        /// the first number is the total weight of loppipops of all sold mixed candy,
        /// the second number is the total weight of chewing gums of all sold mixed candy,
        /// the third number is the total weight of gummy drops of all sold mixed candy,
        /// </summary>
        /// <returns></returns>
        public int[] GetWeightsMixedCandy()
        {
            int[] temp = new int[3];
            foreach(Candy c in this.soldCandy)
            {
                if (c is MixedCandy)
                {
                    temp[0] += ((MixedCandy)c).WeightOfLollipops;
                    temp[1] += ((MixedCandy)c).WeightOfChewingGums;
                    temp[2] += ((MixedCandy)c).WeightOfGummyDrops;
                }
            }
            return temp;
        }
    }
}
