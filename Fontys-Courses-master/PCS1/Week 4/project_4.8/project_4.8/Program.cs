using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            StudyAdvice advice1 = new StudyAdvice();
            Console.Write("Enter your student number: ");
            advice1.StudentNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            advice1.Name = Console.ReadLine();
            Console.Write("Enter received ECs in first block: ");
            advice1.Block1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in second block: ");
            advice1.Block2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in third block: ");
            advice1.Block3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in fourth block: ");
            advice1.Block4 = Convert.ToInt32(Console.ReadLine());

            int firstSemesterECs = advice1.Block1 + advice1.Block2;
            int secondSemesterECs = advice1.Block3 + advice1.Block4;
            string percentage1;
            string percentage2;
            string description;


            if (firstSemesterECs == 100)
            {
                percentage1 = "30\n(100%)";
                description = "(positive)";
            }
            else if (firstSemesterECs >= 23 && firstSemesterECs <= 29)
            {
                percentage1 = "29 .. 23\n(more than 75%)";
                description = "(conditional positive)";
            }
            else if (firstSemesterECs >= 16 && firstSemesterECs <= 22)
            {
                percentage1 = "22 .. 16\n(more than 50%)";
                description = "(conditional negative)";
            }
            else
            {
                percentage1 = "15 .. 0\n(other)";
                description = "(negative)";
            }

            string firstsemester = "Achieved EC's in the 1st semester";
            string secondsemester = "Achieved EC's in the 2nd semester";


            Console.WriteLine("\nPreliminary Advice: ");
            Console.Write("{0} {1}\n\n{2}\n{3}", advice1.PreliminaryAdvice, description, firstsemester, percentage1);

            if (firstSemesterECs == 30 && secondSemesterECs == 30)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "30\n(100%)";
                description = "(positive)";
            }
            else if (firstSemesterECs == 30 && secondSemesterECs >= 16 && secondSemesterECs <= 29)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "29 .. 16\n(more than 50%)";
                description = "(conditional positive)";
            }
            else if (firstSemesterECs == 30 && secondSemesterECs >= 0 && secondSemesterECs <= 15)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "15 .. 0";
                description = "(conditional negative)";
            }
            else
            {
                percentage1 = "29 .. 0";
                percentage2 = "30 .. 0";
                description = "(negative)";
            }



            Console.WriteLine("\n\nFinal Advice: ");
            Console.Write("{0} {1}\n\n{2}\n{3}\n{4}\n{5}", advice1.FinalAdvice, description, firstsemester, percentage1, secondsemester, percentage2);


            StudyAdvice advice2 = new StudyAdvice();
            Console.Write("\n\nEnter your student number: ");
            advice2.StudentNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            advice2.Name = Console.ReadLine();
            Console.Write("Enter received ECs in first block: ");
            advice2.Block1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in second block: ");
            advice2.Block2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in third block: ");
            advice2.Block3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in fourth block: ");
            advice2.Block4 = Convert.ToInt32(Console.ReadLine());

            int firstSemesterECs2 = advice2.Block1 + advice2.Block2;
            int secondSemesterECs2 = advice2.Block3 + advice2.Block4;

            if (firstSemesterECs == 100)
            {
                percentage1 = "30\n(100%)";
                description = "(positive)";
            }
            else if (firstSemesterECs >= 23 && firstSemesterECs <= 29)
            {
                percentage1 = "29 .. 23\n(more than 75%)";
                description = "(conditional positive)";
            }
            else if (firstSemesterECs >= 16 && firstSemesterECs <= 22)
            {
                percentage1 = "22 .. 16\n(more than 50%)";
                description = "(conditional negative)";
            }
            else
            {
                percentage1 = "15 .. 0\n(other)";
                description = "(negative)";
            }

            Console.WriteLine("\nPreliminary Advice: ");
            Console.Write("{0} {1}\n\n{2}\n{3}", advice1.PreliminaryAdvice, description, firstsemester, percentage1);

            if (firstSemesterECs == 30 && secondSemesterECs == 30)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "30\n(100%)";
                description = "(positive)";
            }
            else if (firstSemesterECs == 30 && secondSemesterECs >= 16 && secondSemesterECs <= 29)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "29 .. 16\n(more than 50%)";
                description = "(conditional positive)";
            }
            else if (firstSemesterECs == 30 && secondSemesterECs >= 0 && secondSemesterECs <= 15)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "15 .. 0";
                description = "(conditional negative)";
            }
            else
            {
                percentage1 = "29 .. 0";
                percentage2 = "30 .. 0";
                description = "(negative)";
            }


            Console.WriteLine("\n\nFinal Advice: ");
            Console.Write("{0} {1}\n\n{2}\n{3}\n{4}\n{5}", advice1.FinalAdvice, description, firstsemester, percentage1, secondsemester, percentage2);


            StudyAdvice advice3 = new StudyAdvice();
            Console.Write("\n\nEnter your student number: ");
            advice3.StudentNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            advice3.Name = Console.ReadLine();
            Console.Write("Enter received ECs in first block: ");
            advice3.Block1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in second block: ");
            advice3.Block2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in third block: ");
            advice3.Block3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter received ECs in fourth block: ");
            advice3.Block4 = Convert.ToInt32(Console.ReadLine());

            int firstSemesterECs3 = advice3.Block1 + advice3.Block2;
            int secondSemesterECs3 = advice3.Block3 + advice3.Block4;

            if (firstSemesterECs == 100)
            {
                percentage1 = "30\n(100%)";
                description = "(positive)";
            }
            else if (firstSemesterECs >= 23 && firstSemesterECs <= 29)
            {
                percentage1 = "29 .. 23\n(more than 75%)";
                description = "(conditional positive)";
            }
            else if (firstSemesterECs >= 16 && firstSemesterECs <= 22)
            {
                percentage1 = "22 .. 16\n(more than 50%)";
                description = "(conditional negative)";
            }
            else
            {
                percentage1 = "15 .. 0\n(other)";
                description = "(negative)";
            }

            Console.WriteLine("\nPreliminary Advice: ");
            Console.Write("{0} {1}\n\n{2}\n{3}", advice1.PreliminaryAdvice, description, firstsemester, percentage1);

            if (firstSemesterECs == 30 && secondSemesterECs == 30)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "30\n(100%)";
                description = "(positive)";
            }
            else if (firstSemesterECs == 30 && secondSemesterECs >= 16 && secondSemesterECs <= 29)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "29 .. 16\n(more than 50%)";
                description = "(conditional positive)";
            }
            else if (firstSemesterECs == 30 && secondSemesterECs >= 0 && secondSemesterECs <= 15)
            {
                percentage1 = "30\n(100%)";
                percentage2 = "15 .. 0";
                description = "(conditional negative)";
            }
            else
            {
                percentage1 = "29 .. 0";
                percentage2 = "30 .. 0";
                description = "(negative)";
            }


            Console.WriteLine("\n\nFinal Advice: ");
            Console.Write("{0} {1}\n\n{2}\n{3}\n{4}\n{5}", advice1.FinalAdvice, description, firstsemester, percentage1, secondsemester, percentage2);

            Console.ReadKey();
        }
    }
}
