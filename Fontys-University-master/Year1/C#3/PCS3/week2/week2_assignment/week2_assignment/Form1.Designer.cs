namespace week2_assignment
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
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.btnAddEc = new System.Windows.Forms.Button();
            this.btnNewYear = new System.Windows.Forms.Button();
            this.btnBDay = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbPerson = new System.Windows.Forms.RadioButton();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbEc = new System.Windows.Forms.TextBox();
            this.grpTeacher = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbYearsAtSchool = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPcn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchPcn = new System.Windows.Forms.Button();
            this.btnYoungerThan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.tbYoungerThan = new System.Windows.Forms.TextBox();
            this.tbSearchByPcn = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.tbDisplayPcn = new System.Windows.Forms.TextBox();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.grpAll.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpTeacher.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAll
            // 
            this.grpAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpAll.Controls.Add(this.btnAddEc);
            this.grpAll.Controls.Add(this.btnNewYear);
            this.grpAll.Controls.Add(this.btnBDay);
            this.grpAll.Controls.Add(this.btnInfo);
            this.grpAll.Controls.Add(this.btnPerson);
            this.grpAll.Controls.Add(this.rbTeacher);
            this.grpAll.Controls.Add(this.rbStudent);
            this.grpAll.Controls.Add(this.rbPerson);
            this.grpAll.Controls.Add(this.grpStudent);
            this.grpAll.Controls.Add(this.grpTeacher);
            this.grpAll.Controls.Add(this.tbYearsAtSchool);
            this.grpAll.Controls.Add(this.tbAge);
            this.grpAll.Controls.Add(this.tbName);
            this.grpAll.Controls.Add(this.tbPcn);
            this.grpAll.Controls.Add(this.label4);
            this.grpAll.Controls.Add(this.label3);
            this.grpAll.Controls.Add(this.label2);
            this.grpAll.Controls.Add(this.label1);
            this.grpAll.Location = new System.Drawing.Point(12, 12);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(674, 267);
            this.grpAll.TabIndex = 0;
            this.grpAll.TabStop = false;
            this.grpAll.Text = "groupBox1";
            // 
            // btnAddEc
            // 
            this.btnAddEc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEc.Location = new System.Drawing.Point(536, 152);
            this.btnAddEc.Name = "btnAddEc";
            this.btnAddEc.Size = new System.Drawing.Size(66, 36);
            this.btnAddEc.TabIndex = 4;
            this.btnAddEc.Text = "add EC\'s";
            this.btnAddEc.UseVisualStyleBackColor = true;
            // 
            // btnNewYear
            // 
            this.btnNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewYear.Location = new System.Drawing.Point(536, 110);
            this.btnNewYear.Name = "btnNewYear";
            this.btnNewYear.Size = new System.Drawing.Size(66, 36);
            this.btnNewYear.TabIndex = 4;
            this.btnNewYear.Text = "new school year";
            this.btnNewYear.UseVisualStyleBackColor = true;
            this.btnNewYear.Click += new System.EventHandler(this.btnNewYear_Click);
            // 
            // btnBDay
            // 
            this.btnBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBDay.Location = new System.Drawing.Point(464, 110);
            this.btnBDay.Name = "btnBDay";
            this.btnBDay.Size = new System.Drawing.Size(66, 36);
            this.btnBDay.TabIndex = 4;
            this.btnBDay.Text = "celeb bday";
            this.btnBDay.UseVisualStyleBackColor = true;
            this.btnBDay.Click += new System.EventHandler(this.btnBDay_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(392, 110);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(66, 36);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "show info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerson.Location = new System.Drawing.Point(320, 110);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(66, 36);
            this.btnPerson.TabIndex = 4;
            this.btnPerson.Text = "new person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTeacher.Location = new System.Drawing.Point(320, 72);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(75, 22);
            this.rbTeacher.TabIndex = 3;
            this.rbTeacher.TabStop = true;
            this.rbTeacher.Text = "teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            this.rbTeacher.CheckedChanged += new System.EventHandler(this.rbTeacher_CheckedChanged);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStudent.Location = new System.Drawing.Point(320, 44);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(74, 22);
            this.rbStudent.TabIndex = 3;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "student";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.rbStudent_CheckedChanged);
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerson.Location = new System.Drawing.Point(320, 16);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(72, 22);
            this.rbPerson.TabIndex = 3;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "person";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbPerson_CheckedChanged);
            // 
            // grpStudent
            // 
            this.grpStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpStudent.Controls.Add(this.label5);
            this.grpStudent.Controls.Add(this.label8);
            this.grpStudent.Controls.Add(this.tbCountry);
            this.grpStudent.Controls.Add(this.tbEc);
            this.grpStudent.Location = new System.Drawing.Point(19, 167);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(205, 100);
            this.grpStudent.TabIndex = 2;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Extra for students";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "EC\'s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "country";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(90, 25);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 1;
            // 
            // tbEc
            // 
            this.tbEc.Location = new System.Drawing.Point(90, 55);
            this.tbEc.Name = "tbEc";
            this.tbEc.Size = new System.Drawing.Size(100, 20);
            this.tbEc.TabIndex = 1;
            // 
            // grpTeacher
            // 
            this.grpTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grpTeacher.Controls.Add(this.label6);
            this.grpTeacher.Controls.Add(this.tbSalary);
            this.grpTeacher.Location = new System.Drawing.Point(230, 167);
            this.grpTeacher.Name = "grpTeacher";
            this.grpTeacher.Size = new System.Drawing.Size(205, 100);
            this.grpTeacher.TabIndex = 2;
            this.grpTeacher.TabStop = false;
            this.grpTeacher.Text = "Extra for teachers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "salary";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(90, 25);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 1;
            // 
            // tbYearsAtSchool
            // 
            this.tbYearsAtSchool.Location = new System.Drawing.Point(109, 111);
            this.tbYearsAtSchool.Name = "tbYearsAtSchool";
            this.tbYearsAtSchool.Size = new System.Drawing.Size(100, 20);
            this.tbYearsAtSchool.TabIndex = 1;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(109, 81);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPcn
            // 
            this.tbPcn.Location = new System.Drawing.Point(109, 21);
            this.tbPcn.Name = "tbPcn";
            this.tbPcn.Size = new System.Drawing.Size(100, 20);
            this.tbPcn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "years school";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "pcn";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpOutput.Controls.Add(this.btnSearchName);
            this.grpOutput.Controls.Add(this.btnSearchPcn);
            this.grpOutput.Controls.Add(this.btnYoungerThan);
            this.grpOutput.Controls.Add(this.label9);
            this.grpOutput.Controls.Add(this.label10);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.tbSearchByName);
            this.grpOutput.Controls.Add(this.tbYoungerThan);
            this.grpOutput.Controls.Add(this.tbSearchByPcn);
            this.grpOutput.Controls.Add(this.btnShowAll);
            this.grpOutput.Controls.Add(this.btnClearList);
            this.grpOutput.Controls.Add(this.lbInfo);
            this.grpOutput.Controls.Add(this.tbDisplayPcn);
            this.grpOutput.Controls.Add(this.tbDisplayName);
            this.grpOutput.Location = new System.Drawing.Point(12, 285);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(674, 370);
            this.grpOutput.TabIndex = 0;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "groupBox1";
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(183, 332);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(54, 24);
            this.btnSearchName.TabIndex = 9;
            this.btnSearchName.Text = "search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearchPcn
            // 
            this.btnSearchPcn.Location = new System.Drawing.Point(183, 276);
            this.btnSearchPcn.Name = "btnSearchPcn";
            this.btnSearchPcn.Size = new System.Drawing.Size(54, 24);
            this.btnSearchPcn.TabIndex = 9;
            this.btnSearchPcn.Text = "search";
            this.btnSearchPcn.UseVisualStyleBackColor = true;
            this.btnSearchPcn.Click += new System.EventHandler(this.btnSearchPcn_Click);
            // 
            // btnYoungerThan
            // 
            this.btnYoungerThan.Location = new System.Drawing.Point(404, 276);
            this.btnYoungerThan.Name = "btnYoungerThan";
            this.btnYoungerThan.Size = new System.Drawing.Size(54, 24);
            this.btnYoungerThan.TabIndex = 8;
            this.btnYoungerThan.Text = "search";
            this.btnYoungerThan.UseVisualStyleBackColor = true;
            this.btnYoungerThan.Click += new System.EventHandler(this.btnYoungerThan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Search by name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(249, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Person younger than";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Search by pcn";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(137, 306);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(100, 20);
            this.tbSearchByName.TabIndex = 6;
            // 
            // tbYoungerThan
            // 
            this.tbYoungerThan.Location = new System.Drawing.Point(404, 250);
            this.tbYoungerThan.Name = "tbYoungerThan";
            this.tbYoungerThan.Size = new System.Drawing.Size(54, 20);
            this.tbYoungerThan.TabIndex = 6;
            // 
            // tbSearchByPcn
            // 
            this.tbSearchByPcn.Location = new System.Drawing.Point(137, 250);
            this.tbSearchByPcn.Name = "tbSearchByPcn";
            this.tbSearchByPcn.Size = new System.Drawing.Size(100, 20);
            this.tbSearchByPcn.TabIndex = 6;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(464, 166);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(66, 36);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(464, 208);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(66, 36);
            this.btnClearList.TabIndex = 4;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(19, 19);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(439, 225);
            this.lbInfo.TabIndex = 0;
            // 
            // tbDisplayPcn
            // 
            this.tbDisplayPcn.Location = new System.Drawing.Point(464, 53);
            this.tbDisplayPcn.Name = "tbDisplayPcn";
            this.tbDisplayPcn.Size = new System.Drawing.Size(153, 20);
            this.tbDisplayPcn.TabIndex = 1;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(464, 23);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(153, 20);
            this.tbDisplayName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 734);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAll.ResumeLayout(false);
            this.grpAll.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpTeacher.ResumeLayout(false);
            this.grpTeacher.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.Button btnAddEc;
        private System.Windows.Forms.Button btnNewYear;
        private System.Windows.Forms.Button btnBDay;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbPerson;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbEc;
        private System.Windows.Forms.GroupBox grpTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbYearsAtSchool;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPcn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.TextBox tbDisplayPcn;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnYoungerThan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.TextBox tbYoungerThan;
        private System.Windows.Forms.TextBox tbSearchByPcn;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchPcn;
    }
}

