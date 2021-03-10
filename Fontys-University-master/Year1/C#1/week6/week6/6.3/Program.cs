using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, n = 1, sum = 0, temp = 0;

            Console.Write("Enter the limit: ");
            limit = int.Parse(Console.ReadLine());

            while(n <= limit)
            {
                sum = temp + n;
                Console.WriteLine("{0} + {1} = {2}", temp, n, sum);
                n++;
                temp = sum;
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
