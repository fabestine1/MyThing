using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS4EXAM
{
    public partial class FormCapitolStudio : Form
    {
        public FormCapitolStudio()
        {
            InitializeComponent();
            this.Visible = true;
        }

        /// <summary>
        /// shows information about the startup in the listbox
        /// </summary>
        /// <param name="startup"></param>
        public void ShowStartupInMyListbox(StartUp startup)
        {
            String holder;
            holder = startup.Name + " with description: " + startup.Description;
            this.listBox1.Items.Add(holder);
        }
    }
}
