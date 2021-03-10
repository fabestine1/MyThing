using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double wholesale = -1, markupPresentage = -1, retailPrice;

            while(wholesale < 0)
            {
                Console.Write("Enter wholesale cost: ");
                wholesale = int.Parse(Console.ReadLine());
            }

            while(markupPresentage < 0)
            {
                Console.Write("Enter markup presentage: ");
                markupPresentage = int.Parse(Console.ReadLine());
            }

            retailPrice = wholesale + wholesale * markupPresentage / 100;

            Console.WriteLine("Retail Price: {0}", retailPrice.ToString("0.00"));

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
