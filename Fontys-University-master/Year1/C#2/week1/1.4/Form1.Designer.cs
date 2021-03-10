namespace _1._4
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
            this.euroValue = new System.Windows.Forms.TextBox();
            this.dollarValue = new System.Windows.Forms.TextBox();
            this.euroToDollar = new System.Windows.Forms.Button();
            this.dollarToEuro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exchangeRate = new System.Windows.Forms.NumericUpDown();
            this.exit = new System.Windows.Forms.Button();
            this.madeBy = new System.Windows.Forms.Button();
            this.didoProto = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // euroValue
            // 
            this.euroValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.euroValue.Location = new System.Drawing.Point(106, 131);
            this.euroValue.Name = "euroValue";
            this.euroValue.Size = new System.Drawing.Size(171, 26);
            this.euroValue.TabIndex = 0;
            // 
            // dollarValue
            // 
            this.dollarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollarValue.Location = new System.Drawing.Point(349, 131);
            this.dollarValue.Name = "dollarValue";
            this.dollarValue.Size = new System.Drawing.Size(171, 26);
            this.dollarValue.TabIndex = 1;
            // 
            // euroToDollar
            // 
            this.euroToDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.euroToDollar.Location = new System.Drawing.Point(316, 131);
            this.euroToDollar.Name = "euroToDollar";
            this.euroToDollar.Size = new System.Drawing.Size(27, 26);
            this.euroToDollar.TabIndex = 2;
            this.euroToDollar.Text = ">";
            this.euroToDollar.UseVisualStyleBackColor = true;
            this.euroToDollar.Click += new System.EventHandler(this.euroToDollar_Click);
            // 
            // dollarToEuro
            // 
            this.dollarToEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollarToEuro.Location = new System.Drawing.Point(283, 132);
            this.dollarToEuro.Name = "dollarToEuro";
            this.dollarToEuro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dollarToEuro.Size = new System.Drawing.Size(27, 26);
            this.dollarToEuro.TabIndex = 3;
            this.dollarToEuro.Text = "<";
            this.dollarToEuro.UseVisualStyleBackColor = true;
            this.dollarToEuro.Click += new System.EventHandler(this.dollarToEuro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(526, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 73);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exchange rate 1€ = $ ";
            // 
            // exchangeRate
            // 
            this.exchangeRate.DecimalPlaces = 2;
            this.exchangeRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.exchangeRate.Location = new System.Drawing.Point(221, 33);
            this.exchangeRate.Name = "exchangeRate";
            this.exchangeRate.Size = new System.Drawing.Size(44, 20);
            this.exchangeRate.TabIndex = 7;
            this.exchangeRate.Value = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Yellow;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Navy;
            this.exit.Location = new System.Drawing.Point(539, 256);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 34);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // madeBy
            // 
            this.madeBy.BackColor = System.Drawing.Color.Yellow;
            this.madeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.madeBy.ForeColor = System.Drawing.Color.Navy;
            this.madeBy.Location = new System.Drawing.Point(76, 208);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(105, 39);
            this.madeBy.TabIndex = 9;
            this.madeBy.Text = "Made By";
            this.madeBy.UseVisualStyleBackColor = false;
            this.madeBy.Click += new System.EventHandler(this.madeBy_Click);
            // 
            // didoProto
            // 
            this.didoProto.AutoSize = true;
            this.didoProto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.didoProto.ForeColor = System.Drawing.Color.DeepPink;
            this.didoProto.Location = new System.Drawing.Point(187, 230);
            this.didoProto.Name = "didoProto";
            this.didoProto.Size = new System.Drawing.Size(180, 39);
            this.didoProto.TabIndex = 10;
            this.didoProto.Text = "DidoProto";
            this.didoProto.Visible = false;
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Yellow;
            this.hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide.ForeColor = System.Drawing.Color.Navy;
            this.hide.Location = new System.Drawing.Point(76, 253);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(105, 39);
            this.hide.TabIndex = 11;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 302);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.didoProto);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.exchangeRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dollarToEuro);
            this.Controls.Add(this.euroToDollar);
            this.Controls.Add(this.dollarValue);
            this.Controls.Add(this.euroValue);
            this.Name = "Form1";
            this.Text = "Euro Dollar Conventor";
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox euroValue;
        private System.Windows.Forms.TextBox dollarValue;
        private System.Windows.Forms.Button euroToDollar;
        private System.Windows.Forms.Button dollarToEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown exchangeRate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button madeBy;
        private System.Windows.Forms.Label didoProto;
        private System.Windows.Forms.Button hide;
    }
}

