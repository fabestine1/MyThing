namespace MediaBazar
{
    partial class AddStock
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
            this.addStockNameTbx = new System.Windows.Forms.TextBox();
            this.StockQuantityLbl = new System.Windows.Forms.Label();
            this.indepoQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addStockBttn = new System.Windows.Forms.Button();
            this.departmentsCmbbxAddingStock = new System.Windows.Forms.ComboBox();
            this.inStoreQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.StoreStockQttyLbl = new System.Windows.Forms.Label();
            this.pricePerItemTbx = new System.Windows.Forms.NumericUpDown();
            this.pricePerItemLbl = new System.Windows.Forms.Label();
            this.addStockNameLbl = new System.Windows.Forms.Label();
            this.descriptionTbx = new System.Windows.Forms.RichTextBox();
            this.addStockDescriptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.indepoQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerItemTbx)).BeginInit();
            this.SuspendLayout();
            // 
            // addStockNameTbx
            // 
            this.addStockNameTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockNameTbx.Location = new System.Drawing.Point(27, 41);
            this.addStockNameTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStockNameTbx.Name = "addStockNameTbx";
            this.addStockNameTbx.Size = new System.Drawing.Size(303, 34);
            this.addStockNameTbx.TabIndex = 0;
            this.addStockNameTbx.Text = "Name";
            this.addStockNameTbx.Enter += new System.EventHandler(this.addStockNameTbx_Enter);
            this.addStockNameTbx.Leave += new System.EventHandler(this.addStockNameTbx_Leave);
            // 
            // StockQuantityLbl
            // 
            this.StockQuantityLbl.AutoSize = true;
            this.StockQuantityLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantityLbl.Location = new System.Drawing.Point(21, 261);
            this.StockQuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockQuantityLbl.Name = "StockQuantityLbl";
            this.StockQuantityLbl.Size = new System.Drawing.Size(103, 30);
            this.StockQuantityLbl.TabIndex = 2;
            this.StockQuantityLbl.Text = "In depo:";
            // 
            // indepoQuantityInput
            // 
            this.indepoQuantityInput.CausesValidation = false;
            this.indepoQuantityInput.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indepoQuantityInput.Location = new System.Drawing.Point(27, 294);
            this.indepoQuantityInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.indepoQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.indepoQuantityInput.Name = "indepoQuantityInput";
            this.indepoQuantityInput.Size = new System.Drawing.Size(132, 34);
            this.indepoQuantityInput.TabIndex = 3;
            // 
            // addStockBttn
            // 
            this.addStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockBttn.Location = new System.Drawing.Point(27, 392);
            this.addStockBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStockBttn.Name = "addStockBttn";
            this.addStockBttn.Size = new System.Drawing.Size(302, 42);
            this.addStockBttn.TabIndex = 6;
            this.addStockBttn.Text = "Add Stock";
            this.addStockBttn.UseVisualStyleBackColor = true;
            this.addStockBttn.Click += new System.EventHandler(this.addStockBttn_Click);
            // 
            // departmentsCmbbxAddingStock
            // 
            this.departmentsCmbbxAddingStock.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsCmbbxAddingStock.FormattingEnabled = true;
            this.departmentsCmbbxAddingStock.Location = new System.Drawing.Point(27, 344);
            this.departmentsCmbbxAddingStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentsCmbbxAddingStock.Name = "departmentsCmbbxAddingStock";
            this.departmentsCmbbxAddingStock.Size = new System.Drawing.Size(303, 37);
            this.departmentsCmbbxAddingStock.TabIndex = 5;
            this.departmentsCmbbxAddingStock.Text = "Department";
            // 
            // inStoreQuantityInput
            // 
            this.inStoreQuantityInput.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStoreQuantityInput.Location = new System.Drawing.Point(199, 294);
            this.inStoreQuantityInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inStoreQuantityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.inStoreQuantityInput.Name = "inStoreQuantityInput";
            this.inStoreQuantityInput.Size = new System.Drawing.Size(130, 34);
            this.inStoreQuantityInput.TabIndex = 4;
            // 
            // StoreStockQttyLbl
            // 
            this.StoreStockQttyLbl.AutoSize = true;
            this.StoreStockQttyLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreStockQttyLbl.Location = new System.Drawing.Point(187, 261);
            this.StoreStockQttyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StoreStockQttyLbl.Name = "StoreStockQttyLbl";
            this.StoreStockQttyLbl.Size = new System.Drawing.Size(102, 30);
            this.StoreStockQttyLbl.TabIndex = 7;
            this.StoreStockQttyLbl.Text = "In store:";
            // 
            // pricePerItemTbx
            // 
            this.pricePerItemTbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerItemTbx.Location = new System.Drawing.Point(27, 219);
            this.pricePerItemTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pricePerItemTbx.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricePerItemTbx.Name = "pricePerItemTbx";
            this.pricePerItemTbx.Size = new System.Drawing.Size(302, 34);
            this.pricePerItemTbx.TabIndex = 2;
            // 
            // pricePerItemLbl
            // 
            this.pricePerItemLbl.AutoSize = true;
            this.pricePerItemLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerItemLbl.Location = new System.Drawing.Point(21, 189);
            this.pricePerItemLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricePerItemLbl.Name = "pricePerItemLbl";
            this.pricePerItemLbl.Size = new System.Drawing.Size(173, 30);
            this.pricePerItemLbl.TabIndex = 9;
            this.pricePerItemLbl.Text = "Price per item:";
            // 
            // addStockNameLbl
            // 
            this.addStockNameLbl.AutoSize = true;
            this.addStockNameLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockNameLbl.Location = new System.Drawing.Point(21, 11);
            this.addStockNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addStockNameLbl.Name = "addStockNameLbl";
            this.addStockNameLbl.Size = new System.Drawing.Size(85, 30);
            this.addStockNameLbl.TabIndex = 10;
            this.addStockNameLbl.Text = "Name:";
            // 
            // descriptionTbx
            // 
            this.descriptionTbx.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTbx.Location = new System.Drawing.Point(27, 112);
            this.descriptionTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTbx.MaxLength = 300;
            this.descriptionTbx.Name = "descriptionTbx";
            this.descriptionTbx.Size = new System.Drawing.Size(303, 71);
            this.descriptionTbx.TabIndex = 1;
            this.descriptionTbx.Text = "Description";
            this.descriptionTbx.Enter += new System.EventHandler(this.descriptionTbx_Enter);
            this.descriptionTbx.Leave += new System.EventHandler(this.descriptionTbx_Leave);
            // 
            // addStockDescriptionLbl
            // 
            this.addStockDescriptionLbl.AutoSize = true;
            this.addStockDescriptionLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockDescriptionLbl.Location = new System.Drawing.Point(21, 80);
            this.addStockDescriptionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addStockDescriptionLbl.Name = "addStockDescriptionLbl";
            this.addStockDescriptionLbl.Size = new System.Drawing.Size(146, 30);
            this.addStockDescriptionLbl.TabIndex = 12;
            this.addStockDescriptionLbl.Text = "Description:";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.addStockDescriptionLbl);
            this.Controls.Add(this.descriptionTbx);
            this.Controls.Add(this.addStockNameLbl);
            this.Controls.Add(this.pricePerItemLbl);
            this.Controls.Add(this.pricePerItemTbx);
            this.Controls.Add(this.StoreStockQttyLbl);
            this.Controls.Add(this.inStoreQuantityInput);
            this.Controls.Add(this.departmentsCmbbxAddingStock);
            this.Controls.Add(this.addStockBttn);
            this.Controls.Add(this.indepoQuantityInput);
            this.Controls.Add(this.StockQuantityLbl);
            this.Controls.Add(this.addStockNameTbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStock";
            this.Text = "Add Stock";
            ((System.ComponentModel.ISupportInitialize)(this.indepoQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerItemTbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addStockNameTbx;
        private System.Windows.Forms.Label StockQuantityLbl;
        private System.Windows.Forms.NumericUpDown indepoQuantityInput;
        private System.Windows.Forms.Button addStockBttn;
        private System.Windows.Forms.ComboBox departmentsCmbbxAddingStock;
        private System.Windows.Forms.NumericUpDown inStoreQuantityInput;
        private System.Windows.Forms.Label StoreStockQttyLbl;
        private System.Windows.Forms.NumericUpDown pricePerItemTbx;
        private System.Windows.Forms.Label pricePerItemLbl;
        private System.Windows.Forms.Label addStockNameLbl;
        private System.Windows.Forms.RichTextBox descriptionTbx;
        private System.Windows.Forms.Label addStockDescriptionLbl;
    }
}