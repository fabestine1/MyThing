namespace TraineeRegistration
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
            this.tbBillingTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBillingNrOfCourses = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbBillingDetails = new System.Windows.Forms.GroupBox();
            this.tbBillingName = new System.Windows.Forms.TextBox();
            this.btnShowBeginnerCourses = new System.Windows.Forms.Button();
            this.btnShowAllCourses = new System.Windows.Forms.Button();
            this.btnShowBillingDetails = new System.Windows.Forms.Button();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.gpSelectedCourses = new System.Windows.Forms.GroupBox();
            this.btnChangeCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.rbBeginner = new System.Windows.Forms.RadioButton();
            this.rbIntermediate = new System.Windows.Forms.RadioButton();
            this.gbCourseDetails = new System.Windows.Forms.GroupBox();
            this.rbAdvanced = new System.Windows.Forms.RadioButton();
            this.btnCreateTrainee = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTraineeDetails = new System.Windows.Forms.GroupBox();
            this.gbBillingDetails.SuspendLayout();
            this.gpSelectedCourses.SuspendLayout();
            this.gbCourseDetails.SuspendLayout();
            this.gbTraineeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBillingTotalPrice
            // 
            this.tbBillingTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBillingTotalPrice.Enabled = false;
            this.tbBillingTotalPrice.Location = new System.Drawing.Point(154, 86);
            this.tbBillingTotalPrice.Name = "tbBillingTotalPrice";
            this.tbBillingTotalPrice.Size = new System.Drawing.Size(93, 24);
            this.tbBillingTotalPrice.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(39, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total price (Euro):";
            // 
            // tbBillingNrOfCourses
            // 
            this.tbBillingNrOfCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBillingNrOfCourses.Enabled = false;
            this.tbBillingNrOfCourses.Location = new System.Drawing.Point(154, 56);
            this.tbBillingNrOfCourses.Name = "tbBillingNrOfCourses";
            this.tbBillingNrOfCourses.Size = new System.Drawing.Size(93, 24);
            this.tbBillingNrOfCourses.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(59, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nr. of courses:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trainee\'s name, age:";
            // 
            // gbBillingDetails
            // 
            this.gbBillingDetails.BackColor = System.Drawing.Color.Khaki;
            this.gbBillingDetails.Controls.Add(this.tbBillingTotalPrice);
            this.gbBillingDetails.Controls.Add(this.label11);
            this.gbBillingDetails.Controls.Add(this.tbBillingNrOfCourses);
            this.gbBillingDetails.Controls.Add(this.label9);
            this.gbBillingDetails.Controls.Add(this.tbBillingName);
            this.gbBillingDetails.Controls.Add(this.label8);
            this.gbBillingDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBillingDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbBillingDetails.Location = new System.Drawing.Point(11, 386);
            this.gbBillingDetails.Name = "gbBillingDetails";
            this.gbBillingDetails.Size = new System.Drawing.Size(367, 126);
            this.gbBillingDetails.TabIndex = 8;
            this.gbBillingDetails.TabStop = false;
            this.gbBillingDetails.Text = "Billing details";
            // 
            // tbBillingName
            // 
            this.tbBillingName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBillingName.Enabled = false;
            this.tbBillingName.Location = new System.Drawing.Point(154, 26);
            this.tbBillingName.Name = "tbBillingName";
            this.tbBillingName.Size = new System.Drawing.Size(182, 24);
            this.tbBillingName.TabIndex = 13;
            // 
            // btnShowBeginnerCourses
            // 
            this.btnShowBeginnerCourses.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBeginnerCourses.ForeColor = System.Drawing.Color.Black;
            this.btnShowBeginnerCourses.Location = new System.Drawing.Point(9, 155);
            this.btnShowBeginnerCourses.Name = "btnShowBeginnerCourses";
            this.btnShowBeginnerCourses.Size = new System.Drawing.Size(159, 26);
            this.btnShowBeginnerCourses.TabIndex = 11;
            this.btnShowBeginnerCourses.Text = "Show beginner courses";
            this.btnShowBeginnerCourses.UseVisualStyleBackColor = true;
            this.btnShowBeginnerCourses.Click += new System.EventHandler(this.btnShowBeginnerCourses_Click);
            // 
            // btnShowAllCourses
            // 
            this.btnShowAllCourses.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllCourses.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllCourses.Location = new System.Drawing.Point(9, 123);
            this.btnShowAllCourses.Name = "btnShowAllCourses";
            this.btnShowAllCourses.Size = new System.Drawing.Size(159, 26);
            this.btnShowAllCourses.TabIndex = 10;
            this.btnShowAllCourses.Text = "Show all courses";
            this.btnShowAllCourses.UseVisualStyleBackColor = true;
            this.btnShowAllCourses.Click += new System.EventHandler(this.btnShowAllCourses_Click);
            // 
            // btnShowBillingDetails
            // 
            this.btnShowBillingDetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBillingDetails.ForeColor = System.Drawing.Color.Black;
            this.btnShowBillingDetails.Location = new System.Drawing.Point(227, 153);
            this.btnShowBillingDetails.Name = "btnShowBillingDetails";
            this.btnShowBillingDetails.Size = new System.Drawing.Size(133, 28);
            this.btnShowBillingDetails.TabIndex = 12;
            this.btnShowBillingDetails.Text = "Show billing details";
            this.btnShowBillingDetails.UseVisualStyleBackColor = true;
            this.btnShowBillingDetails.Click += new System.EventHandler(this.btnShowBillingDetails_Click);
            // 
            // lbCourses
            // 
            this.lbCourses.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.ItemHeight = 15;
            this.lbCourses.Location = new System.Drawing.Point(9, 23);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(351, 94);
            this.lbCourses.TabIndex = 9;
            // 
            // gpSelectedCourses
            // 
            this.gpSelectedCourses.BackColor = System.Drawing.Color.LightBlue;
            this.gpSelectedCourses.Controls.Add(this.btnShowBeginnerCourses);
            this.gpSelectedCourses.Controls.Add(this.btnShowAllCourses);
            this.gpSelectedCourses.Controls.Add(this.btnShowBillingDetails);
            this.gpSelectedCourses.Controls.Add(this.lbCourses);
            this.gpSelectedCourses.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSelectedCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gpSelectedCourses.Location = new System.Drawing.Point(11, 187);
            this.gpSelectedCourses.Name = "gpSelectedCourses";
            this.gpSelectedCourses.Size = new System.Drawing.Size(367, 193);
            this.gpSelectedCourses.TabIndex = 7;
            this.gpSelectedCourses.TabStop = false;
            this.gpSelectedCourses.Text = "Details of selected courses";
            // 
            // btnChangeCourse
            // 
            this.btnChangeCourse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCourse.ForeColor = System.Drawing.Color.Black;
            this.btnChangeCourse.Location = new System.Drawing.Point(254, 52);
            this.btnChangeCourse.Name = "btnChangeCourse";
            this.btnChangeCourse.Size = new System.Drawing.Size(107, 26);
            this.btnChangeCourse.TabIndex = 10;
            this.btnChangeCourse.Text = "Change course";
            this.btnChangeCourse.UseVisualStyleBackColor = true;
            this.btnChangeCourse.Click += new System.EventHandler(this.btnChangeCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.Black;
            this.btnAddCourse.Location = new System.Drawing.Point(140, 52);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(107, 26);
            this.btnAddCourse.TabIndex = 9;
            this.btnAddCourse.Text = "Add course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Level:";
            // 
            // cbCourses
            // 
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Items.AddRange(new object[] {
            "PCS1",
            "PCS2",
            "MATH1",
            "MATH2",
            "EDB1",
            "EDB2",
            "FIS1",
            "FIS2",
            "DUTCH",
            "POPD1",
            "POPD2",
            "WEB1",
            "WEB2"});
            this.cbCourses.Location = new System.Drawing.Point(9, 52);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(121, 24);
            this.cbCourses.TabIndex = 8;
            // 
            // rbBeginner
            // 
            this.rbBeginner.AutoSize = true;
            this.rbBeginner.Checked = true;
            this.rbBeginner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeginner.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbBeginner.Location = new System.Drawing.Point(57, 24);
            this.rbBeginner.Name = "rbBeginner";
            this.rbBeginner.Size = new System.Drawing.Size(78, 20);
            this.rbBeginner.TabIndex = 6;
            this.rbBeginner.TabStop = true;
            this.rbBeginner.Text = "Beginner";
            this.rbBeginner.UseVisualStyleBackColor = true;
            this.rbBeginner.CheckedChanged += new System.EventHandler(this.rbBeginner_CheckedChanged);
            // 
            // rbIntermediate
            // 
            this.rbIntermediate.AutoSize = true;
            this.rbIntermediate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIntermediate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbIntermediate.Location = new System.Drawing.Point(154, 24);
            this.rbIntermediate.Name = "rbIntermediate";
            this.rbIntermediate.Size = new System.Drawing.Size(101, 20);
            this.rbIntermediate.TabIndex = 6;
            this.rbIntermediate.Text = "Intermediate";
            this.rbIntermediate.UseVisualStyleBackColor = true;
            this.rbIntermediate.CheckedChanged += new System.EventHandler(this.rbIntermediate_CheckedChanged);
            // 
            // gbCourseDetails
            // 
            this.gbCourseDetails.BackColor = System.Drawing.Color.PaleGreen;
            this.gbCourseDetails.Controls.Add(this.btnChangeCourse);
            this.gbCourseDetails.Controls.Add(this.btnAddCourse);
            this.gbCourseDetails.Controls.Add(this.label4);
            this.gbCourseDetails.Controls.Add(this.cbCourses);
            this.gbCourseDetails.Controls.Add(this.rbBeginner);
            this.gbCourseDetails.Controls.Add(this.rbIntermediate);
            this.gbCourseDetails.Controls.Add(this.rbAdvanced);
            this.gbCourseDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCourseDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbCourseDetails.Location = new System.Drawing.Point(11, 88);
            this.gbCourseDetails.Name = "gbCourseDetails";
            this.gbCourseDetails.Size = new System.Drawing.Size(367, 93);
            this.gbCourseDetails.TabIndex = 4;
            this.gbCourseDetails.TabStop = false;
            this.gbCourseDetails.Text = "Course details";
            // 
            // rbAdvanced
            // 
            this.rbAdvanced.AutoSize = true;
            this.rbAdvanced.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdvanced.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rbAdvanced.Location = new System.Drawing.Point(271, 24);
            this.rbAdvanced.Name = "rbAdvanced";
            this.rbAdvanced.Size = new System.Drawing.Size(89, 20);
            this.rbAdvanced.TabIndex = 7;
            this.rbAdvanced.Text = "Advanced";
            this.rbAdvanced.UseVisualStyleBackColor = true;
            this.rbAdvanced.CheckedChanged += new System.EventHandler(this.rbAdvanced_CheckedChanged);
            // 
            // btnCreateTrainee
            // 
            this.btnCreateTrainee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrainee.ForeColor = System.Drawing.Color.Black;
            this.btnCreateTrainee.Location = new System.Drawing.Point(254, 28);
            this.btnCreateTrainee.Name = "btnCreateTrainee";
            this.btnCreateTrainee.Size = new System.Drawing.Size(106, 26);
            this.btnCreateTrainee.TabIndex = 3;
            this.btnCreateTrainee.Text = "Create trainee";
            this.btnCreateTrainee.UseVisualStyleBackColor = true;
            this.btnCreateTrainee.Click += new System.EventHandler(this.btnCreateTrainee_Click);
            // 
            // tbAge
            // 
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAge.Location = new System.Drawing.Point(205, 29);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(43, 24);
            this.tbAge.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(59, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(89, 24);
            this.tbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(163, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // gbTraineeDetails
            // 
            this.gbTraineeDetails.BackColor = System.Drawing.Color.Bisque;
            this.gbTraineeDetails.Controls.Add(this.btnCreateTrainee);
            this.gbTraineeDetails.Controls.Add(this.tbAge);
            this.gbTraineeDetails.Controls.Add(this.tbName);
            this.gbTraineeDetails.Controls.Add(this.label3);
            this.gbTraineeDetails.Controls.Add(this.label2);
            this.gbTraineeDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTraineeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbTraineeDetails.Location = new System.Drawing.Point(11, 12);
            this.gbTraineeDetails.Name = "gbTraineeDetails";
            this.gbTraineeDetails.Size = new System.Drawing.Size(367, 70);
            this.gbTraineeDetails.TabIndex = 0;
            this.gbTraineeDetails.TabStop = false;
            this.gbTraineeDetails.Text = "Trainee details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 525);
            this.Controls.Add(this.gbBillingDetails);
            this.Controls.Add(this.gpSelectedCourses);
            this.Controls.Add(this.gbCourseDetails);
            this.Controls.Add(this.gbTraineeDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbBillingDetails.ResumeLayout(false);
            this.gbBillingDetails.PerformLayout();
            this.gpSelectedCourses.ResumeLayout(false);
            this.gbCourseDetails.ResumeLayout(false);
            this.gbCourseDetails.PerformLayout();
            this.gbTraineeDetails.ResumeLayout(false);
            this.gbTraineeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbBillingTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBillingNrOfCourses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbBillingDetails;
        private System.Windows.Forms.TextBox tbBillingName;
        private System.Windows.Forms.Button btnShowBeginnerCourses;
        private System.Windows.Forms.Button btnShowAllCourses;
        private System.Windows.Forms.Button btnShowBillingDetails;
        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.GroupBox gpSelectedCourses;
        private System.Windows.Forms.Button btnChangeCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.RadioButton rbBeginner;
        private System.Windows.Forms.RadioButton rbIntermediate;
        private System.Windows.Forms.GroupBox gbCourseDetails;
        private System.Windows.Forms.RadioButton rbAdvanced;
        private System.Windows.Forms.Button btnCreateTrainee;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTraineeDetails;
    }
}

