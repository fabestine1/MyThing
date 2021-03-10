namespace project_6._3
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
            this.btnSelectPlayerA = new System.Windows.Forms.Button();
            this.tbxPlayerACard = new System.Windows.Forms.TextBox();
            this.btnSelectPlayerC = new System.Windows.Forms.Button();
            this.tbxPlayerCCard = new System.Windows.Forms.TextBox();
            this.tbxPlayerBCard = new System.Windows.Forms.TextBox();
            this.btnSelectPlayerB = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectPlayerA
            // 
            this.btnSelectPlayerA.Location = new System.Drawing.Point(31, 29);
            this.btnSelectPlayerA.Name = "btnSelectPlayerA";
            this.btnSelectPlayerA.Size = new System.Drawing.Size(97, 23);
            this.btnSelectPlayerA.TabIndex = 0;
            this.btnSelectPlayerA.Text = "select a card";
            this.btnSelectPlayerA.UseVisualStyleBackColor = true;
            this.btnSelectPlayerA.Click += new System.EventHandler(this.btnSelectPlayerA_Click);
            // 
            // tbxPlayerACard
            // 
            this.tbxPlayerACard.Location = new System.Drawing.Point(31, 82);
            this.tbxPlayerACard.Multiline = true;
            this.tbxPlayerACard.Name = "tbxPlayerACard";
            this.tbxPlayerACard.ReadOnly = true;
            this.tbxPlayerACard.Size = new System.Drawing.Size(97, 92);
            this.tbxPlayerACard.TabIndex = 2;
            // 
            // btnSelectPlayerC
            // 
            this.btnSelectPlayerC.Location = new System.Drawing.Point(308, 29);
            this.btnSelectPlayerC.Name = "btnSelectPlayerC";
            this.btnSelectPlayerC.Size = new System.Drawing.Size(97, 23);
            this.btnSelectPlayerC.TabIndex = 1;
            this.btnSelectPlayerC.Text = "select a card";
            this.btnSelectPlayerC.UseVisualStyleBackColor = true;
            this.btnSelectPlayerC.Click += new System.EventHandler(this.btnSelectPlayerC_Click);
            // 
            // tbxPlayerCCard
            // 
            this.tbxPlayerCCard.Location = new System.Drawing.Point(308, 82);
            this.tbxPlayerCCard.Multiline = true;
            this.tbxPlayerCCard.Name = "tbxPlayerCCard";
            this.tbxPlayerCCard.ReadOnly = true;
            this.tbxPlayerCCard.Size = new System.Drawing.Size(97, 92);
            this.tbxPlayerCCard.TabIndex = 3;
            // 
            // tbxPlayerBCard
            // 
            this.tbxPlayerBCard.Location = new System.Drawing.Point(170, 82);
            this.tbxPlayerBCard.Multiline = true;
            this.tbxPlayerBCard.Name = "tbxPlayerBCard";
            this.tbxPlayerBCard.ReadOnly = true;
            this.tbxPlayerBCard.Size = new System.Drawing.Size(97, 92);
            this.tbxPlayerBCard.TabIndex = 3;
            // 
            // btnSelectPlayerB
            // 
            this.btnSelectPlayerB.Location = new System.Drawing.Point(170, 29);
            this.btnSelectPlayerB.Name = "btnSelectPlayerB";
            this.btnSelectPlayerB.Size = new System.Drawing.Size(97, 23);
            this.btnSelectPlayerB.TabIndex = 1;
            this.btnSelectPlayerB.Text = "select a card";
            this.btnSelectPlayerB.UseVisualStyleBackColor = true;
            this.btnSelectPlayerB.Click += new System.EventHandler(this.btnSelectPlayerB_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(181, 194);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 244);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tbxPlayerCCard);
            this.Controls.Add(this.tbxPlayerBCard);
            this.Controls.Add(this.tbxPlayerACard);
            this.Controls.Add(this.btnSelectPlayerC);
            this.Controls.Add(this.btnSelectPlayerB);
            this.Controls.Add(this.btnSelectPlayerA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPlayerA;
        private System.Windows.Forms.TextBox tbxPlayerACard;
        private System.Windows.Forms.Button btnSelectPlayerC;
        private System.Windows.Forms.TextBox tbxPlayerCCard;
        private System.Windows.Forms.TextBox tbxPlayerBCard;
        private System.Windows.Forms.Button btnSelectPlayerB;
        private System.Windows.Forms.Button btnCompare;
    }
}

