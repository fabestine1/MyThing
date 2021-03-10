using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    class GrownUp : Human
    {
        public GrownUp(string name) : base(name)
        {
        }
        public override string SayGoodMorning(int weekDay)
        {
            if(weekDay < 6)
                return "Oh no, " + Name + " is late for work!";
            else
                return "Go away, " + Name + " wants to sleep some more!";
        }
        public override string SayGoodNight(int hour)
        {
            if (hour > 23)
                return Name + " will have troubles getting up in the morning!";
            else
                return Name + " managed for once to go to sleep on time!";
        }
    }
}
