namespace School
{
    using System;

    public class ECourse : Course
    {
        // fields
        private int price; // the price per participant for this course
        
        // constructor
        public ECourse(int courseId, String courseName, int price)
            :base(courseId, courseName)
        {
            this.price = price;
        }

        // methods

        public override string ToString()
        {
            return "E-Course " + base.ToString() + " Price per participant: " + this.GetPricePerParticipant().ToString();
        }

        public override int GetPricePerParticipant()
        {
            return price;
        }
    }
}
