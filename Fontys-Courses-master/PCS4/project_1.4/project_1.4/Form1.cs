using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._4
{
    public partial class Form1 : Form
    {
        Clock clock;
        Person person;
        public Form1()
        {
            InitializeComponent();
            clock = new Clock(0, 0);
            person = new Person("John", 8, 0);
            clock.AlarmEvent += new Clock.AlarmHandler(person.CheckAlarm);
            person = new Person("George", 9, 0);
            clock.AlarmEvent += new Clock.AlarmHandler(person.CheckAlarm);
            person = new Person("Peter", 8, 0);
            clock.AlarmEvent += new Clock.AlarmHandler(person.CheckAlarm);
            tbxHour.Text = clock.Hour.ToString();
            tbxMinute.Text = clock.Minute.ToString();
        }

        private void btnAddHour_Click(object sender, EventArgs e)
        {
            clock.AddHour();
            tbxHour.Text = clock.Hour.ToString();
        }

        private void btnAddMinute_Click(object sender, EventArgs e)
        {
            clock.AddMinute();
            tbxMinute.Text = clock.Minute.ToString();
        }
    }
}
