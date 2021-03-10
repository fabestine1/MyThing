using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            double g = 9.8, d1 = 0, d2 = 0, temp;

            Console.Write("Enter falling time: ");
            t = int.Parse(Console.ReadLine());

            for(int i = 1; i <= t; i++)
            {
                d1 = g * i * i / 2;
                Console.WriteLine("Falling distance after {0} second<s>: {1}", i, d1);
            }

            Console.WriteLine();
            Console.WriteLine();

            for(int i = 1; i <= t; i++)
            {
                d2 = g * i * i / 2;
                temp = d2 / 20;
                Console.Write("Falling distance after {0} seconds<s>: ", i);
                while(temp >= 1)
                {
                    temp--;
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
