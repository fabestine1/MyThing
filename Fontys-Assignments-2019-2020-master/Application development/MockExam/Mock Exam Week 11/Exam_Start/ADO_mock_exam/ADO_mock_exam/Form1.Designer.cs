namespace ADO_mock_exam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSneakPeek = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKiller = new System.Windows.Forms.TextBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPlayerName);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.btnAddNewPlayer);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(296, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Player";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Name";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(127, 37);
            this.tbPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(160, 22);
            this.tbPlayerName.TabIndex = 2;
            // 
            // cmbRole
            // 
            this.cmbRole.AutoCompleteCustomSource.AddRange(new string[] {
            "King",
            "Knight",
            "Witch",
            "Wizard"});
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "King",
            "Knight",
            "Witch",
            "Wizard"});
            this.cmbRole.Location = new System.Drawing.Point(127, 69);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(160, 24);
            this.cmbRole.TabIndex = 1;
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(127, 102);
            this.btnAddNewPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(161, 28);
            this.btnAddNewPlayer.TabIndex = 0;
            this.btnAddNewPlayer.Text = "Add Player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSneakPeek);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbKiller);
            this.groupBox2.Controls.Add(this.btnKill);
            this.groupBox2.Location = new System.Drawing.Point(16, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(296, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Try 2 Kill";
            // 
            // btnSneakPeek
            // 
            this.btnSneakPeek.Location = new System.Drawing.Point(127, 66);
            this.btnSneakPeek.Margin = new System.Windows.Forms.Padding(4);
            this.btnSneakPeek.Name = "btnSneakPeek";
            this.btnSneakPeek.Size = new System.Drawing.Size(161, 28);
            this.btnSneakPeek.TabIndex = 6;
            this.btnSneakPeek.Text = "Sneak Peek";
            this.btnSneakPeek.UseMnemonic = false;
            this.btnSneakPeek.UseVisualStyleBackColor = true;
            this.btnSneakPeek.Click += new System.EventHandler(this.btnSneakPeek_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Killer Name";
            // 
            // tbKiller
            // 
            this.tbKiller.Location = new System.Drawing.Point(127, 34);
            this.tbKiller.Margin = new System.Windows.Forms.Padding(4);
            this.tbKiller.Name = "tbKiller";
            this.tbKiller.Size = new System.Drawing.Size(160, 22);
            this.tbKiller.TabIndex = 6;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(127, 102);
            this.btnKill.Margin = new System.Windows.Forms.Padding(4);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(161, 28);
            this.btnKill.TabIndex = 0;
            this.btnKill.Text = "Kill Selected";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStatistics);
            this.groupBox3.Controls.Add(this.lbPlayers);
            this.groupBox3.Location = new System.Drawing.Point(320, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(396, 324);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Players Overview";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(253, 274);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(135, 28);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Show Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 16;
            this.lbPlayers.Location = new System.Drawing.Point(8, 23);
            this.lbPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(379, 244);
            this.lbPlayers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "The Witch Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKiller;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSneakPeek;
    }
}

