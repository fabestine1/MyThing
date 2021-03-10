using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> numbers = new List<String>();

            numbers.Add("zsdasd");
            numbers.Add("zsad");
            
            numbers.Sort();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers.Reverse();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
