using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number <= 10)
            {
                Console.Write("Enter an integer larger than 10: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            if (number > 10)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}
