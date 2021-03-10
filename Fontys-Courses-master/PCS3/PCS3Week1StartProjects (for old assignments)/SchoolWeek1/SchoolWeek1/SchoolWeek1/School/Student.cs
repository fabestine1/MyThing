using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    [Serializable]
    class Student : Person
    {
        public string Country { get; set; }
        public int EC { get; set; }
        
        public Student(string name, int pcn, int age, string country, string address) : base(name, pcn, age, address)
        {
            Country = country;
        }
        public Student(string name, int pcn, int age, string country, string address, int ecs, int yearsAtFontys) : base(name, pcn, age, address)
        {
            Country = country;
            EC = ecs;
            YearsAtFontys = yearsAtFontys;
        }
        public override string GetExtraInfo()
        {
            return "country:\t" + Country + "\nEC's:\t" + EC;
        }
        public void AddECs(int n)
        {
            EC += n;
        }
        public override String GetStartOfSpeech()
        {
            return "Hello sunshines! My name is " + Name + " and today it's about";
        }
    }
}
