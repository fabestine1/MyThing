using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._3
{
    class Card
    {
        public SuitsEnum Suits { get; set; }
        public ValueEnum Values { get; set; }

        public Card(SuitsEnum nwSuit, ValueEnum nwValue)
        {
            Suits = nwSuit;
            Values = nwValue;
        }

        public string ShowCard()
        {
            return "Suit: " + Suits.ToString() + "\r\nValue: " + Values.ToString();
        }
        public static int CompareCards(Card card1, Card card2)
        {
            if ((int)card1.Values > (int)card2.Values)
            {
                return -1;
            }
            else if ((int)card2.Values > (int)card1.Values)
            {
                return 1;
            }
            else
            {
                if ((int)card1.Suits > (int)card2.Suits)
                {
                    return -1;
                }
                else if((int) card2.Suits > (int)card1.Suits)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static int CompareCards(Card card1, Card card2, Card card3)
        {
            if ((int)card1.Values > (int)card2.Values && (int)card1.Values > (int)card3.Values)
            {
                return 1;
            }
            else if ((int)card2.Values > (int)card1.Values && (int)card1.Values > (int)card3.Values)
            {
                return 2;
            }
            else if ((int)card3.Values > (int)card1.Values && (int)card1.Values > (int)card2.Values)
            {
                return 3;
            }
            else
            {
                if ((int)card1.Suits > (int)card2.Suits && (int)card1.Suits > (int)card3.Suits)
                {
                    return 1;
                }
                else if ((int)card2.Suits > (int)card1.Suits && (int)card1.Suits > (int)card3.Suits)
                {
                    return 2;
                }
                else if ((int)card3.Suits > (int)card1.Suits && (int)card1.Suits > (int)card2.Suits)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
