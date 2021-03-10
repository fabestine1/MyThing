using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }
        Form opener;
        public Materials(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Materials_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
