using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int asterisk = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (i == 3 || i == 4)
                {
                    asterisk = 4;
                }
                else
                {
                    asterisk = i;
                }
                for (int count = 1; count <= asterisk; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 10; i >= 1; i--)
            {
                if (i == 3 || i == 4)
                {
                    asterisk = 4;
                }
                else
                {
                    asterisk = i;
                }
                for (int count = 1; count <= asterisk; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 10; i >= 1; i--)
            {
                for (int interval = 9; interval > i-1; interval--)
                {
                    if (interval != 0)
                    {
                        Console.Write(" ");
                    }
                }
                for (int count = 1; count <= i; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int interval = 9; interval > i - 1; interval--)
                {
                    if (interval != 0)
                    {
                        Console.Write(" ");
                    }
                }
                for (int count = 1; count <= i; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
