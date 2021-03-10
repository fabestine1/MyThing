using MediaBazar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AssignShifts : Form
    {
        CreateAccount ca;
        List<int> workingDays = new List<int>();
        List<int> workingShifts = new List<int>();
        public AssignShifts(CreateAccount form, List<int>workingdays, List<int> workingshifts)
        {
            InitializeComponent();
            ca = form;
            workingDays = workingdays;
            workingShifts = workingshifts;
            PopulateSchedule(workingDays, workingShifts);
        }

        private void PopulateSchedule(List<int> workingDays, List<int> workingShifts)
        {
            cbMonday.Checked = false;
            cbTuesday.Checked = false;
            cbWednesday.Checked = false;
            cbThursday.Checked = false;
            cbFriday.Checked = false;
            cbSaturday.Checked = false;
            cbSunday.Checked = false;
            cbMondayMorning.Checked = false;
            cbMondayAfternoon.Checked = false;
            cbMondayEvening.Checked = false;
            cbTuesdayMorning.Checked = false;
            cbTuesdayAfternoon.Checked = false;
            cbTuesdayEvening.Checked = false;
            cbWednesdayMorning.Checked = false;
            cbWednesdayEvening.Checked = false;
            cbWednesdayAfternoon.Checked = false;
            cbThursdayMorning.Checked = false;
            cbThursdayEvening.Checked = false;
            cbThursdayAfternoon.Checked = false;
            cbFridayMorning.Checked = false;
            cbFridayEvening.Checked = false;
            cbFridayAfternoon.Checked = false;
            cbSaturdayMorning.Checked = false;
            cbSaturdayAfternoon.Checked = false;
            cbSaturdayEvening.Checked = false;
            cbSundayAfternoon.Checked = false;
            cbSundayEvening.Checked = false;
            cbSundayMorning.Checked = false;

            for (int i = 0; i < workingDays.Count; i++)
            {
                if (workingDays[i] == 0)
                {
                    cbMonday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbMondayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbMondayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbMondayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 1)
                {
                    cbTuesday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbTuesdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbTuesdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbTuesdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 2)
                {
                    cbWednesday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbWednesdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbWednesdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbWednesdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 3)
                {
                    cbThursday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbThursdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbThursdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbThursdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 4)
                {
                    cbFriday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbFridayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbFridayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbFridayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 5)
                {
                    cbSaturday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbSaturdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbSaturdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbSaturdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 6)
                {
                    cbSunday.Checked = true;
                    if (workingShifts[i] == 1)
                    {
                        cbSundayMorning.Checked = true;
                    }
                    if (workingShifts[i] == 2)
                    {
                        cbSundayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == 3)
                    {
                        cbSundayEvening.Checked = true;
                    }
                }
            }
        }

        private void btnAssignCurrentShifts_Click(object sender, EventArgs e)
        {

            if (cbMonday.Checked == false && cbTuesday.Checked == false && cbWednesday.Checked == false && cbThursday.Checked == false && cbFriday.Checked == false && cbSaturday.Checked == false && cbSunday.Checked == false)
            {
                MessageBox.Show("Please select a working day for the employee!");
            }
            else if (cbMondayMorning.Checked == false && cbMondayAfternoon.Checked == false && cbMondayEvening.Checked == false && cbTuesdayMorning.Checked == false && cbTuesdayAfternoon.Checked == false && cbTuesdayEvening.Checked == false && cbWednesdayMorning.Checked == false && cbWednesdayAfternoon.Checked == false && cbWednesdayEvening.Checked == false && cbThursdayMorning.Checked == false && cbThursdayAfternoon.Checked == false && cbThursdayEvening.Checked == false && cbFridayMorning.Checked == false && cbFridayAfternoon.Checked == false && cbFridayEvening.Checked == false && cbSaturdayMorning.Checked == false && cbSaturdayAfternoon.Checked == false && cbSaturdayEvening.Checked == false && cbSundayMorning.Checked == false && cbSundayAfternoon.Checked == false && cbSundayEvening.Checked == false)
            {
                MessageBox.Show("Please select a working shift for the employee!");
            }
            else
            {
                if (MessageBox.Show("Do you really want to save this schedule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.workingDays.Clear();
                    this.workingShifts.Clear();
                    if (cbMonday.Checked)
                    {
                        if (cbMondayMorning.Checked)
                        {
                            this.workingDays.Add(0);
                            this.workingShifts.Add(1);
                        }
                        if (cbMondayAfternoon.Checked)
                        {
                            this.workingDays.Add(0);
                            this.workingShifts.Add(2);
                        }
                        if (cbMondayEvening.Checked)
                        {
                            this.workingDays.Add(0);
                            this.workingShifts.Add(3);
                        }
                    }
                    if (cbTuesday.Checked)
                    {
                        if (cbTuesdayMorning.Checked)
                        {
                            this.workingDays.Add(1);
                            this.workingShifts.Add(1);
                        }
                        if (cbTuesdayAfternoon.Checked)
                        {
                            this.workingDays.Add(1);
                            this.workingShifts.Add(2);
                        }
                        if (cbTuesdayEvening.Checked)
                        {
                            this.workingDays.Add(1);
                            this.workingShifts.Add(3);
                        }
                    }
                    if (cbWednesday.Checked)
                    {
                        if (cbWednesdayMorning.Checked)
                        {
                            this.workingDays.Add(2);
                            this.workingShifts.Add(1);
                        }
                        if (cbWednesdayAfternoon.Checked)
                        {
                            this.workingDays.Add(2);
                            this.workingShifts.Add(2);
                        }
                        if (cbWednesdayEvening.Checked)
                        {
                            this.workingDays.Add(2);
                            this.workingShifts.Add(3);
                        }
                    }
                    if (cbThursday.Checked)
                    {
                        if (cbThursdayMorning.Checked)
                        {
                            this.workingDays.Add(3);
                            this.workingShifts.Add(1);
                        }
                        if (cbThursdayAfternoon.Checked)
                        {
                            this.workingDays.Add(3);
                            this.workingShifts.Add(2);
                        }
                        if (cbThursdayEvening.Checked)
                        {
                            this.workingDays.Add(3);
                            this.workingShifts.Add(3);
                        }
                    }
                    if (cbFriday.Checked)
                    {
                        if (cbFridayMorning.Checked)
                        {
                            this.workingDays.Add(4);
                            this.workingShifts.Add(1);
                        }
                        if (cbFridayAfternoon.Checked)
                        {
                            this.workingDays.Add(4);
                            this.workingShifts.Add(2);
                        }
                        if (cbFridayEvening.Checked)
                        {
                            this.workingDays.Add(4);
                            this.workingShifts.Add(3);
                        }
                    }
                    if (cbSaturday.Checked)
                    {
                        if (cbSaturdayMorning.Checked)
                        {
                            this.workingDays.Add(5);
                            this.workingShifts.Add(1);
                        }
                        if (cbSaturdayAfternoon.Checked)
                        {
                            this.workingDays.Add(5);
                            this.workingShifts.Add(2);
                        }
                        if (cbSaturdayEvening.Checked)
                        {
                            this.workingDays.Add(5);
                            this.workingShifts.Add(3);
                        }
                    }
                    if (cbSunday.Checked)
                    {
                        if (cbSundayMorning.Checked)
                        {
                            this.workingDays.Add(6);
                            this.workingShifts.Add(1);
                        }
                        if (cbSundayAfternoon.Checked)
                        {
                            this.workingDays.Add(6);
                            this.workingShifts.Add(2);
                        }
                        if (cbSundayEvening.Checked)
                        {
                            this.workingDays.Add(6);
                            this.workingShifts.Add(3);
                        }
                    }
                    
                    ca.AddEmployeeShifts(workingDays, workingShifts);
                    this.Hide();
                }
            }
        }
    }
}
