using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];
            int negative = 0;
            int positive = 0;
            int zero = 0;
            for (int i=0; i<5; i++)
            {
                Console.Write("Enter numeric value {0}: ", i+1);
                array[i] = Convert.ToDouble(Console.ReadLine());
                if (array[i] < 0)
                {
                    negative += 1;
                }
                else if (array[i] > 0)
                {
                    positive += 1;
                }
                else
                {
                    zero += 1;
                }
            }
            Console.WriteLine("\nNumber of negative values: {0}", negative);
            Console.WriteLine("Number of positive values: {0}", positive);
            Console.WriteLine("Number of zero values: {0}", zero);
            Console.ReadKey();
        }
    }
}
