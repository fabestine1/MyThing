namespace Assignment1
{
    using System;

    public class Student : Person
    {
        private String country;
        private int nrOfECs;

        public Student(int age, String name, int pcn, int yearsAtSchool, String country, int nrOfECs) 
            : base(age, name, pcn, yearsAtSchool)
        {
            this.country = country;
            this.nrOfECs = nrOfECs;
        }

        public override String AsAString()
        {
            return base.AsAString() + this.country + this.nrOfECs;
        }

        public void AddECs(int n)
        {
            this.nrOfECs += n;
        }
    }
}
