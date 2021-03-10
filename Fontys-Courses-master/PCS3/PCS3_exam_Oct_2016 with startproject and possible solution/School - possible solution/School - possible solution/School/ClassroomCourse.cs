using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ClassroomCourse:Course
    {
        // fields
        private int minNrOfParticipants; // the minimum number of participants for this course
        private int maxNrOfParticipants; // the maximum number of participants for this course
        private int totalPriceForAllParticipants; // the total price for all participants
        private int fee; // a constant fee of 100 euro (per participant) for this course

        // constructor
        public ClassroomCourse(int courseId, String courseName, int min, int max, int price):base(courseId, courseName)
        {
            this.minNrOfParticipants = min;
            this.maxNrOfParticipants = max;
            this.totalPriceForAllParticipants = price;
            this.fee = 100;
        }

        // methods

        // Assignment 1b and 3: (see also classes Course and ECourse)
        public override String ToString()
        {
            String temp = "Classroom course " + base.ToString() + " Min / max # participants: " + this.minNrOfParticipants.ToString();
            temp += " / " + this.maxNrOfParticipants.ToString();
            if (this.WillTakePlace())
                temp += " Price per participant: " + this.GetPricePerParticipant().ToString();
            else
                temp += " Will not take place";
            return temp;
        }

        // Assignment 2b: (see also classes Course and ECourse)
        public override void AddParticipant(int id, String name)
        {
            if (this.GetNrOfParticipants() < this.maxNrOfParticipants)
                base.AddParticipant(id, name);
            else
                throw new CourseException("Participation not possible, max nr of participants reached");
        }

        // Assignment 2c: (see also classes Course and ECourse)
        public override int GetPricePerParticipant()
        {
            int nrOfParticipants = this.GetNrOfParticipants();
            if (nrOfParticipants >= this.minNrOfParticipants)
                return this.fee + this.totalPriceForAllParticipants / nrOfParticipants;
            else
                return -1;
        }


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
    }
}
