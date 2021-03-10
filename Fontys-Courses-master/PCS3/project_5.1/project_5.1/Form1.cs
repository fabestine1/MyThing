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
        TextFileHelper tfh;
        public Form1()
        {
            InitializeComponent();
            tfh = new TextFileHelper("MyTestTextFile.txt");
            lblFileName.Text = tfh.FileName;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            richTextBoxContent.Lines = tfh.LoadFromFile().ToArray();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tfh.SaveToFile(richTextBoxContent.Lines.ToList());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    tfh.FileName = lblFileName.Text = ofd.FileName;
                }
            }
        }
    }
}
