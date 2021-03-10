using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeRegistration
{
    public enum CourseLevel
    {
        BEGINNER, INTERMEDIATE,ADVANCED
    }

    public class Course
    {
        private string code;
        private CourseLevel level;

        public string Code { get => code; set => code = value; }
        public CourseLevel Level { get => level; set => level = value; }

        public Course(string code, CourseLevel level)
        {
            this.Code = code;
            this.Level = level;
        }

        public int GetPrice()
        {
            if (Level == CourseLevel.BEGINNER)
            {
                return 400;
            }
            else if (Level == CourseLevel.BEGINNER)
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
            return $"{this.Code}, level {this.Level}, price {GetPrice()} Euro";
        }
    }
}
