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
        private RedScoutForm redScoutFrm;
        private BlueScoutForm blueScoutFrm;

        private List<Racer> racers = new List<Racer>();         // the list of all racers

        private LinkedListForTestRides LL;

        public RacingFedForm()
        {
            InitializeComponent();
            this.redScoutFrm = new RedScoutForm(); // the window for Red Scout
            this.blueScoutFrm = new BlueScoutForm(); // the window for Blue Scout

            addSomeTestingStuff();
            showAllRacers();
            LL = new LinkedListForTestRides();
        }

        private void showAllRacers()
        {
            lbRacers.Items.Clear();
            foreach (Racer r in racers)
            {
                lbRacers.Items.Add(r);
            }
        }

        internal List<Racer> getAllRacers()
        {
            return this.racers;
        }

        private void addRacer(Racer r)
        {
            racers.Add(r);
            redScoutFrm.showAllProRacers(this.racers);
            blueScoutFrm.showAllProRacers(this.racers);
            if (r.Type == "pro")
            {
                r.rankChanged += new Racer.RankChangedHandler(redScoutFrm.showRankChanges);
                r.rankChanged += new Racer.RankChangedHandler(blueScoutFrm.showRankChanges);
            }
        }
 

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
            racers.Sort();
            showAllRacers();
        }

        private void btnSortTypeNrOfWins_Click(object sender, EventArgs e)
        {
            // to do: assignment 1b
            racers.Sort(new Comparison<Racer>(compareByTypeAndNrOfWins));
            showAllRacers();
        }

        // For assignment 1b, sorting
        private int compareByTypeAndNrOfWins(Racer first, Racer second)
        {
            int typeDifference = first.Type.CompareTo(second.Type);
            if (typeDifference == 0)
            {                
                    return second.NrOfWins-first.NrOfWins;       
            }
            else
                return typeDifference;
        }

        private void btnChangeRank_Click(object sender, EventArgs e)
        {
            // to do: assignment 2
            Racer selected = (Racer)(lbRacers.SelectedItem);
            if (selected !=null)
            {
                selected.setRank(Convert.ToInt32(this.tbNewRank.Text));
            }
            showAllRacers();
        }


        private void btnAddTestRide_Click(object sender, EventArgs e)
        {
            // to do: assignment 3b
            Racer selected = (Racer)(lbRacers.SelectedItem);
            if (selected != null)
            {
                this.LL.addRacerToList(selected) ;
            }
            showAllRacers();
        }

        private void btnGetHighestRank_Click(object sender, EventArgs e)
        {
            if (this.racers.Count==0)
            { MessageBox.Show("there are no racers, so no highest rank"); }
            else
            { MessageBox.Show("highest rank is " + this.getHighestRank(this.racers.Count)); }           
        }

        /// <summary>
        /// we assume racers.Count is not equal to 0 and
        /// n is at least 1 and smaller than racers.count
        /// It returns the highest rank under the first n racers of the list
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int getHighestRank(int n)
        {
            if (n == 1) { return this.racers.ElementAt(0).Rank; }
            else
            {
                int temp = getHighestRank(n - 1);
                if(temp< this.racers.ElementAt(n-1).Rank)
                { return this.racers.ElementAt(n-1).Rank; }
                else { return temp; }
            }

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
