using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    static class Floor
    {
        public static int RoundTointeger(double number)
        {
            int roundUp;

            roundUp = (int)Math.Floor(number + 0.5); 

            return roundUp;
        }

        public static double RoundToTenth(double number)
        {
            double roundUp;

            roundUp = Math.Floor(number * 10 + 0.5) / 10;

            return roundUp;
        }

        public static double RoundToHundreth(double number)
        {
            double roundUp;

            roundUp = Math.Floor(number * 100 + 0.5) / 100;

            return roundUp;
        }

        public static double RoundToThousandth(double number)
        {
            double roundUp;

            roundUp = Math.Floor(number * 1000 + 0.5) / 1000;

            return roundUp;
        }
    }
}
