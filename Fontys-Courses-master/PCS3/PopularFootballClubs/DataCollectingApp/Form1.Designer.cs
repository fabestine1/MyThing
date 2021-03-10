namespace DataCollectingApp
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
            this.pnlGold = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.btnSetCityName = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxNameOfCity = new System.Windows.Forms.TextBox();
            this.tbxFootballClubsAnswer = new System.Windows.Forms.TextBox();
            this.lblNameOfCity = new System.Windows.Forms.Label();
            this.lblFootballClubsQuestion = new System.Windows.Forms.Label();
            this.pnlGold.SuspendLayout();
            this.pnlRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGold
            // 
            this.pnlGold.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlGold.Controls.Add(this.btnSetCityName);
            this.pnlGold.Controls.Add(this.tbxNameOfCity);
            this.pnlGold.Controls.Add(this.lblNameOfCity);
            this.pnlGold.Location = new System.Drawing.Point(29, 12);
            this.pnlGold.Name = "pnlGold";
            this.pnlGold.Size = new System.Drawing.Size(559, 60);
            this.pnlGold.TabIndex = 0;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.Controls.Add(this.lblFootballClubsQuestion);
            this.pnlRed.Controls.Add(this.tbxFootballClubsAnswer);
            this.pnlRed.Controls.Add(this.btnConfirm);
            this.pnlRed.Location = new System.Drawing.Point(29, 78);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(559, 100);
            this.pnlRed.TabIndex = 0;
            // 
            // btnSetCityName
            // 
            this.btnSetCityName.Location = new System.Drawing.Point(312, 20);
            this.btnSetCityName.Name = "btnSetCityName";
            this.btnSetCityName.Size = new System.Drawing.Size(99, 23);
            this.btnSetCityName.TabIndex = 0;
            this.btnSetCityName.Text = "Set city name";
            this.btnSetCityName.UseVisualStyleBackColor = true;
            this.btnSetCityName.Click += new System.EventHandler(this.btnSetCityName_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(228, 58);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxNameOfCity
            // 
            this.tbxNameOfCity.Location = new System.Drawing.Point(206, 22);
            this.tbxNameOfCity.Name = "tbxNameOfCity";
            this.tbxNameOfCity.Size = new System.Drawing.Size(100, 20);
            this.tbxNameOfCity.TabIndex = 2;
            // 
            // tbxFootballClubsAnswer
            // 
            this.tbxFootballClubsAnswer.Location = new System.Drawing.Point(26, 32);
            this.tbxFootballClubsAnswer.Name = "tbxFootballClubsAnswer";
            this.tbxFootballClubsAnswer.Size = new System.Drawing.Size(502, 20);
            this.tbxFootballClubsAnswer.TabIndex = 3;
            // 
            // lblNameOfCity
            // 
            this.lblNameOfCity.AutoSize = true;
            this.lblNameOfCity.Location = new System.Drawing.Point(136, 25);
            this.lblNameOfCity.Name = "lblNameOfCity";
            this.lblNameOfCity.Size = new System.Drawing.Size(64, 13);
            this.lblNameOfCity.TabIndex = 4;
            this.lblNameOfCity.Text = "name of city";
            // 
            // lblFootballClubsQuestion
            // 
            this.lblFootballClubsQuestion.AutoSize = true;
            this.lblFootballClubsQuestion.BackColor = System.Drawing.Color.Red;
            this.lblFootballClubsQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFootballClubsQuestion.Location = new System.Drawing.Point(23, 16);
            this.lblFootballClubsQuestion.Name = "lblFootballClubsQuestion";
            this.lblFootballClubsQuestion.Size = new System.Drawing.Size(228, 13);
            this.lblFootballClubsQuestion.TabIndex = 5;
            this.lblFootballClubsQuestion.Text = "What are your favourite football clubs?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 204);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.pnlGold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlGold.ResumeLayout(false);
            this.pnlGold.PerformLayout();
            this.pnlRed.ResumeLayout(false);
            this.pnlRed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGold;
        private System.Windows.Forms.Button btnSetCityName;
        private System.Windows.Forms.TextBox tbxNameOfCity;
        private System.Windows.Forms.Label lblNameOfCity;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Label lblFootballClubsQuestion;
        private System.Windows.Forms.TextBox tbxFootballClubsAnswer;
        private System.Windows.Forms.Button btnConfirm;
    }
}

