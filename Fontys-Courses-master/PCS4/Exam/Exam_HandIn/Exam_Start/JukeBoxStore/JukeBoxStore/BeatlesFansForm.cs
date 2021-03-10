using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukeBoxStore
{
    public partial class BeatlesFanForm : Form
    {
        public BeatlesFanForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        public void InformAboutBeatlesSong(Song s, string reason)
        {
            this.lbBeatlesFans.Items.Add(s.Artist + "' " + s.Name + " has " + reason);
        }
    }
}
