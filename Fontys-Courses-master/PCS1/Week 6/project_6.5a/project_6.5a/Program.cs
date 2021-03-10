using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                sum = sum + i;
                Console.WriteLine("{0} + {1} = {2}", sum - i, i, sum);
            }
            Console.ReadKey();
        }
    }
}
