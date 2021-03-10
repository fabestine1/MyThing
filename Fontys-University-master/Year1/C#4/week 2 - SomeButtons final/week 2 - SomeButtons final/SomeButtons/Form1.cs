using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeButtons
{
    public partial class Form1 : Form
    {
        private Shop myShop;

        public Form1()
        {
            InitializeComponent();
            this.myShop = new Shop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for each delicious stuff I want a button on the window.
            //In this example I want 10 buttons, because myShop has a list of 10 delicious stuff.

            int widthOfAButton = 110, heightOfAButton = 40;
            int spaceBetweenButtons = 10;
            int x = 10; // (x,y) is the left-top of the button
            int y = 20;
            Font myFont = new Font("Verdana", 14);

            int nrOfButtons = this.myShop.getMyDeliciousStuff().Count;

            Button myButton;
            //if you need them you may store them in an array, otherwise do it anonymously

            foreach (DeliciousStuff ds in this.myShop.getMyDeliciousStuff())
            {
                myButton = new Button();
                myButton.Location = new System.Drawing.Point(x, y);
                myButton.Size = new System.Drawing.Size(widthOfAButton, heightOfAButton);
                myButton.Text = ds.Name;
                myButton.Tag = ds;
                myButton.Font = myFont;
                myButton.Click += new EventHandler(this.ShowMeYouLikeIt);
                this.Controls.Add(myButton);

                x = x + widthOfAButton + spaceBetweenButtons;
            }
        }

        private void ShowMeYouLikeIt(object sender, EventArgs e)
        {
            MessageBox.Show("Aha, you like " +
                ((Button)sender).Text +
                " and it costs " + (    ((DeliciousStuff)((Button)sender).Tag)).Price   );
        }
    }
}
