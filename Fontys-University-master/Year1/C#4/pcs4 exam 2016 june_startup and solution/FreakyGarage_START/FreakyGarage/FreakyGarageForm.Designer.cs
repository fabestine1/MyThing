namespace FreakyGarage
{
    partial class FreakyGarageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreakyGarageForm));
            this.lbCarsForSale = new System.Windows.Forms.ListBox();
            this.btnSortYear = new System.Windows.Forms.Button();
            this.btnSortBrandTypePrice = new System.Windows.Forms.Button();
            this.gbAddCar = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbManufacturingYear = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.gbChangePrice = new System.Windows.Forms.GroupBox();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.tbNewPrice = new System.Windows.Forms.TextBox();
            this.lblCarsForSale = new System.Windows.Forms.Label();
            this.btnAddTestDrive = new System.Windows.Forms.Button();
            this.btnMaxPrice = new System.Windows.Forms.Button();
            this.btnNrOfTestDrives = new System.Windows.Forms.Button();
            this.gbSelectBrand = new System.Windows.Forms.GroupBox();
            this.tbBrandTestDrive = new System.Windows.Forms.TextBox();
            this.lblBrandTest = new System.Windows.Forms.Label();
            this.gbAddCar.SuspendLayout();
            this.gbChangePrice.SuspendLayout();
            this.gbSelectBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCarsForSale
            // 
            this.lbCarsForSale.FormattingEnabled = true;
            this.lbCarsForSale.Location = new System.Drawing.Point(24, 42);
            this.lbCarsForSale.Name = "lbCarsForSale";
            this.lbCarsForSale.Size = new System.Drawing.Size(494, 277);
            this.lbCarsForSale.TabIndex = 0;
            // 
            // btnSortYear
            // 
            this.btnSortYear.BackColor = System.Drawing.Color.Yellow;
            this.btnSortYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortYear.Location = new System.Drawing.Point(24, 453);
            this.btnSortYear.Name = "btnSortYear";
            this.btnSortYear.Size = new System.Drawing.Size(143, 44);
            this.btnSortYear.TabIndex = 1;
            this.btnSortYear.Text = "Sort on year";
            this.btnSortYear.UseVisualStyleBackColor = false;
            this.btnSortYear.Click += new System.EventHandler(this.btnSortYear_Click);
            // 
            // btnSortBrandTypePrice
            // 
            this.btnSortBrandTypePrice.BackColor = System.Drawing.Color.Yellow;
            this.btnSortBrandTypePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortBrandTypePrice.Location = new System.Drawing.Point(196, 453);
            this.btnSortBrandTypePrice.Name = "btnSortBrandTypePrice";
            this.btnSortBrandTypePrice.Size = new System.Drawing.Size(143, 44);
            this.btnSortBrandTypePrice.TabIndex = 2;
            this.btnSortBrandTypePrice.Text = "Sort on brand, type and price";
            this.btnSortBrandTypePrice.UseVisualStyleBackColor = false;
            this.btnSortBrandTypePrice.Click += new System.EventHandler(this.btnSortBrandTypePrice_Click);
            // 
            // gbAddCar
            // 
            this.gbAddCar.Controls.Add(this.lblPrice);
            this.gbAddCar.Controls.Add(this.lblYear);
            this.gbAddCar.Controls.Add(this.lblType);
            this.gbAddCar.Controls.Add(this.lblBrand);
            this.gbAddCar.Controls.Add(this.btnAddCar);
            this.gbAddCar.Controls.Add(this.tbPrice);
            this.gbAddCar.Controls.Add(this.tbManufacturingYear);
            this.gbAddCar.Controls.Add(this.tbType);
            this.gbAddCar.Controls.Add(this.tbBrand);
            this.gbAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCar.Location = new System.Drawing.Point(564, 42);
            this.gbAddCar.Name = "gbAddCar";
            this.gbAddCar.Size = new System.Drawing.Size(251, 238);
            this.gbAddCar.TabIndex = 3;
            this.gbAddCar.TabStop = false;
            this.gbAddCar.Text = "Add car";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 152);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 18);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(20, 113);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 18);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 75);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(20, 37);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(52, 18);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Lime;
            this.btnAddCar.Location = new System.Drawing.Point(48, 193);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(149, 39);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Add car for sale";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(110, 145);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 24);
            this.tbPrice.TabIndex = 3;
            // 
            // tbManufacturingYear
            // 
            this.tbManufacturingYear.Location = new System.Drawing.Point(110, 106);
            this.tbManufacturingYear.Name = "tbManufacturingYear";
            this.tbManufacturingYear.Size = new System.Drawing.Size(100, 24);
            this.tbManufacturingYear.TabIndex = 2;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(110, 68);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 24);
            this.tbType.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(110, 30);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 24);
            this.tbBrand.TabIndex = 0;
            // 
            // gbChangePrice
            // 
            this.gbChangePrice.Controls.Add(this.btnChangePrice);
            this.gbChangePrice.Controls.Add(this.lblNewPrice);
            this.gbChangePrice.Controls.Add(this.tbNewPrice);
            this.gbChangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePrice.Location = new System.Drawing.Point(564, 299);
            this.gbChangePrice.Name = "gbChangePrice";
            this.gbChangePrice.Size = new System.Drawing.Size(250, 102);
            this.gbChangePrice.TabIndex = 4;
            this.gbChangePrice.TabStop = false;
            this.gbChangePrice.Text = "Change price of selected car";
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.Lime;
            this.btnChangePrice.Location = new System.Drawing.Point(48, 65);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(149, 31);
            this.btnChangePrice.TabIndex = 2;
            this.btnChangePrice.Text = "Change price";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(21, 29);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(83, 18);
            this.lblNewPrice.TabIndex = 1;
            this.lblNewPrice.Text = "New price";
            // 
            // tbNewPrice
            // 
            this.tbNewPrice.Location = new System.Drawing.Point(110, 29);
            this.tbNewPrice.Name = "tbNewPrice";
            this.tbNewPrice.Size = new System.Drawing.Size(100, 24);
            this.tbNewPrice.TabIndex = 0;
            // 
            // lblCarsForSale
            // 
            this.lblCarsForSale.AutoSize = true;
            this.lblCarsForSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsForSale.Location = new System.Drawing.Point(166, 21);
            this.lblCarsForSale.Name = "lblCarsForSale";
            this.lblCarsForSale.Size = new System.Drawing.Size(106, 18);
            this.lblCarsForSale.TabIndex = 5;
            this.lblCarsForSale.Text = "Cars for sale";
            // 
            // btnAddTestDrive
            // 
            this.btnAddTestDrive.BackColor = System.Drawing.Color.Yellow;
            this.btnAddTestDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestDrive.Location = new System.Drawing.Point(375, 453);
            this.btnAddTestDrive.Name = "btnAddTestDrive";
            this.btnAddTestDrive.Size = new System.Drawing.Size(143, 44);
            this.btnAddTestDrive.TabIndex = 6;
            this.btnAddTestDrive.Text = "Add test drive";
            this.btnAddTestDrive.UseVisualStyleBackColor = false;
            this.btnAddTestDrive.Click += new System.EventHandler(this.btnAddTestDrive_Click);
            // 
            // btnMaxPrice
            // 
            this.btnMaxPrice.BackColor = System.Drawing.Color.Yellow;
            this.btnMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxPrice.Location = new System.Drawing.Point(727, 453);
            this.btnMaxPrice.Name = "btnMaxPrice";
            this.btnMaxPrice.Size = new System.Drawing.Size(153, 43);
            this.btnMaxPrice.TabIndex = 7;
            this.btnMaxPrice.Text = "Max price Ferrari";
            this.btnMaxPrice.UseVisualStyleBackColor = false;
            this.btnMaxPrice.Click += new System.EventHandler(this.btnMaxPrice_Click);
            // 
            // btnNrOfTestDrives
            // 
            this.btnNrOfTestDrives.BackColor = System.Drawing.Color.Yellow;
            this.btnNrOfTestDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNrOfTestDrives.Location = new System.Drawing.Point(551, 453);
            this.btnNrOfTestDrives.Name = "btnNrOfTestDrives";
            this.btnNrOfTestDrives.Size = new System.Drawing.Size(143, 44);
            this.btnNrOfTestDrives.TabIndex = 8;
            this.btnNrOfTestDrives.Text = "Nr of test drives";
            this.btnNrOfTestDrives.UseVisualStyleBackColor = false;
            this.btnNrOfTestDrives.Click += new System.EventHandler(this.btnNrOfTestDrives_Click);
            // 
            // gbSelectBrand
            // 
            this.gbSelectBrand.Controls.Add(this.tbBrandTestDrive);
            this.gbSelectBrand.Controls.Add(this.lblBrandTest);
            this.gbSelectBrand.Location = new System.Drawing.Point(476, 504);
            this.gbSelectBrand.Name = "gbSelectBrand";
            this.gbSelectBrand.Size = new System.Drawing.Size(236, 52);
            this.gbSelectBrand.TabIndex = 9;
            this.gbSelectBrand.TabStop = false;
            // 
            // tbBrandTestDrive
            // 
            this.tbBrandTestDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrandTestDrive.Location = new System.Drawing.Point(75, 19);
            this.tbBrandTestDrive.Name = "tbBrandTestDrive";
            this.tbBrandTestDrive.Size = new System.Drawing.Size(143, 24);
            this.tbBrandTestDrive.TabIndex = 1;
            // 
            // lblBrandTest
            // 
            this.lblBrandTest.AutoSize = true;
            this.lblBrandTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTest.Location = new System.Drawing.Point(6, 22);
            this.lblBrandTest.Name = "lblBrandTest";
            this.lblBrandTest.Size = new System.Drawing.Size(52, 18);
            this.lblBrandTest.TabIndex = 0;
            this.lblBrandTest.Text = "Brand";
            // 
            // FreakyGarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(888, 571);
            this.Controls.Add(this.gbSelectBrand);
            this.Controls.Add(this.btnNrOfTestDrives);
            this.Controls.Add(this.btnMaxPrice);
            this.Controls.Add(this.btnAddTestDrive);
            this.Controls.Add(this.lblCarsForSale);
            this.Controls.Add(this.gbChangePrice);
            this.Controls.Add(this.gbAddCar);
            this.Controls.Add(this.btnSortBrandTypePrice);
            this.Controls.Add(this.btnSortYear);
            this.Controls.Add(this.lbCarsForSale);
            this.Name = "FreakyGarageForm";
            this.Text = "FREAKY GARAGE";
            this.gbAddCar.ResumeLayout(false);
            this.gbAddCar.PerformLayout();
            this.gbChangePrice.ResumeLayout(false);
            this.gbChangePrice.PerformLayout();
            this.gbSelectBrand.ResumeLayout(false);
            this.gbSelectBrand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCarsForSale;
        private System.Windows.Forms.Button btnSortYear;
        private System.Windows.Forms.Button btnSortBrandTypePrice;
        private System.Windows.Forms.GroupBox gbAddCar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbManufacturingYear;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.GroupBox gbChangePrice;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.TextBox tbNewPrice;
        private System.Windows.Forms.Label lblCarsForSale;
        private System.Windows.Forms.Button btnAddTestDrive;
        private System.Windows.Forms.Button btnMaxPrice;
        private System.Windows.Forms.Button btnNrOfTestDrives;
        private System.Windows.Forms.GroupBox gbSelectBrand;
        private System.Windows.Forms.TextBox tbBrandTestDrive;
        private System.Windows.Forms.Label lblBrandTest;
    }
}

