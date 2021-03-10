using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._4
{
    class Person
    {
        private string name;
        private int alarmHour;
        private int alarmMinute;

        public string Name { get { return name; } }
        public int AlarmHour { get { return alarmHour; } }
        public int AlarmMinute { get { return alarmMinute; } }

        public Person(string name, int alarmHour, int alarmMinute)
        {
            this.name = name;
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
        }

        public void CheckAlarm(int hour, int minute)
        {
            if (hour == alarmHour && minute == alarmMinute)
            MessageBox.Show(name + ": " + "Wake_up, it is " + hour + ":" + minute);
        }
    }
}
