using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1._4
{
    class Clock
    {
        private int hour;
        private int minute;

        public delegate void AlarmHandler(int hour, int minute);
        public event AlarmHandler AlarmEvent;

        public int Hour { get { return hour; } }
        public int Minute { get { return minute; } }

        public Clock(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }

        public void AddHour()
        {
            hour++;
            AlarmEvent(hour, minute);
        }
        public void AddMinute()
        {
            minute++;
            AlarmEvent(hour, minute);
        }
    }
}
