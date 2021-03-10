using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, temp;
            bool checker = false;

            Console.Write("Enter and integer higher or equal to {0}: ", number);
            number = int.Parse(Console.ReadLine());

            temp = number;

            do
            {
                Console.Write("Enter and integer higher or equal to {0}: ", number);
                number = int.Parse(Console.ReadLine());

                if (number >= temp)
                {
                    temp = number;
                }
                else if(number < temp && number != 0)
                {
                    Console.WriteLine("You made an error, {0} > {1}", temp, number);
                    checker = true;
                }
            }
            while (number != 0 && number >= temp);

            if(checker == false)
            {
                Console.WriteLine("You did it,, good job");
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
