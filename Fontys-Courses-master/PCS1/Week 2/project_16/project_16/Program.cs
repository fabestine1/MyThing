using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x\tsquare\tcube");
            int square = 2;
            int cube = 3;
            for(int i=0; i<11; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, Math.Pow(i, square), Math.Pow(i, cube));
            }
            Console.ReadKey();
        }
    }
}
