using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._5
{
    public partial class Form1 : Form
    {
        Client client1;
        Client client2;
        Client client3;
        Client selectedClient;
        ListBox selectedListBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
                if (rbtnCheckings.Checked == true)
                {
                    selectedClient.DepositCheckings(Convert.ToDecimal(tbxAmount.Text));
                }
                else
                {
                    selectedClient.DepositSavings(Convert.ToDecimal(tbxAmount.Text));
                }
                string[] values = selectedClient.ShowClientOverview().Split(',');
                foreach (string value in values)
                {
                    if (value.Trim() == "")
                        continue;
                    selectedListBox.Items.Add(value.Trim());
                }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
                if (rbtnCheckings.Checked == true)
                {
                    selectedClient.WithDrawCheckings(Convert.ToDecimal(tbxAmount.Text));
                }
                else
                {
                    selectedClient.WithDrawSAvings(Convert.ToDecimal(tbxAmount.Text));
                }
                string[] values = selectedClient.ShowClientOverview().Split(',');
                foreach (string value in values)
                {
                    if (value.Trim() == "")
                        continue;
                    selectedListBox.Items.Add(value.Trim());
                }
            }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2(this);
            //frm.Show();
            createUserPanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblClientName_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (cbClients.Items.Count)
            {
                case 0:
                    client1 = new Client(tbxClientName.Text, clientBirthDate.Value);
                    break;
                case 1:
                    client2 = new Client(tbxClientName.Text, clientBirthDate.Value);
                    break;
                case 2:
                    client3 = new Client(tbxClientName.Text, clientBirthDate.Value);
                    btnNewUser.Visible = false;
                    break;
            }
            cbClients.Items.Add(tbxClientName.Text);
            createUserPanel.Visible = false;
            cbClients.SelectedIndex = 0;
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbClients.SelectedIndex)
            {
                case 0:
                    selectedClient = client1;
                    selectedListBox = lbxClient1;
                    break;
                case 1:
                    selectedClient = client2;
                    selectedListBox = lbxClient2;
                    break;
                case 2:
                    selectedClient = client3;
                    selectedListBox = lbxClient3;
                    break;
            }
        }
    }
    }
