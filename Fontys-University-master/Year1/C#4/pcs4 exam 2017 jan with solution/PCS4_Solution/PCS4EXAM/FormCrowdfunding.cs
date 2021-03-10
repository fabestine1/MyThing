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
    public partial class FormCrowdfunding : Form
    {
        private CrowdFunding cf;   // the crowdfunding-object that has a list of startups
        private FormCapitolStudio frmCapitalStudio; // the window for Capitol Studio
        private FormRedFlat frmRedFlat;             // the window for RedFlat

        private LinkedListOfBigDonations LLOBD;

        public FormCrowdfunding()
        {
            InitializeComponent();
            this.cf = new CrowdFunding();
            this.frmCapitalStudio = new FormCapitolStudio();
            this.frmRedFlat = new FormRedFlat();
            this.addSomeTestingStuff();
            this.LLOBD = new LinkedListOfBigDonations();
        }

        private void btnSortOnTotalDonations_Click(object sender, EventArgs e)
        {
            this.cf.SortOnTotalDonations();
            this.showStartups();
        }

        private void btnsortOnNumberOfDonationsName_Click(object sender, EventArgs e)
        {
            this.cf.sortOnNumberOfDonations_Name();
            this.showStartups();
        }

        private void btnAddStartup_Click(object sender, EventArgs e)
        {
            if (this.cf.getStartup(tbNameStartup.Text) == null)
            {
                StartUp temp = new StartUp(tbNameStartup.Text, tbDescription.Text, tbWebsite.Text, Convert.ToInt32(tbThreshold.Text));

                if (temp.Description.Contains("music")) { temp.thresholdReached += new StartUp.thresholdReachedHandler(frmCapitalStudio.ShowStartupInMyListbox); }
                if (temp.Threshold > 10000) { temp.thresholdReached += new StartUp.thresholdReachedHandler(frmRedFlat.AlertMe); }
                temp.thresholdReached += new StartUp.thresholdReachedHandler(this.congratulations);

                this.cf.addStartup(temp);
                this.showStartups();
            }
            else
            {
                MessageBox.Show("there is already a startup with that name!");
            }
        }
        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            StartUp s = this.cf.getStartup(tbNameStartup.Text);
            if (s != null)
            {
                s.addDonation(tbNameDonator.Text, Convert.ToInt32(tbAmount.Text));
                this.showStartups();

                if (Convert.ToInt32(tbAmount.Text) >= 1000)
                {
                    this.LLOBD.addDonationToLinkedList(tbNameStartup.Text, tbNameDonator.Text, Convert.ToInt32(tbAmount.Text));
                }
            }
            else
            {
                MessageBox.Show("there is no startup with that name!");
            }
        }

        private void btnShowLinkedList_Click(object sender, EventArgs e)
        {
            //todo, assignment 4
            List<String> temp = this.LLOBD.getInfoOfAllItems();
            this.listBox1.Items.Clear();
            foreach(String s in temp) { this.listBox1.Items.Add(s); }
        }

        private void btnShowAllStartups_Click(object sender, EventArgs e)
        {
            this.showStartups();
        }
        private void showStartups()
        {
            this.listBox1.Items.Clear();
            foreach (StartUp s in this.cf.getAllStartups())
            {
                this.listBox1.Items.Add(s.ToString());
            }
        }

        /// <summary>
        /// shows information about startup st in the red bar at the bottom on the window
        /// </summary>
        /// <param name="st"></param>
        public void congratulations(StartUp st)
        {
            this.label7.Text = "congrats " + st.Name;
            this.label8.Text = "your donations: " + st.getTotalOfDonations();
            this.label9.Text = "your threshold: " + st.Threshold;
        }

        private void addSomeTestingStuff()
        {
            StartUp s;
            s = new StartUp("Moonlite", "a bedtime story projector for mobile phone", "www.moonlite.com", 7000);
            s.addDonation("Johnson", 450); s.addDonation("J.K.Rowling", 200);
            cf.addStartup(s);
            s = new StartUp("ForeverMine", "a laptop out of building blocks", "www.ForeverMine.com", 10000);
            s.addDonation("Su Jin", 100); s.addDonation("Marcos", 200); s.addDonation("Alessandro", 200);
            cf.addStartup(s);
            s = new StartUp("Trickster", "interactive 3D-movie with music", "www.tricksterStudio.uk", 15000);
            s.addDonation("J.K.Rowling", 4000); s.addDonation("Mr. Bean", 500); s.addDonation("J.K.Rowling", 3000); s.addDonation("Carla", 2000);
            s.addDonation("Frits", 3000); s.addDonation("Peter", 1400);
            cf.addStartup(s);
            s = new StartUp("Brave", "musicshow", "www.Brave.nl", 8000);
            s.addDonation("Armin van Buren", 300); s.addDonation("Marcos", 150); s.addDonation("Dj Tiesto", 350); s.addDonation("Eveline", 100);
            s.addDonation("Beyonce", 100); s.addDonation("Rihanna", 400); s.addDonation("Taylor Swift", 100);
            cf.addStartup(s);
        }
    }
}
