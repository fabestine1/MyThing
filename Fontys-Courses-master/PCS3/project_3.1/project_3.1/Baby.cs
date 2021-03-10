using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    class Baby : Human
    {
        public Baby(string name) : base(name)
        {
        }
        public override string SayGoodMorning(int weekDay)
        {
            return "UUUUUU, " + Name + " is hungryyyyy!";
        }
        public override string SayGoodNight(int hour)
        {
            return "UUUUUU, " + Name + " is hungryyyyy!";
        }
    }
}
