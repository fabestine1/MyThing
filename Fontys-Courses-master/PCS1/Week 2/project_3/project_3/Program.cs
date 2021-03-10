using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the purchase amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double stateTax = 0.04 * amount;
            double countryTax = 0.02 * amount;
            double totalTax = stateTax + countryTax;
            Console.WriteLine("\nState tax is: {0}", stateTax);
            Console.WriteLine("Country tax is: {0}", countryTax);
            Console.WriteLine("Total tax is: {0}", totalTax);
            Console.ReadKey();
        }
    }
}
