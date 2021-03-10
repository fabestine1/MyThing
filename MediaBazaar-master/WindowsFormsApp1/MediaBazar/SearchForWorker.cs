using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class SearchForEmployee : Form
    {
        public SearchForEmployee()
        {
            InitializeComponent();
            PopulateDepartments(Department.GetAllDepartments());
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }
        private void Populateemployees(List<Worker> employees)
        {
            List<ListViewItem> lvitems = new List<ListViewItem>();
            foreach (Worker w in employees)
            {

                if (cbDepartment.SelectedIndex == -1)
                {
                    if (tbFname.Text == "" && tbLname.Text == "")
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvitems.Add(item);

                    }
                    else
                    {
                        if (tbFname.Text == "" || tbLname.Text == "")
                        {
                            MessageBox.Show("Fill in the fullname");
                            break;
                        }
                        if (tbFname.Text == w.FirstName && tbLname.Text == w.LastName)
                        {
                            ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                            lvitems.Add(item);
                        }
                    }
                }
                else
                {
                    int departmentId = ((DepartmentComboBoxItem)cbDepartment.SelectedItem).Id;
                    if (w.DepartmentId == departmentId)
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvitems.Add(item);
                    }
                }
            }
            if (checkfilter())
            {
                foreach (ListViewItem lvi in lvitems)
                {
                    int index = Convert.ToInt32(lvi.SubItems[0].Text);
                    foreach (int i in workshift())
                    {
                        if (i == index)
                        {
                            lvWokerView.Items.Remove(lvi);
                            lvWokerView.Items.Add(lvi);
                        }
                    }

                }
            }
            else
            {
                foreach (ListViewItem lvi in lvitems)
                {
                    lvWokerView.Items.Add(lvi);
                }
            }
        }

        private void PopulateManagers(List<Worker> managers)
        {

            List<ListViewItem> lvitems = new List<ListViewItem>();
            foreach (Worker w in managers)
            {

                if (cbDepartment.SelectedIndex == -1)
                {
                    if (tbFname.Text == "" && tbLname.Text == "")
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvitems.Add(item);

                    }
                    else
                    {
                        if(tbFname.Text == "" || tbLname.Text == "")
                        {
                            int counter = 0;
                            if(counter == 0)
                            {
                                  MessageBox.Show("Fill in the fullname");
                            break;
                            }
                          
                        }
                        if (tbFname.Text == w.FirstName && tbLname.Text == w.LastName)
                        {
                            ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                            lvitems.Add(item);
                        }
                    }
                }
                else
                {
                    int departmentId = ((DepartmentComboBoxItem)cbDepartment.SelectedItem).Id;
                    if (w.DepartmentId == departmentId)
                    {
                        ListViewItem item = new ListViewItem(new[] { w.Id.ToString(), w.FirstName, w.LastName, w.DateOFBirth.ToString(), w.PhoneNumber.ToString(), w.Email });
                        lvitems.Add(item);
                    }
                }
            }
            if (checkfilter())
            {
                foreach (ListViewItem lvi in lvitems)
                {
                    int index = Convert.ToInt32(lvi.SubItems[0].Text);
                    foreach (int i in workshift())
                    {
                        if (i == index)
                        {
                            lvWokerView.Items.Remove(lvi);
                            lvWokerView.Items.Add(lvi);
                        }
                    }

                }
            }
            else
            {
                foreach (ListViewItem lvi in lvitems)
                {
                    lvWokerView.Items.Add(lvi);
                }
            }
        }
        private List<int> workshift()
        {
            List<int> ids = new List<int>();
            int weekday = -1;
            string workshifts = null;
            if (rbMonday.Checked)
            {
                weekday = 0;
            }
            if (rbTuesday.Checked)
            {
                weekday = 1;
            }
            if (rbWednesday.Checked)
            {
                weekday = 2;
            }
            if (rbThrusday.Checked)
            {
                weekday = 3;
            }
            if (rbFriday.Checked)
            {
                weekday = 4;
            }
            if (rbSaturday.Checked)
            {
                weekday = 5;
            }
            if (rbSunday.Checked)
            {
                weekday = 6;
            }
            if (rbMorningshift.Checked)
            {
                workshifts = "morning";
            }
            if (rbAfternoonShift.Checked)
            {
                workshifts = "afternoon";
            }
            if (rbEveningShift.Checked)
            {
                workshifts = "evening";
            }

            Worker.GetworkerIdPerWorkday(weekday, workshifts);
            foreach (int i in Worker.GetworkerIdPerWorkday(weekday, workshifts))
            {
                ids.Add(i);
            }
            return ids;
        }

        private bool checkfilter()
        {
            if (rbMonday.Checked)
            {
                return true;
            }
            if (rbTuesday.Checked)
            {
                return true;
            }
            if (rbWednesday.Checked)
            {
                return true;
            }
            if (rbThrusday.Checked)
            {
                return true;
            }
            if (rbFriday.Checked)
            {
                return true;
            }
            if (rbSaturday.Checked)
            {
                return true;
            }
            if (rbSunday.Checked)
            {
                return true;
            }
            if (rbMorningshift.Checked)
            {
                return true;
            }
            if (rbAfternoonShift.Checked)
            {
                return true;
            }
            if (rbEveningShift.Checked)
            {
                return true;
            }
            return false;


        }

        private void bttnSearchworker_Click(object sender, EventArgs e)
        {
            lvWokerView.Items.Clear();

            if (rbEmployee.Checked)
            {
                Populateemployees(Worker.GetAllEmployees());
            }
            else if (rbManager.Checked)
            {
                PopulateManagers(Worker.GetAllManagers());
            }
            else if (rbAll.Checked)
            {
                PopulateManagers(Worker.GetAllManagers());
                Populateemployees(Worker.GetAllEmployees());
            }
            tbLname.Clear();
            tbFname.Clear();
            rbMorningshift.Checked = false;
            rbAfternoonShift.Checked = false;
            rbEveningShift.Checked = false;
            rbMonday.Checked = false;
            rbTuesday.Checked = false;
            rbWednesday.Checked = false;
            rbThrusday.Checked = false;
            rbFriday.Checked = false;
            rbSaturday.Checked = false;
            rbSunday.Checked = false;
        }
    }
}
