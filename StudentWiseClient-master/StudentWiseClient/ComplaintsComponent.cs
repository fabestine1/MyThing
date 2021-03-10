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
    public partial class ComplaintsComponent : UserControl
    {
        public ComplaintsComponent(Complaint complaint)
        {
            InitializeComponent();
            Refresh(complaint);
        }

        public void Refresh(Complaint complaint)
        {
            titleLbl.Text = complaint.Title.UppercaseFirst();
            descriptionLbl.Text = complaint.Description.UppercaseFirst() ?? "No description provided.";
            statusLbl.Text = complaint.Status.ToString().ToUpper();
            timestampLbl.Text = $"Updated At {complaint.UpdatedAt}";
        }
    }
}
