using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRate
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName, lastName;
            int birthYear = 0;

            Console.Write("Enter your first name:");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name:");
            lastName = Console.ReadLine();

            Console.Write("Enter your birth year:");
            birthYear = int.Parse(Console.ReadLine());

            Monitor myMonitor = new Monitor(firstName, lastName, birthYear);

            myMonitor.EvaluateCurrentRate();

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();  
        }
    }
}
