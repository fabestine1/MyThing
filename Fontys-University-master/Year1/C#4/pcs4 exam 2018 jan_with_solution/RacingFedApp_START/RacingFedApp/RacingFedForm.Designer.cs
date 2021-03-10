namespace RacingFedApp
{
    partial class RacingFedForm
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
            this.lbRacers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRacer = new System.Windows.Forms.Button();
            this.tbNrOfWins = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblNrOfWins = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbChangeRank = new System.Windows.Forms.GroupBox();
            this.btnChangeRank = new System.Windows.Forms.Button();
            this.lblNewRank = new System.Windows.Forms.Label();
            this.tbNewRank = new System.Windows.Forms.TextBox();
            this.btnSortRank = new System.Windows.Forms.Button();
            this.btnSortRankNrOfWins = new System.Windows.Forms.Button();
            this.btnAddTestRide = new System.Windows.Forms.Button();
            this.btnGetHighestRank = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbChangeRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRacers
            // 
            this.lbRacers.FormattingEnabled = true;
            this.lbRacers.Location = new System.Drawing.Point(21, 153);
            this.lbRacers.Name = "lbRacers";
            this.lbRacers.Size = new System.Drawing.Size(380, 238);
            this.lbRacers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Racers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRacer);
            this.groupBox1.Controls.Add(this.tbNrOfWins);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Controls.Add(this.tbNr);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblNrOfWins);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(636, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Racer";
            // 
            // btnAddRacer
            // 
            this.btnAddRacer.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddRacer.Location = new System.Drawing.Point(120, 202);
            this.btnAddRacer.Name = "btnAddRacer";
            this.btnAddRacer.Size = new System.Drawing.Size(149, 31);
            this.btnAddRacer.TabIndex = 3;
            this.btnAddRacer.Text = "Add Racer";
            this.btnAddRacer.UseVisualStyleBackColor = false;
            this.btnAddRacer.Click += new System.EventHandler(this.btnAddRacer_Click);
            // 
            // tbNrOfWins
            // 
            this.tbNrOfWins.Location = new System.Drawing.Point(139, 148);
            this.tbNrOfWins.Name = "tbNrOfWins";
            this.tbNrOfWins.Size = new System.Drawing.Size(130, 29);
            this.tbNrOfWins.TabIndex = 7;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(139, 110);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(130, 29);
            this.tbType.TabIndex = 6;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(139, 38);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(130, 29);
            this.tbNr.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(130, 29);
            this.tbName.TabIndex = 4;
            // 
            // lblNrOfWins
            // 
            this.lblNrOfWins.AutoSize = true;
            this.lblNrOfWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfWins.Location = new System.Drawing.Point(15, 154);
            this.lblNrOfWins.Name = "lblNrOfWins";
            this.lblNrOfWins.Size = new System.Drawing.Size(118, 20);
            this.lblNrOfWins.TabIndex = 3;
            this.lblNrOfWins.Text = "Number of wins";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(33, 119);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Pro/Rec type";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(68, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 20);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gbChangeRank
            // 
            this.gbChangeRank.Controls.Add(this.btnChangeRank);
            this.gbChangeRank.Controls.Add(this.lblNewRank);
            this.gbChangeRank.Controls.Add(this.tbNewRank);
            this.gbChangeRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangeRank.Location = new System.Drawing.Point(21, 410);
            this.gbChangeRank.Name = "gbChangeRank";
            this.gbChangeRank.Size = new System.Drawing.Size(380, 100);
            this.gbChangeRank.TabIndex = 5;
            this.gbChangeRank.TabStop = false;
            this.gbChangeRank.Text = "Change the rank for selected racer";
            // 
            // btnChangeRank
            // 
            this.btnChangeRank.BackColor = System.Drawing.Color.LightGreen;
            this.btnChangeRank.Location = new System.Drawing.Point(225, 40);
            this.btnChangeRank.Name = "btnChangeRank";
            this.btnChangeRank.Size = new System.Drawing.Size(149, 31);
            this.btnChangeRank.TabIndex = 2;
            this.btnChangeRank.Text = "Change rank";
            this.btnChangeRank.UseVisualStyleBackColor = false;
            this.btnChangeRank.Click += new System.EventHandler(this.btnChangeRank_Click);
            // 
            // lblNewRank
            // 
            this.lblNewRank.AutoSize = true;
            this.lblNewRank.Location = new System.Drawing.Point(6, 47);
            this.lblNewRank.Name = "lblNewRank";
            this.lblNewRank.Size = new System.Drawing.Size(67, 17);
            this.lblNewRank.TabIndex = 1;
            this.lblNewRank.Text = "New rank";
            // 
            // tbNewRank
            // 
            this.tbNewRank.Location = new System.Drawing.Point(103, 44);
            this.tbNewRank.Name = "tbNewRank";
            this.tbNewRank.Size = new System.Drawing.Size(76, 23);
            this.tbNewRank.TabIndex = 0;
            // 
            // btnSortRank
            // 
            this.btnSortRank.BackColor = System.Drawing.Color.Gold;
            this.btnSortRank.Location = new System.Drawing.Point(110, 119);
            this.btnSortRank.Name = "btnSortRank";
            this.btnSortRank.Size = new System.Drawing.Size(145, 31);
            this.btnSortRank.TabIndex = 6;
            this.btnSortRank.Text = "Sort by rank";
            this.btnSortRank.UseVisualStyleBackColor = false;
            this.btnSortRank.Click += new System.EventHandler(this.btnSortRank_Click);
            // 
            // btnSortRankNrOfWins
            // 
            this.btnSortRankNrOfWins.BackColor = System.Drawing.Color.Gold;
            this.btnSortRankNrOfWins.Location = new System.Drawing.Point(256, 119);
            this.btnSortRankNrOfWins.Name = "btnSortRankNrOfWins";
            this.btnSortRankNrOfWins.Size = new System.Drawing.Size(145, 31);
            this.btnSortRankNrOfWins.TabIndex = 7;
            this.btnSortRankNrOfWins.Text = "Sort by type and nr of wins";
            this.btnSortRankNrOfWins.UseVisualStyleBackColor = false;
            this.btnSortRankNrOfWins.Click += new System.EventHandler(this.btnSortTypeNrOfWins_Click);
            // 
            // btnAddTestRide
            // 
            this.btnAddTestRide.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddTestRide.Location = new System.Drawing.Point(21, 530);
            this.btnAddTestRide.Name = "btnAddTestRide";
            this.btnAddTestRide.Size = new System.Drawing.Size(149, 31);
            this.btnAddTestRide.TabIndex = 8;
            this.btnAddTestRide.Text = "Add Test Ride";
            this.btnAddTestRide.UseVisualStyleBackColor = false;
            this.btnAddTestRide.Click += new System.EventHandler(this.btnAddTestRide_Click);
            // 
            // btnGetHighestRank
            // 
            this.btnGetHighestRank.BackColor = System.Drawing.Color.LightGreen;
            this.btnGetHighestRank.Location = new System.Drawing.Point(246, 530);
            this.btnGetHighestRank.Name = "btnGetHighestRank";
            this.btnGetHighestRank.Size = new System.Drawing.Size(149, 31);
            this.btnGetHighestRank.TabIndex = 9;
            this.btnGetHighestRank.Text = "Get Highest Racer";
            this.btnGetHighestRank.UseVisualStyleBackColor = false;
            this.btnGetHighestRank.Click += new System.EventHandler(this.btnGetHighestRank_Click);
            // 
            // RacingFedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacingFedApp.Properties.Resources.KartRace;
            this.ClientSize = new System.Drawing.Size(953, 599);
            this.Controls.Add(this.btnGetHighestRank);
            this.Controls.Add(this.btnAddTestRide);
            this.Controls.Add(this.btnSortRankNrOfWins);
            this.Controls.Add(this.btnSortRank);
            this.Controls.Add(this.gbChangeRank);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRacers);
            this.Name = "RacingFedForm";
            this.Text = "RacingFed App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbChangeRank.ResumeLayout(false);
            this.gbChangeRank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRacers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNrOfWins;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAddRacer;
        private System.Windows.Forms.TextBox tbNrOfWins;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbNr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbChangeRank;
        private System.Windows.Forms.Button btnChangeRank;
        private System.Windows.Forms.Label lblNewRank;
        private System.Windows.Forms.TextBox tbNewRank;
        private System.Windows.Forms.Button btnSortRank;
        private System.Windows.Forms.Button btnSortRankNrOfWins;
        private System.Windows.Forms.Button btnAddTestRide;
        private System.Windows.Forms.Button btnGetHighestRank;
    }
}

