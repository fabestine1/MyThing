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
    public partial class PromoBoardForm : Form
    {
        public PromoBoardForm()
        {
            InitializeComponent();
            this.Visible = true;
        }
        public void PromoteCheapSong(Song s)
        {
            this.lbPromo.Items.Add("Get " + s.Name + " by " + s.Artist + ", now for only €" + s.Price);
        }
    }
}
