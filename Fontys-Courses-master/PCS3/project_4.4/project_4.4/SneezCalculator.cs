using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._4
{
    class SneezCalculator
    {
        private int[] catalanNumbers;

        public SneezCalculator()
        {
            catalanNumbers = new int[] { 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, 208012, 742900, 2674440, 9694845, 35357670, 129644790, 477638700, 1767263190 };
        }
        public int GetSneezeNumber(int i)
        {
            if (i >= 3 && i <= 19 && i != 6)
                return catalanNumbers[i] / (catalanNumbers[i - 1] - (int)(Math.Pow(2, i - 1)) - 10);
            else
                throw new NoSuchSneezNumberExcepiton();
        }
    }
}
