using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._4_and_4._5
{
    class SneezCalculator
    {
        private int[] catalanNumbers;

        public SneezCalculator() { }

        public int GetSeezNumber(int i)
        {
            catalanNumbers = new int[] { 1, 1,2,5,14,42,132, 429, 1430, 4862,
                                         16796, 58786, 208012, 742900, 2674440,
                                         9694845, 35357670, 129644790, 477638700, 1767263190
            };

            return catalanNumbers[i] / (catalanNumbers[i - 1] - (int)(Math.Pow(2, i - 1)) - 10);
        }
    }
}
