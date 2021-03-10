using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._1
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
            if (y > 0)
            {
                for (int i = 1; i < y; i++)
                {
                    result *= x;
                }
                Console.WriteLine("\nI am calculating the power!\n{0} to the power of {1} is {2}", x, y, result);
                Console.ReadKey();
            }
        }
    }
}
