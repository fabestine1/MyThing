using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    public class Card
    {
        public Value Value { get; set; }
        public Suit Suit { get; set; }

        public static int CompareCards(Card firstPlayer, Card secondPlayer)
        {
            if((int)firstPlayer.Value > (int)secondPlayer.Value)
            {
                return 1;
            }
            else if((int)firstPlayer.Value == (int)secondPlayer.Value)
            {
                if((int)firstPlayer.Suit > (int)secondPlayer.Suit)
                {
                    return 1;
                }
            }

            return -1;
        }

        public static int CompareCards(Card firstPlayer, Card secondPlayer, Card thirdPlayer)
        {
            if(CompareCards(firstPlayer, secondPlayer) == 1)
            {
                if(CompareCards(firstPlayer, thirdPlayer) == 1)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                if (CompareCards(secondPlayer, thirdPlayer) == 1)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }


        public override string ToString()
        {
            return this.Value.ToString() + " of " + Suit.ToString(); 
        }
    }
}
