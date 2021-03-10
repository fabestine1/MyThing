using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo. This program will calculate \"X to the power of Y\".");
            Console.Write("Please enter X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = x;
            Console.WriteLine("\nI am calculating the power!\n");
            if (y > 0)
            {
                Console.WriteLine("{0} to the power of 1 is {1}", x, x);
                for (int i = 2; i <= y; i++)
                {
                    result *= x;
                    Console.WriteLine("{0} to the power of {1} is {2}", x, i, result);
                }
                Console.ReadKey();
            }
        }
    }
}
