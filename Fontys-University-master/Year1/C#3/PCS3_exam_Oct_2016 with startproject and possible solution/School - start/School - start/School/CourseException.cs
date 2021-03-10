namespace School
{
    using System;

    public class CourseException : Exception
    {
        public CourseException() : base()
        {

        }

        public CourseException(String message) : base(message)
        {

        }
    }
}
