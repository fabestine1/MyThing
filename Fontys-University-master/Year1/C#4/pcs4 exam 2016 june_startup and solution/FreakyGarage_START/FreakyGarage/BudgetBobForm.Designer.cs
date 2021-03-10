namespace FreakyGarage
{
    partial class BudgetBobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetBobForm));
            this.lbBudgetBob = new System.Windows.Forms.ListBox();
            this.pbCheapCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheapCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBudgetBob
            // 
            this.lbBudgetBob.FormattingEnabled = true;
            this.lbBudgetBob.Location = new System.Drawing.Point(37, 109);
            this.lbBudgetBob.Name = "lbBudgetBob";
            this.lbBudgetBob.Size = new System.Drawing.Size(657, 251);
            this.lbBudgetBob.TabIndex = 0;
            // 
            // pbCheapCar
            // 
            this.pbCheapCar.Image = ((System.Drawing.Image)(resources.GetObject("pbCheapCar.Image")));
            this.pbCheapCar.Location = new System.Drawing.Point(280, 12);
            this.pbCheapCar.Name = "pbCheapCar";
            this.pbCheapCar.Size = new System.Drawing.Size(162, 91);
            this.pbCheapCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheapCar.TabIndex = 1;
            this.pbCheapCar.TabStop = false;
            // 
            // BudgetBobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 384);
            this.Controls.Add(this.pbCheapCar);
            this.Controls.Add(this.lbBudgetBob);
            this.Name = "BudgetBobForm";
            this.Text = "Budget Bob";
            ((System.ComponentModel.ISupportInitialize)(this.pbCheapCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBudgetBob;
        private System.Windows.Forms.PictureBox pbCheapCar;
    }
}