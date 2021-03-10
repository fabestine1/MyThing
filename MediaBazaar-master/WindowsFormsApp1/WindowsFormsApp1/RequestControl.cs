using System;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class RequestControl : UserControl
    {
        private int personId;
        private int createdById;
        private int departmentId;
        private string username;
        private string firstName;
        private string lastName;
        private string description;
        private decimal hourlyWage;
        private decimal previousHourlyWage;
        private DateTime contractStartDate;
        private long phoneNumber;
        private string email = null;

        ApproveManagerRequests form;
        public RequestControl(int personId, int createdById, int departmentId, string description, string firstName, string lastName, string username, ApproveManagerRequests form = null)
        {
            InitializeComponent();
            lblRequest.Text = $"{firstName} {lastName} firing!";
            lblRequestDescription.Text = description;
            this.personId = personId;
            this.createdById = createdById;
            this.departmentId = departmentId;
            this.username = username;
            this.description = description;
            this.firstName = firstName;
            this.lastName = lastName;
            this.form = form;
        }

        public RequestControl(int personId, int createdById, string username, string firstName, string lastName, decimal hourlyWage, int departmentId, DateTime contractStartDate, long phoneNumber, string email, ApproveManagerRequests form = null)
        {
            InitializeComponent();
            lblRequest.Text = $"Hiring!";
            lblRequestDescription.Text = $"Hiring of {firstName} {lastName}!";
            this.personId = personId;
            this.createdById = createdById;
            this.departmentId = departmentId;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.hourlyWage = hourlyWage;
            this.contractStartDate = contractStartDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.form = form;
        }

        public RequestControl(int personId, int createdById, string username, string firstName, string lastName, decimal hourlyWage, int departmentId, ApproveManagerRequests form = null)
        {
            InitializeComponent();
            lblRequest.Text = $"Promotion!";
            lblRequestDescription.Text = $"Promoting {firstName} {lastName}!";
            this.personId = personId;
            this.createdById = createdById;
            this.departmentId = departmentId;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.hourlyWage = hourlyWage;
            this.form = form;
            this.previousHourlyWage = Worker.GetworkerCurrentWage(personId);
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (lblRequest.Text.Contains("Hiring"))
            {
                HiringRequest hrForm = new HiringRequest(this.username, this.firstName, this.lastName, this.hourlyWage, this.departmentId, this.contractStartDate, this.phoneNumber, this.email);
                hrForm.Show();
            }
            else if(lblRequest.Text.Contains("firing"))
            {
                FiringRequest frForm = new FiringRequest(flag, this.departmentId, this.username, this.firstName, this.lastName, this.description);
                frForm.Show();
            }
            else if(lblRequest.Text.Contains("Promotion"))
            {
                PromotionRequest prForm = new PromotionRequest(flag,this.departmentId,this.firstName,this.lastName,this.hourlyWage,this.previousHourlyWage);
                prForm.Show();
            }
        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to approve this request?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblRequest.Text.Contains("Hiring"))
                {
                    foreach (HiringRequests hr in HiringRequests.GetAllHiringRequests())
                    {
                        if (hr.PersonId == personId)
                        {
                            hr.ApproveHiringRequest();
                        }
                    }
                    form.UpdateGUI();
                }
                else if (lblRequest.Text.Contains("firing"))
                {
                    foreach (FiringRequests fr in FiringRequests.GetAllFiringRequests())
                    {
                        if (fr.PersonId == personId)
                        {
                            fr.ApproveFiringRequest();
                        }
                    }
                    form.UpdateGUI();
                }
                else if (lblRequest.Text.Contains("Promotion"))
                {
                    foreach (PromotionRequests pr in PromotionRequests.GetAllPromotionRequests())
                    {
                        if (pr.PersonId == personId)
                        {
                            pr.ApprovePromotionRequest();
                        }
                    }
                    form.UpdateGUI();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to reject this request?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblRequest.Text.Contains("Hiring"))
                {
                    foreach (HiringRequests hr in HiringRequests.GetAllHiringRequests())
                    {
                        if (hr.PersonId == personId)
                        {
                            hr.DeclineHiringRequest();
                        }
                    }
                    form.UpdateGUI();
                }
                else if (lblRequest.Text.Contains("firing"))
                {
                    foreach (FiringRequests fr in FiringRequests.GetAllFiringRequests())
                    {
                        if (fr.PersonId == personId)
                        {
                            fr.DeclineFiringRequest();
                        }
                    }
                    form.UpdateGUI();
                }
                else if (lblRequest.Text.Contains("Promotion"))
                {
                    foreach (PromotionRequests pr in PromotionRequests.GetAllPromotionRequests())
                    {
                        if (pr.PersonId == personId)
                        {
                            pr.DeclinePromotionRequest();
                        }
                    }
                    form.UpdateGUI();
                }
            }
        }
    }
}
