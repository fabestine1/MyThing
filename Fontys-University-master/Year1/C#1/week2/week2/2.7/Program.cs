using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 0, equal = 0;
            int[] a = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number {0}: ", (i+1));
                a[i] = int.Parse(Console.ReadLine());   
            }

            if (a[0] > 56 || a[1] > 56 || a[2] > 56)
            {
                Console.WriteLine("Invalid number/s");
            }

                else
                {
                    largest = a[0];
                    equal = a[0];

                    for (int k = 0; k < 3; k++)
                    {
                        if (largest < a[k])
                        {
                            largest = a[k];
                        }

                    }

                    if (largest == a[0] && largest == a[1] && largest == a[2])
                    {
                        Console.WriteLine("All numbers are equal.");
                    }
                    else
                    {
                        Console.WriteLine("The largest is: {0}", largest);
                    }
                }

            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine(); ;
        }
    }
}
