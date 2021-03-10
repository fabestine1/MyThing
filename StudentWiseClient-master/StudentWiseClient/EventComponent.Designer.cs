namespace StudentWiseClient
{
    partial class EventComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventComponent));
            this.EventTypeLbl = new System.Windows.Forms.Label();
            this.EventTitleLbl = new System.Windows.Forms.Label();
            this.EventDescriptionLbl = new System.Windows.Forms.Label();
            this.EventDeadlineLbl = new System.Windows.Forms.Label();
            this.EventPointsLbl = new System.Windows.Forms.Label();
            this.DeleteEventPbx = new System.Windows.Forms.PictureBox();
            this.EventCompletePbx = new System.Windows.Forms.PictureBox();
            this.ImagePbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEventPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventCompletePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePbx)).BeginInit();
            this.SuspendLayout();
            // 
            // EventTypeLbl
            // 
            this.EventTypeLbl.AutoEllipsis = true;
            this.EventTypeLbl.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTypeLbl.Location = new System.Drawing.Point(130, 20);
            this.EventTypeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.EventTypeLbl.Name = "EventTypeLbl";
            this.EventTypeLbl.Size = new System.Drawing.Size(100, 32);
            this.EventTypeLbl.TabIndex = 1;
            this.EventTypeLbl.Text = "KIND";
            // 
            // EventTitleLbl
            // 
            this.EventTitleLbl.AutoEllipsis = true;
            this.EventTitleLbl.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold);
            this.EventTitleLbl.Location = new System.Drawing.Point(130, 52);
            this.EventTitleLbl.Margin = new System.Windows.Forms.Padding(0);
            this.EventTitleLbl.Name = "EventTitleLbl";
            this.EventTitleLbl.Size = new System.Drawing.Size(450, 68);
            this.EventTitleLbl.TabIndex = 2;
            this.EventTitleLbl.Text = "Event Title";
            // 
            // EventDescriptionLbl
            // 
            this.EventDescriptionLbl.AutoEllipsis = true;
            this.EventDescriptionLbl.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDescriptionLbl.Location = new System.Drawing.Point(20, 130);
            this.EventDescriptionLbl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.EventDescriptionLbl.Name = "EventDescriptionLbl";
            this.EventDescriptionLbl.Size = new System.Drawing.Size(560, 80);
            this.EventDescriptionLbl.TabIndex = 3;
            this.EventDescriptionLbl.Text = "Event Description";
            // 
            // EventDeadlineLbl
            // 
            this.EventDeadlineLbl.AutoEllipsis = true;
            this.EventDeadlineLbl.Font = new System.Drawing.Font("Oswald", 7.8F);
            this.EventDeadlineLbl.Location = new System.Drawing.Point(230, 20);
            this.EventDeadlineLbl.Margin = new System.Windows.Forms.Padding(0);
            this.EventDeadlineLbl.Name = "EventDeadlineLbl";
            this.EventDeadlineLbl.Size = new System.Drawing.Size(350, 24);
            this.EventDeadlineLbl.TabIndex = 4;
            this.EventDeadlineLbl.Text = "Start Date and End Date";
            this.EventDeadlineLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EventPointsLbl
            // 
            this.EventPointsLbl.AutoEllipsis = true;
            this.EventPointsLbl.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPointsLbl.Location = new System.Drawing.Point(20, 245);
            this.EventPointsLbl.Margin = new System.Windows.Forms.Padding(0);
            this.EventPointsLbl.Name = "EventPointsLbl";
            this.EventPointsLbl.Size = new System.Drawing.Size(260, 35);
            this.EventPointsLbl.TabIndex = 6;
            this.EventPointsLbl.Text = "Karma: 0";
            this.EventPointsLbl.Visible = false;
            // 
            // DeleteEventPbx
            // 
            this.DeleteEventPbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(66)))), ((int)(((byte)(63)))));
            this.DeleteEventPbx.Image = ((System.Drawing.Image)(resources.GetObject("DeleteEventPbx.Image")));
            this.DeleteEventPbx.Location = new System.Drawing.Point(450, 220);
            this.DeleteEventPbx.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeleteEventPbx.Name = "DeleteEventPbx";
            this.DeleteEventPbx.Padding = new System.Windows.Forms.Padding(10);
            this.DeleteEventPbx.Size = new System.Drawing.Size(60, 60);
            this.DeleteEventPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteEventPbx.TabIndex = 9;
            this.DeleteEventPbx.TabStop = false;
            this.DeleteEventPbx.Click += new System.EventHandler(this.DeleteEventPbx_Click);
            // 
            // EventCompletePbx
            // 
            this.EventCompletePbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.EventCompletePbx.Image = global::StudentWiseClient.Properties.Resources.kisspng_check_mark_symbol_icon_black_checkmark_5a76d35a732948_8416047115177367944717;
            this.EventCompletePbx.Location = new System.Drawing.Point(520, 220);
            this.EventCompletePbx.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EventCompletePbx.Name = "EventCompletePbx";
            this.EventCompletePbx.Padding = new System.Windows.Forms.Padding(10);
            this.EventCompletePbx.Size = new System.Drawing.Size(60, 60);
            this.EventCompletePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventCompletePbx.TabIndex = 8;
            this.EventCompletePbx.TabStop = false;
            this.EventCompletePbx.Click += new System.EventHandler(this.EventCompletePbx_Click);
            // 
            // ImagePbx
            // 
            this.ImagePbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImagePbx.Location = new System.Drawing.Point(20, 20);
            this.ImagePbx.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.ImagePbx.Name = "ImagePbx";
            this.ImagePbx.Size = new System.Drawing.Size(100, 100);
            this.ImagePbx.TabIndex = 0;
            this.ImagePbx.TabStop = false;
            // 
            // EventComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DeleteEventPbx);
            this.Controls.Add(this.EventCompletePbx);
            this.Controls.Add(this.EventPointsLbl);
            this.Controls.Add(this.EventTypeLbl);
            this.Controls.Add(this.EventTitleLbl);
            this.Controls.Add(this.EventDeadlineLbl);
            this.Controls.Add(this.EventDescriptionLbl);
            this.Controls.Add(this.ImagePbx);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EventComponent";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(600, 300);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEventPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventCompletePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePbx;
        private System.Windows.Forms.Label EventTypeLbl;
        private System.Windows.Forms.Label EventTitleLbl;
        private System.Windows.Forms.Label EventDescriptionLbl;
        private System.Windows.Forms.Label EventDeadlineLbl;
        private System.Windows.Forms.Label EventPointsLbl;
        private System.Windows.Forms.PictureBox EventCompletePbx;
        private System.Windows.Forms.PictureBox DeleteEventPbx;
    }
}
