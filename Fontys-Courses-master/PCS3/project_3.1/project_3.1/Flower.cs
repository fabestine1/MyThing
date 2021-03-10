using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace project_3._1
{
    class Flower : ISomeone
    {
        public Color Color { get; set; }
        public Flower(Color color)
        {
            Color = color;
        }
        public string IntroduceYourself()
        {
            return "Hi! I am " + Color.ToKnownColor() + " flower!";
        }
        public string SayGoodMorning(int weekDay)
        {
            return "I have to produce O2!";
        }
        public string SayGoodNight(int hour)
        {
            return "I have to produce CO2!";
        }
    }
}
