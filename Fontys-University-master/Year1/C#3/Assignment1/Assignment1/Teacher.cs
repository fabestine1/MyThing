namespace Assignment1
{
    using System;

    public enum Function
    {
        juniorTeacher, teacher1, teacher2, teacher3, coordinator, director
    }

    public class Teacher : Person
    {
        private double salary;
        private Function function;

        public Teacher(int age, string name, int pcn, int yearsAtSchool, double salary, Function function) 
            : base(age, name, pcn, yearsAtSchool)
        {
            this.salary = salary;
            this.function = function;
        }

        public override string AsAString()
        {
            return base.AsAString() + this.salary + this.function;
        }

        public override void StartAnotherSchoolyear()
        {
            base.StartAnotherSchoolyear();

            if (this.YearsAtSchool % 3 == 0)
            {
                this.salary += this.salary / 10;
            }
        }

        public void MakePromotion()
        {
            if (this.function != Function.director)
            {
                this.function++;
            }
        }
    }
}
