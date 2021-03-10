namespace _1._2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.track = new System.Windows.Forms.TrackBar();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lProgress = new System.Windows.Forms.Label();
            this.CrimsonBack = new System.Windows.Forms.RadioButton();
            this.IndigoBack = new System.Windows.Forms.RadioButton();
            this.CyanBack = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(158, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click To Die";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(403, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // track
            // 
            this.track.BackColor = System.Drawing.Color.DarkMagenta;
            this.track.Location = new System.Drawing.Point(90, 140);
            this.track.Maximum = 69;
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(500, 45);
            this.track.TabIndex = 2;
            this.track.Value = 31;
            this.track.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(90, 43);
            this.progress.Maximum = 69;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(500, 46);
            this.progress.TabIndex = 3;
            this.progress.Value = 31;
            this.progress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProgress.Location = new System.Drawing.Point(22, 56);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(30, 24);
            this.lProgress.TabIndex = 4;
            this.lProgress.Text = "31";
            this.lProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CrimsonBack
            // 
            this.CrimsonBack.AutoSize = true;
            this.CrimsonBack.BackColor = System.Drawing.Color.Crimson;
            this.CrimsonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrimsonBack.Location = new System.Drawing.Point(674, 72);
            this.CrimsonBack.Name = "CrimsonBack";
            this.CrimsonBack.Size = new System.Drawing.Size(205, 28);
            this.CrimsonBack.TabIndex = 5;
            this.CrimsonBack.TabStop = true;
            this.CrimsonBack.Text = "Crimson Background";
            this.CrimsonBack.UseVisualStyleBackColor = false;
            this.CrimsonBack.CheckedChanged += new System.EventHandler(this.CrimsonBack_CheckedChanged);
            // 
            // IndigoBack
            // 
            this.IndigoBack.AutoSize = true;
            this.IndigoBack.BackColor = System.Drawing.Color.Indigo;
            this.IndigoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndigoBack.Location = new System.Drawing.Point(673, 140);
            this.IndigoBack.Name = "IndigoBack";
            this.IndigoBack.Size = new System.Drawing.Size(187, 28);
            this.IndigoBack.TabIndex = 6;
            this.IndigoBack.TabStop = true;
            this.IndigoBack.Text = "Indigo Background";
            this.IndigoBack.UseVisualStyleBackColor = false;
            this.IndigoBack.CheckedChanged += new System.EventHandler(this.IndigoBack_CheckedChanged);
            // 
            // CyanBack
            // 
            this.CyanBack.AutoSize = true;
            this.CyanBack.BackColor = System.Drawing.Color.Cyan;
            this.CyanBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CyanBack.Location = new System.Drawing.Point(674, 106);
            this.CyanBack.Name = "CyanBack";
            this.CyanBack.Size = new System.Drawing.Size(178, 28);
            this.CyanBack.TabIndex = 7;
            this.CyanBack.TabStop = true;
            this.CyanBack.Text = "Cyan Background";
            this.CyanBack.UseVisualStyleBackColor = false;
            this.CyanBack.CheckedChanged += new System.EventHandler(this.CyanBack_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(890, 297);
            this.Controls.Add(this.CyanBack);
            this.Controls.Add(this.IndigoBack);
            this.Controls.Add(this.CrimsonBack);
            this.Controls.Add(this.lProgress);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.track);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "1.2";
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar track;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lProgress;
        private System.Windows.Forms.RadioButton CrimsonBack;
        private System.Windows.Forms.RadioButton IndigoBack;
        private System.Windows.Forms.RadioButton CyanBack;
    }
}

