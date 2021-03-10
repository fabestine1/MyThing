using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, firstNumber, lastNumber, increase, temp = 0;

            Console.Write("Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the last number: ");
            lastNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the increase: ");
            increase = int.Parse(Console.ReadLine());

            for(int i = firstNumber; i < lastNumber; i += increase)
            {
                sum = temp + i;
                Console.WriteLine("{0} + {1} = {2}", temp, i, sum);
                temp = sum;
            }

            Console.WriteLine("Sum is {0}", sum);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
