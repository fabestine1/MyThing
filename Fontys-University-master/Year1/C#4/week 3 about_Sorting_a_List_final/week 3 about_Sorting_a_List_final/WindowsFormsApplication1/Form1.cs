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
        Store s;

        public Form1()
        {
            InitializeComponent();
            s = new Store();

            s.AddDrumble(new Drumble(6, "Robert", 307));
            s.AddDrumble(new Drumble(1, "Dholon", 322));
            s.AddDrumble(new Drumble(14, "Fares", 310));
            s.AddDrumble(new Drumble(15, "Mark", 300));
            s.AddDrumble(new Drumble(38, "Natalia", 251));
            s.AddDrumble(new Drumble(23, "Mara", 302));
            s.AddDrumble(new Drumble(34, "David", 287));
            s.AddDrumble(new Drumble(35, "Timoti", 285));
            s.AddDrumble(new Drumble(16, "Kaloyan", 320));
            s.AddDrumble(new Drumble(77, "Angel", 300));
            s.AddDrumble(new Drumble(17, "Nikolay", 300));
            s.AddDrumble(new Drumble(18, "Anguelv", 310));
            s.AddDrumble(new Drumble(20, "Ivan", 299));
            s.AddDrumble(new Drumble(27, "Ian", 260));
            s.AddDrumble(new Drumble(30, "Huy", 400));
            s.AddDrumble(new Drumble(31, "Nhan", 265));
            s.AddDrumble(new Drumble(43, "Dan", 304));
            s.AddDrumble(new Drumble(42, "Diandra", 411));
            s.AddDrumble(new Drumble(32, "Nidhi", 399));
 
 
            s.AddDrumble(new Drumble(33, "Hristiyan", 290));
            s.AddDrumble(new Drumble(33, "Joe", 301));
            s.AddDrumble(new Drumble(49, "Zhiyao", 320));
            s.AddDrumble(new Drumble(72, "Carina", 315));
            s.AddDrumble(new Drumble(74, "Eliza", 320));
            s.AddDrumble(new Drumble(47, "Ahmed", 320));
            s.AddDrumble(new Drumble(33, "Atanas", 301));
            s.AddDrumble(new Drumble(65, "Dmitrii", 301));
            s.AddDrumble(new Drumble(84, "Stefan", 301));
            s.AddDrumble(new Drumble(54, "Aleks", 301));

            this.ShowStoreInListbox();
        }

        private void ShowStoreInListbox()
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Id  -  name  -  nrOfCredits");
            foreach (Drumble d in this.s.Drumbles)
            {
                this.listBox1.Items.Add(d.ToString());
            }
        }
        private void btSort1_Click(object sender, EventArgs e)
        {
            this.s.SortById();
            this.ShowStoreInListbox();

        }

        private void btSort2_Click(object sender, EventArgs e)
        {
            this.s.SortByName();
            this.ShowStoreInListbox();
        }

        private void btSort3_Click(object sender, EventArgs e)
        {
            this.s.SortbyNumberOfCredits();
            this.ShowStoreInListbox();
        }


      

    }
}
