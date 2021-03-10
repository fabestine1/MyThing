using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter positive integer numbers in ascending order <i.e., from smaller to higher>.\nEnter 0 to exit this program.");
            int last = 0;
            int number;
            do
            {
                Console.Write("Please enter an integer higher or equal to {0}: ", last);
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= last)
                {
                    last = number;
                }
            }
            while (number != 0 && number >= last);
            if (last > number && number != 0)
            {
                Console.WriteLine("Oops, you made an error: {0} > {1} ", last, number);
            }
            else
            {
                Console.WriteLine("Congratulations, you did not make an error!");
            }
            Console.ReadKey();
        }
    }
}
