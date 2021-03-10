using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.Model = "Audi";
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            Console.WriteLine("\nNow some speed changing...");
            myCar1.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Break();
            myCar1.Refuel(35);
            Console.WriteLine("After Refuel 1: {0}", myCar1.Fuel);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            for (int i = 0; i < 24; i++)
            {
                myCar1.Accelerate();
                Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.Model, myCar1.Speed);
            }
            myCar1.Refuel(50);
            Console.WriteLine("After Refuel 2: {0}", myCar1.Fuel);
            Console.ReadKey();
        }
    }
}
