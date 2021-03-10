using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class FormMyPerson : Form, ITeacherRetirement
    {
        private List<Person> persons = new List<Person>();


        public FormMyPerson()
        {
            InitializeComponent();
        }


        private void LogPersonChange(string changeName)
        {
            this.richTextBoxActivityLogMyPerson.AppendText("\n*********************** " + changeName);
            this.richTextBoxActivityLogMyPerson.AppendText("\n" + persons[listBoxAllPersons.SelectedIndex].InfoString());
            this.labelMyPersonInfo.Text = persons[listBoxAllPersons.SelectedIndex].InfoString();
        }                   

        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            persons[listBoxAllPersons.SelectedIndex].StartAnotherSchoolYear();
            LogPersonChange( "year at Fontys");
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            persons[listBoxAllPersons.SelectedIndex].CelebrateBirthDay();
            LogPersonChange( "birthday");
        }
       

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            int pcn = Convert.ToInt32(this.textBoxPCN.Text);
            int age = Convert.ToInt32(this.textBoxAge.Text);
            string country = this.textBoxCountry.Text;
            int salary = Convert.ToInt32(this.textBoxSalary.Text);

            listBoxAllPersons.Items.Add(name);
            listBoxAllPersons.SelectedIndex = listBoxAllPersons.Items.Count - 1;

            if (radioButtonPerson.Checked)
            {
                persons.Add(new Person(name, pcn, age));
                LogPersonChange("CREATED PERSON :");
            }
            else if (radioButtonStudent.Checked)
            {
                persons.Add(new Student(name, pcn, age, country));
                LogPersonChange("CREATED STUDENT :");
            }
            else
            {
                Teacher t = new Teacher(name, pcn, age, Function.JUNIOR_DOCENT, salary);
                persons.Add(t);
                LogPersonChange("CREATED TEACHER :");
                t.SetRetirementListener(this);
            }
        }

        private void buttonPromotion_Click(object sender, EventArgs e)
        {
            if (persons[listBoxAllPersons.SelectedIndex] is Teacher)
            {
                ((Teacher)persons[listBoxAllPersons.SelectedIndex]).Promote();
                LogPersonChange("promotion");
            }
            else
            {
                string messageStr = "";
                if(persons[listBoxAllPersons.SelectedIndex] is Student)
                {
                    messageStr = "Student";
                }
                else
                {
                    messageStr = "Person";
                }
                this.richTextBoxActivityLogMyPerson.AppendText("\n*********************** promote ERROR!\nCannot promote a " + messageStr + "!");
            }
        }

        private void buttonAddModuleECs_Click(object sender, EventArgs e)
        {
            if (persons[listBoxAllPersons.SelectedIndex] is Student)
            {
                ((Student)persons[listBoxAllPersons.SelectedIndex]).AddECs(3);
                LogPersonChange("module EC");
            }
            else
            {
                string messageStr = "";
                if (persons[listBoxAllPersons.SelectedIndex] is Teacher)
                {
                    messageStr = "Teacher";
                }
                else
                {
                    messageStr = "Person";
                }
                this.richTextBoxActivityLogMyPerson.AppendText("\n*********************** promote ERROR!\nCannot add ECs to a " + messageStr + "!");
            }
        }

        private void listBoxAllPersons_MouseClick(object sender, MouseEventArgs e)
        {
            labelMyPersonInfo.Text = persons[listBoxAllPersons.SelectedIndex].InfoString();
        }
        public void WantToRetire(Teacher t, string reason)
        {
            MessageBox.Show(reason);
        }
    }
}
