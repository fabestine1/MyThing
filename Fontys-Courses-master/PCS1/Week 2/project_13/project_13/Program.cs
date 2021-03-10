using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDiameter: {0}", 2*radius);
            Console.WriteLine("Circumference: {0}", 2 * radius * 3.14159);
            Console.WriteLine("Area: {0}", 3.14159 * radius * radius);
            Console.ReadKey();
        }
    }
}
