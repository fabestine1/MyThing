namespace JukeBoxStore
{
    partial class JukeboxForm
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
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.grBAddSong = new System.Windows.Forms.GroupBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.btnSortArtistPriceAndName = new System.Windows.Forms.Button();
            this.grBCtrl = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbChangePrice = new System.Windows.Forms.GroupBox();
            this.tbNewPrice = new System.Windows.Forms.TextBox();
            this.btnFindCheapest = new System.Windows.Forms.Button();
            this.btnSortYear = new System.Windows.Forms.Button();
            this.btnNrOfCreditsPerArtist = new System.Windows.Forms.Button();
            this.gbTotalPlays = new System.Windows.Forms.GroupBox();
            this.labelArtistPlayec = new System.Windows.Forms.Label();
            this.tbArtistPlayed = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.grBAddSong.SuspendLayout();
            this.grBCtrl.SuspendLayout();
            this.gbChangePrice.SuspendLayout();
            this.gbTotalPlays.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.Aquamarine;
            this.btnChangePrice.Location = new System.Drawing.Point(55, 15);
            this.btnChangePrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(137, 37);
            this.btnChangePrice.TabIndex = 2;
            this.btnChangePrice.Text = "New Price";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.BtnChangePrice_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(309, 363);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelInfo.MinimumSize = new System.Drawing.Size(343, 16);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(343, 16);
            this.labelInfo.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(59, 24);
            this.tbName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(143, 23);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Blackbird";
            // 
            // grBAddSong
            // 
            this.grBAddSong.BackColor = System.Drawing.Color.LightGreen;
            this.grBAddSong.CausesValidation = false;
            this.grBAddSong.Controls.Add(this.btnAddSong);
            this.grBAddSong.Controls.Add(this.tbPrice);
            this.grBAddSong.Controls.Add(this.tbYear);
            this.grBAddSong.Controls.Add(this.tbArtist);
            this.grBAddSong.Controls.Add(this.labelYear);
            this.grBAddSong.Controls.Add(this.tbName);
            this.grBAddSong.Controls.Add(this.labelPrice);
            this.grBAddSong.Controls.Add(this.labelArtist);
            this.grBAddSong.Controls.Add(this.labelName);
            this.grBAddSong.Location = new System.Drawing.Point(14, 81);
            this.grBAddSong.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grBAddSong.Name = "grBAddSong";
            this.grBAddSong.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grBAddSong.Size = new System.Drawing.Size(208, 162);
            this.grBAddSong.TabIndex = 0;
            this.grBAddSong.TabStop = false;
            this.grBAddSong.Text = "Add Song";
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddSong.Location = new System.Drawing.Point(13, 121);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(187, 31);
            this.btnAddSong.TabIndex = 5;
            this.btnAddSong.Text = "Add Song to Store";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.BtnAddSong_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(59, 88);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(143, 23);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.Text = "7";
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.Location = new System.Drawing.Point(59, 67);
            this.tbYear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(143, 23);
            this.tbYear.TabIndex = 2;
            this.tbYear.Text = "1968";
            // 
            // tbArtist
            // 
            this.tbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtist.Location = new System.Drawing.Point(59, 45);
            this.tbArtist.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(143, 23);
            this.tbArtist.TabIndex = 1;
            this.tbArtist.Text = "The Beatles";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(17, 68);
            this.labelYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(38, 17);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Year";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(14, 89);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(14, 47);
            this.labelArtist.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(40, 17);
            this.labelArtist.TabIndex = 1;
            this.labelArtist.Text = "Artist";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(10, 26);
            this.labelName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(7, 15);
            this.lbSongs.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(406, 264);
            this.lbSongs.TabIndex = 0;
            // 
            // btnSortArtistPriceAndName
            // 
            this.btnSortArtistPriceAndName.BackColor = System.Drawing.Color.Tomato;
            this.btnSortArtistPriceAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortArtistPriceAndName.Location = new System.Drawing.Point(105, 15);
            this.btnSortArtistPriceAndName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSortArtistPriceAndName.Name = "btnSortArtistPriceAndName";
            this.btnSortArtistPriceAndName.Size = new System.Drawing.Size(96, 38);
            this.btnSortArtistPriceAndName.TabIndex = 3;
            this.btnSortArtistPriceAndName.Text = "Sort by Artist, Price and Name";
            this.btnSortArtistPriceAndName.UseVisualStyleBackColor = false;
            this.btnSortArtistPriceAndName.Click += new System.EventHandler(this.BtnSortArtistPriceAndName_Click);
            // 
            // grBCtrl
            // 
            this.grBCtrl.BackColor = System.Drawing.Color.Plum;
            this.grBCtrl.Controls.Add(this.btnPlay);
            this.grBCtrl.Controls.Add(this.lbSongs);
            this.grBCtrl.Controls.Add(this.gbChangePrice);
            this.grBCtrl.Location = new System.Drawing.Point(230, 15);
            this.grBCtrl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grBCtrl.Name = "grBCtrl";
            this.grBCtrl.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grBCtrl.Size = new System.Drawing.Size(422, 344);
            this.grBCtrl.TabIndex = 1;
            this.grBCtrl.TabStop = false;
            this.grBCtrl.Text = "Song List";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPlay.Location = new System.Drawing.Point(275, 296);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(137, 37);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // gbChangePrice
            // 
            this.gbChangePrice.Controls.Add(this.tbNewPrice);
            this.gbChangePrice.Controls.Add(this.btnChangePrice);
            this.gbChangePrice.Location = new System.Drawing.Point(7, 281);
            this.gbChangePrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbChangePrice.Name = "gbChangePrice";
            this.gbChangePrice.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbChangePrice.Size = new System.Drawing.Size(198, 61);
            this.gbChangePrice.TabIndex = 4;
            this.gbChangePrice.TabStop = false;
            this.gbChangePrice.Text = "Change Price";
            // 
            // tbNewPrice
            // 
            this.tbNewPrice.Location = new System.Drawing.Point(7, 24);
            this.tbNewPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbNewPrice.Name = "tbNewPrice";
            this.tbNewPrice.Size = new System.Drawing.Size(43, 20);
            this.tbNewPrice.TabIndex = 3;
            // 
            // btnFindCheapest
            // 
            this.btnFindCheapest.BackColor = System.Drawing.Color.Khaki;
            this.btnFindCheapest.Location = new System.Drawing.Point(27, 251);
            this.btnFindCheapest.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnFindCheapest.Name = "btnFindCheapest";
            this.btnFindCheapest.Size = new System.Drawing.Size(187, 30);
            this.btnFindCheapest.TabIndex = 5;
            this.btnFindCheapest.Text = "Find Cheapest Beatles Song";
            this.btnFindCheapest.UseVisualStyleBackColor = false;
            this.btnFindCheapest.Click += new System.EventHandler(this.BtnFindCheapestBeatlesSong_Click);
            // 
            // btnSortYear
            // 
            this.btnSortYear.BackColor = System.Drawing.Color.Tomato;
            this.btnSortYear.Location = new System.Drawing.Point(7, 15);
            this.btnSortYear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSortYear.Name = "btnSortYear";
            this.btnSortYear.Size = new System.Drawing.Size(96, 38);
            this.btnSortYear.TabIndex = 5;
            this.btnSortYear.Text = "Sort by Year";
            this.btnSortYear.UseVisualStyleBackColor = false;
            this.btnSortYear.Click += new System.EventHandler(this.BtnSortYear_Click);
            // 
            // btnNrOfCreditsPerArtist
            // 
            this.btnNrOfCreditsPerArtist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNrOfCreditsPerArtist.Location = new System.Drawing.Point(13, 48);
            this.btnNrOfCreditsPerArtist.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnNrOfCreditsPerArtist.Name = "btnNrOfCreditsPerArtist";
            this.btnNrOfCreditsPerArtist.Size = new System.Drawing.Size(187, 30);
            this.btnNrOfCreditsPerArtist.TabIndex = 6;
            this.btnNrOfCreditsPerArtist.Text = "Nr of credits per Artist";
            this.btnNrOfCreditsPerArtist.UseVisualStyleBackColor = false;
            this.btnNrOfCreditsPerArtist.Click += new System.EventHandler(this.BtnNrOfCreditsPerArtist_Click);
            // 
            // gbTotalPlays
            // 
            this.gbTotalPlays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbTotalPlays.Controls.Add(this.labelArtistPlayec);
            this.gbTotalPlays.Controls.Add(this.tbArtistPlayed);
            this.gbTotalPlays.Controls.Add(this.btnNrOfCreditsPerArtist);
            this.gbTotalPlays.Location = new System.Drawing.Point(14, 290);
            this.gbTotalPlays.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbTotalPlays.Name = "gbTotalPlays";
            this.gbTotalPlays.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbTotalPlays.Size = new System.Drawing.Size(208, 88);
            this.gbTotalPlays.TabIndex = 7;
            this.gbTotalPlays.TabStop = false;
            this.gbTotalPlays.Text = "Nr of plays per artist";
            // 
            // labelArtistPlayec
            // 
            this.labelArtistPlayec.AutoSize = true;
            this.labelArtistPlayec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistPlayec.Location = new System.Drawing.Point(10, 20);
            this.labelArtistPlayec.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelArtistPlayec.Name = "labelArtistPlayec";
            this.labelArtistPlayec.Size = new System.Drawing.Size(85, 17);
            this.labelArtistPlayec.TabIndex = 8;
            this.labelArtistPlayec.Text = "Artist / Band";
            // 
            // tbArtistPlayed
            // 
            this.tbArtistPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistPlayed.Location = new System.Drawing.Point(97, 18);
            this.tbArtistPlayed.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbArtistPlayed.Name = "tbArtistPlayed";
            this.tbArtistPlayed.Size = new System.Drawing.Size(105, 23);
            this.tbArtistPlayed.TabIndex = 7;
            // 
            // gbSort
            // 
            this.gbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbSort.Controls.Add(this.btnSortYear);
            this.gbSort.Controls.Add(this.btnSortArtistPriceAndName);
            this.gbSort.Location = new System.Drawing.Point(14, 15);
            this.gbSort.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbSort.Name = "gbSort";
            this.gbSort.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gbSort.Size = new System.Drawing.Size(208, 61);
            this.gbSort.TabIndex = 6;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sort";
            // 
            // JukeboxForm
            // 
            this.AcceptButton = this.btnAddSong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 458);
            this.Controls.Add(this.gbTotalPlays);
            this.Controls.Add(this.btnFindCheapest);
            this.Controls.Add(this.grBCtrl);
            this.Controls.Add(this.grBAddSong);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.gbSort);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(866, 694);
            this.MinimumSize = new System.Drawing.Size(594, 347);
            this.Name = "JukeboxForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jukebox Store";
            this.grBAddSong.ResumeLayout(false);
            this.grBAddSong.PerformLayout();
            this.grBCtrl.ResumeLayout(false);
            this.gbChangePrice.ResumeLayout(false);
            this.gbChangePrice.PerformLayout();
            this.gbTotalPlays.ResumeLayout(false);
            this.gbTotalPlays.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox grBAddSong;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Button btnSortArtistPriceAndName;
        private System.Windows.Forms.GroupBox grBCtrl;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gbChangePrice;
        private System.Windows.Forms.TextBox tbNewPrice;
        private System.Windows.Forms.Button btnFindCheapest;
        private System.Windows.Forms.Button btnSortYear;
        private System.Windows.Forms.Button btnNrOfCreditsPerArtist;
        private System.Windows.Forms.GroupBox gbTotalPlays;
        private System.Windows.Forms.Label labelArtistPlayec;
        private System.Windows.Forms.TextBox tbArtistPlayed;
        private System.Windows.Forms.GroupBox gbSort;
    }
}

