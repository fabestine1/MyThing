using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxStore
{
    class LLOfPlayedSongs
    {
        private Node first;
        private Node last;
        public LLOfPlayedSongs()
        {
            first = last = null;
        }
        public int NrOfCreditsPerArtist(string artistName)
        {
            int counter = 0;
            Node current = first;
            while (current != null)
            {
                if(current.Song.Artist == artistName) counter++;
                current = current.Next;
            }
            return counter;
        }
        public void RegisterPlayed(Song s)
        {
            Node newNode = new Node(s);
            if(first == null) first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
    }
}
