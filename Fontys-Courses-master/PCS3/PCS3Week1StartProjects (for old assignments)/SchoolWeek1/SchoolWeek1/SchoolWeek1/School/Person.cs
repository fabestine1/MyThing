using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    [Serializable]
    abstract class Person : ISpeaker
    {
        private int pcn;
        private int age;
        private int yearsAtFontys;
        public string Name { get; set; }
        public string Address { get; set; }
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

        /// <summary>
        /// Cannot be set outside this class.
        /// Must be more than 18
        /// </summary>
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

        /// <summary>
        /// Cannot be set outside this class.
        /// Cannot be a negative number.
        /// </summary>
        public int YearsAtFontys
        {
            get { return yearsAtFontys; }
            protected set
            {
                if (value >= 0)
                {
                    yearsAtFontys = value;
                }
                else
                {
                    yearsAtFontys = 0;
                }
            }
        }

        public Person(string name, int pcn, int age, string address)
        {
            Name = name;
            PCN = pcn;
            Age = age;
            Address = address;
        }
        /// <summary>
        /// Increases property YearsAtFontys by 1. 
        /// </summary>
        public virtual void StartAnotherSchoolYear()
        {
            YearsAtFontys++;
        }

        /// <summary>
        /// Increases property Age by 1. 
        /// </summary>
        public void CelebrateBirthday()
        {
            Age++;
        }
        public override string ToString()
        {
            return Name + " (" + PCN + ")\n" + "age: " + Age + ", " + YearsAtFontys + " years at Fontys\n" + "address: " + Address + "\n";
        }
        public abstract String GetExtraInfo();
        public abstract String GetStartOfSpeech();
    }
}
