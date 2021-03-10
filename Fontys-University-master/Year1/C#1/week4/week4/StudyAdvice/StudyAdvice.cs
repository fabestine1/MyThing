using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAdvice
{
    class StudyAdvice
    {
        static void Main(string[] args)
        {
            StudyAdviceClass student = new StudyAdviceClass(35681, "David");

            int firstExams, secondExams, thirdExams, forthExams;

            Console.Write("Enter how many exams you passed in the first block: ");
            firstExams = int.Parse(Console.ReadLine());

            Console.Write("Enter how many exams you passed in the second block: ");
            secondExams = int.Parse(Console.ReadLine());

            Console.Write("Enter how many exams you passed in the third block: ");
            thirdExams = int.Parse(Console.ReadLine());

            Console.Write("Enter how many exams you passed in the forth block: ");
            forthExams = int.Parse(Console.ReadLine());

            for(int i = 0; i < firstExams; i++)
            {
                student.FirstBlockExam("passed");
            }

            for (int i = 0; i < secondExams; i++)
            {
                student.SecondBlockExam("passed");
            }

            for (int i = 0; i < thirdExams; i++)
            {
                student.ThirdBlockExam("passed");
            }

            for (int i = 0; i < forthExams; i++)
            {
                student.ForthBlockExam("passed");
            }

            Console.WriteLine("{0} {1} {2} {3}",student.FirstBlock, student.SecondBlock, student.ThirdBlock, student.ForthBlock);

            student.StudyAdvice();

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
