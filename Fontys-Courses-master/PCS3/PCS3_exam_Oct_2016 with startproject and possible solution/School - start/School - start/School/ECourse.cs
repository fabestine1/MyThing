using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ECourse : Course
    {
        // constructor
        public ECourse(int courseId, String courseName, int price) : base(courseId, courseName, price){}

        // methods

        /// <summary>
        /// ToString()
        /// Returns a string with all relevant information about the current classroom course in a string
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            // To do, assignment 1b and 3
            return "E-Course " + base.ToString() + " Price per perticipant: " + price;
        }

        public override int GetPricePerParticipant()
        {
            return price;
        }
    }
}
