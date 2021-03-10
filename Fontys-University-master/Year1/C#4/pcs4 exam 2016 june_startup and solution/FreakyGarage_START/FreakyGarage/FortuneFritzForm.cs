using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreakyGarage
{
    public partial class FortuneFritzForm : Form
    {
        public FortuneFritzForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        public void showFerrari(Garage g, Car c, String reason)
        {
            lbFortuneFritz.Items.Add("Garage " + g.Name + " has a Ferrari " + c.Type + " for sale. Reason for notification: " + reason);
        }

    }
}
