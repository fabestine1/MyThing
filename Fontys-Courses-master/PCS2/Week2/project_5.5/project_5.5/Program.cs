using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double nwNumber = 1;
            bool isNew = true;
            while (isNew)
            {
                Console.Write("Enter a number: ");
                nwNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Original value: " + nwNumber);
                Console.WriteLine("Rounded to nearest integer: " + Rounding.RoundToInteger(nwNumber));
                Console.WriteLine("Rounded to nearest tenth: " + Rounding.RoundToTenths(nwNumber));
                Console.WriteLine("Rounded to nearest hundredth: " + Rounding.RoundToHundredths(nwNumber));
                Console.WriteLine("Rounded to nearest thousandth: " + Rounding.RoundToThousandths(nwNumber));
                if (nwNumber == number)
                {
                    isNew = false;
                }
                number = nwNumber;
            }
        }
    }
}
