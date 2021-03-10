namespace _2._2
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
            this.pbLeftTrafficLight = new System.Windows.Forms.PictureBox();
            this.pbRightTrafficLight = new System.Windows.Forms.PictureBox();
            this.bigger1 = new System.Windows.Forms.Button();
            this.bigger2 = new System.Windows.Forms.Button();
            this.smaller1 = new System.Windows.Forms.Button();
            this.smaller2 = new System.Windows.Forms.Button();
            this.changeColor1 = new System.Windows.Forms.Button();
            this.changeColor2 = new System.Windows.Forms.Button();
            this.btnTurnOnTimerLeft = new System.Windows.Forms.Button();
            this.btnTurnOnTimerRight = new System.Windows.Forms.Button();
            this.tmLeftTraficLight = new System.Windows.Forms.Timer(this.components);
            this.tmRightTraficLight = new System.Windows.Forms.Timer(this.components);
            this.btnTurnOnSimultaneously = new System.Windows.Forms.Button();
            this.tmSimultaneously = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftTrafficLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLeftTrafficLight
            // 
            this.pbLeftTrafficLight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbLeftTrafficLight.Location = new System.Drawing.Point(97, 23);
            this.pbLeftTrafficLight.Name = "pbLeftTrafficLight";
            this.pbLeftTrafficLight.Size = new System.Drawing.Size(104, 246);
            this.pbLeftTrafficLight.TabIndex = 0;
            this.pbLeftTrafficLight.TabStop = false;
            this.pbLeftTrafficLight.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLeftTrafficLight_Paint);
            // 
            // pbRightTrafficLight
            // 
            this.pbRightTrafficLight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbRightTrafficLight.Location = new System.Drawing.Point(441, 23);
            this.pbRightTrafficLight.Name = "pbRightTrafficLight";
            this.pbRightTrafficLight.Size = new System.Drawing.Size(104, 246);
            this.pbRightTrafficLight.TabIndex = 1;
            this.pbRightTrafficLight.TabStop = false;
            this.pbRightTrafficLight.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRightTrafficLight_Paint);
            // 
            // bigger1
            // 
            this.bigger1.BackColor = System.Drawing.Color.LightGreen;
            this.bigger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigger1.ForeColor = System.Drawing.Color.Red;
            this.bigger1.Location = new System.Drawing.Point(77, 275);
            this.bigger1.Name = "bigger1";
            this.bigger1.Size = new System.Drawing.Size(141, 44);
            this.bigger1.TabIndex = 2;
            this.bigger1.Text = "Bigger ";
            this.bigger1.UseVisualStyleBackColor = false;
            this.bigger1.Click += new System.EventHandler(this.bigger1_Click);
            // 
            // bigger2
            // 
            this.bigger2.BackColor = System.Drawing.Color.LightGreen;
            this.bigger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigger2.ForeColor = System.Drawing.Color.Red;
            this.bigger2.Location = new System.Drawing.Point(424, 275);
            this.bigger2.Name = "bigger2";
            this.bigger2.Size = new System.Drawing.Size(141, 44);
            this.bigger2.TabIndex = 3;
            this.bigger2.Text = "Bigger ";
            this.bigger2.UseVisualStyleBackColor = false;
            this.bigger2.Click += new System.EventHandler(this.bigger2_Click);
            // 
            // smaller1
            // 
            this.smaller1.BackColor = System.Drawing.Color.Pink;
            this.smaller1.ForeColor = System.Drawing.Color.MediumBlue;
            this.smaller1.Location = new System.Drawing.Point(106, 325);
            this.smaller1.Name = "smaller1";
            this.smaller1.Size = new System.Drawing.Size(75, 23);
            this.smaller1.TabIndex = 4;
            this.smaller1.Text = "Smaller";
            this.smaller1.UseVisualStyleBackColor = false;
            this.smaller1.Click += new System.EventHandler(this.smaller1_Click);
            // 
            // smaller2
            // 
            this.smaller2.BackColor = System.Drawing.Color.Pink;
            this.smaller2.ForeColor = System.Drawing.Color.MediumBlue;
            this.smaller2.Location = new System.Drawing.Point(460, 325);
            this.smaller2.Name = "smaller2";
            this.smaller2.Size = new System.Drawing.Size(75, 23);
            this.smaller2.TabIndex = 5;
            this.smaller2.Text = "Smaller";
            this.smaller2.UseVisualStyleBackColor = false;
            this.smaller2.Click += new System.EventHandler(this.smaller2_Click);
            // 
            // changeColor1
            // 
            this.changeColor1.BackColor = System.Drawing.Color.DeepPink;
            this.changeColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeColor1.ForeColor = System.Drawing.Color.Lime;
            this.changeColor1.Location = new System.Drawing.Point(254, 76);
            this.changeColor1.Name = "changeColor1";
            this.changeColor1.Size = new System.Drawing.Size(92, 55);
            this.changeColor1.TabIndex = 6;
            this.changeColor1.Text = "Change Color";
            this.changeColor1.UseVisualStyleBackColor = false;
            this.changeColor1.Click += new System.EventHandler(this.changeColor1_Click);
            // 
            // changeColor2
            // 
            this.changeColor2.BackColor = System.Drawing.Color.DeepPink;
            this.changeColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeColor2.ForeColor = System.Drawing.Color.Lime;
            this.changeColor2.Location = new System.Drawing.Point(604, 76);
            this.changeColor2.Name = "changeColor2";
            this.changeColor2.Size = new System.Drawing.Size(92, 55);
            this.changeColor2.TabIndex = 7;
            this.changeColor2.Text = "Change Color";
            this.changeColor2.UseVisualStyleBackColor = false;
            this.changeColor2.Click += new System.EventHandler(this.changeColor2_Click);
            // 
            // btnTurnOnTimerLeft
            // 
            this.btnTurnOnTimerLeft.BackColor = System.Drawing.Color.DeepPink;
            this.btnTurnOnTimerLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTurnOnTimerLeft.ForeColor = System.Drawing.Color.Lime;
            this.btnTurnOnTimerLeft.Location = new System.Drawing.Point(254, 137);
            this.btnTurnOnTimerLeft.Name = "btnTurnOnTimerLeft";
            this.btnTurnOnTimerLeft.Size = new System.Drawing.Size(92, 55);
            this.btnTurnOnTimerLeft.TabIndex = 8;
            this.btnTurnOnTimerLeft.Text = "Turn on Timer";
            this.btnTurnOnTimerLeft.UseVisualStyleBackColor = false;
            this.btnTurnOnTimerLeft.Click += new System.EventHandler(this.btnTurnOnTimerLeft_Click);
            // 
            // btnTurnOnTimerRight
            // 
            this.btnTurnOnTimerRight.BackColor = System.Drawing.Color.DeepPink;
            this.btnTurnOnTimerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTurnOnTimerRight.ForeColor = System.Drawing.Color.Lime;
            this.btnTurnOnTimerRight.Location = new System.Drawing.Point(604, 137);
            this.btnTurnOnTimerRight.Name = "btnTurnOnTimerRight";
            this.btnTurnOnTimerRight.Size = new System.Drawing.Size(92, 55);
            this.btnTurnOnTimerRight.TabIndex = 9;
            this.btnTurnOnTimerRight.Text = "Turn on Timer";
            this.btnTurnOnTimerRight.UseVisualStyleBackColor = false;
            this.btnTurnOnTimerRight.Click += new System.EventHandler(this.btnTurnOnTimerRight_Click);
            // 
            // tmLeftTraficLight
            // 
            this.tmLeftTraficLight.Interval = 1000;
            this.tmLeftTraficLight.Tick += new System.EventHandler(this.tmLeftTraficLight_Tick);
            // 
            // tmRightTraficLight
            // 
            this.tmRightTraficLight.Interval = 1000;
            this.tmRightTraficLight.Tick += new System.EventHandler(this.tmRightTraficLight_Tick);
            // 
            // btnTurnOnSimultaneously
            // 
            this.btnTurnOnSimultaneously.BackColor = System.Drawing.Color.DeepPink;
            this.btnTurnOnSimultaneously.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTurnOnSimultaneously.ForeColor = System.Drawing.Color.Lime;
            this.btnTurnOnSimultaneously.Location = new System.Drawing.Point(266, 293);
            this.btnTurnOnSimultaneously.Name = "btnTurnOnSimultaneously";
            this.btnTurnOnSimultaneously.Size = new System.Drawing.Size(141, 55);
            this.btnTurnOnSimultaneously.TabIndex = 10;
            this.btnTurnOnSimultaneously.Text = "Turn on Simultaneously";
            this.btnTurnOnSimultaneously.UseVisualStyleBackColor = false;
            this.btnTurnOnSimultaneously.Click += new System.EventHandler(this.btnTurnOnSimultaneously_Click);
            // 
            // tmSimultaneously
            // 
            this.tmSimultaneously.Interval = 1000;
            this.tmSimultaneously.Tick += new System.EventHandler(this.tmSimultaneously_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 372);
            this.Controls.Add(this.btnTurnOnSimultaneously);
            this.Controls.Add(this.btnTurnOnTimerRight);
            this.Controls.Add(this.btnTurnOnTimerLeft);
            this.Controls.Add(this.changeColor2);
            this.Controls.Add(this.changeColor1);
            this.Controls.Add(this.smaller2);
            this.Controls.Add(this.smaller1);
            this.Controls.Add(this.bigger2);
            this.Controls.Add(this.bigger1);
            this.Controls.Add(this.pbRightTrafficLight);
            this.Controls.Add(this.pbLeftTrafficLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftTrafficLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightTrafficLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLeftTrafficLight;
        private System.Windows.Forms.PictureBox pbRightTrafficLight;
        private System.Windows.Forms.Button bigger1;
        private System.Windows.Forms.Button bigger2;
        private System.Windows.Forms.Button smaller1;
        private System.Windows.Forms.Button smaller2;
        private System.Windows.Forms.Button changeColor1;
        private System.Windows.Forms.Button changeColor2;
        private System.Windows.Forms.Button btnTurnOnTimerLeft;
        private System.Windows.Forms.Button btnTurnOnTimerRight;
        private System.Windows.Forms.Timer tmLeftTraficLight;
        private System.Windows.Forms.Timer tmRightTraficLight;
        private System.Windows.Forms.Button btnTurnOnSimultaneously;
        private System.Windows.Forms.Timer tmSimultaneously;
    }
}

