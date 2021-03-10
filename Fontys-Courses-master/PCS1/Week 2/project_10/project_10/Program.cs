using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer 4: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer 5: ");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSum of integers: {0}", number1 + number2 + number3 + number4 + number5);
            Console.WriteLine("Average of integers: {0}", (number1 + number2 + number3 + number4 + number5) / 5);
            Console.WriteLine("Product of integers: {0}", number1 * number2 * number3 * number4 * number5);
            Console.WriteLine("Smallest of integers: {0}", Math.Min(Math.Min(Math.Min(Math.Min(number1, number2), number3), number4), number5));
            Console.WriteLine("Largest of integers: {0}", Math.Max(Math.Max(Math.Max(Math.Max(number1, number2), number3), number4), number5));
            Console.ReadKey();
        }
    }
}
