using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._2b
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
                Console.Write("{0}", x);
                for (int i = 1; i < y; i++)
                {
                    result *= x;
                    Console.Write(" * 2");
                }
                Console.Write(" = {0}", result);
                Console.ReadKey();
            }
        }
    }
}
