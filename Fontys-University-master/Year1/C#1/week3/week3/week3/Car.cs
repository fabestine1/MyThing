using System;

namespace carClass
{
    
    class audiCar
    {
        static void Main(string[] args)
        {            
            Car audiCar = new Car("BMW" , 25, "Red", 0);

            /*audiCar.Refill(20);

            Console.WriteLine(audiCar.Fuel);*/

            while (audiCar.Speed < 235 && audiCar.Speed != 0)
            {
                audiCar.Accerelate();

                Console.WriteLine("The audi's speed is {0}", audiCar.Speed);
            }
            while (audiCar.Speed > 200)
            {
                audiCar.Break();

                Console.WriteLine("The audi driver saw a red light and is slowing down to {0}", audiCar.Speed);
            }


            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
