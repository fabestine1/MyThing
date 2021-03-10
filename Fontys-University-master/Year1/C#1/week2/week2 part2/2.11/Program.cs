using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double diameter, circumference, area, pi = Math.PI;

            Console.Write("Give me the radius: ");
            radius = int.Parse(Console.ReadLine());

            diameter = 2 * radius;
            circumference = 2 * radius * pi;
            area = pi * Math.Pow(radius, 2);

            Console.WriteLine("Diameter is {0}, circumference is {1}, area is {2}",
                diameter.ToString("#.##"), circumference.ToString("#.##"), area.ToString("#.##"));

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
