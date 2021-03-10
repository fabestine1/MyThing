using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, max = 0, value = 0;

            Console.Write("Enter and integer bigger than 10: ");
            n = int.Parse(Console.ReadLine());

            while (n < 10)
            {
                Console.WriteLine("Enter and integer BIGGER than 10: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(sum < n)
                {
                    sum += i;

                    value = i;
                }
            }

            if(sum >= n)
            {
                max = sum;
                sum -= value;
                value--;
            }

            Console.Write("1");

            for (int i = 1; i < value; i++)
            {
                Console.Write(" + {0}", i + 1);
            }

            Console.WriteLine(" = {0}", sum);

            Console.Write("1");

            for (int i = 1; i <= value; i++)
            { 
                Console.Write(" + {0}", i + 1);
            }

            Console.WriteLine(" = {0}", max);

            Console.WriteLine("{0} is less than {1}", sum, n);
            Console.WriteLine("{0} is more or equal to {1}", max, n);
            Console.WriteLine("So the value you are looking for is: {0}", value);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
