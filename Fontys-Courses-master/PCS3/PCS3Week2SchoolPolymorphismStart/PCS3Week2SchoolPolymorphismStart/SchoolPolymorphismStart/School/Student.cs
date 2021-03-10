using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        public string Country { get; set; }
        public int EC { get; set; }

        public Student(string name, int pcn, int age, string country) : base(name, pcn, age)
        {
            Country = country;
        }
        public Student(string name, int pcn, int age, string country, int ecs, int yearsAtFontys) : base(name, pcn, age)
        {
            Country = country;
            EC = ecs;
            YearsAtFontys = yearsAtFontys;
        }
        public override string InfoString()
        {
            return base.InfoString() + "\ncountry:\t" + Country + "\nEC's:\t" + EC;
        }
        public void AddECs(int n)
        {
            EC += n;
        }
    }
}
