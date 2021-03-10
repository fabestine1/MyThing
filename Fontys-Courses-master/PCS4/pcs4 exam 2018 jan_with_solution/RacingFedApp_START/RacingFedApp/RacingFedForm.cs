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
    public partial class RacingFedForm : Form
    {
        private RedScoutForm redScoutFrm;                   // var for red scout window
        private BlueScoutForm blueScoutFrm;                 // var for blue scout window
        private LinkedListForTestRides linkedListForTestRides;

        private List<Racer> racers = new List<Racer>();     // the list of all racers
        public event Racer.ShowRacerHandler NewRacer;

        public RacingFedForm()
        {
            InitializeComponent();
            this.redScoutFrm = new RedScoutForm();      // the window instance for Red Scout
            this.blueScoutFrm = new BlueScoutForm();    // the window instance for Blue Scout
            linkedListForTestRides = new LinkedListForTestRides();
            NewRacer += new Racer.ShowRacerHandler(blueScoutFrm.showRacers);
            NewRacer += new Racer.ShowRacerHandler(redScoutFrm.showRacers);
            addSomeTestingStuff();
            showAllRacers();
            blueScoutFrm.ShowProRacers(racers);
            redScoutFrm.ShowProRacers(racers);
        }

        private void showAllRacers()
        {
            lbRacers.Items.Clear();
            foreach (Racer r in racers)
            {
                lbRacers.Items.Add(r);
            }
        }

        // potential
        internal List<Racer> getAllRacers()
        {
            return this.racers;
        }

        private void addRacer(Racer r)
        {
            racers.Add(r);
            if(r.Type == "pro")
            {
                NewRacer(r);
            }
            r.ChangedRacerRank += new Racer.ShowRacerHandler(blueScoutFrm.showRankChanges);
            r.ChangedRacerRank += new Racer.ShowRacerHandler(redScoutFrm.showRankChanges);
        }

        // you may assume valid user tb inputs
        private void btnAddRacer_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(tbNr.Text);
            string name = tbName.Text;
            int rank = Convert.ToInt32(tbNrOfWins.Text);
            string type = tbType.Text;
            int nrOfWins = Convert.ToInt32(tbNrOfWins.Text);
            Racer r = new Racer(nr, name, rank, type, nrOfWins);
            addRacer(r);
            showAllRacers();
        }

        private void btnSortRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 1a
            racers.Sort(new SortRacersByRank());
            showAllRacers();
        }
        private static int CompareRacerTypeNrOfWins(Racer a, Racer b)
        {
            int typeDifference = a.Type.CompareTo(b.Type);
            if (typeDifference == 0) return b.NrOfWins - a.NrOfWins;
            else return typeDifference;
        }
        private void btnSortTypeNrOfWins_Click(object sender, EventArgs e)
        {
            racers.Sort(new Comparison<Racer>(CompareRacerTypeNrOfWins));
            showAllRacers();
            // to do: assignment 1b
        }

        private Racer FindRacer(int id)
        {
            foreach(Racer r in racers)
            {
                if(r.Id == id)
                {
                    return r;
                }
            }
            return null;
        }

        private void btnChangeRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 2
            if (lbRacers.SelectedIndex != -1)
            {
                Racer r = FindRacer(((Racer)lbRacers.SelectedItem).Id);
                r.setRank(Convert.ToInt32(tbNewRank.Text));
                showAllRacers();
            }
        }


        private void btnAddTestRide_Click(object sender, EventArgs e)
        {
            // to do: assignment 3b
            if (lbRacers.SelectedIndex != -1) linkedListForTestRides.addRacerToList((Racer)lbRacers.SelectedItem);
        }

        private int GetHighestRank(int n)
        {
            if(n == 0)
            {
                return -1;
            }
            else
            {
                int highestRankOfRest = GetHighestRank(n - 1);
                if(racers[n - 1].Rank > highestRankOfRest)
                {
                    return racers[n - 1].Rank;
                }
                else
                {
                    return highestRankOfRest;
                }
            }
        }

        private void btnGetHighestRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 4
            MessageBox.Show(GetHighestRank(racers.Count).ToString());
        }

        private void addSomeTestingStuff()
        {
            addRacer(new Racer(45, "Marko", 100, "pro", 5));
            addRacer(new Racer(33, "Alban", 95, "pro", 4));
            addRacer(new Racer(41, "Jack", 100, "pro", 4));
            addRacer(new Racer(37, "Arnaud", 88, "pro", 0));
            addRacer(new Racer(45, "Davide", 83, "pro", 1));
            addRacer(new Racer(11, "Jean", 59, "pro", 0));
            addRacer(new Racer(21, "Eric", 91, "rec", 3));
            addRacer(new Racer(61, "Gary", 91, "pro", 2));
        }
    }
}
