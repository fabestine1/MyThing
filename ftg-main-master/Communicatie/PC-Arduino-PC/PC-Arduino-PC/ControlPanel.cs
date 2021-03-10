using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garagemanagement
{
    public partial class ControlPanel : Form
    {
        private double balance = 0;
        private double amountDue = 7.20;

        private string cardnumber = "E4 AF 45 23 OR 6D 12 8B 9A 00 34 E1";

        private string name = "b3nzchr3ur";

        private string parkingspot = "A12";

        private double stamp = 0;

        private ControlPanelView controlform;

        public ControlPanel()
        {
            InitializeComponent();
            tabControl.ItemSize = new System.Drawing.Size(0, 1);
            controlform = new ControlPanelView();

            timer1.Start();
        }
        private void showText()
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            origin.AddSeconds(this.stamp);

            tbStatusAmountDue.Text = this.amountDue.ToString();
            tbStatusArrivalTime.Text = origin.ToString();
            tbStatusParkingPlace.Text = this.parkingspot;
            tbStatusCardName.Text = this.name;
            tbStatusCardNumber.Text = this.cardnumber;
            tbStatusBalance.Text = this.balance.ToString();
            tbAddBalance.Text = this.balance.ToString();
            tbAddBalanceCardName.Text = this.name;
            tbAddBalanceCardNumber.Text = this.cardnumber;
            tbPaymentAmountDue.Text = this.amountDue.ToString();
            tbPaymentCardName.Text = this.name;
            tbPaymentCardNumber.Text = this.cardnumber;

            if (this.amountDue == 0)
            {
                btnPayCreditcard.Enabled = false;
                btnPayWithBalance.Enabled = false;
            }
            else
            {
                btnPayCreditcard.Enabled = true;
                btnPayWithBalance.Enabled = true;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString();
            lblTime2.Text = dateTime.ToString();
            lblTime3.Text = dateTime.ToString();
            lblTime4.Text = dateTime.ToString();

            if(Program.instructions.Count > 0)
            {
                List<object> instruction = Program.instructions.ElementAt(0);
                Program.instructions.RemoveAt(0);

                {
                    List<object> piece = instruction;

                    if (piece.Count > 0)
                    {
                        string commandname = piece.ElementAt(0) as string;

                        if (commandname is string)
                        {
                            switch(commandname)
                            {
                                case "CHIPFOUND":
                                    {

                                        this.cardnumber = piece.ElementAt(1) as string;

                                        this.name = piece.ElementAt(2) as string;

                                        this.parkingspot = piece.ElementAt(4) as string;

                                        double balance;

                                        double.TryParse(piece.ElementAt(3) as string, out balance);

                                        this.balance = (balance / 100);

                                        double debt;

                                        double.TryParse(piece.ElementAt(5) as string, out debt);

                                        this.amountDue = (debt / 100);

                                        double stamp;

                                        double.TryParse(piece.ElementAt(6) as string, out stamp);

                                        this.stamp = stamp;


                                        tabControl.SelectedTab = tabStatus;
                                        showText();

                                        break;
                                    }
                            }
                        }
                    }
                }
            }
        }

        private void btnPayWithCreditcard_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPayment;
        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabBalance;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabStatus;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabStatus;
        }

        private void btnStopStatus_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabShowCard;
        }

        private void btnStopAddBalance_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabShowCard;
        }

        private void btnStopPayment_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabShowCard;
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            foreach (Communication device in Program.LocalDevices)
            {
                if (device.Connected)
                {
                    Program.MasterServer.Server.Exit(device.comID);
                }
            }
            this.Close();
        }

        private void btnPayWithBalance_Click(object sender, EventArgs e)
        {
            if (balance >= amountDue)
            {
                balance -= amountDue;
                amountDue = 0;
                showText();
                tabControl.SelectedTab = tabShowCard;

                Program.MasterServer.Send("{" + Program.MasterServer.serverID + "," + Program.MasterServer.comID + ",5,\"" + this.name + "\",\"paid\"}");
            }
            else
            {
                MessageBox.Show("Not enough balance please add balance or pay with creditcard");
            }
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            if (nudAddAmount.Value != 0)
            {
                balance += Convert.ToDouble(nudAddAmount.Value);
                nudAddAmount.Value = 0;

                Program.MasterServer.Send("{" + Program.MasterServer.serverID+ "," + Program.MasterServer.comID + ",5,\"" + this.name + "\",\"balance\",\"" + (balance * 100).ToString() + "\"}");

                showText();
                tabControl.SelectedTab = tabPayment;
            }
            else
            {
                MessageBox.Show("Please enter the amount to add.");
            }
        }

        private void btnPayCredit_Click(object sender, EventArgs e)
        {
            if (amountDue != 0)
            {
                DialogResult dr = MessageBox.Show("Do you want To pay?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    amountDue = 0;
                    showText();
                    tabControl.SelectedTab = tabShowCard;

                    Program.MasterServer.Send("{" + Program.MasterServer.serverID + "," + Program.MasterServer.comID + ",5,\"" + this.name + "\",\"paid\"}");
                }
                else
                {
                    MessageBox.Show("Something went wrong, try again.");
                }
            }
        }

        private void HiddenLogin_Click(object sender, EventArgs e)
        {
            if (HiddenLogin.Text == "Admin panel")
            {
                controlform.Show();
            }
            else
            {
                if (adminPASS.Visible)
                {
                    adminPASS.Visible = false;
                }
                else
                {
                    adminPASS.Text = "";
                    adminPASS.Visible = true;
                }
            }
        }

        private void adminPASS_CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (adminPASS.Text == "SECRET")
                {
                    HiddenLogin.Text = "Admin panel";
                    adminPASS.Visible = false;
                }

                adminPASS.Text = "";
            }
        }

        private void adminPASS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}