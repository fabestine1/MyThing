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
        public string Name
        {
            get; set;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(value < 18)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
        }
        public Trainee(string nwName, int nwAge)
        {
            Name = nwName;
            Age = nwAge;
            myCourses = new List<Course>();
        }
        public List<Course> GetAllCourses()
        {
            return myCourses;
        }
        public bool RegisterForCourse(string code, CourseLevel level)
        {
            foreach(Course course in myCourses)
            {
                if(code == course.Code)
                {
                    return false;
                }
            }
            Course newCourse = new Course(code, level);
            myCourses.Add(newCourse);
            return true;
        }
        public bool ChangeCourse(string code, CourseLevel level)
        {
            foreach (Course course in myCourses)
            {
                if (code == course.Code)
                {
                    course.Level = level;
                    return true;
                }
            }
            return false;
        }
        public List<Course> GetAllBeginnerCourses()
        {
            List<Course> courses = new List<Course>();
            foreach(Course course in myCourses)
            {
                if (course.Level == CourseLevel.BEGINNER)
                {
                    courses.Add(course);
                }
            }
            return courses;
        }
    }
}
