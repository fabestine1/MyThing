using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._5b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the last number: ");
            int last = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the limit: ");
            int increase = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= last; i++)
            {
                sum += first;
                first += increase;
                Console.WriteLine("{0} + {1} = {2}", sum - first + increase, first - increase, sum);
            }
            Console.ReadKey();
        }
    }
}
