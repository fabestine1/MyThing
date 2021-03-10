using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_5._1
{
    public partial class Form1 : Form
    {
        private LinkedList ls;
        public Form1()
        {
            InitializeComponent();
            ls = new LinkedList();
            ls.UpdatedList += new LinkedList.UpdatedListHandler(UpdateList);
        }
        public void UpdateList()
        {
            lbxNames.Items.Clear();
            Node n = ls.firstNode;
            while (n != null)
            {
                lbxNames.Items.Add(n.Name);
                n = n.Next;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ls.Insert(tbxName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ls.Delete(tbxName.Text);
        }
    }
}
