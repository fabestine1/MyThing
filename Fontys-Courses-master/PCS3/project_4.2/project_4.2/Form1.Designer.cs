namespace project_4._2
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStudentNumber = new System.Windows.Forms.TextBox();
            this.tbxMark = new System.Windows.Forms.TextBox();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnCalculateAverageMark = new System.Windows.Forms.Button();
            this.lbxMarks = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblNewMark = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblAverageMarkResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(118, 16);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxStudentNumber
            // 
            this.tbxStudentNumber.Location = new System.Drawing.Point(118, 54);
            this.tbxStudentNumber.Name = "tbxStudentNumber";
            this.tbxStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentNumber.TabIndex = 1;
            // 
            // tbxMark
            // 
            this.tbxMark.Location = new System.Drawing.Point(93, 106);
            this.tbxMark.Name = "tbxMark";
            this.tbxMark.Size = new System.Drawing.Size(100, 20);
            this.tbxMark.TabIndex = 2;
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(118, 136);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(75, 23);
            this.btnAddMark.TabIndex = 3;
            this.btnAddMark.Text = "add mark";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(249, 16);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(120, 23);
            this.btnCreateStudent.TabIndex = 4;
            this.btnCreateStudent.Text = "create student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnCalculateAverageMark
            // 
            this.btnCalculateAverageMark.Location = new System.Drawing.Point(249, 209);
            this.btnCalculateAverageMark.Name = "btnCalculateAverageMark";
            this.btnCalculateAverageMark.Size = new System.Drawing.Size(120, 23);
            this.btnCalculateAverageMark.TabIndex = 5;
            this.btnCalculateAverageMark.Text = "calculate average mark";
            this.btnCalculateAverageMark.UseVisualStyleBackColor = true;
            this.btnCalculateAverageMark.Click += new System.EventHandler(this.btnCalculateAverageMark_Click);
            // 
            // lbxMarks
            // 
            this.lbxMarks.FormattingEnabled = true;
            this.lbxMarks.Location = new System.Drawing.Point(249, 108);
            this.lbxMarks.Name = "lbxMarks";
            this.lbxMarks.Size = new System.Drawing.Size(120, 95);
            this.lbxMarks.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "name";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(26, 57);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(80, 13);
            this.lblStudentNumber.TabIndex = 8;
            this.lblStudentNumber.Text = "student number";
            // 
            // lblNewMark
            // 
            this.lblNewMark.AutoSize = true;
            this.lblNewMark.Location = new System.Drawing.Point(26, 110);
            this.lblNewMark.Name = "lblNewMark";
            this.lblNewMark.Size = new System.Drawing.Size(56, 13);
            this.lblNewMark.TabIndex = 9;
            this.lblNewMark.Text = "new mark:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(246, 83);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(35, 13);
            this.lblMarks.TabIndex = 10;
            this.lblMarks.Text = "marks";
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Location = new System.Drawing.Point(235, 247);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(85, 13);
            this.lblAverageMark.TabIndex = 11;
            this.lblAverageMark.Text = "average mark is:";
            // 
            // lblAverageMarkResult
            // 
            this.lblAverageMarkResult.AutoSize = true;
            this.lblAverageMarkResult.Location = new System.Drawing.Point(335, 247);
            this.lblAverageMarkResult.Name = "lblAverageMarkResult";
            this.lblAverageMarkResult.Size = new System.Drawing.Size(0, 13);
            this.lblAverageMarkResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 309);
            this.Controls.Add(this.lblAverageMarkResult);
            this.Controls.Add(this.lblAverageMark);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblNewMark);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbxMarks);
            this.Controls.Add(this.btnCalculateAverageMark);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.tbxMark);
            this.Controls.Add(this.tbxStudentNumber);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStudentNumber;
        private System.Windows.Forms.TextBox tbxMark;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnCalculateAverageMark;
        private System.Windows.Forms.ListBox lbxMarks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblNewMark;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblAverageMarkResult;
    }
}

