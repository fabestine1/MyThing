using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ECourse: Course
    {
        // fields
        private int price; // the price per participant for this course

        // constructor
        public ECourse(int courseId, String courseName, int price):base(courseId, courseName)
        {
            this.price = price;
        }

        // Assignment 1b and 3:  (see also classes Course and ClassroomCourse)
        public override String ToString()
        {
            return "E-Course " + base.ToString() + " Price per participant: " + this.GetPricePerParticipant().ToString();
        }

        // Assignment 2c: (see also classes Course and ClassroomCourse)
        public override int GetPricePerParticipant()
        {
            return this.price;
        }

    }
}
