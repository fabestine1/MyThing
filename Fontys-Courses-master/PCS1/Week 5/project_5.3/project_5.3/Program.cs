using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N\tN * N\tN * N * N\tN * N * N * N");
            int i = 1;
            while (i <= number)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", i, i*i, i*i*i, i*i*i*i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
