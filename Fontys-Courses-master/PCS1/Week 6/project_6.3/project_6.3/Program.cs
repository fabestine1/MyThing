using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._3
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
            Console.ReadKey();
        }
    }
}
