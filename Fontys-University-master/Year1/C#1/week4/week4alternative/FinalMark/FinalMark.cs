using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMark
{
    class FinalMark
    {
        static void Main(string[] args)
        {
            int firstMark, secondMark;
            decimal price;
            String lowOrHigh;
            String month;
            int year;

            Helper help = new Helper();

            Console.Write("Enter First Mark: ");
            firstMark = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Mark: ");
            secondMark = int.Parse(Console.ReadLine());

            Console.WriteLine(help.FinalMark(firstMark, secondMark));

            Console.Write("Enter Price: ");
            price = decimal.Parse(Console.ReadLine());

            Console.Write("Low or Hihg: ");
            lowOrHigh = Console.ReadLine();

            Console.WriteLine(lowOrHigh);
            Console.WriteLine(help.BTW(price, lowOrHigh));

            Console.Write("Enter the month: ");
            month = Console.ReadLine();

            Console.Write("Enter the year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine(help.DaysInMonth(month, year));
            Console.WriteLine(help.DaysInMonth(month, year));
            Console.WriteLine(help.DaysInMonth(month, year));
            Console.WriteLine(help.DaysInMonth(month, year));

            Console.WriteLine(help.Counter());

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
