namespace TraineeRegistration
{
    using System.Collections.Generic;

    public class Trainee
    {
        private int _age;
        public List<Course> myCourses;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set {
                if (_age >= 18)
                {
                    _age = value;
                }
                else
                {
                    _age = 18;
                }
            }
        }

        public Trainee(int age, string name)
        {
            _age = age;
            this.myCourses = new List<Course>();
            _name = name;
        }

        public List<Course> GetAllCourses()
        {
            return this.myCourses;
        }

        public bool RegisterForCourse(string code, CourseLevel level)
        {
            foreach (Course myCourse in this.myCourses)
            {
                if (myCourse.Code == code)
                {
                    return false;
                }
            }

            this.myCourses.Add(new Course(code, level));
            return true;
        }

        public bool ChangeCourse(string code, CourseLevel level)
        {
            foreach (Course myCourse in this.myCourses)
            {
                if (myCourse.Code == code)
                {
                    myCourse.Code = code;
                    myCourse.Level = level;
                    return true;
                }
            }

            return false;
        }

        public List<Course> GetAllBeginnerCourses()
        {
            List<Course> courses = new List<Course>();
            foreach (Course myCourse in this.myCourses)
            {
                if (myCourse.Level == CourseLevel.BEGINNER)
                {
                    courses.Add(myCourse);
                }
            }
            return courses;
        }
    }
}
