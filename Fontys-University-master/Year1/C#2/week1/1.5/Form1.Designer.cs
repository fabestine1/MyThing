namespace _1._5
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
            this.tGallons = new System.Windows.Forms.TextBox();
            this.lGallons = new System.Windows.Forms.Label();
            this.town = new System.Windows.Forms.RadioButton();
            this.highway = new System.Windows.Forms.RadioButton();
            this.lMiles = new System.Windows.Forms.Label();
            this.tMiles = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.calculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tGallons
            // 
            this.tGallons.BackColor = System.Drawing.Color.RosyBrown;
            this.tGallons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tGallons.ForeColor = System.Drawing.Color.OrangeRed;
            this.tGallons.Location = new System.Drawing.Point(107, 69);
            this.tGallons.Name = "tGallons";
            this.tGallons.Size = new System.Drawing.Size(100, 26);
            this.tGallons.TabIndex = 0;
            // 
            // lGallons
            // 
            this.lGallons.AutoSize = true;
            this.lGallons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGallons.ForeColor = System.Drawing.Color.OrangeRed;
            this.lGallons.Location = new System.Drawing.Point(40, 75);
            this.lGallons.Name = "lGallons";
            this.lGallons.Size = new System.Drawing.Size(65, 16);
            this.lGallons.TabIndex = 1;
            this.lGallons.Text = "Gallons:";
            // 
            // town
            // 
            this.town.AutoSize = true;
            this.town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.town.ForeColor = System.Drawing.Color.OrangeRed;
            this.town.Location = new System.Drawing.Point(107, 101);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(79, 20);
            this.town.TabIndex = 2;
            this.town.TabStop = true;
            this.town.Text = "In Town";
            this.town.UseVisualStyleBackColor = true;
            this.town.CheckedChanged += new System.EventHandler(this.town_CheckedChanged);
            // 
            // highway
            // 
            this.highway.AutoSize = true;
            this.highway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highway.ForeColor = System.Drawing.Color.OrangeRed;
            this.highway.Location = new System.Drawing.Point(107, 127);
            this.highway.Name = "highway";
            this.highway.Size = new System.Drawing.Size(108, 20);
            this.highway.TabIndex = 3;
            this.highway.TabStop = true;
            this.highway.Text = "On Highway";
            this.highway.UseVisualStyleBackColor = true;
            this.highway.CheckedChanged += new System.EventHandler(this.highway_CheckedChanged);
            // 
            // lMiles
            // 
            this.lMiles.AutoSize = true;
            this.lMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMiles.ForeColor = System.Drawing.Color.OrangeRed;
            this.lMiles.Location = new System.Drawing.Point(414, 75);
            this.lMiles.Name = "lMiles";
            this.lMiles.Size = new System.Drawing.Size(49, 16);
            this.lMiles.TabIndex = 4;
            this.lMiles.Text = "Miles:";
            // 
            // tMiles
            // 
            this.tMiles.BackColor = System.Drawing.Color.RosyBrown;
            this.tMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tMiles.ForeColor = System.Drawing.Color.OrangeRed;
            this.tMiles.Location = new System.Drawing.Point(465, 69);
            this.tMiles.Name = "tMiles";
            this.tMiles.ReadOnly = true;
            this.tMiles.Size = new System.Drawing.Size(100, 26);
            this.tMiles.TabIndex = 5;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Lime;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.exit.Location = new System.Drawing.Point(481, 183);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(84, 38);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // calculation
            // 
            this.calculation.BackColor = System.Drawing.Color.Lime;
            this.calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculation.ForeColor = System.Drawing.Color.OrangeRed;
            this.calculation.Location = new System.Drawing.Point(277, 62);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(100, 41);
            this.calculation.TabIndex = 7;
            this.calculation.Text = "Calculate";
            this.calculation.UseVisualStyleBackColor = false;
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(641, 241);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.tMiles);
            this.Controls.Add(this.lMiles);
            this.Controls.Add(this.highway);
            this.Controls.Add(this.town);
            this.Controls.Add(this.lGallons);
            this.Controls.Add(this.tGallons);
            this.Name = "Form1";
            this.Text = "Distance per Tank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tGallons;
        private System.Windows.Forms.Label lGallons;
        private System.Windows.Forms.RadioButton town;
        private System.Windows.Forms.RadioButton highway;
        private System.Windows.Forms.Label lMiles;
        private System.Windows.Forms.TextBox tMiles;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button calculation;
    }
}

