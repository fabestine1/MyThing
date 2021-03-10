using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the average value of a serie of numbers.\nPlease enter non-zero real numbers.\nEnter a zero < 0 > to end this program.\n");
            double number;
            int count = 0;
            double sum = 0;
            double average = 0;
            do
            {
                Console.Write("Please enter a real number: ");
                number = Convert.ToDouble(Console.ReadLine());
                if (number != 0)
                {
                    count++;
                    sum += number;
                    average = sum / count;
                }
            }
            while (number != 0);
            Console.WriteLine("\nYou entered {0} value(s). The sum was {1} and the average was {2}.", count, sum, average);
            Console.ReadKey();
        }
    }
}
