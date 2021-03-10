namespace CSharpSerialConnection
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.Commandline = new System.Windows.Forms.RichTextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnGetSpeed = new System.Windows.Forms.Button();
            this.btnGetFuelLevels = new System.Windows.Forms.Button();
            this.tmrLifetime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewStats = new System.Windows.Forms.Button();
            this.Feedback = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 25);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Vehicle";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Commandline
            // 
            this.Commandline.Location = new System.Drawing.Point(12, 43);
            this.Commandline.Name = "Commandline";
            this.Commandline.Size = new System.Drawing.Size(384, 32);
            this.Commandline.TabIndex = 3;
            this.Commandline.Text = "";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(595, 41);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 75);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(500, 126);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 75);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(686, 126);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 75);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(595, 213);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 75);
            this.btnBackward.TabIndex = 4;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnGetSpeed
            // 
            this.btnGetSpeed.Location = new System.Drawing.Point(402, 41);
            this.btnGetSpeed.Name = "btnGetSpeed";
            this.btnGetSpeed.Size = new System.Drawing.Size(173, 34);
            this.btnGetSpeed.TabIndex = 5;
            this.btnGetSpeed.Text = "Get Top Speed Achieved";
            this.btnGetSpeed.UseVisualStyleBackColor = true;
            this.btnGetSpeed.Click += new System.EventHandler(this.btnGetSpeed_Click);
            // 
            // btnGetFuelLevels
            // 
            this.btnGetFuelLevels.Location = new System.Drawing.Point(686, 43);
            this.btnGetFuelLevels.Name = "btnGetFuelLevels";
            this.btnGetFuelLevels.Size = new System.Drawing.Size(127, 34);
            this.btnGetFuelLevels.TabIndex = 5;
            this.btnGetFuelLevels.Text = "Get Fuel Levels";
            this.btnGetFuelLevels.UseVisualStyleBackColor = true;
            this.btnGetFuelLevels.Click += new System.EventHandler(this.btnGetFuelLevels_Click);
            // 
            // tmrLifetime
            // 
            this.tmrLifetime.Enabled = true;
            this.tmrLifetime.Interval = 1000;
            this.tmrLifetime.Tick += new System.EventHandler(this.tmrLifetime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Disconnect from Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnNewStats
            // 
            this.btnNewStats.Location = new System.Drawing.Point(423, 312);
            this.btnNewStats.Name = "btnNewStats";
            this.btnNewStats.Size = new System.Drawing.Size(134, 23);
            this.btnNewStats.TabIndex = 6;
            this.btnNewStats.Text = "Reset Stats/ New Rent";
            this.btnNewStats.UseVisualStyleBackColor = true;
            // 
            // Feedback
            // 
            this.Feedback.Location = new System.Drawing.Point(12, 81);
            this.Feedback.Name = "Feedback";
            this.Feedback.ReadOnly = true;
            this.Feedback.ShortcutsEnabled = false;
            this.Feedback.Size = new System.Drawing.Size(383, 254);
            this.Feedback.TabIndex = 7;
            this.Feedback.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(595, 126);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 75);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(595, 312);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(191, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 347);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.btnNewStats);
            this.Controls.Add(this.btnGetFuelLevels);
            this.Controls.Add(this.btnGetSpeed);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.Commandline);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox Commandline;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnGetSpeed;
        private System.Windows.Forms.Button btnGetFuelLevels;
        private System.Windows.Forms.Timer tmrLifetime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewStats;
        private System.Windows.Forms.RichTextBox Feedback;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

