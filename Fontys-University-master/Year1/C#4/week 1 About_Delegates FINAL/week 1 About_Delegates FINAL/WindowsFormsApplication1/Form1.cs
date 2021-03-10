using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            btnNewNumbers_Click(null, null);
        }


 
        public delegate int CalculateAnswerHandler(int a, int b);
        public CalculateAnswerHandler CalculateRightAnswer;

        private int firstNumber, secondNumber;
        private Random rnd = new Random();

        private void btnPracticeAdding_Click(object sender, EventArgs e)
        {
            CalculateRightAnswer += new CalculateAnswerHandler( this.CalcAddingAnswer );
            // It creates a mysterious object that holds a reference to a method of an object.
            // In this example: it holds a reference to the method CalcAddingAnswer of this form.
            this.label3.Text = "Add";
        }

        private void btnPracticeMultiplying_Click(object sender, EventArgs e)
        {
            CalculateRightAnswer += new CalculateAnswerHandler(this.CalcMultiplyingAnswer);
            this.label3.Text = "Multiply";
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            firstNumber = rnd.Next(0, 10);
            secondNumber = rnd.Next(0,10);
            this.label1.Text = firstNumber.ToString();
            this.label2.Text = secondNumber.ToString();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            int givenAnswer = Convert.ToInt32(this.textBox1.Text);
            int rightAnswer = CalculateRightAnswer(firstNumber, secondNumber);
            if (givenAnswer == rightAnswer)
            {
                MessageBox.Show("Well done, it is correct ! ! !");
            }
            else
            {
                MessageBox.Show("Sorry, wrong answer; anwer should be " +
                                rightAnswer.ToString());
            }
            this.listBox1.Items.Add("******************");
        }

        public int CalcAddingAnswer(int a, int b)
        {
            this.listBox1.Items.Add((a+b).ToString());
            return a + b;
        }

        public int CalcMultiplyingAnswer(int a, int b)
        {
            this.listBox1.Items.Add((a * b).ToString());
            return a * b;
        }

    }
}
