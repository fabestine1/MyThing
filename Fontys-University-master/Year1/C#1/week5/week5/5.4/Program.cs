using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.Write("Enter and integer bigger than 10: ");
            n = int.Parse(Console.ReadLine());

            while(n < 10)
            {
                Console.WriteLine("Enter and integer BIGGER than 10: ");
                n = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                sum += i + 1;
                Console.WriteLine("{0} + {1} = {2}", (sum - i - 1), (i + 1), sum);
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
