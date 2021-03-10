using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInTown = 20 * 21.5;
            Console.WriteLine("distance the car can travel in a town: {0}", distanceInTown);
            double distanceOnHighway = 20 * 26.8;
            Console.WriteLine("distance the car can travel on a highway: {0}", distanceOnHighway);
            Console.ReadKey();
        }
    }
}
