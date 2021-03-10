using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingFedApp
{
    public partial class BlueScoutForm : Form
    {
        public BlueScoutForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        internal void showRacers(Racer r)
        {
            //string holder = "#" + " : " + r.Nr + " " + r.Name +
            //                " rank: " + r.Rank.ToString() +
            //                " type: " + r.Type.ToString() +
            //                " nr of wins: " + r.NrOfWins.ToString();

            lbBlueScout.Items.Add(r);
        }

        internal void showRankChanges(Racer r)
        {
            string holder = r.Name + "'s rank was changed to: " + r.Rank;
            lbBlueScout.Items.Add(holder);
        }
        public void ShowProRacers(List<Racer> racers)
        {
            lbBlueScout.Items.Clear();
            foreach(Racer r in racers)
            {
                if (r.Type == "pro") lbBlueScout.Items.Add(r);
            }
        }
    }
}
