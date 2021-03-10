using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer, temp;

            Console.Write("Enter an integer: ");
            integer = int.Parse(Console.ReadLine());

            temp = integer % 2;

            if(temp == 0)
            {
                Console.WriteLine("The integer is even");
            }

            else
            {
                Console.WriteLine("The integer is odd");
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
