using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxStore
{
    class JukeboxStore
    {
        private string name;        // the name of this store
        private List<Song> mySongs;  // the list of songs available (added) for sale in this store
        public delegate void AddSongHandler(Song s, string reason);
        public event AddSongHandler AddedSong;

        public string Name { get { return name; } }

        public JukeboxStore(string name)
        {
            this.name = name;
            this.mySongs = new List<Song>();
        }
        public void SortByYear()
        {
            // todo: assignment 1a
            mySongs.Sort();
        }

        public void SortByArtistPriceAndName()
        {
            // todo: assignment 1b
            mySongs.Sort(new SortSongsByArtistPriceAndName());
        }

        public List<Song> GetAllSongs()
        {
            return this.mySongs;
        }

        public void AddSong(Song s)
        {
            this.mySongs.Add(s);
            if(s.Artist == "The Beatles")
            {
                if (AddedSong != null) AddedSong(s, "been added");
            }
        }

        private double GetBeatlesSongs(int n) // Additional method added by: Nikolay Nikolaev
        {
            if (n == 0) return 9999;
            if (mySongs[n - 1].Artist == "The Beatles")
            {
                double priceOfRest = GetBeatlesSongs(n - 1);
                if (mySongs[n -1].Price < priceOfRest) return mySongs[n - 1].Price;
                return GetBeatlesSongs(n - 1);
            }
            return GetBeatlesSongs(n - 1);
        }

        public double GetCheapestBeatlesSong()
        {
            // todo: assignment 3
            return GetBeatlesSongs(mySongs.Count);
        }

    }
}
