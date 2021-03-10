using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_assignment
{
    class Person
    {
        //field
        private string name;
        private int age;
        private int pcn;
        private int yearsAtSchool;
        private int currentYear;

        //property
        public String Name
        {
            set { value = this.name; }
            get { return this.name; }
        }
        public int Age
        {
            set { value = this.age; }
            get { return this.age; }
        }
        public int PCN
        {
            set { value = this.pcn; }
            get { return this.pcn; }
        }
        public int YearsAtSchool
        {
            set { value = this.yearsAtSchool; }
            get { return this.yearsAtSchool; }
        }


        public Person(string Name, int Age, int Pcn, int YearsAtSchool)
        {
            this.name = Name;
            this.age = Age;
            this.pcn = Pcn;
            this.yearsAtSchool = YearsAtSchool;

        }

        public virtual String AsString()
        {
            return "Name:" + name + " Age:" + age + " Pcn:" + pcn + " Years at school:"
                + yearsAtSchool + ".";
        }

        public void CelebrateBirthday()
        {
            age++;
        }

        public void StartAnotherSchoolyear()
        {
            yearsAtSchool++;


        }
    }
}