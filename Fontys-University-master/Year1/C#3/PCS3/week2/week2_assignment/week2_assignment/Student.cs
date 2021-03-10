using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_assignment
{
    class Student : Person
    {
        private String country;
        private int nrOfECs;


        public Student(string Name, int Age, int Pcn, int YearsAtSchool, string country, int nrOfECs)
            : base(Name, Age, Pcn, YearsAtSchool)
        {
            this.country = country;
            this.nrOfECs = nrOfECs;
        }


        public void AddECs(int n)
        {
            if (nrOfECs != 50)
            {
                nrOfECs += n;
            }
        }

        public override String AsString()
        {
            return base.AsString() + "Country of origin: " + country + " Number of ECs: " + nrOfECs;
        }
    }
}
