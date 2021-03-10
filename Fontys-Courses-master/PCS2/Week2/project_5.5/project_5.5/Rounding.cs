using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._5
{
    public static class Rounding
    {
        public static int RoundToInteger(double number)
        {
            return (int)Math.Round(number, 0);
        }
        public static double RoundToTenths(double number)
        {
            return Math.Round(number, 1);
        }
        public static double RoundToHundredths(double number)
        {
            return Math.Round(number, 2);
        }
        public static double RoundToThousandths(double number)
        {
            return Math.Round(number, 3);
        }
    }
}
