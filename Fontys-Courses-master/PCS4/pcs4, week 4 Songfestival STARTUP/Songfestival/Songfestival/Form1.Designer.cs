namespace Songfestival
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
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(118, 11);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(135, 24);
            this.tbCountry.TabIndex = 0;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(26, 18);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(60, 18);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "Country";
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore.Location = new System.Drawing.Point(118, 50);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(135, 24);
            this.tbScore.TabIndex = 2;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScore.Location = new System.Drawing.Point(29, 80);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(224, 41);
            this.btnAddScore.TabIndex = 3;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(26, 53);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(48, 18);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score";
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 18;
            this.lbInfo.Location = new System.Drawing.Point(29, 149);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(528, 94);
            this.lbInfo.TabIndex = 7;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(428, 36);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(129, 91);
            this.btnShowInfo.TabIndex = 8;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 263);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.tbCountry);
            this.Name = "Form1";
            this.Text = "Songfestival";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btnShowInfo;
    }
}

