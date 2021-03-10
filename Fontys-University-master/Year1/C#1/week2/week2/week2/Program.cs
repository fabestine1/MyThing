using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent, phone, cable, util;
            int month = 0, year = 0;

            Console.WriteLine("Enter your costs for: ");

            Console.Write("Rent = ");
            rent = int.Parse(Console.ReadLine());

            Console.Write("Phone = ");
            phone = int.Parse(Console.ReadLine());
            
            Console.Write("Cable = ");
            cable = int.Parse(Console.ReadLine());

            Console.Write("Utilities = ");
            util = int.Parse(Console.ReadLine());

            month = rent + phone + cable + util;

            year = 12 * month;

            Console.WriteLine("Your monthly cost is " + month);
            Console.WriteLine("Your annual cost is " + year);
            
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
