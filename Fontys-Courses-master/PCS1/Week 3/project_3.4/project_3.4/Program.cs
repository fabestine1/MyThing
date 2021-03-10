using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            Console.Write("Enter a model: ");
            myCar1.model = Convert.ToString(Console.ReadLine());
            Console.Write("Enter a colour: ");
            myCar1.colour = Convert.ToString(Console.ReadLine());
            Console.Write("Enter a production year: ");
            myCar1.productionyear = Convert.ToInt32(Console.ReadLine());
            myCar1.startingspeed = 0;
            myCar1.step = 15;
            Car myCar2 = new Car();
            myCar2.model = "BMW";
            myCar2.startingspeed = 0;
            myCar2.step = 20;
            Car myCar3 = new Car();
            myCar3.model = "Fiat";
            myCar3.startingspeed = 0;
            myCar3.step = 5;
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            Console.WriteLine("\nNow some speed changing...");
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Break();
            myCar2.Break();
            myCar3.Break();
            Console.WriteLine("\nAfter breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Break();
            myCar2.Break();
            myCar3.Break();
            Console.WriteLine("\nAfter breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Break();
            myCar2.Break();
            myCar3.Break();
            Console.WriteLine("\nAfter breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Break();
            myCar2.Break();
            myCar3.Break();
            Console.WriteLine("\nAfter breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Break();
            myCar2.Break();
            myCar3.Break();
            Console.WriteLine("\nAfter breaking, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After breaking, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.Accelerate();
            myCar2.Accelerate();
            myCar3.Accelerate();
            Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            for (int i = 0; i < 24; i++)
            {
                myCar1.Accelerate();
                myCar2.Accelerate();
                myCar3.Accelerate();
                Console.WriteLine("\nAfter accelerating, new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
                Console.WriteLine("Colour: {0}, Production year: {1}", myCar1.colour, myCar1.productionyear);
                Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
                Console.WriteLine("After accelerating, new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            }
            Console.ReadKey();
        }
    }
}
