namespace MediaBazar
{
    partial class RequestStock
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
            this.requestStockQttyLbl = new System.Windows.Forms.Label();
            this.requestStockQtty = new System.Windows.Forms.NumericUpDown();
            this.requestStockBttn = new System.Windows.Forms.Button();
            this.requestStockStocksCmbbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.requestStockQtty)).BeginInit();
            this.SuspendLayout();
            // 
            // requestStockQttyLbl
            // 
            this.requestStockQttyLbl.AutoSize = true;
            this.requestStockQttyLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestStockQttyLbl.Location = new System.Drawing.Point(38, 261);
            this.requestStockQttyLbl.Name = "requestStockQttyLbl";
            this.requestStockQttyLbl.Size = new System.Drawing.Size(169, 44);
            this.requestStockQttyLbl.TabIndex = 21;
            this.requestStockQttyLbl.Text = "Quantity:";
            // 
            // requestStockQtty
            // 
            this.requestStockQtty.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestStockQtty.Location = new System.Drawing.Point(255, 258);
            this.requestStockQtty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestStockQtty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.requestStockQtty.Name = "requestStockQtty";
            this.requestStockQtty.Size = new System.Drawing.Size(195, 47);
            this.requestStockQtty.TabIndex = 20;
            // 
            // requestStockBttn
            // 
            this.requestStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestStockBttn.Location = new System.Drawing.Point(19, 347);
            this.requestStockBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestStockBttn.Name = "requestStockBttn";
            this.requestStockBttn.Size = new System.Drawing.Size(453, 65);
            this.requestStockBttn.TabIndex = 18;
            this.requestStockBttn.Text = "Request Stock";
            this.requestStockBttn.UseVisualStyleBackColor = true;
            this.requestStockBttn.Click += new System.EventHandler(this.requestStockBttn_Click);
            // 
            // requestStockStocksCmbbx
            // 
            this.requestStockStocksCmbbx.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestStockStocksCmbbx.FormattingEnabled = true;
            this.requestStockStocksCmbbx.Location = new System.Drawing.Point(29, 41);
            this.requestStockStocksCmbbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestStockStocksCmbbx.Name = "requestStockStocksCmbbx";
            this.requestStockStocksCmbbx.Size = new System.Drawing.Size(432, 52);
            this.requestStockStocksCmbbx.TabIndex = 19;
            this.requestStockStocksCmbbx.Text = "Stock";
            // 
            // RequestStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 430);
            this.Controls.Add(this.requestStockQttyLbl);
            this.Controls.Add(this.requestStockQtty);
            this.Controls.Add(this.requestStockStocksCmbbx);
            this.Controls.Add(this.requestStockBttn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestStock";
            this.Text = "RequestStock";
            ((System.ComponentModel.ISupportInitialize)(this.requestStockQtty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requestStockQttyLbl;
        private System.Windows.Forms.NumericUpDown requestStockQtty;
        private System.Windows.Forms.Button requestStockBttn;
        private System.Windows.Forms.ComboBox requestStockStocksCmbbx;
    }
}