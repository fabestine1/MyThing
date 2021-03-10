using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_week1_
{
    enum Function { juniorT, teacher1, teacher2, teacher3,
                    coordinator, director}
    class Teacher: Person
    {
        private Function myFunction;

        private double salary;

        public Double Salary
        {
            set { value = salary; }
            get { return salary; }
        }
        
        public Teacher(string Name, int Age, int Pcn, int YearsAtSchool, double Salary)
            : base(Name, Age, Pcn, YearsAtSchool)
        {
            this.salary = Salary;
        }

        private void MakePromotion()
        {
            if (myFunction == Function.director)
            { }
            else
                myFunction++;
        }

        private void StartAnotherSchoolyear()
        {
            base.YearsAtSchool++;

            if(YearsAtSchool % 3 == 0)
            {
                salary *= 0.1;
            }
        }

    }
}
