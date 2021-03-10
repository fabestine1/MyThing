using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a two digit year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if(month*day == year)
            {
                Console.WriteLine("Date is magic");
            }
            else
            {
                Console.WriteLine("Date is not magic");
            }
            Console.ReadKey();
        }
    }
}
