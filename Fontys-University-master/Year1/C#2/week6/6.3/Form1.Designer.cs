namespace _6._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbFirstPlayerCard = new System.Windows.Forms.TextBox();
            this.lsbCards = new System.Windows.Forms.ListBox();
            this.lbPlayers = new System.Windows.Forms.Label();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.btnFirstPlayerDraw = new System.Windows.Forms.Button();
            this.lbFirstPlayerPoints = new System.Windows.Forms.Label();
            this.gbFirstPlayer = new System.Windows.Forms.GroupBox();
            this.gbSecondPlayer = new System.Windows.Forms.GroupBox();
            this.lbSecondPlayerPoints = new System.Windows.Forms.Label();
            this.tbSecondPlayerCard = new System.Windows.Forms.TextBox();
            this.btnSecondPlayerDraw = new System.Windows.Forms.Button();
            this.gbThirdPlayer = new System.Windows.Forms.GroupBox();
            this.lbThirdPlayerPoints = new System.Windows.Forms.Label();
            this.tbThirdPlayerCard = new System.Windows.Forms.TextBox();
            this.btnThirdPlayerDraw = new System.Windows.Forms.Button();
            this.pnStart = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tmNewRound = new System.Windows.Forms.Timer(this.components);
            this.gbFirstPlayer.SuspendLayout();
            this.gbSecondPlayer.SuspendLayout();
            this.gbThirdPlayer.SuspendLayout();
            this.pnStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // tbFirstPlayerCard
            // 
            this.tbFirstPlayerCard.ForeColor = System.Drawing.Color.Crimson;
            this.tbFirstPlayerCard.Location = new System.Drawing.Point(9, 55);
            this.tbFirstPlayerCard.Name = "tbFirstPlayerCard";
            this.tbFirstPlayerCard.Size = new System.Drawing.Size(147, 22);
            this.tbFirstPlayerCard.TabIndex = 1;
            // 
            // lsbCards
            // 
            this.lsbCards.ForeColor = System.Drawing.Color.DarkGreen;
            this.lsbCards.FormattingEnabled = true;
            this.lsbCards.ItemHeight = 16;
            this.lsbCards.Location = new System.Drawing.Point(42, 92);
            this.lsbCards.Name = "lsbCards";
            this.lsbCards.Size = new System.Drawing.Size(185, 292);
            this.lsbCards.TabIndex = 2;
            // 
            // lbPlayers
            // 
            this.lbPlayers.AutoSize = true;
            this.lbPlayers.Location = new System.Drawing.Point(11, 22);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(140, 16);
            this.lbPlayers.TabIndex = 3;
            this.lbPlayers.Text = "Number of Players:";
            // 
            // cbPlayers
            // 
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbPlayers.Location = new System.Drawing.Point(180, 19);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(121, 24);
            this.cbPlayers.TabIndex = 4;
            // 
            // btnFirstPlayerDraw
            // 
            this.btnFirstPlayerDraw.Location = new System.Drawing.Point(162, 50);
            this.btnFirstPlayerDraw.Name = "btnFirstPlayerDraw";
            this.btnFirstPlayerDraw.Size = new System.Drawing.Size(97, 32);
            this.btnFirstPlayerDraw.TabIndex = 6;
            this.btnFirstPlayerDraw.Text = "Draw Card";
            this.btnFirstPlayerDraw.UseVisualStyleBackColor = true;
            this.btnFirstPlayerDraw.Click += new System.EventHandler(this.btnFirstPlayerDraw_Click);
            // 
            // lbFirstPlayerPoints
            // 
            this.lbFirstPlayerPoints.AutoSize = true;
            this.lbFirstPlayerPoints.Location = new System.Drawing.Point(6, 27);
            this.lbFirstPlayerPoints.Name = "lbFirstPlayerPoints";
            this.lbFirstPlayerPoints.Size = new System.Drawing.Size(62, 16);
            this.lbFirstPlayerPoints.TabIndex = 7;
            this.lbFirstPlayerPoints.Text = "0 points";
            // 
            // gbFirstPlayer
            // 
            this.gbFirstPlayer.BackColor = System.Drawing.Color.Yellow;
            this.gbFirstPlayer.Controls.Add(this.lbFirstPlayerPoints);
            this.gbFirstPlayer.Controls.Add(this.tbFirstPlayerCard);
            this.gbFirstPlayer.Controls.Add(this.btnFirstPlayerDraw);
            this.gbFirstPlayer.ForeColor = System.Drawing.Color.Crimson;
            this.gbFirstPlayer.Location = new System.Drawing.Point(267, 92);
            this.gbFirstPlayer.Name = "gbFirstPlayer";
            this.gbFirstPlayer.Size = new System.Drawing.Size(271, 91);
            this.gbFirstPlayer.TabIndex = 16;
            this.gbFirstPlayer.TabStop = false;
            this.gbFirstPlayer.Text = "First Player:";
            // 
            // gbSecondPlayer
            // 
            this.gbSecondPlayer.BackColor = System.Drawing.Color.Cyan;
            this.gbSecondPlayer.Controls.Add(this.lbSecondPlayerPoints);
            this.gbSecondPlayer.Controls.Add(this.tbSecondPlayerCard);
            this.gbSecondPlayer.Controls.Add(this.btnSecondPlayerDraw);
            this.gbSecondPlayer.ForeColor = System.Drawing.Color.Navy;
            this.gbSecondPlayer.Location = new System.Drawing.Point(267, 189);
            this.gbSecondPlayer.Name = "gbSecondPlayer";
            this.gbSecondPlayer.Size = new System.Drawing.Size(271, 91);
            this.gbSecondPlayer.TabIndex = 17;
            this.gbSecondPlayer.TabStop = false;
            this.gbSecondPlayer.Text = "Second Player:";
            // 
            // lbSecondPlayerPoints
            // 
            this.lbSecondPlayerPoints.AutoSize = true;
            this.lbSecondPlayerPoints.Location = new System.Drawing.Point(6, 27);
            this.lbSecondPlayerPoints.Name = "lbSecondPlayerPoints";
            this.lbSecondPlayerPoints.Size = new System.Drawing.Size(62, 16);
            this.lbSecondPlayerPoints.TabIndex = 7;
            this.lbSecondPlayerPoints.Text = "0 points";
            // 
            // tbSecondPlayerCard
            // 
            this.tbSecondPlayerCard.ForeColor = System.Drawing.Color.Navy;
            this.tbSecondPlayerCard.Location = new System.Drawing.Point(9, 55);
            this.tbSecondPlayerCard.Name = "tbSecondPlayerCard";
            this.tbSecondPlayerCard.Size = new System.Drawing.Size(147, 22);
            this.tbSecondPlayerCard.TabIndex = 1;
            // 
            // btnSecondPlayerDraw
            // 
            this.btnSecondPlayerDraw.Location = new System.Drawing.Point(162, 50);
            this.btnSecondPlayerDraw.Name = "btnSecondPlayerDraw";
            this.btnSecondPlayerDraw.Size = new System.Drawing.Size(97, 32);
            this.btnSecondPlayerDraw.TabIndex = 6;
            this.btnSecondPlayerDraw.Text = "Draw Card";
            this.btnSecondPlayerDraw.UseVisualStyleBackColor = true;
            this.btnSecondPlayerDraw.Click += new System.EventHandler(this.btnSecondPlayerDraw_Click);
            // 
            // gbThirdPlayer
            // 
            this.gbThirdPlayer.BackColor = System.Drawing.Color.Lime;
            this.gbThirdPlayer.Controls.Add(this.lbThirdPlayerPoints);
            this.gbThirdPlayer.Controls.Add(this.tbThirdPlayerCard);
            this.gbThirdPlayer.Controls.Add(this.btnThirdPlayerDraw);
            this.gbThirdPlayer.ForeColor = System.Drawing.Color.Purple;
            this.gbThirdPlayer.Location = new System.Drawing.Point(267, 286);
            this.gbThirdPlayer.Name = "gbThirdPlayer";
            this.gbThirdPlayer.Size = new System.Drawing.Size(271, 91);
            this.gbThirdPlayer.TabIndex = 17;
            this.gbThirdPlayer.TabStop = false;
            this.gbThirdPlayer.Text = "Third Player:";
            // 
            // lbThirdPlayerPoints
            // 
            this.lbThirdPlayerPoints.AutoSize = true;
            this.lbThirdPlayerPoints.Location = new System.Drawing.Point(6, 27);
            this.lbThirdPlayerPoints.Name = "lbThirdPlayerPoints";
            this.lbThirdPlayerPoints.Size = new System.Drawing.Size(62, 16);
            this.lbThirdPlayerPoints.TabIndex = 7;
            this.lbThirdPlayerPoints.Text = "0 points";
            // 
            // tbThirdPlayerCard
            // 
            this.tbThirdPlayerCard.ForeColor = System.Drawing.Color.Purple;
            this.tbThirdPlayerCard.Location = new System.Drawing.Point(9, 55);
            this.tbThirdPlayerCard.Name = "tbThirdPlayerCard";
            this.tbThirdPlayerCard.Size = new System.Drawing.Size(147, 22);
            this.tbThirdPlayerCard.TabIndex = 1;
            // 
            // btnThirdPlayerDraw
            // 
            this.btnThirdPlayerDraw.Location = new System.Drawing.Point(162, 50);
            this.btnThirdPlayerDraw.Name = "btnThirdPlayerDraw";
            this.btnThirdPlayerDraw.Size = new System.Drawing.Size(97, 32);
            this.btnThirdPlayerDraw.TabIndex = 6;
            this.btnThirdPlayerDraw.Text = "Draw Card";
            this.btnThirdPlayerDraw.UseVisualStyleBackColor = true;
            this.btnThirdPlayerDraw.Click += new System.EventHandler(this.btnThirdPlayerDraw_Click);
            // 
            // pnStart
            // 
            this.pnStart.Controls.Add(this.cbPlayers);
            this.pnStart.Controls.Add(this.lbPlayers);
            this.pnStart.Controls.Add(this.btnStart);
            this.pnStart.Location = new System.Drawing.Point(12, 12);
            this.pnStart.Name = "pnStart";
            this.pnStart.Size = new System.Drawing.Size(453, 62);
            this.pnStart.TabIndex = 18;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(476, 21);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(102, 42);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tmNewRound
            // 
            this.tmNewRound.Interval = 2000;
            this.tmNewRound.Tick += new System.EventHandler(this.tmNewRound_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(590, 399);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pnStart);
            this.Controls.Add(this.gbThirdPlayer);
            this.Controls.Add(this.gbSecondPlayer);
            this.Controls.Add(this.gbFirstPlayer);
            this.Controls.Add(this.lsbCards);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Card Game";
            this.gbFirstPlayer.ResumeLayout(false);
            this.gbFirstPlayer.PerformLayout();
            this.gbSecondPlayer.ResumeLayout(false);
            this.gbSecondPlayer.PerformLayout();
            this.gbThirdPlayer.ResumeLayout(false);
            this.gbThirdPlayer.PerformLayout();
            this.pnStart.ResumeLayout(false);
            this.pnStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbFirstPlayerCard;
        private System.Windows.Forms.ListBox lsbCards;
        private System.Windows.Forms.Label lbPlayers;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.Button btnFirstPlayerDraw;
        private System.Windows.Forms.Label lbFirstPlayerPoints;
        private System.Windows.Forms.GroupBox gbFirstPlayer;
        private System.Windows.Forms.GroupBox gbSecondPlayer;
        private System.Windows.Forms.Label lbSecondPlayerPoints;
        private System.Windows.Forms.TextBox tbSecondPlayerCard;
        private System.Windows.Forms.Button btnSecondPlayerDraw;
        private System.Windows.Forms.GroupBox gbThirdPlayer;
        private System.Windows.Forms.Label lbThirdPlayerPoints;
        private System.Windows.Forms.TextBox tbThirdPlayerCard;
        private System.Windows.Forms.Button btnThirdPlayerDraw;
        private System.Windows.Forms.Panel pnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer tmNewRound;
    }
}

