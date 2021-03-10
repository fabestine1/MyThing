using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._6
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
            Console.WriteLine("Your choice: {0}", number);
            int sum = 0;
            if (number > 10)
            {
                int lastnumber = 0;
                int i = 0;
                while (sum + i < number)
                {
                    sum += i;
                    lastnumber = i;
                    i++;
                }
                Console.Write("1 + 2 + 3 + ... + {0} equals {1}\n{1} is less than {2}", lastnumber, sum, number);
                while (sum < number)
                {
                    sum += i;
                    lastnumber = i;
                    i++;
                }
                Console.Write("\n1 + 2 + 3 + ... + {0} equals {1}\n{1} is greater than or equal to {2}\nSo the value asked for is: {3}.", lastnumber, sum, number, lastnumber-1);
                Console.ReadKey();
            }
        }
    }
}
