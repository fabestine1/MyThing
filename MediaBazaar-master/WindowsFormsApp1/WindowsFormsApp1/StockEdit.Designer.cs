namespace MediaBazar
{
    partial class StockEdit
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
            this.editStockBttn = new System.Windows.Forms.Button();
            this.depoQuantityStock = new System.Windows.Forms.NumericUpDown();
            this.storeQuantityStock = new System.Windows.Forms.NumericUpDown();
            this.stocksEditNameTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pricePerItemTbx = new System.Windows.Forms.NumericUpDown();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depoQuantityStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeQuantityStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerItemTbx)).BeginInit();
            this.SuspendLayout();
            // 
            // editStockBttn
            // 
            this.editStockBttn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStockBttn.Location = new System.Drawing.Point(333, 162);
            this.editStockBttn.Margin = new System.Windows.Forms.Padding(4);
            this.editStockBttn.Name = "editStockBttn";
            this.editStockBttn.Size = new System.Drawing.Size(148, 89);
            this.editStockBttn.TabIndex = 30;
            this.editStockBttn.Text = "Edit";
            this.editStockBttn.UseVisualStyleBackColor = true;
            this.editStockBttn.Click += new System.EventHandler(this.editStockBttn_Click);
            // 
            // depoQuantityStock
            // 
            this.depoQuantityStock.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoQuantityStock.Location = new System.Drawing.Point(185, 162);
            this.depoQuantityStock.Margin = new System.Windows.Forms.Padding(4);
            this.depoQuantityStock.Name = "depoQuantityStock";
            this.depoQuantityStock.Size = new System.Drawing.Size(137, 39);
            this.depoQuantityStock.TabIndex = 29;
            // 
            // storeQuantityStock
            // 
            this.storeQuantityStock.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeQuantityStock.Location = new System.Drawing.Point(185, 210);
            this.storeQuantityStock.Margin = new System.Windows.Forms.Padding(4);
            this.storeQuantityStock.Name = "storeQuantityStock";
            this.storeQuantityStock.Size = new System.Drawing.Size(137, 39);
            this.storeQuantityStock.TabIndex = 27;
            // 
            // stocksEditNameTbx
            // 
            this.stocksEditNameTbx.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksEditNameTbx.Location = new System.Drawing.Point(258, 11);
            this.stocksEditNameTbx.Margin = new System.Windows.Forms.Padding(4);
            this.stocksEditNameTbx.Name = "stocksEditNameTbx";
            this.stocksEditNameTbx.Size = new System.Drawing.Size(220, 39);
            this.stocksEditNameTbx.TabIndex = 26;
            this.stocksEditNameTbx.Text = "Name";
            this.stocksEditNameTbx.Enter += new System.EventHandler(this.stocksEditNameTbx_Enter);
            this.stocksEditNameTbx.Leave += new System.EventHandler(this.stocksEditNameTbx_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Q in store:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Q in depo:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(160, 11);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(62, 33);
            this.idLbl.TabIndex = 17;
            this.idLbl.Text = "(ID)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Stock ID:";
            // 
            // pricePerItemTbx
            // 
            this.pricePerItemTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerItemTbx.Location = new System.Drawing.Point(185, 116);
            this.pricePerItemTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricePerItemTbx.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricePerItemTbx.Name = "pricePerItemTbx";
            this.pricePerItemTbx.Size = new System.Drawing.Size(292, 40);
            this.pricePerItemTbx.TabIndex = 32;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLbl.Location = new System.Drawing.Point(251, 64);
            this.DepartmentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(62, 33);
            this.DepartmentLbl.TabIndex = 34;
            this.DepartmentLbl.Text = "(ID)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Price:";
            // 
            // StockEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricePerItemTbx);
            this.Controls.Add(this.editStockBttn);
            this.Controls.Add(this.depoQuantityStock);
            this.Controls.Add(this.storeQuantityStock);
            this.Controls.Add(this.stocksEditNameTbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockEdit";
            this.Text = "StockEdit";
            ((System.ComponentModel.ISupportInitialize)(this.depoQuantityStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeQuantityStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerItemTbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editStockBttn;
        private System.Windows.Forms.NumericUpDown depoQuantityStock;
        private System.Windows.Forms.NumericUpDown storeQuantityStock;
        private System.Windows.Forms.TextBox stocksEditNameTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pricePerItemTbx;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}