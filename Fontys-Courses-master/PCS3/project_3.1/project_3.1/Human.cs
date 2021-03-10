using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    abstract class Human : ISomeone
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
        public String IntroduceYourself()
        {
            return Name;
        }
        public abstract String SayGoodMorning(int weekDay);
        public abstract String SayGoodNight(int hour);
    }
}
