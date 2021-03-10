using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._3
{
    public partial class Form1 : Form
    {
        private void NewGame()
        {
            numberPlayers = 0;
            firstPlayerPoints = 0;
            secondPlayerPoints = 0;
            thirdPlayerPoints = 0;

            this.lbFirstPlayerPoints.Text = firstPlayerPoints.ToString();
            this.lbSecondPlayerPoints.Text = secondPlayerPoints.ToString();
            this.lbThirdPlayerPoints.Text = thirdPlayerPoints.ToString();

            cards = new List<Card>()
            {
                AceOfSpades,
                KindOfSpades,
                QueenOfSpades,
                JackOfSpades ,
                TenOfSpades ,
                AceOfClubs ,
                KingOfClubs,
                QueenOfClubs,
                JackOfClubs ,
                TenOfClubs ,
                AceOfDiamonds,
                KingOfDiamonds,
                QueenOfDiamonds,
                JackOfDiamonds,
                TenOfDiamonds ,
                AceOfHearts,
                KingOfHearts ,
                QueenOfHearts,
                JackOfHearts ,
                TenOfHearts
            };
            int counterValue = 0, counterSuit = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                if (counterValue > 4)
                {
                    counterValue = 0;
                    counterSuit++;
                }

                cards[i].Value = (Value)counterValue;
                cards[i].Suit = (Suit)counterSuit;

                counterValue++;
            }

            UpdateGUI(numberPlayers);
        }

        private void UpdateGUI(int numberPlayers)
        {
            if(numberPlayers == 0)
            {
                this.pnStart.Enabled = true;

                this.btnRestart.Visible = false;
                this.lsbCards.Visible = false;
                this.gbFirstPlayer.Visible = false;
                this.gbSecondPlayer.Visible = false;
                this.gbThirdPlayer.Visible = false;

                this.Size = new Size(493, 125);
            }
            else if (numberPlayers == 2)
            {
                this.btnRestart.Visible = true;
                this.lsbCards.Visible = true;
                this.gbFirstPlayer.Visible = true;
                this.gbSecondPlayer.Visible = true;

                this.gbThirdPlayer.Visible = false;

                this.pnStart.Enabled = false;

                this.btnSecondPlayerDraw.Enabled = false;

                this.Size = new Size(606, 337);
                this.lsbCards.Size = new Size(185, 196);
            }
            else if (numberPlayers == 3)
            {
                this.btnRestart.Visible = true;
                this.lsbCards.Visible = true;
                this.gbFirstPlayer.Visible = true;
                this.gbSecondPlayer.Visible = true;
                this.gbThirdPlayer.Visible = true;

                this.pnStart.Enabled = false;

                this.btnSecondPlayerDraw.Enabled = false;
                this.btnThirdPlayerDraw.Enabled = false;

                this.Size = new Size(606, 438);
                this.lsbCards.Size = new Size(185, 292);
            }
        }

        private void UpdateListBox()
        {
            this.lsbCards.Items.Clear();

            for (int i = 0; i < cards.Count; i++)
            {
                this.lsbCards.Items.Add(cards[i].ToString());
            }
        }

        Random rnd = new Random();
        int firstPlayerPoints = 0, secondPlayerPoints = 0, thirdPlayerPoints = 0, numberPlayers = 0;
        Card firstPlayerCard = new Card();
        Card secondPlayerCard = new Card();
        Card thirdPlayerCard = new Card();

        List<Card> cards;
        Card AceOfSpades = new Card();
        Card KindOfSpades = new Card();
        Card QueenOfSpades = new Card();
        Card JackOfSpades = new Card();
        Card TenOfSpades = new Card();
        Card AceOfClubs = new Card();
        Card KingOfClubs = new Card();
        Card QueenOfClubs = new Card();
        Card JackOfClubs = new Card();
        Card TenOfClubs = new Card();
        Card AceOfDiamonds = new Card();
        Card KingOfDiamonds = new Card();
        Card QueenOfDiamonds = new Card();
        Card JackOfDiamonds = new Card();
        Card TenOfDiamonds = new Card();
        Card AceOfHearts = new Card();
        Card KingOfHearts = new Card();
        Card QueenOfHearts = new Card();
        Card JackOfHearts = new Card();
        Card TenOfHearts = new Card();

        public Form1()
        {
            InitializeComponent();

            NewGame();
            
            UpdateGUI(numberPlayers);
        }

        private void btnFirstPlayerDraw_Click(object sender, EventArgs e)
        {
            this.btnSecondPlayerDraw.Enabled = true;

            firstPlayerCard = cards[rnd.Next(cards.Count)];

            cards.Remove(firstPlayerCard);

            UpdateListBox();

            this.tbFirstPlayerCard.Text = firstPlayerCard.ToString();
        }

        private void btnSecondPlayerDraw_Click(object sender, EventArgs e)
        {
            secondPlayerCard = cards[rnd.Next(cards.Count)];

            cards.Remove(secondPlayerCard);

            UpdateListBox();

            this.tbSecondPlayerCard.Text = secondPlayerCard.ToString();

            if(numberPlayers == 2)
            {
                int checker = Card.CompareCards(firstPlayerCard, secondPlayerCard);
                if(checker == -1)
                {
                    secondPlayerPoints++;

                    this.lbSecondPlayerPoints.Text = secondPlayerPoints.ToString();
                }
                else if(checker == 1)
                {
                    firstPlayerPoints++;

                    this.lbFirstPlayerPoints.Text = firstPlayerPoints.ToString();
                }

                this.tmNewRound.Enabled = true;

                if(cards.Count < 2)
                {
                    MessageBox.Show("No cards left, game is restarting");

                    NewGame();

                    UpdateGUI(numberPlayers);
                }
            }
            if(numberPlayers == 3)
            {
                this.btnThirdPlayerDraw.Enabled = true;
            }
        }

        private void btnThirdPlayerDraw_Click(object sender, EventArgs e)
        {
            thirdPlayerCard = cards[rnd.Next(cards.Count)];

            cards.Remove(thirdPlayerCard);

            UpdateListBox();

            this.tbThirdPlayerCard.Text = thirdPlayerCard.ToString();

            int checker = Card.CompareCards(firstPlayerCard, secondPlayerCard, thirdPlayerCard);

            if(checker == 1)
            {
                firstPlayerPoints++;

                this.lbFirstPlayerPoints.Text = firstPlayerPoints.ToString();
            }
            else if(checker == 2)
            {
                secondPlayerPoints++;

                this.lbSecondPlayerPoints.Text = secondPlayerPoints.ToString();
            }
            else if(checker == 3)
            {
                thirdPlayerPoints++;

                this.lbThirdPlayerPoints.Text = thirdPlayerPoints.ToString();
            }

            this.tmNewRound.Enabled = true;

            if(cards.Count < 3)
            {
                MessageBox.Show("No cards left, game is restarting");

                NewGame();

                UpdateGUI(numberPlayers);
            }
        }

        private void tmNewRound_Tick(object sender, EventArgs e)
        {
            this.tbFirstPlayerCard.Clear();
            this.tbSecondPlayerCard.Clear();
            this.tbThirdPlayerCard.Clear();

            this.tmNewRound.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            NewGame();

            UpdateGUI(numberPlayers);
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(this.cbPlayers.Text, out numberPlayers))
            {
                numberPlayers = int.Parse(this.cbPlayers.Text);

                UpdateGUI(numberPlayers);

                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Chose number of players");
            }
        }      
    }
}
