using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2._8
{
    public partial class lblText : Form
    {
        public lblText()
        {
            InitializeComponent();
        }

        private void tbxAdd_Enter(object sender, EventArgs e)
        {
            lbxText.Items.Add(tbxAdd.Text);
        }

        private void tbxAdd_Leave(object sender, EventArgs e)
        {
            lbxText.Items.Add(tbxAdd.Text);
        }
    }
}
