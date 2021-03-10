using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            HeartRate Heartrate1 = new HeartRate();
            Console.Write("Enter your first name: ");
            Heartrate1.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            Heartrate1.LastName = Console.ReadLine();
            Console.Write("Enter your birth year: ");
            Heartrate1.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max heart rate: {0}", Heartrate1.MaxRate);
            Console.WriteLine("Down heart rate limit: {0}", Heartrate1.LowTarget);
            Console.WriteLine("Upper heart rate limit: {0}", Heartrate1.UpTarget);
            Heartrate1.EvaluateCurrentRate(100);
            HeartRate Heartrate2 = new HeartRate();
            Console.Write("\nEnter your first name: ");
            Heartrate2.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            Heartrate2.LastName = Console.ReadLine();
            Console.Write("Enter your birth year: ");
            Heartrate2.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max heart rate: {0}", Heartrate2.MaxRate);
            Console.WriteLine("Down heart rate limit: {0}", Heartrate2.LowTarget);
            Console.WriteLine("Upper heart rate limit: {0}", Heartrate2.UpTarget);
            Heartrate2.EvaluateCurrentRate(40);
            HeartRate Heartrate3 = new HeartRate();
            Console.Write("\nEnter your first name: ");
            Heartrate3.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            Heartrate3.LastName = Console.ReadLine();
            Console.Write("Enter your birth year: ");
            Heartrate3.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max heart rate: {0}", Heartrate3.MaxRate);
            Console.WriteLine("Down heart rate limit: {0}", Heartrate3.LowTarget);
            Console.WriteLine("Upper heart rate limit: {0}", Heartrate3.UpTarget);
            Heartrate3.EvaluateCurrentRate(160);
            Console.ReadKey();
        }
    }
}
