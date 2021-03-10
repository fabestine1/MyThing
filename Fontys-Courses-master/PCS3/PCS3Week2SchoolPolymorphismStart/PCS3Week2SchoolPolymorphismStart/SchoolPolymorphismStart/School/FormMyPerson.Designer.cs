namespace School
{
    partial class FormMyPerson
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
            this.buttonBirthday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMyPersonInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSchoolYear = new System.Windows.Forms.Button();
            this.richTextBoxActivityLogMyPerson = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPCN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonPerson = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.buttonPromotion = new System.Windows.Forms.Button();
            this.buttonAddModuleECs = new System.Windows.Forms.Button();
            this.listBoxAllPersons = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBirthday
            // 
            this.buttonBirthday.Location = new System.Drawing.Point(180, 321);
            this.buttonBirthday.Name = "buttonBirthday";
            this.buttonBirthday.Size = new System.Drawing.Size(114, 27);
            this.buttonBirthday.TabIndex = 7;
            this.buttonBirthday.Text = "celebrate birthday!";
            this.buttonBirthday.UseVisualStyleBackColor = true;
            this.buttonBirthday.Click += new System.EventHandler(this.buttonBirthdayStudent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMyPersonInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 122);
            this.panel1.TabIndex = 10;
            // 
            // labelMyPersonInfo
            // 
            this.labelMyPersonInfo.AutoSize = true;
            this.labelMyPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelMyPersonInfo.Location = new System.Drawing.Point(10, 29);
            this.labelMyPersonInfo.Name = "labelMyPersonInfo";
            this.labelMyPersonInfo.Size = new System.Drawing.Size(74, 13);
            this.labelMyPersonInfo.TabIndex = 22;
            this.labelMyPersonInfo.Text = "please create!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "my person:";
            // 
            // buttonSchoolYear
            // 
            this.buttonSchoolYear.Location = new System.Drawing.Point(180, 290);
            this.buttonSchoolYear.Name = "buttonSchoolYear";
            this.buttonSchoolYear.Size = new System.Drawing.Size(114, 27);
            this.buttonSchoolYear.TabIndex = 12;
            this.buttonSchoolYear.Text = "another school year";
            this.buttonSchoolYear.UseVisualStyleBackColor = true;
            this.buttonSchoolYear.Click += new System.EventHandler(this.buttonSchoolYearTeacher_Click);
            // 
            // richTextBoxActivityLogMyPerson
            // 
            this.richTextBoxActivityLogMyPerson.Location = new System.Drawing.Point(370, 23);
            this.richTextBoxActivityLogMyPerson.Name = "richTextBoxActivityLogMyPerson";
            this.richTextBoxActivityLogMyPerson.Size = new System.Drawing.Size(234, 458);
            this.richTextBoxActivityLogMyPerson.TabIndex = 16;
            this.richTextBoxActivityLogMyPerson.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "action log";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(120, 189);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 32;
            this.buttonCreate.Text = "create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeacher.Controls.Add(this.textBoxSalary);
            this.panelTeacher.Controls.Add(this.label7);
            this.panelTeacher.Location = new System.Drawing.Point(247, 115);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(106, 59);
            this.panelTeacher.TabIndex = 31;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(47, 6);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(50, 20);
            this.textBoxSalary.TabIndex = 13;
            this.textBoxSalary.Text = "1500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "salary";
            // 
            // panelStudent
            // 
            this.panelStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudent.Controls.Add(this.textBoxStudentNumber);
            this.panelStudent.Controls.Add(this.label6);
            this.panelStudent.Controls.Add(this.label5);
            this.panelStudent.Controls.Add(this.textBoxCountry);
            this.panelStudent.Location = new System.Drawing.Point(78, 115);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(163, 59);
            this.panelStudent.TabIndex = 30;
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(87, 29);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(65, 20);
            this.textBoxStudentNumber.TabIndex = 13;
            this.textBoxStudentNumber.Text = "222222";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "student number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(87, 3);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(65, 20);
            this.textBoxCountry.TabIndex = 11;
            this.textBoxCountry.Text = "USA";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(93, 62);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(261, 20);
            this.textBoxAge.TabIndex = 29;
            this.textBoxAge.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "age";
            // 
            // textBoxPCN
            // 
            this.textBoxPCN.Location = new System.Drawing.Point(93, 36);
            this.textBoxPCN.Name = "textBoxPCN";
            this.textBoxPCN.Size = new System.Drawing.Size(261, 20);
            this.textBoxPCN.TabIndex = 27;
            this.textBoxPCN.Text = "123456";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "pcn";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 20);
            this.textBoxName.TabIndex = 25;
            this.textBoxName.Text = "Peter Smith";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "name";
            // 
            // radioButtonPerson
            // 
            this.radioButtonPerson.AutoSize = true;
            this.radioButtonPerson.Checked = true;
            this.radioButtonPerson.Location = new System.Drawing.Point(12, 92);
            this.radioButtonPerson.Name = "radioButtonPerson";
            this.radioButtonPerson.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPerson.TabIndex = 34;
            this.radioButtonPerson.TabStop = true;
            this.radioButtonPerson.Text = "person";
            this.radioButtonPerson.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(78, 92);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(60, 17);
            this.radioButtonStudent.TabIndex = 35;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Location = new System.Drawing.Point(247, 92);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(61, 17);
            this.radioButtonTeacher.TabIndex = 36;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "teacher";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // buttonPromotion
            // 
            this.buttonPromotion.Location = new System.Drawing.Point(180, 354);
            this.buttonPromotion.Name = "buttonPromotion";
            this.buttonPromotion.Size = new System.Drawing.Size(114, 23);
            this.buttonPromotion.TabIndex = 37;
            this.buttonPromotion.Text = "make promotion";
            this.buttonPromotion.UseVisualStyleBackColor = true;
            this.buttonPromotion.Click += new System.EventHandler(this.buttonPromotion_Click);
            // 
            // buttonAddModuleECs
            // 
            this.buttonAddModuleECs.Location = new System.Drawing.Point(180, 385);
            this.buttonAddModuleECs.Name = "buttonAddModuleECs";
            this.buttonAddModuleECs.Size = new System.Drawing.Size(114, 23);
            this.buttonAddModuleECs.TabIndex = 38;
            this.buttonAddModuleECs.Text = "add module ECs";
            this.buttonAddModuleECs.UseVisualStyleBackColor = true;
            this.buttonAddModuleECs.Click += new System.EventHandler(this.buttonAddModuleECs_Click);
            // 
            // listBoxAllPersons
            // 
            this.listBoxAllPersons.FormattingEnabled = true;
            this.listBoxAllPersons.Location = new System.Drawing.Point(11, 218);
            this.listBoxAllPersons.Name = "listBoxAllPersons";
            this.listBoxAllPersons.Size = new System.Drawing.Size(343, 43);
            this.listBoxAllPersons.TabIndex = 39;
            this.listBoxAllPersons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAllPersons_MouseClick);
            // 
            // FormMyPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 496);
            this.Controls.Add(this.listBoxAllPersons);
            this.Controls.Add(this.buttonAddModuleECs);
            this.Controls.Add(this.buttonPromotion);
            this.Controls.Add(this.radioButtonTeacher);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.radioButtonPerson);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPCN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxActivityLogMyPerson);
            this.Controls.Add(this.buttonSchoolYear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBirthday);
            this.Name = "FormMyPerson";
            this.Text = "School Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBirthday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSchoolYear;
        private System.Windows.Forms.RichTextBox richTextBoxActivityLogMyPerson;
        private System.Windows.Forms.Label labelMyPersonInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPCN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonPerson;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonTeacher;
        private System.Windows.Forms.Button buttonPromotion;
        private System.Windows.Forms.Button buttonAddModuleECs;
        private System.Windows.Forms.ListBox listBoxAllPersons;
    }
}

