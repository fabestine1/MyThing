using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        private Function function;     // function. E,g, DOCENT_1, DOCENT_2, TEAM_LEADER, ...
        private double salary;         // monthly salary 
        private ITeacherRetirement retirementListener;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Function Function
        {
            get { return function; }
            set { function = value; }
        }

        /// <summary>
        /// The only constructor.</summary>
        /// <param name="name">Initial name of the teacher.</param>
        /// <param name="pcn">Personal Fontys number of the teacher.</param>
        /// <param name="age">Age of the teacher.</param>
        /// <param name="function">Function of the teacher.</param>
        /// <param name="salary">Monthly salary of the teacher.</param>
        public Teacher(string name, int pcn, int age, Function function, int salary) : base(name, pcn, age)
        {
            this.Function = function;
            this.Salary = salary;
        }
        public Teacher(string name, int pcn, int age, Function function, int salary, int yearsAtFontys) : base(name, pcn, age)
        {
            this.Function = function;
            this.Salary = salary;
            this.YearsAtFontys = yearsAtFontys;
        }

        /// <summary>
        /// Returns values of all properties in the following string format:
        /// "John Doe (12456)
        ///  age 45, 15 years at Fontys
        ///  function: DOCENT_1
        ///  salary:   15000"
        /// </summary>
        public override string InfoString()
        {
            string info = base.InfoString();

            info += "\nfunction:\t" + this.Function.ToString();
            info += "\nsalary:\t" + this.Salary.ToString();

            return info;
        }

        /// <summary>
        /// Promotes the teacher by one function. 
        /// For example, DOCENT_1 is promoted into DOCENT_2.
        /// </summary>
        public void Promote()
        {
            if (function < Function.DIRECTOR)
                function++;
        }

        public override void StartAnotherSchoolYear()
        {
            if(YearsAtFontys <= 20)
            {
                base.StartAnotherSchoolYear();
                if (YearsAtFontys % 3 == 0)
                {
                    salary *= 1.1;
                }
            }
            else
            {
                retirementListener.WantToRetire(this, Name + " wants to retire.\nThe reason is: I work " + YearsAtFontys + " years at Fontys and I am " + Age + " years old!");
            }
        }
        public void SetRetirementListener(ITeacherRetirement retirementListener)
        {
            this.retirementListener = retirementListener;
        }

        public override void CelebrateBirthDay()
        {
            if (Age > 60)
            {
                retirementListener.WantToRetire(this, Name + " wants to retire.\nThe reason is: I am " + Age + " years old!");
            }
            else
                base.CelebrateBirthDay();
        }
    }
}
