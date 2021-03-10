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
        private List<Song> onlySongsWithBeatles;

        public string Name { get { return name; } }

        public delegate void InterestingSongHandler(Song s, string reason);
        public event InterestingSongHandler processBeatles;
        public event InterestingSongHandler processBeatlesChange;


        public delegate void InterestingSongPromotionHandler(Song s);
        public event InterestingSongPromotionHandler processPromotion;

        public JukeboxStore(string name)
        {
            this.name = name;
            this.mySongs = new List<Song>();

            onlySongsWithBeatles = new List<Song>();
        }
        public void SortByYear()
        {
            // todo: assignment 1a
            this.mySongs.Sort();
        }

        public void SortByArtistPriceAndName()
        {
            // todo: assignment 1b
            this.mySongs.Sort(new Comparison<Song>(SortbyArtistPriceandName));
        }

        public int SortbyArtistPriceandName(Song first, Song second)
        {
            int artistDifference = first.Artist.CompareTo(second.Artist);
            if (artistDifference == 0)
            {
                int priceDifference = second.Price.CompareTo(first.Price);
                if (priceDifference == 0)
                {
                    // Artist and price are the same, so sort on name in descending order
                    return first.Name.CompareTo(second.Name);
                }
                else
                    return priceDifference; // Artist is the same, sort on price
            }
            else
                return artistDifference; // Sort on artist
        }

        public List<Song> GetAllSongs()
        {
            return this.mySongs;
        }

        public void AddSong(Song s)
        {
            this.mySongs.Add(s);

            this.NotifyListeners(s, "New car added for sale");
        }


        public void NotifyListeners(Song s, string reason)
        {
            // To do: assignment 2
            if (s.Artist.Equals("The Beatles"))
            {
                if (reason == "New car added for sale")
                {
                    if (processBeatles != null)
                    {
                        processBeatles(s, reason);
                    }
                }

                if (reason == "Price change")
                {
                    if (processBeatlesChange != null)
                    {
                        processBeatlesChange(s, reason);
                    }
                }
            }
            else if (s.Price <= 2 && reason == "Price change")
            {
                if (processPromotion != null)
                    processPromotion(s);
            }
        }

        public double GetCheapestBeatlesSong()
        {
            // todo: assignment 3
            if (this.mySongs.Count == 1)
            {
                return this.mySongs.ElementAt(0).Price;
            }
            else
            {
                foreach (var mySong in mySongs)
                {
                    if (mySong.Artist.Equals("The Beatles"))
                    {
                        onlySongsWithBeatles.Add(mySong);
                    }
                }
                double minPriceOfTheRest = something(onlySongsWithBeatles.Count);
                return minPriceOfTheRest;
            }
        }

        public double something(int n)
        {
            if (n == 1)
            {
                return this.onlySongsWithBeatles.ElementAt(0).Price;
            }
            else
            {
                double minPriceOfTheRest = something(n - 1);
                if (this.onlySongsWithBeatles.ElementAt(n - 1).Price < minPriceOfTheRest)
                    return this.onlySongsWithBeatles.ElementAt(n - 1).Price;
                else
                    return minPriceOfTheRest;
            }
        }

    }
}
