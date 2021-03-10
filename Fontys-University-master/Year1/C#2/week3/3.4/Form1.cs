using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4
{
    public partial class movement : Form
    {
        Point loc;

        public movement()
        {
            InitializeComponent();

            loc = this.pbHead.Location;
        }

        private void movement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                loc.Y += 4;
                this.pbHead.Location = loc;   
            }
            if (e.KeyCode == Keys.Up)
            {
                loc.Y -= 4;
                this.pbHead.Location = loc;
            }
            if (e.KeyCode == Keys.Left)
            {
                loc.X -= 4;
                this.pbHead.Location = loc;
            }
            if (e.KeyCode == Keys.Right)
            {
                loc.X += 4;
                this.pbHead.Location = loc;
            }
        }
    }
}
