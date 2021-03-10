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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.rbtnID = new System.Windows.Forms.RadioButton();
            this.rbtnBuyerName = new System.Windows.Forms.RadioButton();
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
            this.btSortByWeight.Location = new System.Drawing.Point(16, 125);
            this.btSortByWeight.Name = "btSortByWeight";
            this.btSortByWeight.Size = new System.Drawing.Size(212, 23);
            this.btSortByWeight.TabIndex = 1;
            this.btSortByWeight.Text = "SORT BY WEIGHT";
            this.btSortByWeight.UseVisualStyleBackColor = true;
            this.btSortByWeight.Click += new System.EventHandler(this.btSortByWeight_Click);
            // 
            // btSortByName
            // 
            this.btSortByName.Location = new System.Drawing.Point(16, 172);
            this.btSortByName.Name = "btSortByName";
            this.btSortByName.Size = new System.Drawing.Size(212, 23);
            this.btSortByName.TabIndex = 2;
            this.btSortByName.Text = "SORT BY BUYER\'S NAME";
            this.btSortByName.UseVisualStyleBackColor = true;
            this.btSortByName.Click += new System.EventHandler(this.btSortByName_Click);
            // 
            // btSortById
            // 
            this.btSortById.Location = new System.Drawing.Point(16, 219);
            this.btSortById.Name = "btSortById";
            this.btSortById.Size = new System.Drawing.Size(212, 23);
            this.btSortById.TabIndex = 3;
            this.btSortById.Text = "SORT BY ID";
            this.btSortById.UseVisualStyleBackColor = true;
            this.btSortById.Click += new System.EventHandler(this.btSortById_Click);
            // 
            // btSortByAddress
            // 
            this.btSortByAddress.Location = new System.Drawing.Point(16, 266);
            this.btSortByAddress.Name = "btSortByAddress";
            this.btSortByAddress.Size = new System.Drawing.Size(212, 23);
            this.btSortByAddress.TabIndex = 4;
            this.btSortByAddress.Text = "SORT BY ADDRESS";
            this.btSortByAddress.UseVisualStyleBackColor = true;
            this.btSortByAddress.Click += new System.EventHandler(this.btSortByAddress_Click);
            // 
            // btSortForPostman
            // 
            this.btSortForPostman.Location = new System.Drawing.Point(16, 313);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(153, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(16, 63);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(131, 20);
            this.tbxSearch.TabIndex = 9;
            // 
            // rbtnID
            // 
            this.rbtnID.AutoSize = true;
            this.rbtnID.Checked = true;
            this.rbtnID.Location = new System.Drawing.Point(16, 89);
            this.rbtnID.Name = "rbtnID";
            this.rbtnID.Size = new System.Drawing.Size(36, 17);
            this.rbtnID.TabIndex = 10;
            this.rbtnID.TabStop = true;
            this.rbtnID.Text = "ID";
            this.rbtnID.UseVisualStyleBackColor = true;
            // 
            // rbtnBuyerName
            // 
            this.rbtnBuyerName.AutoSize = true;
            this.rbtnBuyerName.Location = new System.Drawing.Point(66, 89);
            this.rbtnBuyerName.Name = "rbtnBuyerName";
            this.rbtnBuyerName.Size = new System.Drawing.Size(81, 17);
            this.rbtnBuyerName.TabIndex = 11;
            this.rbtnBuyerName.Text = "Buyer name";
            this.rbtnBuyerName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 381);
            this.Controls.Add(this.rbtnBuyerName);
            this.Controls.Add(this.rbtnID);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSearch);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.RadioButton rbtnID;
        private System.Windows.Forms.RadioButton rbtnBuyerName;
    }
}

