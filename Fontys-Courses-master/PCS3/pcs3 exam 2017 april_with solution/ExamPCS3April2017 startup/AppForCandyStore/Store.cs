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

        /// <summary>
        /// returns a list of all sold mixed candy
        /// </summary>
        /// <returns></returns>
        public List<Candy> GetAllSoldCandy()
        {
            return this.soldCandy;
        }

        public List<Candy> GetSoldMixedCandy()
        {
            //todo, assignment 2
            List<Candy> temp = new List<Candy>();
            foreach(Candy candy in soldCandy)
            {
                if(candy is MixedCandy)
                {
                    temp.Add(candy);
                }
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
            //todo, assignment 2
            int[] temp = new int[3];
            foreach(Candy candy in soldCandy)
            {
                if(candy is MixedCandy)
                {
                    temp[0] += ((MixedCandy)candy).WeightLollipops;
                    temp[1] += ((MixedCandy)candy).WeightChewingGums;
                    temp[2] += ((MixedCandy)candy).WeightGummyDrops;
                }
            }
            return temp;
        }

    }
}
