namespace _6_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnToss = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.pbFirstCoin = new System.Windows.Forms.PictureBox();
            this.pbSecondCoin = new System.Windows.Forms.PictureBox();
            this.tmChange = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToss.Location = new System.Drawing.Point(14, 261);
            this.btnToss.Margin = new System.Windows.Forms.Padding(5);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(163, 52);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(146, 9);
            this.lbResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 20);
            this.lbResult.TabIndex = 1;
            // 
            // pbFirstCoin
            // 
            this.pbFirstCoin.Image = ((System.Drawing.Image)(resources.GetObject("pbFirstCoin.Image")));
            this.pbFirstCoin.Location = new System.Drawing.Point(71, 45);
            this.pbFirstCoin.Name = "pbFirstCoin";
            this.pbFirstCoin.Size = new System.Drawing.Size(223, 199);
            this.pbFirstCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstCoin.TabIndex = 2;
            this.pbFirstCoin.TabStop = false;
            this.pbFirstCoin.Visible = false;
            // 
            // pbSecondCoin
            // 
            this.pbSecondCoin.Image = ((System.Drawing.Image)(resources.GetObject("pbSecondCoin.Image")));
            this.pbSecondCoin.Location = new System.Drawing.Point(71, 45);
            this.pbSecondCoin.Name = "pbSecondCoin";
            this.pbSecondCoin.Size = new System.Drawing.Size(223, 199);
            this.pbSecondCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecondCoin.TabIndex = 3;
            this.pbSecondCoin.TabStop = false;
            this.pbSecondCoin.Visible = false;
            // 
            // tmChange
            // 
            this.tmChange.Interval = 1000;
            this.tmChange.Tick += new System.EventHandler(this.tmChange_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(208, 261);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(163, 52);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(385, 327);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pbSecondCoin);
            this.Controls.Add(this.pbFirstCoin);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnToss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Tomato;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pbFirstCoin;
        private System.Windows.Forms.PictureBox pbSecondCoin;
        private System.Windows.Forms.Timer tmChange;
        private System.Windows.Forms.Button btnRestart;
    }
}

