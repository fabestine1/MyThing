using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_week1_
{
    class Student: Person
    {
        private String country;
        private int nrOfECs;


        public Student(string Name, int Age, int Pcn, int YearsAtSchool, string country, int nrOfECs)
            :base(Name, Age, Pcn, YearsAtSchool)
        {
            this.country = country;
            this.nrOfECs = nrOfECs;
        }


        public void AddECs(int n)
        {
            if(nrOfECs != 50)
            {
                nrOfECs += n;
            }

            
        }
    }
}
