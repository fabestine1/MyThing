using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter positive integer: ");
            n = int.Parse(Console.ReadLine());

            while(n < 0)
            {
                Console.Write("Enter POSITIVE integer: ");
                n = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("N\tN*N\tN*N*N\tN*N*N*N");

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i, Math.Pow(i, 2), Math.Pow(i, 3), Math.Pow(i, 4));
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
