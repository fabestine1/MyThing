namespace project_2._2
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.btnBigger = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnBigger2 = new System.Windows.Forms.Button();
            this.btnSmaller2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.pbTrafficLight2 = new System.Windows.Forms.PictureBox();
            this.timerTrafficLightLeft = new System.Windows.Forms.Timer(this.components);
            this.timerTrafficLightRight = new System.Windows.Forms.Timer(this.components);
            this.btnStartSync = new System.Windows.Forms.Button();
            this.timerSync = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.btnSmaller);
            this.panelLeft.Controls.Add(this.pbTrafficLight);
            this.panelLeft.Controls.Add(this.btnBigger);
            this.panelLeft.Controls.Add(this.btnStart);
            this.panelLeft.Location = new System.Drawing.Point(12, 28);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(326, 403);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(183, 365);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(75, 23);
            this.btnSmaller.TabIndex = 3;
            this.btnSmaller.Text = "SMALLER";
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbTrafficLight.Location = new System.Drawing.Point(27, 12);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(139, 318);
            this.pbTrafficLight.TabIndex = 2;
            this.pbTrafficLight.TabStop = false;
            this.pbTrafficLight.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTrafficLight_Paint);
            // 
            // btnBigger
            // 
            this.btnBigger.Location = new System.Drawing.Point(27, 365);
            this.btnBigger.Name = "btnBigger";
            this.btnBigger.Size = new System.Drawing.Size(75, 23);
            this.btnBigger.TabIndex = 2;
            this.btnBigger.Text = "BIGGER";
            this.btnBigger.UseVisualStyleBackColor = true;
            this.btnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(204, 156);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelRight.Controls.Add(this.btnBigger2);
            this.panelRight.Controls.Add(this.btnSmaller2);
            this.panelRight.Controls.Add(this.btnStart2);
            this.panelRight.Controls.Add(this.pbTrafficLight2);
            this.panelRight.Location = new System.Drawing.Point(374, 28);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(326, 403);
            this.panelRight.TabIndex = 0;
            // 
            // btnBigger2
            // 
            this.btnBigger2.Location = new System.Drawing.Point(39, 365);
            this.btnBigger2.Name = "btnBigger2";
            this.btnBigger2.Size = new System.Drawing.Size(75, 23);
            this.btnBigger2.TabIndex = 4;
            this.btnBigger2.Text = "BIGGER";
            this.btnBigger2.UseVisualStyleBackColor = true;
            this.btnBigger2.Click += new System.EventHandler(this.btnBigger2_Click);
            // 
            // btnSmaller2
            // 
            this.btnSmaller2.Location = new System.Drawing.Point(167, 365);
            this.btnSmaller2.Name = "btnSmaller2";
            this.btnSmaller2.Size = new System.Drawing.Size(75, 23);
            this.btnSmaller2.TabIndex = 5;
            this.btnSmaller2.Text = "SMALLER";
            this.btnSmaller2.UseVisualStyleBackColor = true;
            this.btnSmaller2.Click += new System.EventHandler(this.btnSmaller2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Enabled = false;
            this.btnStart2.Location = new System.Drawing.Point(196, 156);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 44);
            this.btnStart2.TabIndex = 2;
            this.btnStart2.Text = "START";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnChangeColor2_Click);
            // 
            // pbTrafficLight2
            // 
            this.pbTrafficLight2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbTrafficLight2.Location = new System.Drawing.Point(15, 12);
            this.pbTrafficLight2.Name = "pbTrafficLight2";
            this.pbTrafficLight2.Size = new System.Drawing.Size(139, 318);
            this.pbTrafficLight2.TabIndex = 1;
            this.pbTrafficLight2.TabStop = false;
            this.pbTrafficLight2.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTrafficLight2_Paint);
            // 
            // timerTrafficLightLeft
            // 
            this.timerTrafficLightLeft.Tick += new System.EventHandler(this.timerTrafficLightLeft_Tick);
            // 
            // timerTrafficLightRight
            // 
            this.timerTrafficLightRight.Tick += new System.EventHandler(this.timerTrafficLightRight_Tick);
            // 
            // btnStartSync
            // 
            this.btnStartSync.Location = new System.Drawing.Point(318, 468);
            this.btnStartSync.Name = "btnStartSync";
            this.btnStartSync.Size = new System.Drawing.Size(75, 23);
            this.btnStartSync.TabIndex = 1;
            this.btnStartSync.Text = "START";
            this.btnStartSync.UseVisualStyleBackColor = true;
            this.btnStartSync.Click += new System.EventHandler(this.btnStartSync_Click);
            // 
            // timerSync
            // 
            this.timerSync.Tick += new System.EventHandler(this.timerSync_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 503);
            this.Controls.Add(this.btnStartSync);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBigger2;
        private System.Windows.Forms.Button btnSmaller2;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.PictureBox pbTrafficLight2;
        private System.Windows.Forms.Timer timerTrafficLightLeft;
        private System.Windows.Forms.Timer timerTrafficLightRight;
        private System.Windows.Forms.Button btnStartSync;
        private System.Windows.Forms.Timer timerSync;
    }
}

