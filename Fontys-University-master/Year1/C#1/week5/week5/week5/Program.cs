using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            Console.Write("Enter a month in numeric value: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter a day in numeric value: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter a year in numeric value: ");
            year = int.Parse(Console.ReadLine());

            year %= 100;

            month.ToString("##");
            day.ToString("##");
            year.ToString("##");

            if(year == month * day)
            {
                Console.WriteLine("The date is magic.");
            }
            else
            {
                Console.WriteLine("The date is NOT magic");
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
