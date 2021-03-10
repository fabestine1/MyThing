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
    public partial class AgreementComponent : UserControl
    {
        public AgreementComponent(Agreement agreement)
        {
            InitializeComponent();
            Refresh(agreement);
        }

        public void Refresh(Agreement agreement)
        {
            titleLbl.Text = agreement.Title.UppercaseFirst();
            descriptionLbl.Text = agreement.Description.UppercaseFirst() ?? "No description provided.";
            timestampLbl.Text = $"Created by {agreement.Creator}\r\non {agreement.CreatedAt.ToShortDateString()}";
        }
    }
}
