using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentWiseApi;

namespace StudentWiseClient
{
    public partial class MiniComplaintComponent : UserControl
    {
        public MiniComplaintComponent(Complaint complaint)
        {
            InitializeComponent();
            Refresh(complaint);
        }

        public void Refresh(Complaint complaint)
        {
            titleLbl.Text = complaint.Title;
            statusLbl.Text = complaint.Status.ToString().ToUpper();
        }
    }
}
