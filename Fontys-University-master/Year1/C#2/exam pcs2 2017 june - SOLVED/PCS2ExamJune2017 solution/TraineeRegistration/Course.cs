using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeRegistration
{
    class Course
    {
        private string code;
        private CourseLevel level;

        public string Code
        {
            get { return code; }
            private set { code = value; }
        }

        public CourseLevel Level
        {
            get { return level; }
            set { level = value; }
        }

        public Course(string code, CourseLevel level)
        {
            Code = code;
            Level = level;
        }

        public int GetPrice()
        {
            if (level == CourseLevel.BEGINNER)
            {
                return 400;
            }
            else if (level == CourseLevel.INTERMEDIATE)
            {
                return 500;
            }
            else
            {
                return 600;
            }
        }

        public string AsString()
        {
            return code + ", level " + level + ", price " + GetPrice() + " Euros";
        }

    }
}
