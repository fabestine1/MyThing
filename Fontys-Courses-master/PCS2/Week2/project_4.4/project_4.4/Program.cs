using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            int[] advice = new int[5];
            char[] adviceArray = { 'A', 'B', 'Ç', 'D', 'E' };
            do
            {
                Console.Write("Please enter a grade between 1 and 100 or a 0 to quit: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade > 0 && grade <= 100)
                {
                    if (grade >= 90)
                    {
                        advice[0]++;
                    }
                    else if (grade >= 80)
                    {
                        advice[1]++;
                    }
                    else if (grade >= 70)
                    {
                        advice[2]++;
                    }
                    else if (grade >= 60)
                    {
                        advice[3]++;
                    }
                    else
                    {
                        advice[4]++;
                    }
                }
            }
            while (grade != 0);
            Console.WriteLine("---------------------------");
            for (int i=0; i < advice.Length; i++)
            {
                Console.WriteLine("Grade {0}: {1}", adviceArray[i], advice[i]);
            }
            Console.ReadKey();
        }
    }
}
