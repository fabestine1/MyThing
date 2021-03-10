using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 1, sum = 0, br = 0, avg;

            do
            {
                Console.Write("Enter a real number: ");
                number = double.Parse(Console.ReadLine());
                sum += number;
                br++;
            }
            while (number != 0);

            br--;

            avg = sum / br;

            Console.WriteLine("Your entered {0}, the sum is {1} and the average is {2}", br, sum, avg);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
