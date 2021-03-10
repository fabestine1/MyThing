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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }        

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fNameTbx.Text))
                throw new ApplicationException("Please, enter your first name.");

            if (string.IsNullOrEmpty(lNameTbx.Text))
                throw new ApplicationException("Please, enter your last name.");

            if (string.IsNullOrEmpty(emailAddressTbx.Text) ||
                !EmailValidation.IsValidEmail(emailAddressTbx.Text))
                throw new ApplicationException("Please, enter a valid email address.");

            if (string.IsNullOrEmpty(passwordTbx.Text))
                throw new ApplicationException("Please, enter a password.");

            Server.CurrentSession = Server.CreateUser(emailAddressTbx.Text, fNameTbx.Text, lNameTbx.Text, passwordTbx.Text);

            // User logged in successfully, go to the according page
            FormMain dashboard = new FormMain();
            dashboard.Show();
            Close();
        }

        private void LoginLinkL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginScreen = new Login();
            loginScreen.Show();
            Close();
        }

        private void passwordTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                registerBtn.PerformClick();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ExitIfLastForm();
        }
    }
}
