using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your costs for");
            Console.Write("for rent or mortgage payment: ");
            double rentOrMortgage = Convert.ToDouble(Console.ReadLine());
            Console.Write("for phones: ");
            double phones = Convert.ToDouble(Console.ReadLine());
            Console.Write("for cable: ");
            double cable = Convert.ToDouble(Console.ReadLine());
            Console.Write("for utilities: ");
            double utilities = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nyour monthly cost: {0}", rentOrMortgage + phones + cable + utilities);
            Console.WriteLine("your annual cost: {0}", (rentOrMortgage + phones + cable + utilities) * 12);
            Console.ReadKey();
        }
    }
}
