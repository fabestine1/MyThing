namespace PizzaShopRevisited
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.gbxRevenue = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxOrders = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.lblCurrentDay = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.btBack = new System.Windows.Forms.Button();
            this.gbxRevenue.SuspendLayout();
            this.gbxOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRevenue
            // 
            this.gbxRevenue.Controls.Add(this.btBack);
            this.gbxRevenue.Controls.Add(this.dtpDate);
            this.gbxRevenue.Controls.Add(this.lblCurrentDay);
            this.gbxRevenue.Controls.Add(this.btSearch);
            this.gbxRevenue.Controls.Add(this.lblFormat);
            this.gbxRevenue.Controls.Add(this.lblSelectDate);
            this.gbxRevenue.Controls.Add(this.lblTotalRevenue);
            this.gbxRevenue.Location = new System.Drawing.Point(12, 12);
            this.gbxRevenue.Name = "gbxRevenue";
            this.gbxRevenue.Size = new System.Drawing.Size(491, 264);
            this.gbxRevenue.TabIndex = 0;
            this.gbxRevenue.TabStop = false;
            this.gbxRevenue.Text = "Revenue";
            // 
            // gbxOrders
            // 
            this.gbxOrders.Controls.Add(this.lbxOrders);
            this.gbxOrders.Location = new System.Drawing.Point(12, 282);
            this.gbxOrders.Name = "gbxOrders";
            this.gbxOrders.Size = new System.Drawing.Size(491, 290);
            this.gbxOrders.TabIndex = 1;
            this.gbxOrders.TabStop = false;
            this.gbxOrders.Text = "Orders";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(136, 37);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(224, 25);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Total revenue: €00.00";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(187, 97);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(102, 18);
            this.lblSelectDate.TabIndex = 2;
            this.lblSelectDate.Text = "Select date :";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.Location = new System.Drawing.Point(178, 148);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(119, 13);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "Format(dd/MM/yyyy)";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btSearch.Location = new System.Drawing.Point(168, 164);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(137, 50);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Show";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lblCurrentDay
            // 
            this.lblCurrentDay.AutoSize = true;
            this.lblCurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDay.Location = new System.Drawing.Point(127, 234);
            this.lblCurrentDay.Name = "lblCurrentDay";
            this.lblCurrentDay.Size = new System.Drawing.Size(212, 17);
            this.lblCurrentDay.TabIndex = 5;
            this.lblCurrentDay.Text = "Revenue for that day: €0.00";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(159, 118);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // lbxOrders
            // 
            this.lbxOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.ItemHeight = 16;
            this.lbxOrders.Location = new System.Drawing.Point(6, 33);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(479, 244);
            this.lbxOrders.TabIndex = 7;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btBack.Location = new System.Drawing.Point(378, 0);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(113, 34);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Back!";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(515, 584);
            this.Controls.Add(this.gbxOrders);
            this.Controls.Add(this.gbxRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.gbxRevenue.ResumeLayout(false);
            this.gbxRevenue.PerformLayout();
            this.gbxOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRevenue;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxOrders;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblCurrentDay;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.Button btBack;
    }
}