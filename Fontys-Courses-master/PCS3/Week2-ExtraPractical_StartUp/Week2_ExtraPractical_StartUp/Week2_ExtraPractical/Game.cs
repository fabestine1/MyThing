using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Week2_ExtraPractical
{
    class Game
    {
        private int score;
        private GameCharacter player;
        private GameCharacter enemy1;
        private GameCharacter enemy2;
        private GameCharacter enemy3;

        private Brush playerBrush;
        private Brush enemy1Brush;
        private Brush enemy2Brush;
        private Brush enemy3Brush;
        private Brush gameWorldBrush;

        private Font scoreFont;
        public int Score
        {
            get {
                return score;
            }
            private set
            {
                if(value < 0)
                {
                    score = 0;
                }
                else
                {
                    score = value;
                }
            }
        }
        public Game(string playerName, Color playerColor, string playerSize)
        {
            score = 100;
            player = new GameCharacter(playerName, playerColor, playerSize, 300, 136, 5);
            enemy1 = new GameCharacter("Enemy 1", Color.Red, "Small", 200, 136, 1);
            enemy2 = new GameCharacter("Enemy 2", Color.Red, "Small", 100, 136, 2);
            enemy3 = new GameCharacter("Enemy 3", Color.Red, "Small", 400, 136, 5);
            playerBrush = new SolidBrush(player.Color);
            enemy1Brush = new SolidBrush(enemy1.Color);
            enemy2Brush = new SolidBrush(enemy2.Color);
            enemy3Brush = new SolidBrush(enemy3.Color);
            gameWorldBrush = new SolidBrush(Color.Gray);
            scoreFont = new Font("Arial", 16);
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(gameWorldBrush, 0, 136, 665, 150);
            player.Draw(g, playerBrush);
            enemy1.Draw(g, enemy1Brush);
            enemy2.Draw(g, enemy2Brush);
            enemy3.Draw(g, enemy3Brush);
            g.DrawString("Score: " + Score, scoreFont, Brushes.Black, 500, 0);
        }
        public void UpdateScore(int amount)
        {
            score -= amount;
        }
        public string GetInfo()
        {
            return "The score is " + Score + "\nInhabitants:\n" + player.Name + " is " + player.Width + " x " + player.Height + "px and located @ " + player.X + "," + player.Y + "\n" + enemy1.Name + " is " + enemy1.Width + " x " + enemy1.Height + "px and located @ " + enemy1.X + "," + enemy2.Y + "\n" + enemy2.Name + " is " + enemy2.Width + " x " + enemy2.Height + "px and located @ " + enemy2.X + "," + enemy2.Y + "\n" + enemy3.Name + " is " + enemy3.Width + " x " + enemy3.Height + "px and located @ " + enemy3.X + "," + enemy3.Y;
        }
        public void Update(bool leftMovement, bool rightMovement, bool jump)
        {
            enemy1.UpdateAI();
            enemy2.UpdateAI();
            enemy3.UpdateAI();
            player.Update(leftMovement, rightMovement, jump);
        }
}
}
