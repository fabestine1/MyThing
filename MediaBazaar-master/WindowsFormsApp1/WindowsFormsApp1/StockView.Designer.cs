namespace MediaBazar
{
    partial class StockView
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.editStockBttn = new System.Windows.Forms.Button();
            this.removeStockBttn = new System.Windows.Forms.Button();
            this.stockNameTbx = new System.Windows.Forms.TextBox();
            this.departmentsCmbbxStockView = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stocksViewLbx = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterStocksBttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editStockBttn
            // 
            this.editStockBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStockBttn.Location = new System.Drawing.Point(20, 94);
            this.editStockBttn.Margin = new System.Windows.Forms.Padding(4);
            this.editStockBttn.Name = "editStockBttn";
            this.editStockBttn.Size = new System.Drawing.Size(213, 48);
            this.editStockBttn.TabIndex = 5;
            this.editStockBttn.Text = "Edit stock";
            this.editStockBttn.UseVisualStyleBackColor = true;
            this.editStockBttn.Click += new System.EventHandler(this.editStockBttn_Click);
            // 
            // removeStockBttn
            // 
            this.removeStockBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStockBttn.Location = new System.Drawing.Point(20, 39);
            this.removeStockBttn.Margin = new System.Windows.Forms.Padding(4);
            this.removeStockBttn.Name = "removeStockBttn";
            this.removeStockBttn.Size = new System.Drawing.Size(213, 46);
            this.removeStockBttn.TabIndex = 4;
            this.removeStockBttn.Text = "Remove stock";
            this.removeStockBttn.UseVisualStyleBackColor = true;
            this.removeStockBttn.Click += new System.EventHandler(this.removeStockBttn_Click);
            // 
            // stockNameTbx
            // 
            this.stockNameTbx.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTbx.Location = new System.Drawing.Point(755, 70);
            this.stockNameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.stockNameTbx.Name = "stockNameTbx";
            this.stockNameTbx.Size = new System.Drawing.Size(249, 39);
            this.stockNameTbx.TabIndex = 13;
            this.stockNameTbx.TabStop = false;
            this.stockNameTbx.Text = "Stock name";
            this.stockNameTbx.Enter += new System.EventHandler(this.stockNameTbx_Enter);
            this.stockNameTbx.Leave += new System.EventHandler(this.stockNameTbx_Leave);
            // 
            // departmentsCmbbxStockView
            // 
            this.departmentsCmbbxStockView.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsCmbbxStockView.FormattingEnabled = true;
            this.departmentsCmbbxStockView.Location = new System.Drawing.Point(755, 14);
            this.departmentsCmbbxStockView.Margin = new System.Windows.Forms.Padding(4);
            this.departmentsCmbbxStockView.Name = "departmentsCmbbxStockView";
            this.departmentsCmbbxStockView.Size = new System.Drawing.Size(249, 40);
            this.departmentsCmbbxStockView.TabIndex = 11;
            this.departmentsCmbbxStockView.Text = "Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editStockBttn);
            this.groupBox1.Controls.Add(this.removeStockBttn);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(755, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(261, 155);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock remove/edit";
            // 
            // stocksViewLbx
            // 
            this.stocksViewLbx.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.stocksViewLbx.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksViewLbx.FullRowSelect = true;
            this.stocksViewLbx.HideSelection = false;
            this.stocksViewLbx.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.stocksViewLbx.Location = new System.Drawing.Point(11, 14);
            this.stocksViewLbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocksViewLbx.MultiSelect = false;
            this.stocksViewLbx.Name = "stocksViewLbx";
            this.stocksViewLbx.Size = new System.Drawing.Size(729, 333);
            this.stocksViewLbx.TabIndex = 14;
            this.stocksViewLbx.UseCompatibleStateImageBehavior = false;
            this.stocksViewLbx.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 5;
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "In Store";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 3;
            this.columnHeader5.Text = "In Depo";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 4;
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 100;
            // 
            // filterStocksBttn
            // 
            this.filterStocksBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterStocksBttn.Location = new System.Drawing.Point(774, 123);
            this.filterStocksBttn.Margin = new System.Windows.Forms.Padding(4);
            this.filterStocksBttn.Name = "filterStocksBttn";
            this.filterStocksBttn.Size = new System.Drawing.Size(213, 44);
            this.filterStocksBttn.TabIndex = 6;
            this.filterStocksBttn.Text = "Filter";
            this.filterStocksBttn.UseVisualStyleBackColor = true;
            this.filterStocksBttn.Click += new System.EventHandler(this.filterStocksBttn_Click);
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 386);
            this.Controls.Add(this.filterStocksBttn);
            this.Controls.Add(this.stocksViewLbx);
            this.Controls.Add(this.stockNameTbx);
            this.Controls.Add(this.departmentsCmbbxStockView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockView";
            this.Text = "StockView";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editStockBttn;
        private System.Windows.Forms.Button removeStockBttn;
        private System.Windows.Forms.TextBox stockNameTbx;
        private System.Windows.Forms.ComboBox departmentsCmbbxStockView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView stocksViewLbx;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button filterStocksBttn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}