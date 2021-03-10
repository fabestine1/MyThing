namespace Deliveries
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
            this.btLoad = new System.Windows.Forms.Button();
            this.btSortByWeight = new System.Windows.Forms.Button();
            this.btSortByName = new System.Windows.Forms.Button();
            this.btSortById = new System.Windows.Forms.Button();
            this.btSortByAddress = new System.Windows.Forms.Button();
            this.btSortForPostman = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(153, 25);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "LOAD ALL";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSortByWeight
            // 
            this.btSortByWeight.Location = new System.Drawing.Point(16, 96);
            this.btSortByWeight.Name = "btSortByWeight";
            this.btSortByWeight.Size = new System.Drawing.Size(212, 23);
            this.btSortByWeight.TabIndex = 1;
            this.btSortByWeight.Text = "SORT BY WEIGHT";
            this.btSortByWeight.UseVisualStyleBackColor = true;
            this.btSortByWeight.Click += new System.EventHandler(this.btSortByWeight_Click);
            // 
            // btSortByName
            // 
            this.btSortByName.Location = new System.Drawing.Point(16, 143);
            this.btSortByName.Name = "btSortByName";
            this.btSortByName.Size = new System.Drawing.Size(212, 23);
            this.btSortByName.TabIndex = 2;
            this.btSortByName.Text = "SORT BY BUYER\'S NAME";
            this.btSortByName.UseVisualStyleBackColor = true;
            this.btSortByName.Click += new System.EventHandler(this.btSortByName_Click);
            // 
            // btSortById
            // 
            this.btSortById.Location = new System.Drawing.Point(16, 190);
            this.btSortById.Name = "btSortById";
            this.btSortById.Size = new System.Drawing.Size(212, 23);
            this.btSortById.TabIndex = 3;
            this.btSortById.Text = "SORT BY ID";
            this.btSortById.UseVisualStyleBackColor = true;
            this.btSortById.Click += new System.EventHandler(this.btSortById_Click);
            // 
            // btSortByAddress
            // 
            this.btSortByAddress.Location = new System.Drawing.Point(16, 237);
            this.btSortByAddress.Name = "btSortByAddress";
            this.btSortByAddress.Size = new System.Drawing.Size(212, 23);
            this.btSortByAddress.TabIndex = 4;
            this.btSortByAddress.Text = "SORT BY ADDRESS";
            this.btSortByAddress.UseVisualStyleBackColor = true;
            this.btSortByAddress.Click += new System.EventHandler(this.btSortByAddress_Click);
            // 
            // btSortForPostman
            // 
            this.btSortForPostman.Location = new System.Drawing.Point(16, 284);
            this.btSortForPostman.Name = "btSortForPostman";
            this.btSortForPostman.Size = new System.Drawing.Size(212, 23);
            this.btSortForPostman.TabIndex = 5;
            this.btSortForPostman.Text = "SORT FOR THE POSTMAN";
            this.btSortForPostman.UseVisualStyleBackColor = true;
            this.btSortForPostman.Click += new System.EventHandler(this.btSortForPostman_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(254, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(713, 324);
            this.listBox1.TabIndex = 6;
            // 
            // btMerge
            // 
            this.btMerge.Location = new System.Drawing.Point(16, 25);
            this.btMerge.Name = "btMerge";
            this.btMerge.Size = new System.Drawing.Size(75, 23);
            this.btMerge.TabIndex = 7;
            this.btMerge.Text = "MERGE";
            this.btMerge.UseVisualStyleBackColor = true;
            this.btMerge.Click += new System.EventHandler(this.btMerge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 381);
            this.Controls.Add(this.btMerge);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btSortForPostman);
            this.Controls.Add(this.btSortByAddress);
            this.Controls.Add(this.btSortById);
            this.Controls.Add(this.btSortByName);
            this.Controls.Add(this.btSortByWeight);
            this.Controls.Add(this.btLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSortByWeight;
        private System.Windows.Forms.Button btSortByName;
        private System.Windows.Forms.Button btSortById;
        private System.Windows.Forms.Button btSortByAddress;
        private System.Windows.Forms.Button btSortForPostman;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btMerge;
    }
}

