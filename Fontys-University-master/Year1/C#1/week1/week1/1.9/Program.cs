using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int tempx, tempy;

            Console.Write("Enter a value for x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter a value for y: ");
            y = int.Parse(Console.ReadLine());

            tempx = x;
            tempy = y;

            x = tempy;
            y = tempx;

            Console.WriteLine("At the end: x = " + x + " y = " + y);

            /* Another way:
              
            Console.WriteLine("At the end: x = " + y + " y = " + x);
            
             */
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
