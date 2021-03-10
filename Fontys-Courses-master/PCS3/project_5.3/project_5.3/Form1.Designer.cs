namespace project_5._3
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
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.tbYearsAtSchool = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPCN = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPCN = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblYearsAtSchool = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSelebrateBirthday = new System.Windows.Forms.Button();
            this.btnStartAnotherSchoolYear = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(22, 37);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(390, 95);
            this.lbxPeople.TabIndex = 0;
            // 
            // tbYearsAtSchool
            // 
            this.tbYearsAtSchool.Location = new System.Drawing.Point(114, 267);
            this.tbYearsAtSchool.Name = "tbYearsAtSchool";
            this.tbYearsAtSchool.Size = new System.Drawing.Size(100, 20);
            this.tbYearsAtSchool.TabIndex = 1;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(114, 234);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 2;
            // 
            // tbPCN
            // 
            this.tbPCN.Location = new System.Drawing.Point(114, 202);
            this.tbPCN.Name = "tbPCN";
            this.tbPCN.Size = new System.Drawing.Size(100, 20);
            this.tbPCN.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(114, 167);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(238, 205);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(238, 167);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblPCN
            // 
            this.lblPCN.AutoSize = true;
            this.lblPCN.Location = new System.Drawing.Point(25, 205);
            this.lblPCN.Name = "lblPCN";
            this.lblPCN.Size = new System.Drawing.Size(32, 13);
            this.lblPCN.TabIndex = 9;
            this.lblPCN.Text = "PCN:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(25, 237);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age:";
            // 
            // lblYearsAtSchool
            // 
            this.lblYearsAtSchool.AutoSize = true;
            this.lblYearsAtSchool.Location = new System.Drawing.Point(25, 270);
            this.lblYearsAtSchool.Name = "lblYearsAtSchool";
            this.lblYearsAtSchool.Size = new System.Drawing.Size(83, 13);
            this.lblYearsAtSchool.TabIndex = 11;
            this.lblYearsAtSchool.Text = "Years at school:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(238, 304);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSelebrateBirthday
            // 
            this.btnSelebrateBirthday.Location = new System.Drawing.Point(331, 167);
            this.btnSelebrateBirthday.Name = "btnSelebrateBirthday";
            this.btnSelebrateBirthday.Size = new System.Drawing.Size(75, 51);
            this.btnSelebrateBirthday.TabIndex = 14;
            this.btnSelebrateBirthday.Text = "Celebrate birthday";
            this.btnSelebrateBirthday.UseVisualStyleBackColor = true;
            this.btnSelebrateBirthday.Click += new System.EventHandler(this.btnSelebrateBirthday_Click);
            // 
            // btnStartAnotherSchoolYear
            // 
            this.btnStartAnotherSchoolYear.Location = new System.Drawing.Point(331, 224);
            this.btnStartAnotherSchoolYear.Name = "btnStartAnotherSchoolYear";
            this.btnStartAnotherSchoolYear.Size = new System.Drawing.Size(75, 50);
            this.btnStartAnotherSchoolYear.TabIndex = 15;
            this.btnStartAnotherSchoolYear.Text = "Start another school year";
            this.btnStartAnotherSchoolYear.UseVisualStyleBackColor = true;
            this.btnStartAnotherSchoolYear.Click += new System.EventHandler(this.btnStartAnotherSchoolYear_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(331, 289);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfo.TabIndex = 16;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 352);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnStartAnotherSchoolYear);
            this.Controls.Add(this.btnSelebrateBirthday);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblYearsAtSchool);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPCN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPCN);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbYearsAtSchool);
            this.Controls.Add(this.lbxPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.TextBox tbYearsAtSchool;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbPCN;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPCN;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblYearsAtSchool;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSelebrateBirthday;
        private System.Windows.Forms.Button btnStartAnotherSchoolYear;
        private System.Windows.Forms.Button btnShowInfo;
    }
}

