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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnGetSpeed = new System.Windows.Forms.Button();
            this.btnGetFuelLevels = new System.Windows.Forms.Button();
            this.tmrLifetime = new System.Windows.Forms.Timer(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnNewStats = new System.Windows.Forms.Button();
            this.trackSpeedBar = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSendRaw = new System.Windows.Forms.TextBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTopSpeed = new System.Windows.Forms.Label();
            this.lblFuelLvl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeedBar)).BeginInit();
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
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 43);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(384, 265);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
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
            this.tmrLifetime.Interval = 1000;
            this.tmrLifetime.Tick += new System.EventHandler(this.tmrLifetime_Tick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(148, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(130, 25);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect from Vehicle";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
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
            // trackSpeedBar
            // 
            this.trackSpeedBar.Location = new System.Drawing.Point(595, 316);
            this.trackSpeedBar.Maximum = 20;
            this.trackSpeedBar.Name = "trackSpeedBar";
            this.trackSpeedBar.Size = new System.Drawing.Size(212, 45);
            this.trackSpeedBar.TabIndex = 7;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(600, 300);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(57, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Set Speed";
            // 
            // tbSendRaw
            // 
            this.tbSendRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSendRaw.Location = new System.Drawing.Point(13, 314);
            this.tbSendRaw.Name = "tbSendRaw";
            this.tbSendRaw.Size = new System.Drawing.Size(297, 20);
            this.tbSendRaw.TabIndex = 9;
            this.tbSendRaw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSendRaw_KeyDown);
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(316, 312);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(80, 23);
            this.btnSendCmd.TabIndex = 10;
            this.btnSendCmd.Text = "Send";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(595, 126);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 75);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTopSpeed
            // 
            this.lblTopSpeed.AutoSize = true;
            this.lblTopSpeed.Location = new System.Drawing.Point(399, 82);
            this.lblTopSpeed.Name = "lblTopSpeed";
            this.lblTopSpeed.Size = new System.Drawing.Size(66, 13);
            this.lblTopSpeed.TabIndex = 12;
            this.lblTopSpeed.Text = "Top Speed: ";
            // 
            // lblFuelLvl
            // 
            this.lblFuelLvl.AutoSize = true;
            this.lblFuelLvl.Location = new System.Drawing.Point(686, 82);
            this.lblFuelLvl.Name = "lblFuelLvl";
            this.lblFuelLvl.Size = new System.Drawing.Size(59, 13);
            this.lblFuelLvl.TabIndex = 13;
            this.lblFuelLvl.Text = "Fuel Level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 347);
            this.Controls.Add(this.lblFuelLvl);
            this.Controls.Add(this.lblTopSpeed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSendCmd);
            this.Controls.Add(this.tbSendRaw);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.trackSpeedBar);
            this.Controls.Add(this.btnNewStats);
            this.Controls.Add(this.btnGetFuelLevels);
            this.Controls.Add(this.btnGetSpeed);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnGetSpeed;
        private System.Windows.Forms.Button btnGetFuelLevels;
        private System.Windows.Forms.Timer tmrLifetime;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnNewStats;
        private System.Windows.Forms.TrackBar trackSpeedBar;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox tbSendRaw;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTopSpeed;
        private System.Windows.Forms.Label lblFuelLvl;
    }
}

