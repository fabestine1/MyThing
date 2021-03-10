using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Form1 : Form
    {
        TransportCompany myCompany;

        public Form1()
        {
            InitializeComponent();
            myCompany = new TransportCompany();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open a persons data file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    myCompany.LoadPersonsFromFile(ofd.FileName);
                    using (OpenFileDialog ofdDeliverables = new OpenFileDialog())
                    {
                        ofd.Title = "Open a deliverables data file";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            myCompany.LoadDeliverablesFromFile(ofd.FileName);
                            foreach (Deliverable d in myCompany.Deliverables)
                            {
                                listBox1.Items.Add(d);
                            }
                        }
                    }
                }
            }
        }

        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            myCompany.SortByWeight();
            RebuildList();
        }

        private void RebuildList()
        {
            listBox1.Items.Clear();
            foreach (Deliverable d in myCompany.Deliverables)
            {
                listBox1.Items.Add(d);
            }
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            myCompany.SortByName();
            RebuildList();
        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            myCompany.SortById();
            RebuildList();
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            myCompany.SortByAddress();
            RebuildList();
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            myCompany.SortForPostman();
            RebuildList();
        }

        private void btMerge_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open a persons data file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    myCompany.LoadPersonsFromFile(ofd.FileName);
                    using (OpenFileDialog ofdDeliverables = new OpenFileDialog())
                    {
                        ofd.Title = "Open a deliverables data file for merge";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            myCompany.Merge(ofd.FileName);
                            listBox1.Items.Clear();
                            foreach (Deliverable d in myCompany.Deliverables)
                            {
                                listBox1.Items.Add(d);
                            }
                        }
                    }
                }
            }
        }
    }
}
