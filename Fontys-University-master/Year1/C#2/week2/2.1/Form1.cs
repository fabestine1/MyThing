using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, result = 0;
            char sign;
            bool check = true;

            firstNumber = double.Parse(this.firstNumber.Text);
            secondNumber = double.Parse(this.secondNumber.Text);
            sign = char.Parse(this.sign.Text);
    
            if(sign == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if(sign == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if(sign == '.' || sign == '*')
            {
                result = firstNumber * secondNumber;
            }
            else if(sign == '/' || sign == ':')
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("You can NOT divide by 0");
                    check = false;
                }
                else
                {
                    result = firstNumber / secondNumber;
                }
            }
            else if(sign == '%')
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("You can NOT divide by 0");
                    check = false;
                }
                else
                {
                    result = firstNumber % secondNumber;
                }
            }

            if (check == true)
            {
                if (result == 0)
                {
                    this.result.Text = result.ToString();
                }
                else
                {
                    this.result.Text = result.ToString("#.##");
                }
            }
            else
            {
                this.result.Text = "??????";
            }
        }

        private void firstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || 
                e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || 
                e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == (char)8)
            {
                
            }
            else
            {
                e.KeyChar = '0';
            }
        }

        private void secondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' ||
                e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' ||
                e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == (char)8)
            {

            }
            else
            {
                e.KeyChar = '0';
            }
        }

        private void sign_KeyPress(object sender, KeyPressEventArgs e)
        {
            int br = 0;
            char sign = ' ';

            if(br == 0)
            {
                sign = e.KeyChar;
            }

            br++;

            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '.' ||
                e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == '%' || e.KeyChar == (char)8)
            {
               
            }
            else
            {
                MessageBox.Show("Invalid operator");
                e.KeyChar = (char)8;
            }            
        }
    }
}
