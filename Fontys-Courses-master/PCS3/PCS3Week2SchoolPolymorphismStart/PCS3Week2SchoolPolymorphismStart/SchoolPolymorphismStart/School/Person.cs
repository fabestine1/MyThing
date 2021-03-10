using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
          // mutual
        private string name;
        private int pcn;
        private int age;
        private int yearsAtFontys;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // must be in range 11 11 11  to 99 99 99
        public int PCN
        {
            get { return pcn; }
            set
            {
                if (value >= 111111 && value <= 999999)
                    pcn = value;
                else
                {
                    if (value < 111111)
                        pcn = 11111;
                    else pcn = 999999;
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value > 18)
                    age = value;
                else age = 18;
            }
        }


        public int YearsAtFontys
        {
            get { return yearsAtFontys; }
            protected set { yearsAtFontys = value;} 
        }

        public virtual void StartAnotherSchoolYear()
        {
            yearsAtFontys++;
        }

        public virtual void CelebrateBirthDay()
        {
            Age++;
        }
                

        public Person(string name, int pcn, int age)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.YearsAtFontys = 0;
        }

        public virtual string InfoString()
        {
            string info = "";
            info +=  this.Name + " (" + this.PCN.ToString() + ")";
            info += "\nage " + this.Age.ToString() + ", " + this.YearsAtFontys.ToString() + " years at Fontys" ;
            return info;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
