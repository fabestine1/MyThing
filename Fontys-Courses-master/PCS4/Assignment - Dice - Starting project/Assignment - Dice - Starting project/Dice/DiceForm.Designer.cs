namespace Dobbelsteen
{
    partial class DiceForm
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
            this.RollButton = new System.Windows.Forms.Button();
            this.number6PictureBox = new System.Windows.Forms.PictureBox();
            this.number5PictureBox = new System.Windows.Forms.PictureBox();
            this.number4PictureBox = new System.Windows.Forms.PictureBox();
            this.number3PictureBox = new System.Windows.Forms.PictureBox();
            this.number2PictureBox = new System.Windows.Forms.PictureBox();
            this.number1PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.number6PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(218, 372);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(120, 23);
            this.RollButton.TabIndex = 0;
            this.RollButton.Text = "Roll dice!";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // number6PictureBox
            // 
            this.number6PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice6;
            this.number6PictureBox.Location = new System.Drawing.Point(380, 191);
            this.number6PictureBox.Name = "number6PictureBox";
            this.number6PictureBox.Size = new System.Drawing.Size(162, 157);
            this.number6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number6PictureBox.TabIndex = 6;
            this.number6PictureBox.TabStop = false;
            this.number6PictureBox.Visible = false;
            // 
            // number5PictureBox
            // 
            this.number5PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice5;
            this.number5PictureBox.Location = new System.Drawing.Point(196, 191);
            this.number5PictureBox.Name = "number5PictureBox";
            this.number5PictureBox.Size = new System.Drawing.Size(162, 157);
            this.number5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number5PictureBox.TabIndex = 5;
            this.number5PictureBox.TabStop = false;
            this.number5PictureBox.Visible = false;
            // 
            // number4PictureBox
            // 
            this.number4PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice4;
            this.number4PictureBox.Location = new System.Drawing.Point(12, 191);
            this.number4PictureBox.Name = "number4PictureBox";
            this.number4PictureBox.Size = new System.Drawing.Size(162, 157);
            this.number4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number4PictureBox.TabIndex = 4;
            this.number4PictureBox.TabStop = false;
            this.number4PictureBox.Visible = false;
            // 
            // number3PictureBox
            // 
            this.number3PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice3;
            this.number3PictureBox.Location = new System.Drawing.Point(380, 12);
            this.number3PictureBox.Name = "number3PictureBox";
            this.number3PictureBox.Size = new System.Drawing.Size(162, 157);
            this.number3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number3PictureBox.TabIndex = 3;
            this.number3PictureBox.TabStop = false;
            this.number3PictureBox.Visible = false;
            // 
            // number2PictureBox
            // 
            this.number2PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice2;
            this.number2PictureBox.Location = new System.Drawing.Point(196, 12);
            this.number2PictureBox.Name = "number2PictureBox";
            this.number2PictureBox.Size = new System.Drawing.Size(162, 157);
            this.number2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number2PictureBox.TabIndex = 2;
            this.number2PictureBox.TabStop = false;
            this.number2PictureBox.Visible = false;
            // 
            // number1PictureBox
            // 
            this.number1PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice1;
            this.number1PictureBox.Location = new System.Drawing.Point(12, 12);
            this.number1PictureBox.Name = "number1PictureBox";
            this.number1PictureBox.Size = new System.Drawing.Size(162, 157);
            this.number1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number1PictureBox.TabIndex = 1;
            this.number1PictureBox.TabStop = false;
            this.number1PictureBox.Visible = false;
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 410);
            this.Controls.Add(this.number6PictureBox);
            this.Controls.Add(this.number5PictureBox);
            this.Controls.Add(this.number4PictureBox);
            this.Controls.Add(this.number3PictureBox);
            this.Controls.Add(this.number2PictureBox);
            this.Controls.Add(this.number1PictureBox);
            this.Controls.Add(this.RollButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiceForm";
            this.Text = "Dice";
            ((System.ComponentModel.ISupportInitialize)(this.number6PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number1PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.PictureBox number1PictureBox;
        private System.Windows.Forms.PictureBox number2PictureBox;
        private System.Windows.Forms.PictureBox number3PictureBox;
        private System.Windows.Forms.PictureBox number4PictureBox;
        private System.Windows.Forms.PictureBox number5PictureBox;
        private System.Windows.Forms.PictureBox number6PictureBox;
    }
}

