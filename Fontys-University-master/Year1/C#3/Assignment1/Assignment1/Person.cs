namespace Assignment1
{
    using System;

    public abstract class Person
    {
        private int age;
        private String name;
        private int pcn; 
        private int yearsAtSchool;
        
        public Person(int age, String name, int pcn, int yearsAtSchool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
        }

        public int YearsAtSchool { get => yearsAtSchool; set => yearsAtSchool = value; }
        public String Name { get => name; set => name = value; }
        public int Pcn { get => pcn; set => pcn = value; }
        public int Age { get => age; set => age = value; }

        public virtual String AsAString()
        {
            return this.Age + this.Name + this.Pcn + this.YearsAtSchool;
        }

        public void CelebrateBirthday()
        {
            this.Age = this.Age++;
        }

        public virtual void StartAnotherSchoolyear()
        {
            this.YearsAtSchool++;
        }
    }
}
