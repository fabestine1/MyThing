namespace _6._5
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lsbCounter = new System.Windows.Forms.ListBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fifth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sixth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(153, 275);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(97, 41);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lsbCounter
            // 
            this.lsbCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lsbCounter.FormattingEnabled = true;
            this.lsbCounter.ItemHeight = 20;
            this.lsbCounter.Location = new System.Drawing.Point(390, 12);
            this.lsbCounter.Name = "lsbCounter";
            this.lsbCounter.Size = new System.Drawing.Size(155, 224);
            this.lsbCounter.TabIndex = 3;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First,
            this.Second,
            this.Thrid,
            this.Forth,
            this.Fifth,
            this.Sixth});
            this.dgvTable.Location = new System.Drawing.Point(10, 12);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(345, 257);
            this.dgvTable.TabIndex = 4;
            // 
            // First
            // 
            this.First.HeaderText = "1";
            this.First.Name = "First";
            this.First.Width = 50;
            // 
            // Second
            // 
            this.Second.HeaderText = "2";
            this.Second.Name = "Second";
            this.Second.Width = 50;
            // 
            // Thrid
            // 
            this.Thrid.HeaderText = "3";
            this.Thrid.Name = "Thrid";
            this.Thrid.Width = 50;
            // 
            // Forth
            // 
            this.Forth.HeaderText = "4";
            this.Forth.Name = "Forth";
            this.Forth.Width = 50;
            // 
            // Fifth
            // 
            this.Fifth.HeaderText = "5";
            this.Fifth.Name = "Fifth";
            this.Fifth.Width = 50;
            // 
            // Sixth
            // 
            this.Sixth.HeaderText = "6";
            this.Sixth.Name = "Sixth";
            this.Sixth.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(601, 324);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.lsbCounter);
            this.Controls.Add(this.btnRoll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListBox lsbCounter;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fifth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sixth;
    }
}

