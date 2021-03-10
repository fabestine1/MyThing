using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Talent candidate = new Talent();
            Console.Write("Enter first name: ");
            candidate.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            candidate.LastName = Console.ReadLine();
            Console.Write("Enter birth year: ");
            candidate.BirthYear = Convert.ToInt32(Console.ReadLine());
            double newScore;
            for (int i = 1; i < 6; i++)
            {
                Console.Write("Enter judge score {0}: ", i);
                newScore = Convert.ToInt32(Console.ReadLine());
                candidate.AddJudge(newScore);
            }
            Console.WriteLine("\nCandidate: {0} {1} \nBirth year: {2}\nThe score of the candidate is: {3}", candidate.FirstName, candidate.LastName, candidate.BirthYear, candidate.Score);
            Console.ReadKey();
        }
    }
}
