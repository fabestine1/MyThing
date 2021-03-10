using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingClient.SrvClient;

namespace MessagingClient
{
    public partial class Form1 : Form, IMessagerCallback
    {
        private InstanceContext context;
        private MessagerClient proxy;
        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new MessagerClient(context);
        }

        public void LoginStatus(bool isSuccessful, string message)
        {
            labelLoginStatus.Text = message;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            proxy.Connect(tbUserName.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Disconnect();
        }

        private void btGetListOfUsers_Click(object sender, EventArgs e)
        {
            List<User> users = proxy.GetUsers().ToList();
            lbUsers.Items.Clear();
            foreach (User user in users)
            {
                if (user.Username != tbUserName.Text)
                lbUsers.Items.Add(user.Username);
            }
        }

        private void btSendPrivate_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex > -1)
            proxy.SendMessage(tbPrivateMessage.Text, lbUsers.SelectedItem.ToString());
        }

        public void ReceivedMessage(string message)
        {
            lbMessages.Items.Add(message);
        }

        private void btPostPublic_Click(object sender, EventArgs e)
        {
            proxy.SendPublicMessage(tbPublicMessage.Text);
        }

        public void Blocked(string message)
        {
            lbMessages.Items.Add(message);
        }
    }
}
