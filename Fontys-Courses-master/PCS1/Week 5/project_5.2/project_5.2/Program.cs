using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter wholesale cost (>=0): ");
            double wholesalecost = Convert.ToDouble(Console.ReadLine());
            int percentagemarkup = -1;
            while (percentagemarkup < 0)
            {
                Console.Write("Enter markup percentage (>=0): ");
                percentagemarkup = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nRetail price: {0:0.00}", wholesalecost + percentagemarkup/100 * wholesalecost);
            Console.ReadKey();
        }
    }
}
