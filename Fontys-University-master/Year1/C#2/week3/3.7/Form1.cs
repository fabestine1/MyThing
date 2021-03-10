using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;

namespace _2._4
{
    public partial class Form1 : Form
    {
        DateTime birth = new DateTime(1998, 03, 31);

        BankAccount checkingsAccount = new BankAccount();

        BankAccount savingsAccount = new BankAccount();

        Client person;

        public Form1()
        {
            InitializeComponent();

            person = new Client("Mlg", "Pro", birth, checkingsAccount, savingsAccount);
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            decimal deposit;

            deposit = decimal.Parse(this.tbDeposit.Text);

            if(this.rbCheckings.Checked == true)
            {
                person.CheckingsAccount.Deposit(deposit);
                this.tbChekings.Text = person.CheckingsAccount.Balance.ToString();
            }
            if(this.rbSavings.Checked == true)
            {
                person.SavingsAccount.Deposit(deposit);
                this.tbSavings.Text = person.SavingsAccount.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Chose savings or checkings");
            }

            this.tbDeposit.Text = String.Empty;
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            decimal withdraw;
            
            withdraw = decimal.Parse(this.tbWithdraw.Text);
            
            if (this.rbCheckings.Checked == true)
            {
                if (withdraw > person.CheckingsAccount.Balance)
                {
                    MessageBox.Show("You cann NOT withdraw more money than what you have");
                }
                else
                {
                    person.CheckingsAccount.Withdraw(withdraw);
                    this.tbChekings.Text = person.CheckingsAccount.Balance.ToString();
                }
            }
            if (this.rbSavings.Checked == true)
            {
                if (withdraw > person.CheckingsAccount.Balance)
                {
                    MessageBox.Show("You cann NOT withdraw more money than what you have");
                }
                {
                    person.SavingsAccount.Withdraw(withdraw);
                    this.tbSavings.Text = person.SavingsAccount.Balance.ToString();
                }
            }
            else
            {
                MessageBox.Show("Chose savings or checkings");
            }

            this.tbWithdraw.Text = String.Empty;
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            this.tbInfo.Text = person.ShowClientOverview();

            this.dtpBirth.Value = person.BirthDate;

            this.dtpBirth.Visible = true;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
