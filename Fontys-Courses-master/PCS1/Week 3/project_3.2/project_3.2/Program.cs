using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.model = "Audi";
            myCar1.startingspeed = 25;
            Car myCar2 = new Car();
            myCar2.model = "Mercedes";
            myCar2.startingspeed = 47;
            Car myCar3 = new Car();
            myCar3.model = "Lamborghini";
            myCar3.startingspeed = 54;
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            Console.WriteLine("\nNow some speed changing...");
            myCar1.ChangeSpeed(36);
            myCar2.ChangeSpeed(26);
            myCar3.ChangeSpeed(78);
            Console.WriteLine("\nAfter setting to 36, the new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("After setting to 26, the new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After setting to 78, the new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.ChangeSpeed(53);
            myCar2.ChangeSpeed(74);
            myCar3.ChangeSpeed(37);
            Console.WriteLine("\nAfter setting to 53, the new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("After setting to 74, the new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After setting to 37, the new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.ChangeSpeed(63);
            myCar2.ChangeSpeed(72);
            myCar3.ChangeSpeed(74);
            Console.WriteLine("\nAfter setting to 63, the new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("After setting to 72, the new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After setting to 74, the new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.ChangeSpeed(63);
            myCar2.ChangeSpeed(66);
            myCar3.ChangeSpeed(73);
            Console.WriteLine("\nAfter setting to 63, the new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("After setting to 66, the new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After setting to 73, the new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            myCar1.ChangeSpeed(52);
            myCar2.ChangeSpeed(74);
            myCar3.ChangeSpeed(83);
            Console.WriteLine("\nAfter setting to 52, the new speed of {0} is: {1} km/h", myCar1.model, myCar1.startingspeed);
            Console.WriteLine("After setting to 74, the new speed of {0} is: {1} km/h", myCar2.model, myCar2.startingspeed);
            Console.WriteLine("After setting to 83, the new speed of {0} is: {1} km/h", myCar3.model, myCar3.startingspeed);
            Console.ReadKey();
        }
    }
}
