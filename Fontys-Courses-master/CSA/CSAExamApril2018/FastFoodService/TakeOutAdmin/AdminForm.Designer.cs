namespace TakeOutAdmin
{
    partial class AdminForm
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
            this.btGetOrders = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.btReady = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderReady = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGetOrders
            // 
            this.btGetOrders.Location = new System.Drawing.Point(13, 13);
            this.btGetOrders.Name = "btGetOrders";
            this.btGetOrders.Size = new System.Drawing.Size(75, 23);
            this.btGetOrders.TabIndex = 0;
            this.btGetOrders.Text = "Get Orders";
            this.btGetOrders.UseVisualStyleBackColor = true;
            this.btGetOrders.Click += new System.EventHandler(this.btGetOrders_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(94, 13);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(135, 95);
            this.lbOrders.TabIndex = 1;
            // 
            // btReady
            // 
            this.btReady.Location = new System.Drawing.Point(12, 85);
            this.btReady.Name = "btReady";
            this.btReady.Size = new System.Drawing.Size(75, 23);
            this.btReady.TabIndex = 2;
            this.btReady.Text = "Ready";
            this.btReady.UseVisualStyleBackColor = true;
            this.btReady.Click += new System.EventHandler(this.btDeliver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ready:";
            // 
            // tbOrderReady
            // 
            this.tbOrderReady.BackColor = System.Drawing.Color.PaleGreen;
            this.tbOrderReady.Location = new System.Drawing.Point(94, 130);
            this.tbOrderReady.Name = "tbOrderReady";
            this.tbOrderReady.ReadOnly = true;
            this.tbOrderReady.Size = new System.Drawing.Size(135, 20);
            this.tbOrderReady.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 162);
            this.Controls.Add(this.tbOrderReady);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReady);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.btGetOrders);
            this.Name = "AdminForm";
            this.Text = "Take Out Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGetOrders;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button btReady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrderReady;
    }
}

