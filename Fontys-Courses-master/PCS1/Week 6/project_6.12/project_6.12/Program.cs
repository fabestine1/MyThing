using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            Console.Write("Enter the model name: ");
            myCar1.model = Console.ReadLine();
            myCar1.speed = 0;
            myCar1.step = 10;
            Console.WriteLine("Current speed of {0} is: {1}", myCar1.model, myCar1.speed);
            Console.Write("Choose the action <a> accelerate or <b> break: ");
            char action = Convert.ToChar(Console.ReadLine());
            while (action == 'a' || action == 'b')
            {
                if (action == 'a')
                {
                    myCar1.Accelerate();
                }
                else
                {
                    myCar1.Break();
                }
                Console.WriteLine("Current speed of {0} is: {1}", myCar1.model, myCar1.speed);
                Console.Write("Choose the action <a> accelerate or <b> break: ");
                action = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
