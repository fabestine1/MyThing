using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentWiseApi;

namespace StudentWiseClient
{
    public partial class NewEvent : Form
    {        
        public NewEvent()
        {
            InitializeComponent();
            
            // Disable past dates
            endDttpkr.MinDate = DateTime.Today;
            startDttpkr.MinDate = DateTime.Today;

            // Add event types
            eventTypeCmbbx.Items.AddRange(
                Enum.GetValues(typeof(EventType)).Cast<object>().ToArray()
            );
            eventTypeCmbbx.SelectedIndex = 0;
        }

        private void CreateBttn_Click(object sender, EventArgs e)
        {
            // check that the fields are populated
            if (string.IsNullOrEmpty(titleTbx.Text))
                throw new ApplicationException("Please, enter a title.");

            DateTime startDateTime = startDttpkr.Value.Date + startTimepkr.Value.TimeOfDay;
            DateTime endDateTime = endDttpkr.Value.Date + EndTimepkr.Value.TimeOfDay;

            if (startDateTime >= endDateTime)
                throw new ApplicationException("The finish time must greater then the start time.");            

            Event newEvent = Event.Create(
                titleTbx.Text,
                string.IsNullOrWhiteSpace(descriptionTbx.Text) ? null : descriptionTbx.Text,
                (EventType)eventTypeCmbbx.SelectedItem,
                startDateTime,
                endDateTime
            );

            FormMain.Instance.AddEventToUI(newEvent);           
            Close();
        }
    }
}
