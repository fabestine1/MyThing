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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ContinueBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailAddressTbx.Text) ||
                !EmailValidation.IsValidEmail(emailAddressTbx.Text))
                throw new ApplicationException("Please, enter a valid email address.");

            if (string.IsNullOrEmpty(passwordTbx.Text))
                throw new ApplicationException("Please, enter your password.");

            Server.CurrentSession = Server.Login(emailAddressTbx.Text, passwordTbx.Text);
            
            FormMain dashboard = new FormMain();
            dashboard.Show();
            Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerScreen = new Register();
            registerScreen.Show();
            Close();
        }

        private void passwordTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                continueBttn.PerformClick();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ExitIfLastForm();
        }
    }
}
