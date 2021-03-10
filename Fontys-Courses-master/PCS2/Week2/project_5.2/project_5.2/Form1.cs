using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_5._2
{
    public partial class Form1 : Form
    {
        List<string> names;
        public Form1()
        {
            InitializeComponent();
            names = new List<string>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lbxNames.Items.Add(tbxName.Text);
            names.Add(tbxName.Text);
            names.Sort();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            names.RemoveAt(lbxNames.SelectedIndex);
            lbxNames.Items.RemoveAt(lbxNames.SelectedIndex);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxNames.Items.Clear();
            lbxNames.SelectedIndex = lbxNames.Items.IndexOf(tbxSearchName.Text);
            string query = tbxName.Text;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == query)
                {
                    lbxNames.Items.Add(names[i]);
                }
            }
        }
    }
}
