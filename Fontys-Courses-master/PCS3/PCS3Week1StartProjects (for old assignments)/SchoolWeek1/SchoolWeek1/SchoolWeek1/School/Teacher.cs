using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    enum Function { JUNIOR_DOCENT, DOCENT_1, DOCENT_2, INTERNSHIP_COORDINATOR, TEAM_LEADER, DIRECTOR }

    [Serializable]
    class Teacher : Person
    {
        private Function function;     // function. E,g, DOCENT_1, DOCENT_2, TEAM_LEADER, ...
        private double salary;         // monthly salary 

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
        public Teacher(string name, int pcn, int age, Function function, int salary, string address) : base(name, pcn, age, address)
        {
            this.Function = function;
            this.Salary = salary;
        }
        public Teacher(string name, int pcn, int age, Function function, int salary, string address, int yearsAtFontys) : base(name, pcn, age, address)
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
        public override string GetExtraInfo()
        {
            return "\nfunction:\t" + this.Function.ToString() + "\nsalary:\t" + this.Salary.ToString();
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
            base.StartAnotherSchoolYear();
            if(YearsAtFontys % 3 == 0)
            {
                salary *= 1.1;
            }
        }
        public override String GetStartOfSpeech()
        {
            return "Hello everybody, my name is " + Name + " and I will talk about";
        }

    }
}
