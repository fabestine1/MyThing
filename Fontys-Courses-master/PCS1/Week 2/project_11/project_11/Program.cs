using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("\nThe integer is even.");
            }
            else
            {
                Console.WriteLine("\nThe integer is odd.");
            }
            Console.ReadKey();
        }
    }
}
