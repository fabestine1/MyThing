namespace JukeBoxStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LLOfPlayedSongs
    {
        private Node first;
        private Node last;
        private int itemCounter;

        public LLOfPlayedSongs()
        {
            this.first = null;
            this.itemCounter = 0;
        }

        public void RegisterPlayed(Song s)
        {
            if (first == null)
            {
                Node temp = new Node(s);
                first = temp;
                last = temp;
                itemCounter++;
            }
            else
            {
                //add at the start of the list

                Node temp = new Node(s);
                temp.setNext(first);
                first = temp;

                //add at the end of the list

                //Node temp = new Node(s);
                //last.setNext(temp);
                //last = temp;

                itemCounter++;
            }
        }

        public int NrOfCreditsPerArtist(string artistName)
        {
            if (this.first == null)
                return 0;
            else
            {
                Node curr = this.first;
                int counter = 0;
                while (curr != null)
                {
                    if (curr.getItem().Artist.Equals(artistName))
                    {
                        counter++;
                    }
                    curr = curr.getNext();
                }
                return counter;
            }
        }
    }
}
