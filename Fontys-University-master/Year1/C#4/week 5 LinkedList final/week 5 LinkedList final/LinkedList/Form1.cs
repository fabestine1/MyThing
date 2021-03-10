using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {

        private ToDoList myList;
            public Form1()
        {
            InitializeComponent();
            myList = new ToDoList("jobs for the weekend");
            Item i;

            //i = new Item("buying tickets for a nice event", 10, 30);
            //myList.AddItem( i );
            //this.listBox1.Items.Add("Added: " + i.ToString());

            //i = new Item("studying pcs4", 4, 200);
            //myList.AddItem(i);
            //this.listBox1.Items.Add("Added: " + i.ToString());

            //i = new Item("getting beer for Friday-evening", 8, 60);
            //myList.AddItem(i);
            //this.listBox1.Items.Add("Added: " + i.ToString());

            //i = new Item("phoning my mam", 7, 10);
            //myList.AddItem(i);
            //this.listBox1.Items.Add("Added: " + i.ToString());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(myList.GetName());
            this.listBox1.Items.Add(myList.GetInfoFirstItem());
            this.listBox1.Items.Add(myList.GetInfoSecondItem());
            this.listBox1.Items.Add(myList.GetInfoThirdItem());
            this.listBox1.Items.Add("*****************");

            //a trick to select the last item of the listbox.
            //if you skip this trick, you need to scroll yourself to the bottom of the listbox
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item i = new Item(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            myList.AddItem( i );
            this.listBox1.Items.Add("Added: "+ i.ToString() );
            this.listBox1.Items.Add("*****************");
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Item i = myList.removeItem();
            if (i != null)
            {
                this.listBox1.Items.Add("Removed: " + i.ToString());
            }
            else
            {
                this.listBox1.Items.Add("Nothing to remove");
            }
            this.listBox1.Items.Add("*****************");
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
        }
    }
}
