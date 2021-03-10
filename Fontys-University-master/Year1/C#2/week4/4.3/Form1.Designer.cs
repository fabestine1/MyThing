namespace _4._3
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbSettings = new System.Windows.Forms.Label();
            this.lbMaxValue = new System.Windows.Forms.Label();
            this.lbMaxDrawn = new System.Windows.Forms.Label();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.tbMaxDrawn = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lsbDrawnNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(54, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Location = new System.Drawing.Point(51, 31);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(68, 16);
            this.lbSettings.TabIndex = 1;
            this.lbSettings.Text = "Settings:";
            // 
            // lbMaxValue
            // 
            this.lbMaxValue.AutoSize = true;
            this.lbMaxValue.Location = new System.Drawing.Point(51, 69);
            this.lbMaxValue.Name = "lbMaxValue";
            this.lbMaxValue.Size = new System.Drawing.Size(80, 16);
            this.lbMaxValue.TabIndex = 2;
            this.lbMaxValue.Text = "Max Value";
            // 
            // lbMaxDrawn
            // 
            this.lbMaxDrawn.AutoSize = true;
            this.lbMaxDrawn.Location = new System.Drawing.Point(51, 107);
            this.lbMaxDrawn.Name = "lbMaxDrawn";
            this.lbMaxDrawn.Size = new System.Drawing.Size(83, 16);
            this.lbMaxDrawn.TabIndex = 3;
            this.lbMaxDrawn.Text = "Max Drawn";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(140, 66);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(100, 22);
            this.tbMaxValue.TabIndex = 4;
            // 
            // tbMaxDrawn
            // 
            this.tbMaxDrawn.Location = new System.Drawing.Point(140, 104);
            this.tbMaxDrawn.Name = "tbMaxDrawn";
            this.tbMaxDrawn.Size = new System.Drawing.Size(100, 22);
            this.tbMaxDrawn.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(54, 187);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(186, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Draw Next Number";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAll
            // 
            this.btnAll.Enabled = false;
            this.btnAll.Location = new System.Drawing.Point(54, 226);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(186, 33);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Draw All Numbers";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lsbDrawnNumbers
            // 
            this.lsbDrawnNumbers.ForeColor = System.Drawing.Color.Teal;
            this.lsbDrawnNumbers.FormattingEnabled = true;
            this.lsbDrawnNumbers.ItemHeight = 16;
            this.lsbDrawnNumbers.Location = new System.Drawing.Point(283, 31);
            this.lsbDrawnNumbers.Name = "lsbDrawnNumbers";
            this.lsbDrawnNumbers.Size = new System.Drawing.Size(135, 228);
            this.lsbDrawnNumbers.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(466, 303);
            this.Controls.Add(this.lsbDrawnNumbers);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbMaxDrawn);
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.lbMaxDrawn);
            this.Controls.Add(this.lbMaxValue);
            this.Controls.Add(this.lbSettings);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lottery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Label lbMaxValue;
        private System.Windows.Forms.Label lbMaxDrawn;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.TextBox tbMaxDrawn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ListBox lsbDrawnNumbers;
    }
}

