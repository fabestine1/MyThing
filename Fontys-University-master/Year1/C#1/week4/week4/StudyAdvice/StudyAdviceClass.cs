using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAdvice
{
    public class StudyAdviceClass
    {
        private int _firstBlock, _secondBlock, _thirdBlock, _forthBlock;
        private String _firstName;
        private int _studentNumber;
        private char _preliminaryAdvice;
        private char _finalAdvice;

        public StudyAdviceClass()
        {

        }

        public StudyAdviceClass(int studentNumber, String firstName, int firstBlock = 0, int secondBlock = 0, int thirdBlock = 0, int forthBlock = 0)
        {
            this.StudentNumber = studentNumber;
            this.FirstName = firstName;
            this.FirstBlock = firstBlock;
            this.SecondBlock = secondBlock;
            this.ThirdBlock = thirdBlock;
            this.ForthBlock = forthBlock;
        }

        public String FirstName
        {
            get
            {
                return this._firstName;
            }

            private set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException("First Name can NOT be without character");
                }

                this._firstName = value;
            }
        }
        public int StudentNumber
        {
            get
            {
                return this._studentNumber;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Student Number can NOT be negative");
                }

                this._studentNumber = value;
            }
        }

        public int FirstBlock
        {
            get
            {
                return this._firstBlock;
            }

            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("EC's for one block can NOT be negative or more than 15");
                }

                this._firstBlock = value;
            }
        }

        public int SecondBlock
        {
            get
            {
                return this._secondBlock;
            }

            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("EC's for one block can NOT be negative or more than 15");
                }

                this._secondBlock = value;
            }
        }

        public int ThirdBlock
        {
            get
            { 
                return this._thirdBlock;
            }

            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("EC's for one block can NOT be negative or more than 15");
                }

                this._thirdBlock = value;
            }
        }

        public int ForthBlock
        {
            get
            {
                return this._forthBlock;
            }

            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("EC's for one block can NOT be negative or more than 15");
                }

                this._forthBlock = value;
            }
        }

        public int FirstBlockExam(String ExamResult)
        {
            if(ExamResult == "passed")
            {
                FirstBlock += 3;
                return this.FirstBlock;
            }
            else
            {
                return this.FirstBlock;
            }
        }
        public int SecondBlockExam(String ExamResult)
        {
            if (ExamResult == "passed")
            {
                SecondBlock += 3;
                return this.SecondBlock;
            }
            else
            {
                return this.SecondBlock;
            }
        }
        public int ThirdBlockExam(String ExamResult)
        {
            if (ExamResult == "passed")
            {
                ThirdBlock += 3;
                return this.ThirdBlock;
            }
            else
            {
                return this.ThirdBlock;
            }
        }
        public int ForthBlockExam(String ExamResult)
        {
            if (ExamResult == "passed")
            {
                ForthBlock += 3;
                return this.ForthBlock;
            }
            else
            {
                return this.ForthBlock;
            }
        }

        public void StudyAdvice(int firstSemester = 0, int secondSemester = 0)
        {
            firstSemester = FirstBlock + SecondBlock;
            secondSemester = ThirdBlock + ForthBlock;

            if(firstSemester == 30)
            {
                Console.WriteLine("First part A (positive)");
            }
            else if(firstSemester < 30 && firstSemester >= 23)
            {
                Console.WriteLine("First part B (conditional positive)");
            }
            else if(firstSemester < 23 && firstSemester >=16)
            {
                Console.WriteLine("First part C (conditional negative)");
            }
            else
            {
                Console.WriteLine("Frist part D (negative)");
            }

            if (firstSemester == 30 && secondSemester == 30)
            {
                Console.WriteLine("Whole A (positive)");
            }
            else if (firstSemester == 30 && secondSemester < 29 && secondSemester >= 16)
            {
                Console.WriteLine("Whole B (conditional positive)");
            }
            else if (firstSemester == 30 && secondSemester < 15 && secondSemester > 0)
            {
                Console.WriteLine("Whole C (conditional negative)");
            }
            else
            {
                Console.WriteLine("Whole D (negative)");
            }
        }
    }
}
