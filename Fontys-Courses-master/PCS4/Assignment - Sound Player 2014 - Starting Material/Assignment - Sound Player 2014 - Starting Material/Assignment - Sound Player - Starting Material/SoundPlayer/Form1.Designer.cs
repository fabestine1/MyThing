namespace SoundPlayer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAddFragment = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbFragmentNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.btShowPlaylist = new System.Windows.Forms.Button();
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.pbDuration = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.btAddFragment);
            this.groupBox1.Controls.Add(this.btBrowse);
            this.groupBox1.Controls.Add(this.tbFilename);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSeconds);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMinutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(328, 54);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAddFragment
            // 
            this.btAddFragment.Location = new System.Drawing.Point(18, 156);
            this.btAddFragment.Name = "btAddFragment";
            this.btAddFragment.Size = new System.Drawing.Size(135, 23);
            this.btAddFragment.TabIndex = 12;
            this.btAddFragment.Text = "Add fragment";
            this.btAddFragment.UseVisualStyleBackColor = true;
            this.btAddFragment.Click += new System.EventHandler(this.btAddFragment_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(328, 111);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 11;
            this.btBrowse.Text = "Browse ...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(76, 114);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(235, 20);
            this.tbFilename.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "File name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "sec";
            // 
            // tbSeconds
            // 
            this.tbSeconds.Location = new System.Drawing.Point(175, 85);
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.Size = new System.Drawing.Size(73, 20);
            this.tbSeconds.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "min";
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(67, 85);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(73, 20);
            this.tbMinutes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(67, 57);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(244, 20);
            this.tbTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(67, 27);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id-Nr:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.tbFragmentNr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btPlay);
            this.groupBox2.Location = new System.Drawing.Point(13, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(15, 57);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(44, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "<INFO>";
            // 
            // tbFragmentNr
            // 
            this.tbFragmentNr.Location = new System.Drawing.Point(173, 22);
            this.tbFragmentNr.Name = "tbFragmentNr";
            this.tbFragmentNr.Size = new System.Drawing.Size(75, 20);
            this.tbFragmentNr.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "fragment nr:";
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(18, 20);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.Location = new System.Drawing.Point(12, 379);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(448, 134);
            this.lbPlaylist.TabIndex = 2;
            this.lbPlaylist.SelectedIndexChanged += new System.EventHandler(this.lbPlaylist_SelectedIndexChanged);
            // 
            // btShowPlaylist
            // 
            this.btShowPlaylist.Location = new System.Drawing.Point(12, 353);
            this.btShowPlaylist.Name = "btShowPlaylist";
            this.btShowPlaylist.Size = new System.Drawing.Size(140, 23);
            this.btShowPlaylist.TabIndex = 3;
            this.btShowPlaylist.Text = "Show playlist";
            this.btShowPlaylist.UseVisualStyleBackColor = true;
            this.btShowPlaylist.Click += new System.EventHandler(this.btShowPlaylist_Click);
            // 
            // timerDuration
            // 
            this.timerDuration.Interval = 1000;
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // pbDuration
            // 
            this.pbDuration.Location = new System.Drawing.Point(12, 309);
            this.pbDuration.Name = "pbDuration";
            this.pbDuration.Size = new System.Drawing.Size(448, 23);
            this.pbDuration.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 541);
            this.Controls.Add(this.pbDuration);
            this.Controls.Add(this.btShowPlaylist);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sound player";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddFragment;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbFragmentNr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Button btShowPlaylist;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.ProgressBar pbDuration;
    }
}

