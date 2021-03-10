using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            int c;
            c = x;
            x = y;
            y = c;
            Console.WriteLine("x = " + x + "    y=" + y);
            Console.ReadKey();

        }
    }
}
