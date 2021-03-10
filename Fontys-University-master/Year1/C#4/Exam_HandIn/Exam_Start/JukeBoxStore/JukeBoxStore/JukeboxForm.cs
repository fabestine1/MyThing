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
    public partial class JukeboxForm : Form
    {
        private JukeboxStore myStore;          // The store with the list of songs
        private BeatlesFanForm frmBeatles;
        private PromoBoardForm frmPromo;


        private LLOfPlayedSongs listOfPlayedSongs = new LLOfPlayedSongs(); 

        public JukeboxForm()
        {
            InitializeComponent();
            this.myStore = new JukeboxStore("The Nuke Juke");
            this.frmBeatles = new BeatlesFanForm(); // the window for Beatles fan
            this.frmPromo = new PromoBoardForm();   // the window for promotions
            this.Text = myStore.Name;
            
            this.myStore.processBeatles += new JukeboxStore.InterestingSongHandler(frmBeatles.InformAboutBeatlesSong);
            this.myStore.processBeatlesChange += new JukeboxStore.InterestingSongHandler(frmBeatles.InformAboutBeatlesSong);

            this.myStore.processPromotion += new JukeboxStore.InterestingSongPromotionHandler(frmPromo.PromoteCheapSong);

            AddTestData();
        }

        private void ShowSongs()
        {
            this.lbSongs.Items.Clear();
            foreach (Song s in this.myStore.GetAllSongs())
            {
                this.lbSongs.Items.Add(s);
            }
        }

        private void BtnSortYear_Click(object sender, EventArgs e)
        {
            this.myStore.SortByYear();
            ShowSongs();
        }

        private void BtnSortArtistPriceAndName_Click(object sender, EventArgs e)
        {
            this.myStore.SortByArtistPriceAndName();
            ShowSongs();
        }
        

        private void BtnAddSong_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string artist = tbArtist.Text;
            int year = Convert.ToInt32(tbYear.Text);
            double price = Convert.ToDouble(tbPrice.Text);
            Song s = new Song(name,artist,year,price);

            this.myStore.AddSong(s);
            ShowSongs();
            labelInfo.Text = "New song added";
        }

        private void BtnChangePrice_Click(object sender, EventArgs e)
        {
            Song selectedSong = (Song)lbSongs.SelectedItem;
            if (selectedSong != null)
            {
                double newPrice = Convert.ToDouble(tbNewPrice.Text);
                selectedSong.ChangePrice(newPrice);
                
                this.myStore.NotifyListeners(selectedSong, "Price change");
                ShowSongs();

                labelInfo.Text = "New price (€" + selectedSong.Price + ") for " + selectedSong.Name;
            }
            else
            {
                MessageBox.Show("Please select a song from the list first!");
            }
        }

        private void BtnFindCheapestBeatlesSong_Click(object sender, EventArgs e)
        {
            // todo: assignment 3
            if (this.myStore.GetAllSongs().Count == 0)
            { MessageBox.Show("9999"); }
            else
            { MessageBox.Show("The Cheapest Beatles Song is " + myStore.GetCheapestBeatlesSong()); }
        }
        private void BtnNrOfCreditsPerArtist_Click(object sender, EventArgs e)
        {
            // todo: assignment 4
            MessageBox.Show(listOfPlayedSongs.NrOfCreditsPerArtist(tbArtistPlayed.Text).ToString());
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            // todo: assignment 4
            Song selectedSong = (Song)lbSongs.SelectedItem;
            listOfPlayedSongs.RegisterPlayed(selectedSong);
        }

        private void AddTestData()
        {
            Song s;
            s = new Song("Another Brick in the Wall", "Pink Floyd", 1979, 2.5);
            this.myStore.AddSong(s);
            s = new Song("Hey Jude", "The Beatles", 1968, 3.0);
            this.myStore.AddSong(s);
            s = new Song("Candle in the Wind", "Elton John", 1997, 5.5);
            this.myStore.AddSong(s);
            s = new Song("Umbrella", "Rihanna & Jay-Z", 2007, 5.0);
            this.myStore.AddSong(s);
            s = new Song("Heart of Glass", "Blondie", 1979, 2.8);
            this.myStore.AddSong(s);
            s = new Song("Paint It, Black", "Rolling Stones", 1966, 3.3);
            this.myStore.AddSong(s);
            s = new Song("Here Comes the Sun", "The Beatles", 1969, 3.7);
            this.myStore.AddSong(s);
            s = new Song("Billie Jean", "Michael Jackson", 1983, 4.2);
            this.myStore.AddSong(s);
            s = new Song("Shape of My Heart", "Sting", 1993, 5);
            this.myStore.AddSong(s);
            s = new Song("Don't Let Me Down", "The Beatles", 1988, 3.9);
            this.myStore.AddSong(s);
            s = new Song("Lose Yourself", "Eminem", 2003, 3);
            this.myStore.AddSong(s);
            s = new Song("Nothing Else Matters", "Metallica", 1991, 5.25);
            this.myStore.AddSong(s);
            s = new Song("Redemption Song", "Bob Marley", 1980, 2.2);
            this.myStore.AddSong(s);
            s = new Song("Yesterday", "The Beatles", 1965, 5);
            this.myStore.AddSong(s);
            ShowSongs();
            labelInfo.Text = "Test data added";
        }
     }
}
