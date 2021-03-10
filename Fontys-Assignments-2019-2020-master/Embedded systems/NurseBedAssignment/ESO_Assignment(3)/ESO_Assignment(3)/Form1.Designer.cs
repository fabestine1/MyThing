namespace ESO_Assignment_3_
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
            this.lbxAlarmHistory = new System.Windows.Forms.ListBox();
            this.lblAlarmHistory = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRoomTemp = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxAlarmHistory
            // 
            this.lbxAlarmHistory.FormattingEnabled = true;
            this.lbxAlarmHistory.ItemHeight = 16;
            this.lbxAlarmHistory.Location = new System.Drawing.Point(271, 46);
            this.lbxAlarmHistory.Name = "lbxAlarmHistory";
            this.lbxAlarmHistory.Size = new System.Drawing.Size(274, 228);
            this.lbxAlarmHistory.TabIndex = 0;
            // 
            // lblAlarmHistory
            // 
            this.lblAlarmHistory.AutoSize = true;
            this.lblAlarmHistory.Location = new System.Drawing.Point(268, 26);
            this.lblAlarmHistory.Name = "lblAlarmHistory";
            this.lblAlarmHistory.Size = new System.Drawing.Size(94, 17);
            this.lblAlarmHistory.TabIndex = 1;
            this.lblAlarmHistory.Text = "Alarm history:";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAlarm.Location = new System.Drawing.Point(12, 26);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(48, 17);
            this.lblAlarm.TabIndex = 2;
            this.lblAlarm.Text = "Alarm:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(72, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRoomTemp
            // 
            this.lblRoomTemp.AutoSize = true;
            this.lblRoomTemp.Location = new System.Drawing.Point(14, 257);
            this.lblRoomTemp.Name = "lblRoomTemp";
            this.lblRoomTemp.Size = new System.Drawing.Size(138, 17);
            this.lblRoomTemp.TabIndex = 5;
            this.lblRoomTemp.Text = "Room temperature : ";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(15, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 122);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRoomTemp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.lblAlarmHistory);
            this.Controls.Add(this.lbxAlarmHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAlarmHistory;
        private System.Windows.Forms.Label lblAlarmHistory;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRoomTemp;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

