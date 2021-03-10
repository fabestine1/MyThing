using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ClassroomCourse : Course
    {
        // fields
        private int minNrOfParticipants; // the minimum number of participants for this course
        private int maxNrOfParticipants; // the maximum number of participants for this course
        private int fee = 100; // a constant fee of 100 euro (per participant) for this course

        // constructor
        public ClassroomCourse(int courseId, string courseName, int min, int max, int price) : base(courseId, courseName, price)
        {
            this.minNrOfParticipants = min;
            this.maxNrOfParticipants = max;
            this.fee = 100;
        }

        // methods

        /// <summary>
        /// WillTakePlace()
        /// Returns true if the course will take place 
        /// (i.e. at least the minimum number of participants will attend), 
        /// and false otherwise
        /// </summary>
        /// <returns></returns>
        public bool WillTakePlace()
        {
            // The method returns true if the course will take place, and false otherwise
            if (this.GetNrOfParticipants() < this.minNrOfParticipants)
                return false;
            else
                return true;
        }

        /// <summary>
        /// ToString()
        /// Returns a string with all relevant information about the current classroom course in a string
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            // To do, assignment 1b and 3
            String holder = "Classroom course " + base.ToString() + " Min / max # participants: " + minNrOfParticipants + " / " + maxNrOfParticipants;
            if (WillTakePlace()) holder += " Price per perticipant: " + GetPricePerParticipant(); else holder += " Will not take place";
            return holder;
        }

        public override void AddParticipant(int id, string name)
        {
            if(base.GetNrOfParticipants() < maxNrOfParticipants) base.AddParticipant(id, name);
            else throw new CourseException("Participation not possible, max nr of participants reached");
        }

        public override int GetPricePerParticipant()
        {
            int numberOfParticipants = GetNrOfParticipants();
            if (numberOfParticipants >= minNrOfParticipants) return fee + (price / numberOfParticipants);
            else return -1;
        }
    }
}
