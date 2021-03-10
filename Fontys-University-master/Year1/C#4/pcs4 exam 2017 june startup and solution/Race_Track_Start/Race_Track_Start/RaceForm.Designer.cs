namespace Race_Track_Solution
{
    partial class RaceForm
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
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmrAnimate = new System.Windows.Forms.Timer(this.components);
            this.btnAgeHobbySort = new System.Windows.Forms.Button();
            this.btnNameSort = new System.Windows.Forms.Button();
            this.btnYoungest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Location = new System.Drawing.Point(12, 12);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(500, 300);
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            this.pbRaceTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRaceTrack_Paint);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Info;
            this.btnStart.Location = new System.Drawing.Point(12, 346);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Info;
            this.btnReset.Location = new System.Drawing.Point(12, 375);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStatistics.Location = new System.Drawing.Point(12, 404);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(75, 23);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Display stats";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(228, 346);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(284, 82);
            this.lbInfo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result:";
            // 
            // tmrAnimate
            // 
            this.tmrAnimate.Interval = 200;
            this.tmrAnimate.Tick += new System.EventHandler(this.TmrAnimate_Tick);
            // 
            // btnAgeHobbySort
            // 
            this.btnAgeHobbySort.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgeHobbySort.Location = new System.Drawing.Point(93, 375);
            this.btnAgeHobbySort.Name = "btnAgeHobbySort";
            this.btnAgeHobbySort.Size = new System.Drawing.Size(129, 23);
            this.btnAgeHobbySort.TabIndex = 11;
            this.btnAgeHobbySort.Text = "Sort by Age then Hobby";
            this.btnAgeHobbySort.UseVisualStyleBackColor = false;
            this.btnAgeHobbySort.Click += new System.EventHandler(this.btnAgeHobbySort_Click);
            // 
            // btnNameSort
            // 
            this.btnNameSort.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNameSort.Location = new System.Drawing.Point(93, 346);
            this.btnNameSort.Name = "btnNameSort";
            this.btnNameSort.Size = new System.Drawing.Size(129, 23);
            this.btnNameSort.TabIndex = 12;
            this.btnNameSort.Text = "Sort by Name";
            this.btnNameSort.UseVisualStyleBackColor = false;
            this.btnNameSort.Click += new System.EventHandler(this.btnNameSort_Click);
            // 
            // btnYoungest
            // 
            this.btnYoungest.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnYoungest.Location = new System.Drawing.Point(93, 404);
            this.btnYoungest.Name = "btnYoungest";
            this.btnYoungest.Size = new System.Drawing.Size(129, 23);
            this.btnYoungest.TabIndex = 13;
            this.btnYoungest.Text = "Display youngest";
            this.btnYoungest.UseVisualStyleBackColor = false;
            this.btnYoungest.Click += new System.EventHandler(this.btnYoungest_Click);
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 440);
            this.Controls.Add(this.btnYoungest);
            this.Controls.Add(this.btnNameSort);
            this.Controls.Add(this.btnAgeHobbySort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbRaceTrack);
            this.MaximumSize = new System.Drawing.Size(540, 478);
            this.MinimumSize = new System.Drawing.Size(540, 478);
            this.Name = "RaceForm";
            this.Text = "My Race";
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.Button btnAgeHobbySort;
        private System.Windows.Forms.Button btnNameSort;
        private System.Windows.Forms.Button btnYoungest;
    }
}

