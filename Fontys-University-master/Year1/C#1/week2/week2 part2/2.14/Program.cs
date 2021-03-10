using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, square = 1, cube = 1;

            Console.WriteLine("{0}   {1} {2}", "x", "square", "cube");

            for(int i = 0; i < 10; i++)
            {
                x = i;
                square = x * x;
                cube = x * x * x;

                Console.WriteLine("{0}   {1}      {2}", x , square, cube);
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
