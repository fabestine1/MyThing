using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter integer 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if(number1 % number2 == 0)
            {
                Console.WriteLine("\nThe first integer is a multiple of the second.");
            }
            else
            {
                Console.WriteLine("\nThe first integer is not a multiple of the second.");
            }
            Console.ReadKey();
        }
    }
}
