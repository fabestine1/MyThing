using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    class Dog : ISomeone
    {
        public int Age { get; set; }
        public Dog(int age)
        {
            Age = age;
        }
        public string IntroduceYourself()
        {
            return "Waf! I am " + Age*7 + " years old!";
        }
        public string SayGoodMorning(int weekDay)
        {
            return "Waf, wake up, take me out for a walk!";
        }
        public string SayGoodNight(int hour)
        {
            if(hour < 23)
                return "Waf, wake up, take me out for a walk!";
            else
                return "Waf, wake up, take me out for a walk!";
        }
    }
}
