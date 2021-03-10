using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5-digit integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n{0}-{1}-{2}-{3}-{4}", number / 10000, (number % 10000) / 1000, (number % 1000) / 100, (number % 100) / 10, (number % 10000) % 10);
            Console.ReadKey();
        }
    }
}
