namespace project_1._8
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
            this.tbxOrderNumber = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxShippingAddress = new System.Windows.Forms.TextBox();
            this.cbxWhite = new System.Windows.Forms.CheckBox();
            this.cbxBlack = new System.Windows.Forms.CheckBox();
            this.cbxBlue = new System.Windows.Forms.CheckBox();
            this.tbxWhiteQuantity = new System.Windows.Forms.TextBox();
            this.tbxBlackQuantity = new System.Windows.Forms.TextBox();
            this.tbxBlueQuantity = new System.Windows.Forms.TextBox();
            this.tbxTaxRate = new System.Windows.Forms.TextBox();
            this.tbxTotalCost = new System.Windows.Forms.TextBox();
            this.tbxShipCharg = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblWhiteQuantity = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblShipCharg = new System.Windows.Forms.Label();
            this.lblBlackQuantity = new System.Windows.Forms.Label();
            this.lblBlueQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxOrderNumber
            // 
            this.tbxOrderNumber.AccessibleDescription = "";
            this.tbxOrderNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxOrderNumber.Location = new System.Drawing.Point(23, 22);
            this.tbxOrderNumber.Name = "tbxOrderNumber";
            this.tbxOrderNumber.Size = new System.Drawing.Size(194, 20);
            this.tbxOrderNumber.TabIndex = 1;
            this.tbxOrderNumber.Text = "Order number";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxCustomerName.Location = new System.Drawing.Point(23, 48);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(194, 20);
            this.tbxCustomerName.TabIndex = 2;
            this.tbxCustomerName.Text = "Customer name";
            // 
            // tbxShippingAddress
            // 
            this.tbxShippingAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxShippingAddress.Location = new System.Drawing.Point(23, 74);
            this.tbxShippingAddress.Name = "tbxShippingAddress";
            this.tbxShippingAddress.Size = new System.Drawing.Size(194, 20);
            this.tbxShippingAddress.TabIndex = 3;
            this.tbxShippingAddress.Text = "Shipping address";
            // 
            // cbxWhite
            // 
            this.cbxWhite.AutoSize = true;
            this.cbxWhite.Location = new System.Drawing.Point(23, 114);
            this.cbxWhite.Name = "cbxWhite";
            this.cbxWhite.Size = new System.Drawing.Size(54, 17);
            this.cbxWhite.TabIndex = 4;
            this.cbxWhite.Text = "White";
            this.cbxWhite.UseVisualStyleBackColor = true;
            this.cbxWhite.CheckedChanged += new System.EventHandler(this.cbxWhite_CheckedChanged);
            // 
            // cbxBlack
            // 
            this.cbxBlack.AutoSize = true;
            this.cbxBlack.Location = new System.Drawing.Point(23, 140);
            this.cbxBlack.Name = "cbxBlack";
            this.cbxBlack.Size = new System.Drawing.Size(53, 17);
            this.cbxBlack.TabIndex = 5;
            this.cbxBlack.Text = "Black";
            this.cbxBlack.UseVisualStyleBackColor = true;
            this.cbxBlack.CheckedChanged += new System.EventHandler(this.cbxBlack_CheckedChanged);
            // 
            // cbxBlue
            // 
            this.cbxBlue.AutoSize = true;
            this.cbxBlue.Location = new System.Drawing.Point(23, 166);
            this.cbxBlue.Name = "cbxBlue";
            this.cbxBlue.Size = new System.Drawing.Size(47, 17);
            this.cbxBlue.TabIndex = 6;
            this.cbxBlue.Text = "Blue";
            this.cbxBlue.UseVisualStyleBackColor = true;
            this.cbxBlue.CheckedChanged += new System.EventHandler(this.cbxBlue_CheckedChanged);
            // 
            // tbxWhiteQuantity
            // 
            this.tbxWhiteQuantity.Enabled = false;
            this.tbxWhiteQuantity.Location = new System.Drawing.Point(186, 112);
            this.tbxWhiteQuantity.Name = "tbxWhiteQuantity";
            this.tbxWhiteQuantity.Size = new System.Drawing.Size(31, 20);
            this.tbxWhiteQuantity.TabIndex = 8;
            this.tbxWhiteQuantity.Text = "0";
            this.tbxWhiteQuantity.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            // 
            // tbxBlackQuantity
            // 
            this.tbxBlackQuantity.Enabled = false;
            this.tbxBlackQuantity.Location = new System.Drawing.Point(186, 138);
            this.tbxBlackQuantity.Name = "tbxBlackQuantity";
            this.tbxBlackQuantity.Size = new System.Drawing.Size(31, 20);
            this.tbxBlackQuantity.TabIndex = 9;
            this.tbxBlackQuantity.Text = "0";
            this.tbxBlackQuantity.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            // 
            // tbxBlueQuantity
            // 
            this.tbxBlueQuantity.Enabled = false;
            this.tbxBlueQuantity.Location = new System.Drawing.Point(186, 164);
            this.tbxBlueQuantity.Name = "tbxBlueQuantity";
            this.tbxBlueQuantity.Size = new System.Drawing.Size(31, 20);
            this.tbxBlueQuantity.TabIndex = 10;
            this.tbxBlueQuantity.Text = "0";
            this.tbxBlueQuantity.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            // 
            // tbxTaxRate
            // 
            this.tbxTaxRate.Location = new System.Drawing.Point(134, 262);
            this.tbxTaxRate.Name = "tbxTaxRate";
            this.tbxTaxRate.ReadOnly = true;
            this.tbxTaxRate.Size = new System.Drawing.Size(83, 20);
            this.tbxTaxRate.TabIndex = 13;
            // 
            // tbxTotalCost
            // 
            this.tbxTotalCost.Location = new System.Drawing.Point(134, 236);
            this.tbxTotalCost.Name = "tbxTotalCost";
            this.tbxTotalCost.ReadOnly = true;
            this.tbxTotalCost.Size = new System.Drawing.Size(83, 20);
            this.tbxTotalCost.TabIndex = 12;
            // 
            // tbxShipCharg
            // 
            this.tbxShipCharg.Location = new System.Drawing.Point(134, 288);
            this.tbxShipCharg.Name = "tbxShipCharg";
            this.tbxShipCharg.ReadOnly = true;
            this.tbxShipCharg.Size = new System.Drawing.Size(83, 20);
            this.tbxShipCharg.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(142, 327);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblWhiteQuantity
            // 
            this.lblWhiteQuantity.AutoSize = true;
            this.lblWhiteQuantity.Location = new System.Drawing.Point(131, 115);
            this.lblWhiteQuantity.Name = "lblWhiteQuantity";
            this.lblWhiteQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblWhiteQuantity.TabIndex = 16;
            this.lblWhiteQuantity.Text = "Quantity:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(19, 239);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(57, 13);
            this.lblTotalCost.TabIndex = 20;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(20, 265);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(49, 13);
            this.lblTaxRate.TabIndex = 21;
            this.lblTaxRate.Text = "Tax rate:";
            // 
            // lblShipCharg
            // 
            this.lblShipCharg.AutoSize = true;
            this.lblShipCharg.Location = new System.Drawing.Point(20, 291);
            this.lblShipCharg.Name = "lblShipCharg";
            this.lblShipCharg.Size = new System.Drawing.Size(92, 13);
            this.lblShipCharg.TabIndex = 22;
            this.lblShipCharg.Text = "Shipping charges:";
            // 
            // lblBlackQuantity
            // 
            this.lblBlackQuantity.AutoSize = true;
            this.lblBlackQuantity.Location = new System.Drawing.Point(131, 141);
            this.lblBlackQuantity.Name = "lblBlackQuantity";
            this.lblBlackQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblBlackQuantity.TabIndex = 17;
            this.lblBlackQuantity.Text = "Quantity:";
            // 
            // lblBlueQuantity
            // 
            this.lblBlueQuantity.AutoSize = true;
            this.lblBlueQuantity.Location = new System.Drawing.Point(131, 167);
            this.lblBlueQuantity.Name = "lblBlueQuantity";
            this.lblBlueQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblBlueQuantity.TabIndex = 18;
            this.lblBlueQuantity.Text = "Quantity:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 358);
            this.Controls.Add(this.lblShipCharg);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblBlueQuantity);
            this.Controls.Add(this.lblBlackQuantity);
            this.Controls.Add(this.lblWhiteQuantity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxShipCharg);
            this.Controls.Add(this.tbxTotalCost);
            this.Controls.Add(this.tbxTaxRate);
            this.Controls.Add(this.tbxBlueQuantity);
            this.Controls.Add(this.tbxBlackQuantity);
            this.Controls.Add(this.tbxWhiteQuantity);
            this.Controls.Add(this.cbxBlue);
            this.Controls.Add(this.cbxBlack);
            this.Controls.Add(this.cbxWhite);
            this.Controls.Add(this.tbxShippingAddress);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.tbxOrderNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOrderNumber;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxShippingAddress;
        private System.Windows.Forms.CheckBox cbxWhite;
        private System.Windows.Forms.CheckBox cbxBlack;
        private System.Windows.Forms.CheckBox cbxBlue;
        private System.Windows.Forms.TextBox tbxWhiteQuantity;
        private System.Windows.Forms.TextBox tbxBlackQuantity;
        private System.Windows.Forms.TextBox tbxBlueQuantity;
        private System.Windows.Forms.TextBox tbxTaxRate;
        private System.Windows.Forms.TextBox tbxTotalCost;
        private System.Windows.Forms.TextBox tbxShipCharg;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWhiteQuantity;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label lblShipCharg;
        private System.Windows.Forms.Label lblBlackQuantity;
        private System.Windows.Forms.Label lblBlueQuantity;
    }
}

