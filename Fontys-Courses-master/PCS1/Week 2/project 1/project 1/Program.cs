using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age % 2 == 0)
            {
                Console.WriteLine("\n\nHello {0}!", name);
                Console.WriteLine("Your age is an even number");
                Console.WriteLine("Next year you are {0}", age + 1);
            }
            if (age % 2 == 1)
            {
                Console.WriteLine("\n\nHello {0}!", name);
                Console.WriteLine("Your age is an odd number");
                Console.WriteLine("Next year you are {0}", age + 1);
            }
            if (age < 0)
            {
                Console.WriteLine("This is impossible");
            }
            Console.ReadKey();
        }
    }
}
