using System;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class LoginForm : Form
    {
        Worker worker;
        public LoginForm()
        {
            InitializeComponent();
            mediaBazarLogoLogin.BorderStyle = BorderStyle.None;
            worker = new Worker();
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(usernameLoginInput.Text))
            {
                MessageBox.Show("Enter username");
                return;
            }

            if (String.IsNullOrWhiteSpace(passwordLoginInput.Text))
            {
                MessageBox.Show("Enter password");
                return;
            }

            string username = usernameLoginInput.Text;
            string psswd = passwordLoginInput.Text;
            bool isLoggedIn = worker.Login(username, psswd);
            int user_id = worker.Id;
            int workerRole = worker.WorkerRole;
            if (!isLoggedIn)
            {
                MessageBox.Show("You have entered wrong credentials");
                return;
            }
            (new MainForm(username, workerRole, user_id)).Show();
            this.Hide();

        }
    }
}
