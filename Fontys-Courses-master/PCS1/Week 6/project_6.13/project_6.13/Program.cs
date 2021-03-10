using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            Console.Write("Welcome to the shipping application! Enter the type of your truck: ");
            truck.Type = Console.ReadLine();
            int distance = 1;
            double weight = 0;
            while (distance != 0)
            {
                Console.Write("\nPlease enter the distance of the package <enter 0 to exit>: ");
                distance = Convert.ToInt32(Console.ReadLine());
                if (distance != 0)
                {
                    Console.Write("Please enter the weight of the package: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    truck.AddPackage(distance, weight);
                }
                }
            Console.WriteLine("End of program. Here are the statistics:");
            Console.WriteLine(truck.PrintAllInfo());
            Console.ReadKey();
        }
    }
}
