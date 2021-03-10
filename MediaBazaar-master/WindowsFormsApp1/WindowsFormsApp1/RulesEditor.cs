using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Mail;

namespace MediaBazar
{
    public partial class RulesEditor : Form
    {
        Rules rule;
        private int createdBy;
        private const int SmtpServerPort = 587;

        public RulesEditor(int userId)
        {
            InitializeComponent();
            this.createdBy = userId;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbRuleList.Items.Clear();
            tbDescription.Clear();
            foreach (Rules rule in Rules.GetAllRules())
            {
                lbRuleList.Items.Add(rule.id.ToString() + "  -  " + rule.description);
            }
        }

        private void AddRulebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("Description is empty");
            }
            else
            {
                Rules newRule = new Rules(tbDescription.Text, createdBy);

                try
                {
                    foreach (Worker w in Worker.GetAllEmployees())
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress("mediabazaartest@gmail.com");
                        mail.To.Add(w.Email);
                        mail.Subject = "Rule Changed!";
                        mail.Body = "Hey there is a new rule added to the list! Go and check it out: <link here>.";

                        SmtpServer.Port = SmtpServerPort;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("MediaBazaarTest@gmail.com", "MediaBazaar!Test123");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                    }
                    MessageBox.Show("Rules updated and mail sent!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                UpdateForm();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (lbRuleList.SelectedIndex == -1)
            {
                MessageBox.Show("Select a rule");
            }
            else
            {
                if (MessageBox.Show("Do you really want to delete this rule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ruleText = lbRuleList.SelectedItem.ToString();
                    string ruleId = ruleText.Substring(0, ruleText.IndexOf("-"));
                    Rules.RemoveRule(Convert.ToInt32(ruleId));
                    try
                    {
                        foreach (Worker w in Worker.GetAllEmployees())
                        {
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            mail.From = new MailAddress("mediabazaartest@gmail.com");
                            mail.To.Add(w.Email);
                            mail.Subject = "Rule Changed!";
                            mail.Body = "Hey a rule was deleted from the list! Go and check it out: <link here>.";

                            SmtpServer.Port = SmtpServerPort;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("MediaBazaarTest@gmail.com", "MediaBazaar!Test123");
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);
                        }
                        MessageBox.Show("Rules updated and mail sent!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    UpdateForm();
                }
            }
        }
    }
}
