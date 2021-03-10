using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Practical2_4
{
    public partial class Form1 : Form
    {
        BankAccount baA;
        BankAccount baB;
        BankAccount baC;

        BankAccount selectedAccount;
        ListBox selectedListBox;

        public Form1()
        {
            InitializeComponent();
            baA = new BankAccount(1, 0, "John");
            baB = new BankAccount(2, 1000, "Jane");
            baC = new BankAccount(5, 10, "Doe");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            selectedAccount.Deposit(Convert.ToDecimal(amountTextBox.Text));
            selectedListBox.Items.Add("New balance:" + selectedAccount.Balance);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            
            if(selectedAccount.Withdraw(Convert.ToDecimal(amountTextBox.Text)))
            {
                selectedListBox.Items.Add("New balance:" + selectedAccount.Balance);
            }
            else
            {
                selectedListBox.Items.Add("Insufficient balance");
            }
            
           
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (accountComboBox.SelectedIndex)
            {
                case 0: //Account A                    
                    selectedAccount = baA;
                    selectedListBox = accountAListBox;
                    break;
                case 1: //Account B
                    selectedAccount = baB;
                    selectedListBox = accountBListBox;
                    break;
                case 2: //Account C
                    selectedAccount = baC;
                    selectedListBox = accountCListBox;
                    break;
            }
        }
    }
}
