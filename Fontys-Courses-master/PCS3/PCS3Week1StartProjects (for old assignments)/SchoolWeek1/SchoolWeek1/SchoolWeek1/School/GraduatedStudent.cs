using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class GraduatedStudent : Person
    {
        public int YearOfGraduation;
        public double GraduationMark;
        public GraduatedStudent(string name, int pcn, int age, string address, int yearOfGraduation, double graduationMark) : base(name, pcn, age, address)
        {
            YearOfGraduation = yearOfGraduation;
            GraduationMark = graduationMark;
        }
        public override string GetExtraInfo()
        {
            return "";
        }
        public override String GetStartOfSpeech()
        {
            return "";
        }
    }
}
