using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeRegistration
{
    class Trainee
    {
        private int age;
        private List<Course> myCourses;

        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                {
                    age = value;
                } else
                {
                    age = 18;
                }
            }
        }

        public Trainee(string name, int age)
        {
            Name = name;
            Age = age;
            myCourses = new List<Course>();
        }
    
        public List<Course> GetAllCourses()
        {
            return myCourses;
        }

        public bool RegisterForCourse(string code, CourseLevel level)
        {
            foreach (Course o in myCourses)
            {
                if (o.Code == code)
                {
                    return false;
                }
            }

            myCourses.Add(new Course(code, level));
            return true;
        }
        
        public bool ChangeCourse(string code, CourseLevel level)
        {
            foreach (Course o in myCourses)
            {
                if (o.Code == code)
                {
                    o.Level = level;
                    return true;
                }
            }
            return false;
        }

        public List<Course> GetAllBeginnerCourses()
        {
            List<Course> resList = new List<Course>();

            foreach (Course o in myCourses)
            {
                if (o.Level == CourseLevel.BEGINNER)
                {
                    resList.Add(o);
                }
            }

            return resList;
        }




    }
}
