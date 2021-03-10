using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, checker = 0;

            Console.Write("Enter Number: ");
            number = double.Parse(Console.ReadLine());

            while (number != checker)
            {
                checker = number;

                Console.WriteLine(Floor.RoundTointeger(number));

                Console.WriteLine(Floor.RoundToTenth(number));

                Console.WriteLine(Floor.RoundToHundreth(number));

                Console.WriteLine(Floor.RoundToThousandth(number));

                Console.Write("Enter Number: ");
                number = double.Parse(Console.ReadLine());
            } 

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
