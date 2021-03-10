using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.model = "Audi";
            myCar1.startingspeed = 0;
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("\nNow some speed changing...");
            myCar1.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Break();
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            myCar1.Accelerate();
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            for(int i=0; i<24; i++)
            {
                myCar1.Accelerate();
                Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            }
            Console.ReadKey();
        }
    }
}
