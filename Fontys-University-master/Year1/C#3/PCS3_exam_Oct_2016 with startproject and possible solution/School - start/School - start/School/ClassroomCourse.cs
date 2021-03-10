namespace School
{
    using System;

    public class ClassroomCourse : Course
    {
        // fields
        private int minNrOfParticipants; // the minimum number of participants for this course
        private int maxNrOfParticipants; // the maximum number of participants for this course
        private int totalPriceForAllParticipants; // the total price for all participants
        private int fee; // a constant fee of 100 euro (per participant) for this course

        // constructor
        public ClassroomCourse(int courseId, string courseName, int min, int max, int price)
            :base(courseId, courseName)
        {
            this.minNrOfParticipants = min;
            this.maxNrOfParticipants = max;
            this.totalPriceForAllParticipants = price;
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

        public override string ToString()
        {
            String temp = "Classroom course " + base.ToString() + " Min / max # participants: " + this.minNrOfParticipants.ToString();
            temp += " / " + this.maxNrOfParticipants.ToString();
            if (this.WillTakePlace())
                temp += " Price per participant: " + this.GetPricePerParticipant().ToString();
            else
                temp += " Will not take place";
            return temp;
        }

        public override void AddParticipant(int id, string name)
        {
            if (GetNrOfParticipants() < this.maxNrOfParticipants)
            {
                base.AddParticipant(id, name);
            }
            else
            {
                throw new CourseException("Participation not possible, max nr of participants reached");
            }
        }

        public override int GetPricePerParticipant()
        {
            if (GetNrOfParticipants() >= this.minNrOfParticipants)
            {
                return fee + (totalPriceForAllParticipants / GetNrOfParticipants());
            }
            else
            {
                return -1;
            }
        }
    }
}
