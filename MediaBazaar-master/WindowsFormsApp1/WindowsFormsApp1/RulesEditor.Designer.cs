namespace MediaBazar
{
    partial class RulesEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.AddRulebtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.lbRuleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rule description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(12, 239);
            this.tbDescription.MaxLength = 255;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(547, 64);
            this.tbDescription.TabIndex = 11;
            // 
            // AddRulebtn
            // 
            this.AddRulebtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRulebtn.Location = new System.Drawing.Point(12, 309);
            this.AddRulebtn.Name = "AddRulebtn";
            this.AddRulebtn.Size = new System.Drawing.Size(351, 33);
            this.AddRulebtn.TabIndex = 12;
            this.AddRulebtn.Text = "Add Rule";
            this.AddRulebtn.UseVisualStyleBackColor = true;
            this.AddRulebtn.Click += new System.EventHandler(this.AddRulebtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(369, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(186, 33);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // lbRuleList
            // 
            this.lbRuleList.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuleList.FormattingEnabled = true;
            this.lbRuleList.HorizontalScrollbar = true;
            this.lbRuleList.ItemHeight = 22;
            this.lbRuleList.Location = new System.Drawing.Point(12, 12);
            this.lbRuleList.Name = "lbRuleList";
            this.lbRuleList.Size = new System.Drawing.Size(547, 202);
            this.lbRuleList.TabIndex = 16;
            // 
            // RulesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 350);
            this.Controls.Add(this.lbRuleList);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.AddRulebtn);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Name = "RulesEditor";
            this.Text = "RulesEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button AddRulebtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox lbRuleList;
    }
}