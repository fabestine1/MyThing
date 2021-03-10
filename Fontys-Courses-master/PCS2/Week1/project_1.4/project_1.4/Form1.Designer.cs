namespace project_1._4
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
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.tbxEuro = new System.Windows.Forms.TextBox();
            this.tbxDollar = new System.Windows.Forms.TextBox();
            this.btnToEuro = new System.Windows.Forms.Button();
            this.btnToDollar = new System.Windows.Forms.Button();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.exchangeRate = new System.Windows.Forms.NumericUpDown();
            this.madeBy = new System.Windows.Forms.Button();
            this.rbtnDollar = new System.Windows.Forms.RadioButton();
            this.rbtnYuan = new System.Windows.Forms.RadioButton();
            this.rbtnRupee = new System.Windows.Forms.RadioButton();
            this.rbtnLev = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDollar.Location = new System.Drawing.Point(584, 55);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(99, 108);
            this.lblDollar.TabIndex = 0;
            this.lblDollar.Text = "$";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEuro.Location = new System.Drawing.Point(32, 55);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(99, 108);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "€";
            // 
            // tbxEuro
            // 
            this.tbxEuro.Location = new System.Drawing.Point(120, 102);
            this.tbxEuro.Name = "tbxEuro";
            this.tbxEuro.Size = new System.Drawing.Size(172, 20);
            this.tbxEuro.TabIndex = 1;
            this.tbxEuro.TextChanged += new System.EventHandler(this.tbxEuro_TextChanged);
            // 
            // tbxDollar
            // 
            this.tbxDollar.Location = new System.Drawing.Point(416, 102);
            this.tbxDollar.Name = "tbxDollar";
            this.tbxDollar.Size = new System.Drawing.Size(172, 20);
            this.tbxDollar.TabIndex = 1;
            // 
            // btnToEuro
            // 
            this.btnToEuro.Location = new System.Drawing.Point(298, 99);
            this.btnToEuro.Name = "btnToEuro";
            this.btnToEuro.Size = new System.Drawing.Size(44, 23);
            this.btnToEuro.TabIndex = 2;
            this.btnToEuro.Text = "<";
            this.btnToEuro.UseVisualStyleBackColor = true;
            this.btnToEuro.Click += new System.EventHandler(this.btnToEuro_Click);
            // 
            // btnToDollar
            // 
            this.btnToDollar.Location = new System.Drawing.Point(366, 99);
            this.btnToDollar.Name = "btnToDollar";
            this.btnToDollar.Size = new System.Drawing.Size(44, 23);
            this.btnToDollar.TabIndex = 2;
            this.btnToDollar.Text = ">";
            this.btnToDollar.UseVisualStyleBackColor = true;
            this.btnToDollar.Click += new System.EventHandler(this.btnToDollar_Click);
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(228, 150);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(133, 13);
            this.lblExchangeRate.TabIndex = 3;
            this.lblExchangeRate.Text = "Exchannge rate 1 euro = $";
            this.lblExchangeRate.Click += new System.EventHandler(this.lblExchangeRate_Click);
            // 
            // exchangeRate
            // 
            this.exchangeRate.DecimalPlaces = 2;
            this.exchangeRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.exchangeRate.Location = new System.Drawing.Point(393, 148);
            this.exchangeRate.Name = "exchangeRate";
            this.exchangeRate.Size = new System.Drawing.Size(120, 20);
            this.exchangeRate.TabIndex = 4;
            this.exchangeRate.ValueChanged += new System.EventHandler(this.exchangeRate_ValueChanged);
            // 
            // madeBy
            // 
            this.madeBy.Location = new System.Drawing.Point(579, 205);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(75, 23);
            this.madeBy.TabIndex = 5;
            this.madeBy.Text = "Made by";
            this.madeBy.UseVisualStyleBackColor = true;
            this.madeBy.Click += new System.EventHandler(this.madeBy_Click);
            // 
            // rbtnDollar
            // 
            this.rbtnDollar.AutoSize = true;
            this.rbtnDollar.Checked = true;
            this.rbtnDollar.Location = new System.Drawing.Point(231, 179);
            this.rbtnDollar.Name = "rbtnDollar";
            this.rbtnDollar.Size = new System.Drawing.Size(52, 17);
            this.rbtnDollar.TabIndex = 6;
            this.rbtnDollar.TabStop = true;
            this.rbtnDollar.Text = "Dollar";
            this.rbtnDollar.UseVisualStyleBackColor = true;
            this.rbtnDollar.CheckedChanged += new System.EventHandler(this.rbtnDollar_CheckedChanged);
            // 
            // rbtnYuan
            // 
            this.rbtnYuan.AutoSize = true;
            this.rbtnYuan.Location = new System.Drawing.Point(292, 179);
            this.rbtnYuan.Name = "rbtnYuan";
            this.rbtnYuan.Size = new System.Drawing.Size(50, 17);
            this.rbtnYuan.TabIndex = 7;
            this.rbtnYuan.TabStop = true;
            this.rbtnYuan.Text = "Yuan";
            this.rbtnYuan.UseVisualStyleBackColor = true;
            this.rbtnYuan.CheckedChanged += new System.EventHandler(this.rbtnYuan_CheckedChanged);
            // 
            // rbtnRupee
            // 
            this.rbtnRupee.AutoSize = true;
            this.rbtnRupee.Location = new System.Drawing.Point(348, 179);
            this.rbtnRupee.Name = "rbtnRupee";
            this.rbtnRupee.Size = new System.Drawing.Size(57, 17);
            this.rbtnRupee.TabIndex = 8;
            this.rbtnRupee.TabStop = true;
            this.rbtnRupee.Text = "Rupee";
            this.rbtnRupee.UseVisualStyleBackColor = true;
            this.rbtnRupee.CheckedChanged += new System.EventHandler(this.rbtnRupee_CheckedChanged);
            // 
            // rbtnLev
            // 
            this.rbtnLev.AutoSize = true;
            this.rbtnLev.Location = new System.Drawing.Point(411, 179);
            this.rbtnLev.Name = "rbtnLev";
            this.rbtnLev.Size = new System.Drawing.Size(43, 17);
            this.rbtnLev.TabIndex = 9;
            this.rbtnLev.TabStop = true;
            this.rbtnLev.Text = "Lev";
            this.rbtnLev.UseVisualStyleBackColor = true;
            this.rbtnLev.CheckedChanged += new System.EventHandler(this.rbtnLev_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 240);
            this.Controls.Add(this.rbtnLev);
            this.Controls.Add(this.rbtnRupee);
            this.Controls.Add(this.rbtnYuan);
            this.Controls.Add(this.rbtnDollar);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.exchangeRate);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.btnToDollar);
            this.Controls.Add(this.btnToEuro);
            this.Controls.Add(this.tbxDollar);
            this.Controls.Add(this.tbxEuro);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblEuro);
            this.Name = "Form1";
            this.Text = "Euro Dollar Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox tbxEuro;
        private System.Windows.Forms.TextBox tbxDollar;
        private System.Windows.Forms.Button btnToEuro;
        private System.Windows.Forms.Button btnToDollar;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.NumericUpDown exchangeRate;
        private System.Windows.Forms.Button madeBy;
        private System.Windows.Forms.RadioButton rbtnDollar;
        private System.Windows.Forms.RadioButton rbtnYuan;
        private System.Windows.Forms.RadioButton rbtnRupee;
        private System.Windows.Forms.RadioButton rbtnLev;
    }
}

