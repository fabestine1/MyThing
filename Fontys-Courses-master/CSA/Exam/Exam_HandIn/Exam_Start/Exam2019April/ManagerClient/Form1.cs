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
using ManagerClient.SrvAdmin;


namespace ManagerClient
{
    public partial class Form1 : Form
    {
        private InstanceContext context;
        private AdminClient proxy;
        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new AdminClient();
        }

        private void btGetUsers_Click(object sender, EventArgs e)
        {
            List<User> users = proxy.GetAllUsers().ToList();
            lbUsers.Items.Clear();
            foreach (User user in users)
            {
                lbUsers.Items.Add(user);
            }
        }
    }
}
