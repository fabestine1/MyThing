using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Audi";
            myCar.startingspeed = 25;
            Console.WriteLine("Starting speed of {0} is: {1} km/h", myCar.model, myCar.startingspeed);
            Console.WriteLine("\nNow some speed changing...");
            myCar.ChangeSpeed(50);
            Console.WriteLine("\nAfter setting to 50, the new speed of {0} is: {1} km/h", myCar.model, myCar.startingspeed);
            myCar.ChangeSpeed(51);
            Console.WriteLine("After setting to 51, the new speed of {0} is: {1} km/h", myCar.model, myCar.startingspeed);
            myCar.ChangeSpeed(-98);
            Console.WriteLine("After setting to -98, the new speed of {0} is: {1} km/h", myCar.model, myCar.startingspeed);
            myCar.ChangeSpeed(698);
            Console.WriteLine("After setting to 698, the new speed of {0} is: {1} km/h", myCar.model, myCar.startingspeed);
            myCar.ChangeSpeed(5);
            Console.WriteLine("After setting to 5, the new speed of {0} is: {1} km/h", myCar.model, myCar.startingspeed);
            Console.ReadKey();
        }
    }
}
