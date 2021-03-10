using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2
{
    public partial class Form1 : Form
    {
        List<String> names;

        public Form1()
        {
            InitializeComponent();

            names = new List<String>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name;

            name = this.tbAddName.Text;

            names.Add(name);
            names.Sort();

            this.lbNames.Items.Clear();

            for (int i = 0; i < names.Count; i++)
            {
                this.lbNames.Items.Add(names[i]);
            }
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            String name;

            name = this.tbFindName.Text;

            lbNames.SetSelected(lbNames.FindString(name), true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String name;

            name = this.lbNames.GetItemText(this.lbNames.SelectedItem);

            names.Remove(name);
            names.Sort();

            this.lbNames.Items.Clear();

            for (int i = 0; i < names.Count; i++)
            {
                this.lbNames.Items.Add(names[i]);
            }
        }
    }
}
