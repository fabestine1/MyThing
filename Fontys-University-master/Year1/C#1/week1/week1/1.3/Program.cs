using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, height, weight;

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your height: ");
            height = int.Parse(Console.ReadLine());

            Console.Write("Enter your weight: ");
            weight = int.Parse(Console.ReadLine());

            Console.WriteLine("You are " + age + " years old, " + height + " tall and " + weight  + " kilos.");

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
