using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, firstpow = 1, secondpow = 1;

            Console.Write("Enter the value of X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of Y: ");
            y = int.Parse(Console.ReadLine());

            for(int i = 1; i <= y; i++)
            {
                firstpow *= x;

                Console.WriteLine("{0} to the power of {1} is: {2}", x, i, firstpow);
            }

            for(int i = 0; i < y; i++)
            {
                secondpow *= x;

                if(i + 1 < y)
                {
                    Console.Write("{0} * ", x);
                }
            }

            Console.WriteLine("{0} = {1}",x ,secondpow);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
