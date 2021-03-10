using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4._2_and_4._3
{
    class Student
    {
        String name;
        int stNumber;
        List<int> marks;

        //constructor
        public Student(String Name, int StNumber)
        {
            this.name = Name;
            this.stNumber = StNumber;
            marks = new List<int>();
        }

        //methods
        public void AddMark(int mark)
        {
            if (mark >= 1 && mark <= 10)
            {
                marks.Add(mark);
            }
            else
            {
                throw new MarkOutOfRangeException();
            }
        }

        //check it again
        public double CalculateAverageMark()
        {
            double avg = marks.Average();

            return Math.Round(avg);
        }
    }
}
