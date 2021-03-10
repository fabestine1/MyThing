using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        // fields
        private String name; // the name of the school
        private List<Course> courses; // the list of courses offered by the school

        // constructor
        public School(String name)
        {
            this.name = name;
            this.courses = new List<Course>();
        }

        // methods

        /// <summary>
        /// AddCourse(Course c)
        /// Adds course c to the list of courses
        /// </summary>
        /// <param name="c"></param>
        public void AddCourse(Course c)
        {
            this.courses.Add(c);
        }

        /// <summary>
        /// GetAllCourses()
        /// Returns the list of courses
        /// </summary>
        /// <returns></returns>
        public List<Course> GetAllCourses()
        {
            return this.courses;
        }

        /// <summary>
        /// GetCourse(int id)
        /// If this course is in the list of courses, returns the course with id number id
        /// Otherwise null is returned
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Course GetCourse(int id)
        {
            foreach(Course c in this.courses)
            {
                if (c.CourseId == id)
                    return c;
            }
            return null;
        }

        /// <summary>
        /// AddParticipantToCourse(int courseId, int participantId, string name)
        /// Adds a participant to the course with id courseId, 
        /// if the course with courseId occurs in the list of courses.
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="participantId"></param>
        /// <param name="name"></param>
        public void AddParticipantToCourse(int courseId, int participantId, string name)
        {
            Course c = GetCourse(courseId);
            if (c != null)
            {
                c.AddParticipant(participantId, name);
            }
        }
    }
}
