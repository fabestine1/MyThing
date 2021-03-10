namespace GUI_Pizza_L
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
            this.lblCook = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblMarkPizza = new System.Windows.Forms.Label();
            this.readyPizzas = new System.Windows.Forms.ListBox();
            this.btnMarkAsReady = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCook
            // 
            this.lblCook.AutoSize = true;
            this.lblCook.BackColor = System.Drawing.Color.GreenYellow;
            this.lblCook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCook.Location = new System.Drawing.Point(12, 9);
            this.lblCook.Name = "lblCook";
            this.lblCook.Size = new System.Drawing.Size(170, 32);
            this.lblCook.TabIndex = 0;
            this.lblCook.Text = "Cook: Luigi";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::GUI_Pizza_L.Properties.Resources.unknown;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(614, 9);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(174, 128);
            this.pnlLogo.TabIndex = 7;
            // 
            // lblMarkPizza
            // 
            this.lblMarkPizza.AutoSize = true;
            this.lblMarkPizza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkPizza.Location = new System.Drawing.Point(12, 60);
            this.lblMarkPizza.Name = "lblMarkPizza";
            this.lblMarkPizza.Size = new System.Drawing.Size(288, 32);
            this.lblMarkPizza.TabIndex = 8;
            this.lblMarkPizza.Text = "Mark pizza as ready";
            // 
            // readyPizzas
            // 
            this.readyPizzas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyPizzas.FormattingEnabled = true;
            this.readyPizzas.HorizontalScrollbar = true;
            this.readyPizzas.ItemHeight = 21;
            this.readyPizzas.Location = new System.Drawing.Point(13, 137);
            this.readyPizzas.Name = "readyPizzas";
            this.readyPizzas.Size = new System.Drawing.Size(772, 256);
            this.readyPizzas.TabIndex = 9;
            // 
            // btnMarkAsReady
            // 
            this.btnMarkAsReady.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsReady.Location = new System.Drawing.Point(13, 418);
            this.btnMarkAsReady.Name = "btnMarkAsReady";
            this.btnMarkAsReady.Size = new System.Drawing.Size(772, 61);
            this.btnMarkAsReady.TabIndex = 10;
            this.btnMarkAsReady.Text = "Ready!";
            this.btnMarkAsReady.UseVisualStyleBackColor = true;
            this.btnMarkAsReady.Click += new System.EventHandler(this.BtnMarkAsReady_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.Location = new System.Drawing.Point(531, 16);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(23, 25);
            this.countLbl.TabIndex = 11;
            this.countLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Done pizzas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.btnMarkAsReady);
            this.Controls.Add(this.readyPizzas);
            this.Controls.Add(this.lblMarkPizza);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.lblCook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCook;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblMarkPizza;
        private System.Windows.Forms.ListBox readyPizzas;
        private System.Windows.Forms.Button btnMarkAsReady;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label label2;
    }
}

