using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._8
{
    class StudyAdvice
    {
        private int studentNumber;
        private string name;
        private int block1;
        private int block2;
        private int block3;
        private int block4;
        private char preliminaryAdvice;
        private char finalAdvice;

        public int StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Block1
        {
            get { return block1; }
            set
            {
                if (value > block1 && value >= 0 && value <= 15)
                {
                    block1 = value;
                }
            }
        }
        public int Block2
        {
            get { return block2; }
            set
            {
                if (value > block2 && value >= 0 && value <= 15)
                {
                    block2 = value;
                }
            }
        }
        public int Block3
        {
            get { return block3; }
            set
            {
                if (value > block3 && value >= 0 && value <= 15)
                {
                    block3 = value;
                }
            }
        }
        public int Block4
        {
            get { return block4; }
            set
            {
                if (value > block4 && value >= 0 && value <= 15)
                {
                    block4 = value;
                }
            }
        }
        public char PreliminaryAdvice
        {
            get
            {
                int firstSemesterECs = Block1 + Block2;
                if (firstSemesterECs == 30)
                {
                    return preliminaryAdvice = 'A';
                }
                else if (firstSemesterECs >= 23 && firstSemesterECs <= 29)
                {
                    return preliminaryAdvice = 'B';
                }
                else if (firstSemesterECs >= 16 && firstSemesterECs <= 22)
                {
                    return preliminaryAdvice = 'C';
                }
                else
                {
                    return preliminaryAdvice = 'D';
                }
            }
        }
        public char FinalAdvice
        {
            get
            {
                int firstSemesterECs = Block1 + Block2;
                int secondSemesterECs = Block3 + Block4;
                if (firstSemesterECs == 30 && secondSemesterECs == 30)
                {
                    return preliminaryAdvice = 'A';
                }
                else if (firstSemesterECs == 30 && secondSemesterECs >= 16 && secondSemesterECs <= 29)
                {
                    return preliminaryAdvice = 'B';
                }
                else if (firstSemesterECs == 30 && secondSemesterECs >= 0 && secondSemesterECs <= 15)
                {
                    return preliminaryAdvice = 'C';
                }
                else
                {
                    return preliminaryAdvice = 'D';
                }
            }
        }
    }
}