using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._2
{
    class Student
    {
        public string Name { get; set; }
        public int StNumber { get; set; }
        private List<int> marks;

        public Student(string name, int stNr)
        {
            Name = name;
            StNumber = stNr;
            marks = new List<int>();
        }
        public void AddMark(int mark)
        {
            if (mark >= 1 && mark <= 10)
                marks.Add(mark);
            else
                throw new MarkOutOfRangeException();
        }
        public int CalculateAverageMark()
        {
            return Convert.ToInt32(marks.Average());
        }
    }
}
