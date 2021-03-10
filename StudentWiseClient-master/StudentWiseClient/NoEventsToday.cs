using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWiseClient
{
    public partial class NoEventsToday : UserControl
    {
        public NoEventsToday()
        {
            InitializeComponent();
        }

        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            FormMain.Instance.ShowNewEventForm();
        }
    }
}
