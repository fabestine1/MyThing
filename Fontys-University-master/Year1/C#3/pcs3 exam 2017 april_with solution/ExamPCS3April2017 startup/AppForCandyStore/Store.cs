namespace AppForCandyStore
{
    using System;
    using System.Collections.Generic;

    public class Store
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
            var temp = new List<Candy>();
            foreach (var s in this.soldCandy)
            {
                if (s is MixedCandy)
                {
                    temp.Add(s);
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
            int loppipops = 0;
            int gums = 0;
            int drops = 0;

            foreach (var candy in this.GetSoldMixedCandy())
            {
                loppipops += ((MixedCandy) candy).WeightLollipops;
                gums += ((MixedCandy) candy).WeightChewingGums;
                drops += ((MixedCandy) candy).WeightGummyDrops;
            }
            int[] arr = new[] {loppipops, gums, drops};
            return arr;
        }

    }
}
