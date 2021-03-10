using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_6._3
{
    public partial class Form1 : Form
    {
        List<Card> cards;
        Random rnd;
        int card;
        Card cardA;
        Card cardB;
        Card cardC;
        int[] points = new int[3];
        public Form1()
        {
            InitializeComponent();
            cards = new List<Card>();
            for (int i = 0; i <= 3; i++)
            {
                for (int m = 0; m <= 4; m++)
                {
                    cards.Add(new Card((SuitsEnum)i, (ValueEnum)m));
                }
            }
            rnd = new Random();
        }

        private void btnSelectPlayerB_Click(object sender, EventArgs e)
        {
            if (cards.Count != 2)
            {
                card = rnd.Next(0, cards.Count);
                cardB = cards[card];
                tbxPlayerBCard.Text = cardB.ShowCard();
                cards.RemoveAt(card);
            }
        }

        private void btnSelectPlayerA_Click(object sender, EventArgs e)
        {
            if (cards.Count != 2)
            {
                card = rnd.Next(0, cards.Count);
                cardA = cards[card];
                tbxPlayerACard.Text = cardA.ShowCard();
                cards.RemoveAt(card);
            }
        }

        private void btnSelectPlayerC_Click(object sender, EventArgs e)
        {
            if (cards.Count != 2)
            {
                card = rnd.Next(0, cards.Count);
                cardC = cards[card];
                tbxPlayerCCard.Text = cardC.ShowCard();
                cards.RemoveAt(card);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (cards.Count == 2)
            {
                if(points[0] > points [1] && points[0] > points[2])
                {
                    MessageBox.Show("The winner is player A!");
                }
                else if(points[1] > points[0] && points[1] > points[2])
                {
                    MessageBox.Show("The winner is player B");
                }
                else if(points[2] > points[0] && points[2] > points[1]){
                    MessageBox.Show("The winner is player C");

                }
                else
                {
                    MessageBox.Show("There is no winner!");
                }
            }
            else
            {
                switch (Card.CompareCards(cardA, cardB, cardC))
                {
                    case 1:
                        points[0]++;
                        break;
                    case 2:
                        points[1]++;
                        break;
                    case 3:
                        points[2]++;
                        break;
                }
            }
        }
    }
}
