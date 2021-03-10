using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Week2_ExtraPractical
{
    public partial class Form1 : Form
    {
        Game game;
        bool moveLeft;
        bool moveRight;
        bool jump;
        bool notimer;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (game != null)
            {
                if (keyData == Keys.Right || keyData == Keys.D)
                {
                    game.Update(false, true, jump);
                    notimer = true;
                    return true;
                }
                else if (keyData == Keys.Left || keyData == Keys.A)
                {
                    game.Update(true, false, jump);
                    notimer = true;
                    return true;
                }
                else if (keyData == Keys.Up || keyData == Keys.W)
                {
                    jump = true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Color c = Color.Red;
            switch (colorComboBox.Text)
            {
                case "Red":
                    c = Color.Red;
                    break;
                case "Green":
                    c = Color.Green;
                    break;
                case "Blue":
                    c = Color.Blue;
                    break;
            }
            game = new Game(nameTextBox.Text, c, sizeComboBox.Text);
            actionsGroupBox.Enabled = true;
            logListBox.Items.Add("Game started");
            drawGraphics.Start();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            game.UpdateScore(10);
            logListBox.Items.Add("Score changed from " + (game.Score + 10) + " to " + game.Score);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.GetInfo());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
        }

        private void canvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (game != null)
            {
                //Call draw method of Game-object
                game.Draw(e.Graphics);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            canvasPictureBox.Refresh();
            logListBox.Items.Add("Game world has been repainted");
        }

        private void drawGraphics_Tick(object sender, EventArgs e)
        {
            canvasPictureBox.Refresh();
            if (notimer == false)
            {
                game.Update(moveLeft, moveRight, jump);
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            moveLeft = true;
            moveRight = false;
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            moveLeft = false;
            moveRight = true;
        }

        private void btnStill_Click(object sender, EventArgs e)
        {
            moveLeft = false;
            moveRight = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (game != null)
            {
                game.Update(false, false, jump);
                notimer = false;
            }
        }

        private void logListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            jump = true;
        }
    }
}
