using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double amnt;
            double stTax, cnTax, total;

            Console.Write("Enter the purchase amount: ");
            amnt = int.Parse(Console.ReadLine());

            stTax = amnt * 0.04;
            cnTax = amnt * 0.02;
            total = stTax + cnTax;

            Console.WriteLine("State tax is: " + stTax);
            Console.WriteLine("Country tax is: " + cnTax);
            Console.WriteLine("Total tax is: " + total);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
