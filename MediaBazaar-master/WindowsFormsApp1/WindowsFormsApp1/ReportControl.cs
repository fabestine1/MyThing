using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class ReportControl : UserControl
    {
        private int reportId;
        private string reportSubject;
        private string reportMessage;
        private string reportStatus;
        MainForm form;

        public ReportControl(int reportId, string reportSubject, string reportMessage, string reportStatus, MainForm form = null)
        {
            InitializeComponent();
            this.reportId = reportId;
            this.reportSubject = reportSubject;
            this.reportMessage = reportMessage;
            this.reportStatus = reportStatus;
            this.form = form;
            lblReportSubject.Text = this.reportSubject;
            rtbReportMessage.Text = this.reportMessage;
        }


        private void BtnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to mark as read this report?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Report r in Report.GetAllReports())
                {
                    if (r.ReportId == this.reportId)
                    {
                        r.MarkAsRead(this.reportId);
                    }
                }
                form.UpdateGUI();
            }
        }
    }
}
