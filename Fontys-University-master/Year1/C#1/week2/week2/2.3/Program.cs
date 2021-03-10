using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double gallon = 20, town, highway, trvTown, trvHighway;

            Console.Write("Miles per gallon in town: ");
            town = double.Parse(Console.ReadLine());

            Console.Write("Miles per gallon on highway: ");
            highway = double.Parse(Console.ReadLine());

            trvTown = town * gallon;

            trvHighway = highway * gallon;

            Console.WriteLine("Distance the car can travel in town: " + trvTown);
            Console.WriteLine("Distance the car can travel in highway: " + trvHighway);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
