namespace PCS2_Exam_Solution
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.radioButtonAllBooks = new System.Windows.Forms.RadioButton();
			this.radioButtonHorror = new System.Windows.Forms.RadioButton();
			this.radioButtonComedy = new System.Windows.Forms.RadioButton();
			this.radioButtonCooking = new System.Windows.Forms.RadioButton();
			this.radioButtonDrama = new System.Windows.Forms.RadioButton();
			this.radioButtonFantasy = new System.Windows.Forms.RadioButton();
			this.buttonDisplayBooks = new System.Windows.Forms.Button();
			this.buttonHistory = new System.Windows.Forms.Button();
			this.listBoxBooks = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDownAddPrice = new System.Windows.Forms.NumericUpDown();
			this.lblEurosAdd = new System.Windows.Forms.Label();
			this.lblPriceAdd = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioButtonHorrorAdd = new System.Windows.Forms.RadioButton();
			this.radioButtonComedyAdd = new System.Windows.Forms.RadioButton();
			this.radioButtonCookingAdd = new System.Windows.Forms.RadioButton();
			this.radioButtonFantasyAdd = new System.Windows.Forms.RadioButton();
			this.radioButtonDramaAdd = new System.Windows.Forms.RadioButton();
			this.textBoxTitleAdd = new System.Windows.Forms.TextBox();
			this.lblAuthorAdd = new System.Windows.Forms.Label();
			this.numCopiesAdd = new System.Windows.Forms.NumericUpDown();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblNameAdd = new System.Windows.Forms.Label();
			this.textBoxAuthorAdd = new System.Windows.Forms.TextBox();
			this.buttonAddNewBook = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonSellBook = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPrice)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCopiesAdd)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.buttonDisplayBooks);
			this.groupBox1.Controls.Add(this.buttonHistory);
			this.groupBox1.Controls.Add(this.listBoxBooks);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(230, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(510, 291);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock Overview";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.radioButtonAllBooks);
			this.groupBox5.Controls.Add(this.radioButtonHorror);
			this.groupBox5.Controls.Add(this.radioButtonComedy);
			this.groupBox5.Controls.Add(this.radioButtonCooking);
			this.groupBox5.Controls.Add(this.radioButtonDrama);
			this.groupBox5.Controls.Add(this.radioButtonFantasy);
			this.groupBox5.Location = new System.Drawing.Point(6, 233);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(217, 58);
			this.groupBox5.TabIndex = 28;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Display";
			// 
			// radioButtonAllBooks
			// 
			this.radioButtonAllBooks.AutoSize = true;
			this.radioButtonAllBooks.Checked = true;
			this.radioButtonAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonAllBooks.Location = new System.Drawing.Point(6, 15);
			this.radioButtonAllBooks.Name = "radioButtonAllBooks";
			this.radioButtonAllBooks.Size = new System.Drawing.Size(69, 17);
			this.radioButtonAllBooks.TabIndex = 22;
			this.radioButtonAllBooks.TabStop = true;
			this.radioButtonAllBooks.Text = "All Books";
			this.radioButtonAllBooks.UseVisualStyleBackColor = true;
			// 
			// radioButtonHorror
			// 
			this.radioButtonHorror.AutoSize = true;
			this.radioButtonHorror.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonHorror.Location = new System.Drawing.Point(151, 36);
			this.radioButtonHorror.Name = "radioButtonHorror";
			this.radioButtonHorror.Size = new System.Drawing.Size(54, 17);
			this.radioButtonHorror.TabIndex = 27;
			this.radioButtonHorror.Text = "Horror";
			this.radioButtonHorror.UseVisualStyleBackColor = true;
			// 
			// radioButtonComedy
			// 
			this.radioButtonComedy.AutoSize = true;
			this.radioButtonComedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonComedy.Location = new System.Drawing.Point(6, 36);
			this.radioButtonComedy.Name = "radioButtonComedy";
			this.radioButtonComedy.Size = new System.Drawing.Size(63, 17);
			this.radioButtonComedy.TabIndex = 23;
			this.radioButtonComedy.Text = "Comedy";
			this.radioButtonComedy.UseVisualStyleBackColor = true;
			// 
			// radioButtonCooking
			// 
			this.radioButtonCooking.AutoSize = true;
			this.radioButtonCooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonCooking.Location = new System.Drawing.Point(81, 15);
			this.radioButtonCooking.Name = "radioButtonCooking";
			this.radioButtonCooking.Size = new System.Drawing.Size(64, 17);
			this.radioButtonCooking.TabIndex = 26;
			this.radioButtonCooking.Text = "Cooking";
			this.radioButtonCooking.UseVisualStyleBackColor = true;
			// 
			// radioButtonDrama
			// 
			this.radioButtonDrama.AutoSize = true;
			this.radioButtonDrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonDrama.Location = new System.Drawing.Point(81, 36);
			this.radioButtonDrama.Name = "radioButtonDrama";
			this.radioButtonDrama.Size = new System.Drawing.Size(56, 17);
			this.radioButtonDrama.TabIndex = 24;
			this.radioButtonDrama.Text = "Drama";
			this.radioButtonDrama.UseVisualStyleBackColor = true;
			// 
			// radioButtonFantasy
			// 
			this.radioButtonFantasy.AutoSize = true;
			this.radioButtonFantasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonFantasy.Location = new System.Drawing.Point(151, 15);
			this.radioButtonFantasy.Name = "radioButtonFantasy";
			this.radioButtonFantasy.Size = new System.Drawing.Size(62, 17);
			this.radioButtonFantasy.TabIndex = 25;
			this.radioButtonFantasy.Text = "Fantasy";
			this.radioButtonFantasy.UseVisualStyleBackColor = true;
			// 
			// buttonDisplayBooks
			// 
			this.buttonDisplayBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDisplayBooks.Location = new System.Drawing.Point(229, 237);
			this.buttonDisplayBooks.Name = "buttonDisplayBooks";
			this.buttonDisplayBooks.Size = new System.Drawing.Size(89, 48);
			this.buttonDisplayBooks.TabIndex = 21;
			this.buttonDisplayBooks.Text = "Display books";
			this.buttonDisplayBooks.UseVisualStyleBackColor = true;
			this.buttonDisplayBooks.Click += new System.EventHandler(this.buttonDisplayBooks_Click);
			// 
			// buttonHistory
			// 
			this.buttonHistory.Location = new System.Drawing.Point(402, 237);
			this.buttonHistory.Name = "buttonHistory";
			this.buttonHistory.Size = new System.Drawing.Size(102, 48);
			this.buttonHistory.TabIndex = 17;
			this.buttonHistory.Text = "History (Bonus)";
			this.buttonHistory.UseVisualStyleBackColor = true;
			this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
			// 
			// listBoxBooks
			// 
			this.listBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxBooks.FormattingEnabled = true;
			this.listBoxBooks.Location = new System.Drawing.Point(6, 19);
			this.listBoxBooks.Name = "listBoxBooks";
			this.listBoxBooks.Size = new System.Drawing.Size(498, 212);
			this.listBoxBooks.TabIndex = 15;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
			this.groupBox2.Controls.Add(this.numericUpDownAddPrice);
			this.groupBox2.Controls.Add(this.lblEurosAdd);
			this.groupBox2.Controls.Add(this.lblPriceAdd);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.textBoxTitleAdd);
			this.groupBox2.Controls.Add(this.lblAuthorAdd);
			this.groupBox2.Controls.Add(this.numCopiesAdd);
			this.groupBox2.Controls.Add(this.lblAmount);
			this.groupBox2.Controls.Add(this.lblNameAdd);
			this.groupBox2.Controls.Add(this.textBoxAuthorAdd);
			this.groupBox2.Controls.Add(this.buttonAddNewBook);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(212, 234);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "New Book";
			// 
			// numericUpDownAddPrice
			// 
			this.numericUpDownAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownAddPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownAddPrice.Location = new System.Drawing.Point(75, 72);
			this.numericUpDownAddPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownAddPrice.Name = "numericUpDownAddPrice";
			this.numericUpDownAddPrice.Size = new System.Drawing.Size(131, 20);
			this.numericUpDownAddPrice.TabIndex = 18;
			this.numericUpDownAddPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblEurosAdd
			// 
			this.lblEurosAdd.AutoSize = true;
			this.lblEurosAdd.Location = new System.Drawing.Point(55, 74);
			this.lblEurosAdd.Name = "lblEurosAdd";
			this.lblEurosAdd.Size = new System.Drawing.Size(14, 13);
			this.lblEurosAdd.TabIndex = 16;
			this.lblEurosAdd.Text = "€";
			// 
			// lblPriceAdd
			// 
			this.lblPriceAdd.AutoSize = true;
			this.lblPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriceAdd.Location = new System.Drawing.Point(6, 74);
			this.lblPriceAdd.Name = "lblPriceAdd";
			this.lblPriceAdd.Size = new System.Drawing.Size(34, 13);
			this.lblPriceAdd.TabIndex = 14;
			this.lblPriceAdd.Text = "Price:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.radioButtonHorrorAdd);
			this.groupBox4.Controls.Add(this.radioButtonComedyAdd);
			this.groupBox4.Controls.Add(this.radioButtonCookingAdd);
			this.groupBox4.Controls.Add(this.radioButtonFantasyAdd);
			this.groupBox4.Controls.Add(this.radioButtonDramaAdd);
			this.groupBox4.Location = new System.Drawing.Point(9, 97);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(197, 74);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Genre:";
			// 
			// radioButtonHorrorAdd
			// 
			this.radioButtonHorrorAdd.AutoSize = true;
			this.radioButtonHorrorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonHorrorAdd.Location = new System.Drawing.Point(137, 21);
			this.radioButtonHorrorAdd.Name = "radioButtonHorrorAdd";
			this.radioButtonHorrorAdd.Size = new System.Drawing.Size(54, 17);
			this.radioButtonHorrorAdd.TabIndex = 7;
			this.radioButtonHorrorAdd.TabStop = true;
			this.radioButtonHorrorAdd.Text = "Horror";
			this.radioButtonHorrorAdd.UseVisualStyleBackColor = true;
			// 
			// radioButtonComedyAdd
			// 
			this.radioButtonComedyAdd.AutoSize = true;
			this.radioButtonComedyAdd.Checked = true;
			this.radioButtonComedyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonComedyAdd.Location = new System.Drawing.Point(6, 19);
			this.radioButtonComedyAdd.Name = "radioButtonComedyAdd";
			this.radioButtonComedyAdd.Size = new System.Drawing.Size(63, 17);
			this.radioButtonComedyAdd.TabIndex = 5;
			this.radioButtonComedyAdd.TabStop = true;
			this.radioButtonComedyAdd.Text = "Comedy";
			this.radioButtonComedyAdd.UseVisualStyleBackColor = true;
			// 
			// radioButtonCookingAdd
			// 
			this.radioButtonCookingAdd.AutoSize = true;
			this.radioButtonCookingAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonCookingAdd.Location = new System.Drawing.Point(6, 42);
			this.radioButtonCookingAdd.Name = "radioButtonCookingAdd";
			this.radioButtonCookingAdd.Size = new System.Drawing.Size(64, 17);
			this.radioButtonCookingAdd.TabIndex = 8;
			this.radioButtonCookingAdd.TabStop = true;
			this.radioButtonCookingAdd.Text = "Cooking";
			this.radioButtonCookingAdd.UseVisualStyleBackColor = true;
			// 
			// radioButtonFantasyAdd
			// 
			this.radioButtonFantasyAdd.AutoSize = true;
			this.radioButtonFantasyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonFantasyAdd.Location = new System.Drawing.Point(75, 44);
			this.radioButtonFantasyAdd.Name = "radioButtonFantasyAdd";
			this.radioButtonFantasyAdd.Size = new System.Drawing.Size(62, 17);
			this.radioButtonFantasyAdd.TabIndex = 9;
			this.radioButtonFantasyAdd.TabStop = true;
			this.radioButtonFantasyAdd.Text = "Fantasy";
			this.radioButtonFantasyAdd.UseVisualStyleBackColor = true;
			// 
			// radioButtonDramaAdd
			// 
			this.radioButtonDramaAdd.AutoSize = true;
			this.radioButtonDramaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonDramaAdd.Location = new System.Drawing.Point(75, 21);
			this.radioButtonDramaAdd.Name = "radioButtonDramaAdd";
			this.radioButtonDramaAdd.Size = new System.Drawing.Size(56, 17);
			this.radioButtonDramaAdd.TabIndex = 6;
			this.radioButtonDramaAdd.TabStop = true;
			this.radioButtonDramaAdd.Text = "Drama";
			this.radioButtonDramaAdd.UseVisualStyleBackColor = true;
			// 
			// textBoxTitleAdd
			// 
			this.textBoxTitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTitleAdd.Location = new System.Drawing.Point(58, 19);
			this.textBoxTitleAdd.Name = "textBoxTitleAdd";
			this.textBoxTitleAdd.Size = new System.Drawing.Size(148, 20);
			this.textBoxTitleAdd.TabIndex = 1;
			// 
			// lblAuthorAdd
			// 
			this.lblAuthorAdd.AutoSize = true;
			this.lblAuthorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAuthorAdd.Location = new System.Drawing.Point(6, 48);
			this.lblAuthorAdd.Name = "lblAuthorAdd";
			this.lblAuthorAdd.Size = new System.Drawing.Size(41, 13);
			this.lblAuthorAdd.TabIndex = 9;
			this.lblAuthorAdd.Text = "Author:";
			// 
			// numCopiesAdd
			// 
			this.numCopiesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numCopiesAdd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numCopiesAdd.Location = new System.Drawing.Point(58, 177);
			this.numCopiesAdd.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numCopiesAdd.Name = "numCopiesAdd";
			this.numCopiesAdd.Size = new System.Drawing.Size(148, 20);
			this.numCopiesAdd.TabIndex = 10;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmount.Location = new System.Drawing.Point(6, 179);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(42, 13);
			this.lblAmount.TabIndex = 6;
			this.lblAmount.Text = "Copies:";
			// 
			// lblNameAdd
			// 
			this.lblNameAdd.AutoSize = true;
			this.lblNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNameAdd.Location = new System.Drawing.Point(6, 22);
			this.lblNameAdd.Name = "lblNameAdd";
			this.lblNameAdd.Size = new System.Drawing.Size(30, 13);
			this.lblNameAdd.TabIndex = 5;
			this.lblNameAdd.Text = "Title:";
			// 
			// textBoxAuthorAdd
			// 
			this.textBoxAuthorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAuthorAdd.Location = new System.Drawing.Point(58, 45);
			this.textBoxAuthorAdd.Name = "textBoxAuthorAdd";
			this.textBoxAuthorAdd.Size = new System.Drawing.Size(148, 20);
			this.textBoxAuthorAdd.TabIndex = 2;
			// 
			// buttonAddNewBook
			// 
			this.buttonAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddNewBook.Location = new System.Drawing.Point(6, 203);
			this.buttonAddNewBook.Name = "buttonAddNewBook";
			this.buttonAddNewBook.Size = new System.Drawing.Size(200, 23);
			this.buttonAddNewBook.TabIndex = 11;
			this.buttonAddNewBook.Text = "Add Books";
			this.buttonAddNewBook.UseVisualStyleBackColor = true;
			this.buttonAddNewBook.Click += new System.EventHandler(this.buttonAddBook_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
			this.groupBox3.Controls.Add(this.buttonSellBook);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 252);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(212, 51);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sell Book";
			// 
			// buttonSellBook
			// 
			this.buttonSellBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSellBook.Location = new System.Drawing.Point(6, 19);
			this.buttonSellBook.Name = "buttonSellBook";
			this.buttonSellBook.Size = new System.Drawing.Size(200, 23);
			this.buttonSellBook.TabIndex = 14;
			this.buttonSellBook.Text = "Sell Book";
			this.buttonSellBook.UseVisualStyleBackColor = true;
			this.buttonSellBook.Click += new System.EventHandler(this.buttonSellBook_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(752, 317);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.MaximumSize = new System.Drawing.Size(768, 355);
			this.MinimumSize = new System.Drawing.Size(768, 355);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bookstore";
			this.groupBox1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPrice)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCopiesAdd)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxBooks;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxTitleAdd;
		private System.Windows.Forms.Label lblAuthorAdd;
		private System.Windows.Forms.NumericUpDown numCopiesAdd;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label lblNameAdd;
		private System.Windows.Forms.RadioButton radioButtonFantasyAdd;
		private System.Windows.Forms.RadioButton radioButtonComedyAdd;
		private System.Windows.Forms.TextBox textBoxAuthorAdd;
		private System.Windows.Forms.Button buttonAddNewBook;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButtonCookingAdd;
		private System.Windows.Forms.RadioButton radioButtonDramaAdd;
		private System.Windows.Forms.RadioButton radioButtonHorrorAdd;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button buttonSellBook;
		private System.Windows.Forms.Label lblEurosAdd;
		private System.Windows.Forms.Label lblPriceAdd;
		private System.Windows.Forms.Button buttonHistory;
		private System.Windows.Forms.NumericUpDown numericUpDownAddPrice;
		private System.Windows.Forms.Button buttonDisplayBooks;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton radioButtonAllBooks;
		private System.Windows.Forms.RadioButton radioButtonHorror;
		private System.Windows.Forms.RadioButton radioButtonComedy;
		private System.Windows.Forms.RadioButton radioButtonCooking;
		private System.Windows.Forms.RadioButton radioButtonDrama;
		private System.Windows.Forms.RadioButton radioButtonFantasy;
	}
}

