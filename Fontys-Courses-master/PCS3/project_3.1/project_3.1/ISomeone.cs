using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._1
{
    interface ISomeone
    {
        String IntroduceYourself();
        String SayGoodMorning(int weekDay);
        String SayGoodNight(int hour);
    }
}
