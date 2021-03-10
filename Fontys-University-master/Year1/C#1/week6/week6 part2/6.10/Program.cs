using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            int rows, columns, temp;

            Console.Write("Enter how many rows and columns you want: ");
            rows = int.Parse(Console.ReadLine());

            columns = rows;

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    temp = j;
                    if (temp <= i)
                    {
                        Console.Write(star);
                        temp++;
                    }
                    else
                    {
                        Console.Write(" ");
                        temp++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = columns; j > 0; j--)
                {
                    temp = j;
                    if (temp > i)
                    {
                        Console.Write(star);
                        temp++;
                    }
                    else
                    {
                        Console.Write(" ");
                        temp++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp = j;
                    if (temp < i)
                    {
                        Console.Write(" ");
                        temp++;
                    }
                    else
                    {
                        Console.Write(star);
                        temp++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = columns; j > 0; j--)
                {
                    temp = j - 1;
                    if (temp > i)
                    {
                        Console.Write(" ");
                        temp++;
                    }
                    else
                    {
                        Console.Write(star);
                        temp++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
