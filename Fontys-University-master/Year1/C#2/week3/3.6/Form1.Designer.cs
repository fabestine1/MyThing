namespace _3._6
{
    partial class CarApp
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
            this.tbTotalMileage = new System.Windows.Forms.TextBox();
            this.lbDetails = new System.Windows.Forms.Label();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.rbPorsche = new System.Windows.Forms.RadioButton();
            this.nudTanked = new System.Windows.Forms.NumericUpDown();
            this.rbMustang = new System.Windows.Forms.RadioButton();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbMileage = new System.Windows.Forms.Label();
            this.lbFillUp = new System.Windows.Forms.Label();
            this.lbLitersFilled = new System.Windows.Forms.Label();
            this.lbTotalMileage = new System.Windows.Forms.Label();
            this.tbLitersInCar = new System.Windows.Forms.TextBox();
            this.lbLitersInCar = new System.Windows.Forms.Label();
            this.lb1km = new System.Windows.Forms.Label();
            this.btShow = new System.Windows.Forms.Button();
            this.lbEfficiency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanked)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTotalMileage
            // 
            this.tbTotalMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalMileage.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbTotalMileage.Location = new System.Drawing.Point(165, 222);
            this.tbTotalMileage.Name = "tbTotalMileage";
            this.tbTotalMileage.Size = new System.Drawing.Size(100, 22);
            this.tbTotalMileage.TabIndex = 0;
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDetails.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDetails.Location = new System.Drawing.Point(48, 28);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(65, 20);
            this.lbDetails.TabIndex = 1;
            this.lbDetails.Text = "Details";
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(293, 44);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(618, 409);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 2;
            this.pbCar.TabStop = false;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btUpdate.Location = new System.Drawing.Point(119, 306);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // rbPorsche
            // 
            this.rbPorsche.AutoSize = true;
            this.rbPorsche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPorsche.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbPorsche.Location = new System.Drawing.Point(51, 58);
            this.rbPorsche.Name = "rbPorsche";
            this.rbPorsche.Size = new System.Drawing.Size(83, 20);
            this.rbPorsche.TabIndex = 4;
            this.rbPorsche.Text = "Porsche";
            this.rbPorsche.UseVisualStyleBackColor = true;
            this.rbPorsche.CheckedChanged += new System.EventHandler(this.rbPorsche_CheckedChanged);
            // 
            // nudTanked
            // 
            this.nudTanked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTanked.ForeColor = System.Drawing.Color.DarkGreen;
            this.nudTanked.Location = new System.Drawing.Point(165, 184);
            this.nudTanked.Name = "nudTanked";
            this.nudTanked.Size = new System.Drawing.Size(43, 22);
            this.nudTanked.TabIndex = 5;
            // 
            // rbMustang
            // 
            this.rbMustang.AutoSize = true;
            this.rbMustang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMustang.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbMustang.Location = new System.Drawing.Point(165, 58);
            this.rbMustang.Name = "rbMustang";
            this.rbMustang.Size = new System.Drawing.Size(84, 20);
            this.rbMustang.TabIndex = 6;
            this.rbMustang.TabStop = true;
            this.rbMustang.Text = "Mustang";
            this.rbMustang.UseVisualStyleBackColor = true;
            this.rbMustang.CheckedChanged += new System.EventHandler(this.rbPorsche_CheckedChanged);
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBrand.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbBrand.Location = new System.Drawing.Point(48, 94);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(80, 16);
            this.lbBrand.TabIndex = 7;
            this.lbBrand.Text = "                  ";
            // 
            // lbMileage
            // 
            this.lbMileage.AutoSize = true;
            this.lbMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMileage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbMileage.Location = new System.Drawing.Point(48, 121);
            this.lbMileage.Name = "lbMileage";
            this.lbMileage.Size = new System.Drawing.Size(80, 16);
            this.lbMileage.TabIndex = 8;
            this.lbMileage.Text = "                  ";
            // 
            // lbFillUp
            // 
            this.lbFillUp.AutoSize = true;
            this.lbFillUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFillUp.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbFillUp.Location = new System.Drawing.Point(48, 154);
            this.lbFillUp.Name = "lbFillUp";
            this.lbFillUp.Size = new System.Drawing.Size(60, 20);
            this.lbFillUp.TabIndex = 9;
            this.lbFillUp.Text = "Fill Up";
            // 
            // lbLitersFilled
            // 
            this.lbLitersFilled.AutoSize = true;
            this.lbLitersFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLitersFilled.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbLitersFilled.Location = new System.Drawing.Point(48, 186);
            this.lbLitersFilled.Name = "lbLitersFilled";
            this.lbLitersFilled.Size = new System.Drawing.Size(89, 16);
            this.lbLitersFilled.TabIndex = 10;
            this.lbLitersFilled.Text = "Liters Filled";
            // 
            // lbTotalMileage
            // 
            this.lbTotalMileage.AutoSize = true;
            this.lbTotalMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalMileage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbTotalMileage.Location = new System.Drawing.Point(48, 222);
            this.lbTotalMileage.Name = "lbTotalMileage";
            this.lbTotalMileage.Size = new System.Drawing.Size(104, 16);
            this.lbTotalMileage.TabIndex = 11;
            this.lbTotalMileage.Text = "Total Mileage";
            // 
            // tbLitersInCar
            // 
            this.tbLitersInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLitersInCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbLitersInCar.Location = new System.Drawing.Point(165, 258);
            this.tbLitersInCar.Name = "tbLitersInCar";
            this.tbLitersInCar.Size = new System.Drawing.Size(100, 22);
            this.tbLitersInCar.TabIndex = 12;
            // 
            // lbLitersInCar
            // 
            this.lbLitersInCar.AutoSize = true;
            this.lbLitersInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLitersInCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbLitersInCar.Location = new System.Drawing.Point(48, 258);
            this.lbLitersInCar.Name = "lbLitersInCar";
            this.lbLitersInCar.Size = new System.Drawing.Size(90, 16);
            this.lbLitersInCar.TabIndex = 13;
            this.lbLitersInCar.Text = "Liters In Car";
            // 
            // lb1km
            // 
            this.lb1km.AutoSize = true;
            this.lb1km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1km.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb1km.Location = new System.Drawing.Point(47, 352);
            this.lb1km.Name = "lb1km";
            this.lb1km.Size = new System.Drawing.Size(119, 20);
            this.lb1km.TabIndex = 14;
            this.lb1km.Text = "1 litter per km";
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShow.ForeColor = System.Drawing.Color.DarkGreen;
            this.btShow.Location = new System.Drawing.Point(119, 391);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 15;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // lbEfficiency
            // 
            this.lbEfficiency.AutoSize = true;
            this.lbEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEfficiency.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbEfficiency.Location = new System.Drawing.Point(75, 433);
            this.lbEfficiency.Name = "lbEfficiency";
            this.lbEfficiency.Size = new System.Drawing.Size(154, 20);
            this.lbEfficiency.TabIndex = 16;
            this.lbEfficiency.Text = "                             ";
            // 
            // CarApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(945, 504);
            this.Controls.Add(this.lbEfficiency);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.lb1km);
            this.Controls.Add(this.lbLitersInCar);
            this.Controls.Add(this.tbLitersInCar);
            this.Controls.Add(this.lbTotalMileage);
            this.Controls.Add(this.lbLitersFilled);
            this.Controls.Add(this.lbFillUp);
            this.Controls.Add(this.lbMileage);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.rbMustang);
            this.Controls.Add(this.nudTanked);
            this.Controls.Add(this.rbPorsche);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.tbTotalMileage);
            this.Name = "CarApp";
            this.Text = "Car App";
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTotalMileage;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.RadioButton rbPorsche;
        private System.Windows.Forms.NumericUpDown nudTanked;
        private System.Windows.Forms.RadioButton rbMustang;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbMileage;
        private System.Windows.Forms.Label lbFillUp;
        private System.Windows.Forms.Label lbLitersFilled;
        private System.Windows.Forms.Label lbTotalMileage;
        private System.Windows.Forms.TextBox tbLitersInCar;
        private System.Windows.Forms.Label lbLitersInCar;
        private System.Windows.Forms.Label lb1km;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Label lbEfficiency;
    }
}

