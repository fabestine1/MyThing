using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer, digit1, digit2 = 0, digit3 = 0, digit4 = 0, digit5 = 0, more, less;

            Console.Write("Input 5 digit integer: ");
            integer = int.Parse(Console.ReadLine());

            less = integer / 10000;

            more = less % 10;

            digit1 = integer / 10000;

            digit2 = integer % 10000 / 1000;

            digit3 = integer % 1000 / 100;

            digit4 = integer % 100 / 10;

            digit5 = integer % 10;

            if (less == 0)
            {
                Console.WriteLine("The integer you entered is less than 5 digits");
            }
                else if(more != less)
                {
                    Console.WriteLine("The integer you entered is more than 5 digits");
                }
                    else
                    {
                        Console.WriteLine("{0}-{1}-{2}-{3}-{4}", digit1, digit2, digit3, digit4, digit5);
                    }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
