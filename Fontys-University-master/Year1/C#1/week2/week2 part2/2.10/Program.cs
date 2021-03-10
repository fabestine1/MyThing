using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, temp;

            Console.Write("Enter first integer: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            second = int.Parse(Console.ReadLine());

            temp = second % first;

            if(temp == 0)
            {
                Console.WriteLine("The first integer is multiple of the second.");
            }

                else
                {
                    Console.WriteLine("The first integer is NOT multiple of the second");
                }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
