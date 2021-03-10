namespace TransportationDemo
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
            this.carBttn = new System.Windows.Forms.Button();
            this.bicycleBttn = new System.Windows.Forms.Button();
            this.boatBttn = new System.Windows.Forms.Button();
            this.bikeLbl = new System.Windows.Forms.Label();
            this.carLbl = new System.Windows.Forms.Label();
            this.boatLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carBttn
            // 
            this.carBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBttn.Location = new System.Drawing.Point(47, 131);
            this.carBttn.Name = "carBttn";
            this.carBttn.Size = new System.Drawing.Size(206, 55);
            this.carBttn.TabIndex = 1;
            this.carBttn.Text = "Car";
            this.carBttn.UseVisualStyleBackColor = false;
            this.carBttn.Click += new System.EventHandler(this.CarBttn_Click);
            // 
            // bicycleBttn
            // 
            this.bicycleBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bicycleBttn.Location = new System.Drawing.Point(47, 50);
            this.bicycleBttn.Name = "bicycleBttn";
            this.bicycleBttn.Size = new System.Drawing.Size(206, 55);
            this.bicycleBttn.TabIndex = 2;
            this.bicycleBttn.Text = "Bicycle";
            this.bicycleBttn.UseVisualStyleBackColor = false;
            this.bicycleBttn.Click += new System.EventHandler(this.BicycleBttn_Click);
            // 
            // boatBttn
            // 
            this.boatBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatBttn.Location = new System.Drawing.Point(47, 211);
            this.boatBttn.Name = "boatBttn";
            this.boatBttn.Size = new System.Drawing.Size(206, 55);
            this.boatBttn.TabIndex = 3;
            this.boatBttn.Text = "Boat";
            this.boatBttn.UseVisualStyleBackColor = false;
            this.boatBttn.Click += new System.EventHandler(this.BoatBttn_Click);
            // 
            // bikeLbl
            // 
            this.bikeLbl.AutoSize = true;
            this.bikeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeLbl.Location = new System.Drawing.Point(317, 63);
            this.bikeLbl.Name = "bikeLbl";
            this.bikeLbl.Size = new System.Drawing.Size(120, 29);
            this.bikeLbl.TabIndex = 4;
            this.bikeLbl.Text = "bicycle lbl";
            // 
            // carLbl
            // 
            this.carLbl.AutoSize = true;
            this.carLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLbl.Location = new System.Drawing.Point(317, 144);
            this.carLbl.Name = "carLbl";
            this.carLbl.Size = new System.Drawing.Size(78, 29);
            this.carLbl.TabIndex = 5;
            this.carLbl.Text = "car lbl";
            // 
            // boatLbl
            // 
            this.boatLbl.AutoSize = true;
            this.boatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatLbl.Location = new System.Drawing.Point(317, 224);
            this.boatLbl.Name = "boatLbl";
            this.boatLbl.Size = new System.Drawing.Size(92, 29);
            this.boatLbl.TabIndex = 6;
            this.boatLbl.Text = "boat lbl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boatLbl);
            this.Controls.Add(this.carLbl);
            this.Controls.Add(this.bikeLbl);
            this.Controls.Add(this.boatBttn);
            this.Controls.Add(this.bicycleBttn);
            this.Controls.Add(this.carBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button carBttn;
        private System.Windows.Forms.Button bicycleBttn;
        private System.Windows.Forms.Button boatBttn;
        private System.Windows.Forms.Label bikeLbl;
        private System.Windows.Forms.Label carLbl;
        private System.Windows.Forms.Label boatLbl;
    }
}

