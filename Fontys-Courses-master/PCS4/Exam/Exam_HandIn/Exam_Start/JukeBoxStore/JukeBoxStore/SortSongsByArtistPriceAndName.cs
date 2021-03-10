using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxStore
{
    class SortSongsByArtistPriceAndName : IComparer<Song>
    {
        public int Compare(Song a, Song b)
        {
            int artistDifference = a.Artist.CompareTo(b.Artist);
            if(artistDifference == 0)
            {
                int priceDifference = b.Price.CompareTo(a.Price);
                if (priceDifference == 0) return a.Name.CompareTo(b.Name);
                return priceDifference;
            }
            return artistDifference;
        }
    }
}
