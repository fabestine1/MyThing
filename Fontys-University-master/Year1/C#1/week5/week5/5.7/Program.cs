using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;

            Console.Write("Enter first number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            third = int.Parse(Console.ReadLine());

            if(first > second)
            {
                if(first > third)
                {
                    Console.WriteLine("First number {0} is the biggest", first);
                }
            }
            else
            {
                if(second > third)
                {
                    Console.WriteLine("Second number {0} is the biggest", second);
                }
            }
            if(third > first)
            {
                if(third > second)
                {
                    Console.WriteLine("Third number {0} is the biggest", third);
                }
            }

            if(first < second)
            {
                if(first < third)
                {
                    Console.WriteLine("First number {0} is the smallest", first);
                }
            }
            else
            {
                if(second < third)
                {
                    Console.WriteLine("Second number {0} is the smallest", second);
                }
            }
            if(third < second)
            {
                if(third < first)
                {
                    Console.WriteLine("Third number {0} is the smallest", third);
                }
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
