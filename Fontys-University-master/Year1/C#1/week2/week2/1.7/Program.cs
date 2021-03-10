using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0, average = 0, product = 1, smallest = 0, largest = 0;

            /*Console.Write("Enter how many numbers you need: " );
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int j = 0; j < n; j++)
            {
                sum += a[j];
                product *= a[j];
            }

            average = sum / n;

            smallest = a[0];

            largest = a[0];
            
            for(int k = 0; k < n; k++)
            {
                if(largest < a[k])
                {
                    largest = a[k];
                }
                if(smallest > a[k])
                {
                    smallest = a[k];
                }
            }*/

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            
            int bigest = Math.Max(numbers,0);
            
            Console.WriteLine("The sum is: {0}", sum);

            Console.WriteLine("The average is: {0}", average);

            Console.WriteLine("The product is: {0}", product);

            Console.WriteLine("The smallest is: {0}", smallest);

            Console.WriteLine("The largest is: {0}", bigest);

            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
