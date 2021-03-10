namespace ExamApril2018StartUp
{
    partial class MyBookShelfForm
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.tbBorrower = new System.Windows.Forms.TextBox();
            this.btnCreateTxt = new System.Windows.Forms.Button();
            this.btnAllReadables = new System.Windows.Forms.Button();
            this.btnAllBorrowedBooks = new System.Windows.Forms.Button();
            this.btnReceiveBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.lbReadables = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBorrowId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReceiveId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(3, 6);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(49, 13);
            this.lblPerson.TabIndex = 18;
            this.lblPerson.Text = "Borrower";
            // 
            // tbBorrower
            // 
            this.tbBorrower.Location = new System.Drawing.Point(58, 3);
            this.tbBorrower.Name = "tbBorrower";
            this.tbBorrower.Size = new System.Drawing.Size(82, 20);
            this.tbBorrower.TabIndex = 3;
            // 
            // btnCreateTxt
            // 
            this.btnCreateTxt.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateTxt.ForeColor = System.Drawing.Color.Black;
            this.btnCreateTxt.Location = new System.Drawing.Point(21, 32);
            this.btnCreateTxt.Name = "btnCreateTxt";
            this.btnCreateTxt.Size = new System.Drawing.Size(101, 23);
            this.btnCreateTxt.TabIndex = 7;
            this.btnCreateTxt.Text = "Create text file";
            this.btnCreateTxt.UseVisualStyleBackColor = false;
            this.btnCreateTxt.Click += new System.EventHandler(this.btnBookReport_Click);
            // 
            // btnAllReadables
            // 
            this.btnAllReadables.BackColor = System.Drawing.SystemColors.Control;
            this.btnAllReadables.ForeColor = System.Drawing.Color.Black;
            this.btnAllReadables.Location = new System.Drawing.Point(3, 3);
            this.btnAllReadables.Name = "btnAllReadables";
            this.btnAllReadables.Size = new System.Drawing.Size(101, 23);
            this.btnAllReadables.TabIndex = 1;
            this.btnAllReadables.Text = "View all readables";
            this.btnAllReadables.UseVisualStyleBackColor = false;
            this.btnAllReadables.Click += new System.EventHandler(this.btnAllReadables_Click);
            // 
            // btnAllBorrowedBooks
            // 
            this.btnAllBorrowedBooks.BackColor = System.Drawing.SystemColors.Control;
            this.btnAllBorrowedBooks.ForeColor = System.Drawing.Color.Black;
            this.btnAllBorrowedBooks.Location = new System.Drawing.Point(3, 32);
            this.btnAllBorrowedBooks.Name = "btnAllBorrowedBooks";
            this.btnAllBorrowedBooks.Size = new System.Drawing.Size(101, 46);
            this.btnAllBorrowedBooks.TabIndex = 2;
            this.btnAllBorrowedBooks.Text = "View all borrowed books";
            this.btnAllBorrowedBooks.UseVisualStyleBackColor = false;
            this.btnAllBorrowedBooks.Click += new System.EventHandler(this.btnAllBorrowedBooks_Click);
            // 
            // btnReceiveBook
            // 
            this.btnReceiveBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnReceiveBook.ForeColor = System.Drawing.Color.Black;
            this.btnReceiveBook.Location = new System.Drawing.Point(3, 55);
            this.btnReceiveBook.Name = "btnReceiveBook";
            this.btnReceiveBook.Size = new System.Drawing.Size(102, 23);
            this.btnReceiveBook.TabIndex = 6;
            this.btnReceiveBook.Text = "Receive book";
            this.btnReceiveBook.UseVisualStyleBackColor = false;
            this.btnReceiveBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrowBook.ForeColor = System.Drawing.Color.Black;
            this.btnBorrowBook.Location = new System.Drawing.Point(3, 55);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(137, 23);
            this.btnBorrowBook.TabIndex = 4;
            this.btnBorrowBook.Text = "Borrow book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // lbReadables
            // 
            this.lbReadables.FormattingEnabled = true;
            this.lbReadables.Location = new System.Drawing.Point(12, 12);
            this.lbReadables.Name = "lbReadables";
            this.lbReadables.Size = new System.Drawing.Size(523, 173);
            this.lbReadables.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "book id";
            // 
            // tbBorrowId
            // 
            this.tbBorrowId.Location = new System.Drawing.Point(58, 29);
            this.tbBorrowId.Name = "tbBorrowId";
            this.tbBorrowId.Size = new System.Drawing.Size(38, 20);
            this.tbBorrowId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "book id";
            // 
            // tbReceiveId
            // 
            this.tbReceiveId.Location = new System.Drawing.Point(67, 3);
            this.tbReceiveId.Name = "tbReceiveId";
            this.tbReceiveId.Size = new System.Drawing.Size(38, 20);
            this.tbReceiveId.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnBorrowBook);
            this.panel1.Controls.Add(this.tbBorrowId);
            this.panel1.Controls.Add(this.tbBorrower);
            this.panel1.Controls.Add(this.lblPerson);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(127, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 83);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnReceiveBook);
            this.panel2.Controls.Add(this.tbReceiveId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(278, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 83);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.btnAllReadables);
            this.panel3.Controls.Add(this.btnAllBorrowedBooks);
            this.panel3.Location = new System.Drawing.Point(12, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 83);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.btnCreateTxt);
            this.panel4.Location = new System.Drawing.Point(392, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 83);
            this.panel4.TabIndex = 26;
            // 
            // MyBookShelfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 282);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbReadables);
            this.Name = "MyBookShelfForm";
            this.Text = "My bookshelf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TextBox tbBorrower;
        private System.Windows.Forms.Button btnCreateTxt;
        private System.Windows.Forms.Button btnAllReadables;
        private System.Windows.Forms.Button btnAllBorrowedBooks;
        private System.Windows.Forms.Button btnReceiveBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.ListBox lbReadables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBorrowId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReceiveId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

