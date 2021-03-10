using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeRegistration
{
    enum CourseLevel
    {
        BEGINNER, INTERMEDIATE, ADVANCED
    }
    class Course
    {
        private string code;
        private CourseLevel level;

        public string Code
        {
            get { return code; }
        }
        public CourseLevel Level
        {
            get { return level; }
            set { level = value; }
        }

        public Course(string nwCode, CourseLevel nwLevel)
        {
            code = nwCode;
            level = nwLevel;
        }
        public int GetPrice()
        {
            if(level == CourseLevel.BEGINNER)
            {
                return 400;
            }
            else if(level == CourseLevel.INTERMEDIATE)
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
            return code + ", level " + level + ", price " + GetPrice() + " Euros.";
        }
    }
}
