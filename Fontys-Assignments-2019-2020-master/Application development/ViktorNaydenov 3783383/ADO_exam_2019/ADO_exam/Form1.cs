using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_exam
{
    public partial class Form1 : Form
    {
        List<string> piggyNames = new List<string>();
        List<double> piggyBalance = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            if (name == "")
            {
                MessageBox.Show("This is not valid name!");
            }
            else
            {
                var found = false;
                for (int i = 0; i < piggyNames.Count; i++)
                {
                    if (piggyNames[i] == name)
                    {
                        MessageBox.Show("There already exists a piggy bank owner with this name!");
                        found = true;
                    }
                }
                if (!found)
                {
                    piggyNames.Add(name);
                    piggyBalance.Add(5.00);
                    lbPiggyBanks.Items.Add($"{name}'s piggy bank: {piggyBalance[piggyBalance.Count - 1]:f2}");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var index = 0;
            if (name == "")
            {
                MessageBox.Show("This is not valid name!");
            }
            else
            {
                var found = false;
                for (int i = 0; i < piggyNames.Count; i++)
                {

                    if (piggyNames[i] == name)
                    {
                        index = i;
                        found = true;
                    }
                }
                if (found)
                {
                    if (piggyBalance[index] == 0)
                    {
                        piggyNames.RemoveAt(index);
                        piggyBalance.RemoveAt(index);
                        lbPiggyBanks.Items.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show("There are still some money in your piggy bank!");
                    }
                }
                else
                {
                    MessageBox.Show("Piggy bank owner name not found!");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateListBox();

        }

        private void UpdateListBox()
        {
            lbPiggyBanks.Items.Clear();

            for (int i = 0; i < piggyNames.Count; i++)
            {
                lbPiggyBanks.Items.Add($"{piggyNames[i]}'s piggy bank: {piggyBalance[i]:f2}");
            }
        }

        private void btnShowAtLeast_Click(object sender, EventArgs e)
        {
            var atLeastBalanceText = tbLimit.Text;
            if (tbLimit.Text == "")
            {
                MessageBox.Show("This is not valid amount");
            }
            else
            {
                var atLeastBalance = double.Parse(atLeastBalanceText);

                lbPiggyBanks.Items.Clear();
                for (int i = 0; i < piggyNames.Count; i++)
                {
                    if (piggyBalance[i] > atLeastBalance)
                    {
                        lbPiggyBanks.Items.Add($"{piggyNames[i]}'s piggy bank: {piggyBalance[i]:f2}");
                    }
                }
            }
        }

        private void btnShowTotal_Click(object sender, EventArgs e)
        {
            var total = 0.00d;
            for (int i = 0; i < piggyBalance.Count; i++)
            {
                total += piggyBalance[i];
            }
            MessageBox.Show($"The total balance of all piggy bank owners is {total:f2} euro");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var index = 0;
            if (tbAmount.Text == "")
            {
                MessageBox.Show("This is not valid amount!");
            }
            else if (tbName.Text == "")
            {
                MessageBox.Show("This is not valid name!");
            }
            else
            {
                var amountToDeposit = int.Parse(tbAmount.Text);
                index = piggyNames.IndexOf(tbName.Text);
                if (index == -1)
                {
                    MessageBox.Show("There is no piggy owner with that name!");
                }
                else
                {
                    if (rbEuro.Checked)
                    {
                        piggyBalance[index] += amountToDeposit;
                    }
                    else
                    {
                        piggyBalance[index] += amountToDeposit / 100.0;
                    }
                    UpdateListBox();
                }

            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbTransferToName.Text == "")
            {
                MessageBox.Show("Please enter valid names!");
            }
            else
            {
                if (!piggyNames.Contains(tbName.Text) || !piggyNames.Contains(tbTransferToName.Text))
                {
                    MessageBox.Show("Piggy bank owner name not found");
                }
                else if (tbName.Text == tbTransferToName.Text)
                {
                    MessageBox.Show("You cannot transfer to your own piggy bank");
                }
                else
                {
                    var indexOfTheTbName = piggyNames.IndexOf(tbName.Text);
                    var indexOfTheTransferToName = piggyNames.IndexOf(tbTransferToName.Text);

                    piggyBalance[indexOfTheTransferToName] += piggyBalance[indexOfTheTbName];
                    piggyBalance[indexOfTheTbName] = 0.00;
                    UpdateListBox();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
