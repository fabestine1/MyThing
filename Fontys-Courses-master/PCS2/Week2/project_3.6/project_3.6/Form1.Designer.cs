namespace project_3._6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMileageCaption = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.rbtnPrivateCar = new System.Windows.Forms.RadioButton();
            this.rbtnBusinessCar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblLitersInCar = new System.Windows.Forms.Label();
            this.udLitersTanked = new System.Windows.Forms.NumericUpDown();
            this.tbxLitersLeft = new System.Windows.Forms.TextBox();
            this.lblLitersTanked = new System.Windows.Forms.Label();
            this.tbxTotalMileage = new System.Windows.Forms.TextBox();
            this.lblTotalMileage = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKmPerLiter = new System.Windows.Forms.Label();
            this.lblFuelEfficiency = new System.Windows.Forms.Label();
            this.lblKmPerLiterCaption = new System.Windows.Forms.Label();
            this.btnShowFuelEfficiency = new System.Windows.Forms.Button();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLitersTanked)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.lblMileage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMileageCaption);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.rbtnPrivateCar);
            this.groupBox1.Controls.Add(this.rbtnBusinessCar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car details";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(73, 71);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(0, 13);
            this.lblMileage.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // lblMileageCaption
            // 
            this.lblMileageCaption.AutoSize = true;
            this.lblMileageCaption.Location = new System.Drawing.Point(27, 71);
            this.lblMileageCaption.Name = "lblMileageCaption";
            this.lblMileageCaption.Size = new System.Drawing.Size(47, 13);
            this.lblMileageCaption.TabIndex = 9;
            this.lblMileageCaption.Text = "Mileage:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(27, 51);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 13);
            this.lblBrand.TabIndex = 8;
            // 
            // rbtnPrivateCar
            // 
            this.rbtnPrivateCar.AutoSize = true;
            this.rbtnPrivateCar.Location = new System.Drawing.Point(7, 19);
            this.rbtnPrivateCar.Name = "rbtnPrivateCar";
            this.rbtnPrivateCar.Size = new System.Drawing.Size(76, 17);
            this.rbtnPrivateCar.TabIndex = 1;
            this.rbtnPrivateCar.TabStop = true;
            this.rbtnPrivateCar.Text = "Private car";
            this.rbtnPrivateCar.UseVisualStyleBackColor = true;
            this.rbtnPrivateCar.CheckedChanged += new System.EventHandler(this.rbtnPrivateCar_CheckedChanged);
            // 
            // rbtnBusinessCar
            // 
            this.rbtnBusinessCar.AutoSize = true;
            this.rbtnBusinessCar.Location = new System.Drawing.Point(117, 19);
            this.rbtnBusinessCar.Name = "rbtnBusinessCar";
            this.rbtnBusinessCar.Size = new System.Drawing.Size(85, 17);
            this.rbtnBusinessCar.TabIndex = 2;
            this.rbtnBusinessCar.TabStop = true;
            this.rbtnBusinessCar.Text = "Business car";
            this.rbtnBusinessCar.UseVisualStyleBackColor = true;
            this.rbtnBusinessCar.CheckedChanged += new System.EventHandler(this.rbtnBusinessCar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.lblLitersInCar);
            this.groupBox2.Controls.Add(this.udLitersTanked);
            this.groupBox2.Controls.Add(this.tbxLitersLeft);
            this.groupBox2.Controls.Add(this.lblLitersTanked);
            this.groupBox2.Controls.Add(this.tbxTotalMileage);
            this.groupBox2.Controls.Add(this.lblTotalMileage);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 187);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill Up";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblLitersInCar
            // 
            this.lblLitersInCar.AutoSize = true;
            this.lblLitersInCar.Location = new System.Drawing.Point(36, 112);
            this.lblLitersInCar.Name = "lblLitersInCar";
            this.lblLitersInCar.Size = new System.Drawing.Size(57, 13);
            this.lblLitersInCar.TabIndex = 10;
            this.lblLitersInCar.Text = "liters in car";
            // 
            // udLitersTanked
            // 
            this.udLitersTanked.Location = new System.Drawing.Point(178, 31);
            this.udLitersTanked.Name = "udLitersTanked";
            this.udLitersTanked.Size = new System.Drawing.Size(76, 20);
            this.udLitersTanked.TabIndex = 7;
            // 
            // tbxLitersLeft
            // 
            this.tbxLitersLeft.Location = new System.Drawing.Point(163, 109);
            this.tbxLitersLeft.Name = "tbxLitersLeft";
            this.tbxLitersLeft.Size = new System.Drawing.Size(100, 20);
            this.tbxLitersLeft.TabIndex = 6;
            // 
            // lblLitersTanked
            // 
            this.lblLitersTanked.AutoSize = true;
            this.lblLitersTanked.Location = new System.Drawing.Point(27, 31);
            this.lblLitersTanked.Name = "lblLitersTanked";
            this.lblLitersTanked.Size = new System.Drawing.Size(64, 13);
            this.lblLitersTanked.TabIndex = 4;
            this.lblLitersTanked.Text = "liters tanked";
            // 
            // tbxTotalMileage
            // 
            this.tbxTotalMileage.Location = new System.Drawing.Point(163, 65);
            this.tbxTotalMileage.Name = "tbxTotalMileage";
            this.tbxTotalMileage.Size = new System.Drawing.Size(100, 20);
            this.tbxTotalMileage.TabIndex = 5;
            // 
            // lblTotalMileage
            // 
            this.lblTotalMileage.AutoSize = true;
            this.lblTotalMileage.Location = new System.Drawing.Point(27, 68);
            this.lblTotalMileage.Name = "lblTotalMileage";
            this.lblTotalMileage.Size = new System.Drawing.Size(66, 13);
            this.lblTotalMileage.TabIndex = 3;
            this.lblTotalMileage.Text = "total mileage";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblKmPerLiter);
            this.groupBox3.Controls.Add(this.lblFuelEfficiency);
            this.groupBox3.Controls.Add(this.lblKmPerLiterCaption);
            this.groupBox3.Controls.Add(this.btnShowFuelEfficiency);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1 liter --> km";
            // 
            // lblKmPerLiter
            // 
            this.lblKmPerLiter.AutoSize = true;
            this.lblKmPerLiter.Location = new System.Drawing.Point(145, 53);
            this.lblKmPerLiter.Name = "lblKmPerLiter";
            this.lblKmPerLiter.Size = new System.Drawing.Size(0, 13);
            this.lblKmPerLiter.TabIndex = 13;
            // 
            // lblFuelEfficiency
            // 
            this.lblFuelEfficiency.AutoSize = true;
            this.lblFuelEfficiency.Location = new System.Drawing.Point(60, 53);
            this.lblFuelEfficiency.Name = "lblFuelEfficiency";
            this.lblFuelEfficiency.Size = new System.Drawing.Size(78, 13);
            this.lblFuelEfficiency.TabIndex = 12;
            this.lblFuelEfficiency.Text = "Fuel efficiency:";
            // 
            // lblKmPerLiterCaption
            // 
            this.lblKmPerLiterCaption.AutoSize = true;
            this.lblKmPerLiterCaption.Location = new System.Drawing.Point(185, 53);
            this.lblKmPerLiterCaption.Name = "lblKmPerLiterCaption";
            this.lblKmPerLiterCaption.Size = new System.Drawing.Size(97, 13);
            this.lblKmPerLiterCaption.TabIndex = 1;
            this.lblKmPerLiterCaption.Text = "kilometers on 1 liter";
            // 
            // btnShowFuelEfficiency
            // 
            this.btnShowFuelEfficiency.Location = new System.Drawing.Point(76, 19);
            this.btnShowFuelEfficiency.Name = "btnShowFuelEfficiency";
            this.btnShowFuelEfficiency.Size = new System.Drawing.Size(158, 23);
            this.btnShowFuelEfficiency.TabIndex = 12;
            this.btnShowFuelEfficiency.Text = "Show fuel efficiency";
            this.btnShowFuelEfficiency.UseVisualStyleBackColor = true;
            this.btnShowFuelEfficiency.Click += new System.EventHandler(this.btnShowFuelEfficiency_Click);
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(447, 12);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(261, 212);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCar.TabIndex = 1;
            this.pbCar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 422);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CarApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLitersTanked)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnPrivateCar;
        private System.Windows.Forms.RadioButton rbtnBusinessCar;
        private System.Windows.Forms.Label lblTotalMileage;
        private System.Windows.Forms.Label lblLitersTanked;
        private System.Windows.Forms.Label lblMileageCaption;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblLitersInCar;
        private System.Windows.Forms.NumericUpDown udLitersTanked;
        private System.Windows.Forms.TextBox tbxLitersLeft;
        private System.Windows.Forms.TextBox tbxTotalMileage;
        private System.Windows.Forms.Label lblFuelEfficiency;
        private System.Windows.Forms.Label lblKmPerLiterCaption;
        private System.Windows.Forms.Button btnShowFuelEfficiency;
        private System.Windows.Forms.Label lblKmPerLiter;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label label2;
    }
}

