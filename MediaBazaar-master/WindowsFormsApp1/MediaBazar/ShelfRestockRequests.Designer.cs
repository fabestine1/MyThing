namespace MediaBazar
{
    partial class ShelfRestockRequests
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.shelfRestockView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exportToExcelBttn = new System.Windows.Forms.Button();
            this.exportToCsvBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shelfRestockView
            // 
            this.shelfRestockView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.shelfRestockView.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfRestockView.HideSelection = false;
            this.shelfRestockView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.shelfRestockView.Location = new System.Drawing.Point(42, 39);
            this.shelfRestockView.Name = "shelfRestockView";
            this.shelfRestockView.Size = new System.Drawing.Size(1128, 415);
            this.shelfRestockView.TabIndex = 0;
            this.shelfRestockView.UseCompatibleStateImageBehavior = false;
            this.shelfRestockView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Arrival Date";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 500;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 200;
            // 
            // exportToExcelBttn
            // 
            this.exportToExcelBttn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToExcelBttn.Location = new System.Drawing.Point(656, 490);
            this.exportToExcelBttn.Name = "exportToExcelBttn";
            this.exportToExcelBttn.Size = new System.Drawing.Size(514, 63);
            this.exportToExcelBttn.TabIndex = 1;
            this.exportToExcelBttn.Text = "Export to Excel";
            this.exportToExcelBttn.UseVisualStyleBackColor = true;
            this.exportToExcelBttn.Click += new System.EventHandler(this.exportToExcelBttn_Click);
            // 
            // exportToCsvBttn
            // 
            this.exportToCsvBttn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToCsvBttn.Location = new System.Drawing.Point(42, 490);
            this.exportToCsvBttn.Name = "exportToCsvBttn";
            this.exportToCsvBttn.Size = new System.Drawing.Size(530, 63);
            this.exportToCsvBttn.TabIndex = 2;
            this.exportToCsvBttn.Text = " Export to CSV";
            this.exportToCsvBttn.UseVisualStyleBackColor = true;
            this.exportToCsvBttn.Click += new System.EventHandler(this.exportToCsvBttn_Click);
            // 
            // ShelfRestockRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 593);
            this.Controls.Add(this.exportToCsvBttn);
            this.Controls.Add(this.exportToExcelBttn);
            this.Controls.Add(this.shelfRestockView);
            this.Name = "ShelfRestockRequests";
            this.Text = "Shelf Restock Requests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView shelfRestockView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button exportToExcelBttn;
        private System.Windows.Forms.Button exportToCsvBttn;
    }
}