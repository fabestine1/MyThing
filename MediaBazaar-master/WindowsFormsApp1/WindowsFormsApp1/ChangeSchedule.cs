using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace MediaBazar
{
    public partial class ChangeSchedule : Form
    {
        private const string Status = "unread";
        private int userId;
        private const int SmtpServerPort = 587;
        List<int> workingDays;
        List<int> workingShifts;
        public ChangeSchedule(int id)
        {
            InitializeComponent();
            PopulateEmployees(Employee.GetAllEmployees());
            workingDays = new List<int>();
            workingShifts = new List<int>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.userId = id;
            rtbMessage.MaxLength = 500;
            gbMondayShift.Enabled = false;
            gbFridayShift.Enabled = false;
            gbTuesdayShift.Enabled = false;
            gbWednesdayShift.Enabled = false;
            gbThursdayShift.Enabled = false;
            gbSundayShift.Enabled = false;
            gbSaturdayShift.Enabled = false;
        }

        private void PopulateEmployees(List<Employee> employees)
        {
            cbEmployee.Items.Clear();
            foreach (Employee e in employees)
            {
                cbEmployee.Items.Add(new EmployeeComboBoxItem(e));
            }
        }

        private void PopulateSchedule(List<int> workingDays, List<string> workingShifts)
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
                if(workingDays[i] == 0)
                {
                    cbMonday.Checked = true;
                    if(workingShifts[i] == "morning")
                    {
                        cbMondayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbMondayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbMondayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 1)
                {
                    cbTuesday.Checked = true;
                    if (workingShifts[i] == "morning")
                    {
                        cbTuesdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbTuesdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbTuesdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 2)
                {
                    cbWednesday.Checked = true;
                    if (workingShifts[i] == "morning")
                    {
                        cbWednesdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbWednesdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbWednesdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 3)
                {
                    cbThursday.Checked = true;
                    if (workingShifts[i] == "morning")
                    {
                        cbThursdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbThursdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbThursdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 4)
                {
                    cbFriday.Checked = true;
                    if (workingShifts[i] == "morning")
                    {
                        cbFridayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbFridayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbFridayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 5)
                {
                    cbSaturday.Checked = true;
                    if (workingShifts[i] == "morning")
                    {
                        cbSaturdayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbSaturdayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbSaturdayEvening.Checked = true;
                    }
                }
                if (workingDays[i] == 6)
                {
                    cbSunday.Checked = true;
                    if (workingShifts[i] == "morning")
                    {
                        cbSundayMorning.Checked = true;
                    }
                    if (workingShifts[i] == "afternoon")
                    {
                        cbSundayAfternoon.Checked = true;
                    }
                    if (workingShifts[i] == "evening")
                    {
                        cbSundayEvening.Checked = true;
                    }
                }
            }
        }

        private void CbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbMondayShift.Enabled = true;
            gbFridayShift.Enabled = true;
            gbTuesdayShift.Enabled = true;
            gbWednesdayShift.Enabled = true;
            gbThursdayShift.Enabled = true;
            gbSundayShift.Enabled = true;
            gbSaturdayShift.Enabled = true;
            int employeeId = ((EmployeeComboBoxItem)cbEmployee.SelectedItem).Id;
            List<int> workDays = Employee.GetEmployeeWorkingDays(employeeId);
            List<string> workShifts = Employee.GetEmployeeWorkingShifts(employeeId);
            PopulateSchedule(workDays, workShifts);
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            string message = rtbMessage.Text;
            if (cbEmployee.Text == "Employee" || cbEmployee.Text == "")
            {
                MessageBox.Show("Please select an employee!");
            }
            else if (rtbMessage.Text == "Message" || rtbMessage.Text == "")
            {
                MessageBox.Show("Please write a message to the employee!");
            }
            else if (cbMonday.Checked == false && cbTuesday.Checked == false && cbWednesday.Checked == false && cbThursday.Checked == false && cbFriday.Checked == false && cbSaturday.Checked == false && cbSunday.Checked == false)
            {
                MessageBox.Show("Please select a working day for the employee!");
            }
            else if (cbMondayMorning.Checked == false && cbMondayAfternoon.Checked == false && cbMondayEvening.Checked == false && cbTuesdayMorning.Checked == false && cbTuesdayAfternoon.Checked == false && cbTuesdayEvening.Checked == false && cbWednesdayMorning.Checked == false && cbWednesdayAfternoon.Checked == false && cbWednesdayEvening.Checked == false && cbThursdayMorning.Checked == false && cbThursdayAfternoon.Checked == false && cbThursdayEvening.Checked == false && cbFridayMorning.Checked == false && cbFridayAfternoon.Checked == false && cbFridayEvening.Checked == false && cbSaturdayMorning.Checked == false && cbSaturdayAfternoon.Checked == false && cbSaturdayEvening.Checked == false && cbSundayMorning.Checked == false && cbSundayAfternoon.Checked == false && cbSundayEvening.Checked == false)
            {
                MessageBox.Show("Please select a working shift for the employee!");
            }
            else
            {
                if (MessageBox.Show("Do you really want to change this schedule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    int employeeId = ((EmployeeComboBoxItem)cbEmployee.SelectedItem).Id;
                    Employee.ChangeEmployeeShift(employeeId, this.workingDays, this.workingShifts);
                    DateTime today = DateTime.Now;

                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        string sendNotification = "INSERT INTO notifications (employee_id, created_by_id, message, datetime, status) VALUE(@employee_id, @user_id, @message, @datetime, @status)";
                        MySqlCommand notificationQuery = new MySqlCommand(sendNotification, conn);
                        conn.Open();
                        notificationQuery.Parameters.AddWithValue("@employee_id", employeeId);
                        notificationQuery.Parameters.AddWithValue("@user_id", this.userId);
                        notificationQuery.Parameters.AddWithValue("@message", message);
                        notificationQuery.Parameters.AddWithValue("@datetime", today);
                        notificationQuery.Parameters.AddWithValue("@status", Status);
                        notificationQuery.ExecuteNonQuery();

                        string getEmployeeEmail = "SELECT email FROM person WHERE id=@employee_id";
                        MySqlCommand getEmployeeEmailQuery = new MySqlCommand(getEmployeeEmail, conn);
                        getEmployeeEmailQuery.Parameters.AddWithValue("@employee_id", employeeId);
                        string emailResult = getEmployeeEmailQuery.ExecuteScalar().ToString();

                        try
                        {
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            mail.From = new MailAddress("mediabazaartest@gmail.com");
                            mail.To.Add(emailResult);
                            mail.Subject = "New notification!";
                            mail.Body = "Hey you have a new notification on the website! Go and check it out: <link here>.";

                            SmtpServer.Port = SmtpServerPort;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("MediaBazaarTest@gmail.com", "MediaBazaar!Test123");
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);
                            MessageBox.Show("Mail sent!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        // TODO: add it to error log in the future
                    }
                    finally
                    {
                        conn.Close();
                    }

                    rtbMessage.Text = "";
                    cbEmployee.Text = "Employee";
                    cbMonday.Checked = false;
                    cbThursday.Checked = false;
                    cbTuesday.Checked = false;
                    cbSaturday.Checked = false;
                    cbSunday.Checked = false;
                    cbWednesday.Checked = false;
                    cbFriday.Checked = false;

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

                    gbMondayShift.Enabled = false;
                    gbFridayShift.Enabled = false;
                    gbTuesdayShift.Enabled = false;
                    gbWednesdayShift.Enabled = false;
                    gbThursdayShift.Enabled = false;
                    gbSundayShift.Enabled = false;
                    gbSaturdayShift.Enabled = false;
                }
            }
            
        }

        private void RtbMessage_Enter(object sender, EventArgs e)
        {
            if(rtbMessage.Text == "Message")
            {
                rtbMessage.Text = "";
            }
        }

        private void RtbMessage_Leave(object sender, EventArgs e)
        {
            if(rtbMessage.Text == "")
            {
                rtbMessage.Text = "Message";
            }
        }
    }
}
