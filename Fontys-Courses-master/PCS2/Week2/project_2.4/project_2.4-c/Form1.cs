using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._4_c
{
    public partial class Form1 : Form
    {

        private BankAccount ba = new BankAccount(12, "John Smith");
        private BankAccount ba2 = new BankAccount(25, "William Jones");
        private BankAccount ba3 = new BankAccount(27, "David Brown");
        private BankAccount selectedAccount;
        private ListBox selectedListBox;
        public Form1()
        {
            InitializeComponent();
            selectedListBox.Items.Add(selectedAccount.Balance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            selectedAccount.Deposit(Convert.ToDecimal(tbxAmount.Text));
            selectedListBox.Items.Add(selectedAccount.Balance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            selectedAccount.Withdraw(Convert.ToDecimal(tbxAmount.Text));
            selectedListBox.Items.Add(selectedAccount.Balance);
        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAccount.SelectedIndex)
            {
                case 0:
                    selectedAccount = ba;
                    selectedListBox = lbxAccount1;
                    break;
                case 1:
                    selectedAccount = ba2;
                    selectedListBox = lbxAccount2;
                    break;
                case 2:
                    selectedAccount = ba3;
                    selectedListBox = gbxAccount3;
                    break;
            }
        }
    }
}
