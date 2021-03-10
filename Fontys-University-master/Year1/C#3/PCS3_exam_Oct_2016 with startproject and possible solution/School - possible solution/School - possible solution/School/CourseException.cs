using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    // Assignment 2b: (see also classes Course, ClassroomCourse, and ECourse)
    public class CourseException: Exception
    {
        public CourseException(): base()
        {

        }

        public CourseException(String message): base(message)
        {

        }
    }
}
