using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the falling time in seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            double distance;
            Console.WriteLine("\nStart falling!\n");
            for (int i = 1; i <= seconds; i++)
            {
                distance = 0.5 * 9.8 * i * i;
                Console.WriteLine("Falling distance after {0} second(s):\t{1}", i, distance);
            }
            Console.WriteLine("\nStart falling stars!\n");
            for (int i = 1; i <= seconds; i++)
            {
                double stars = 0.5 * 9.8 * i * i / 20;
                Console.Write("Falling distance after {0} second(s):\t", i);
                for (int star = 0; star < (int) stars; star++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
