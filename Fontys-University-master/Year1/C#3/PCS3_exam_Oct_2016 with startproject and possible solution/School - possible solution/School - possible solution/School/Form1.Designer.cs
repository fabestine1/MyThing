namespace School
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
            this.gbAddCourse = new System.Windows.Forms.GroupBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblMaxNrOfParticipants = new System.Windows.Forms.Label();
            this.tbMaxNrPart = new System.Windows.Forms.TextBox();
            this.lblMinNrPart = new System.Windows.Forms.Label();
            this.tbMinNrPart = new System.Windows.Forms.TextBox();
            this.rbOnlineCourse = new System.Windows.Forms.RadioButton();
            this.rbClassroomCourse = new System.Windows.Forms.RadioButton();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.tbCourseId = new System.Windows.Forms.TextBox();
            this.lbCourseOverview = new System.Windows.Forms.ListBox();
            this.lblCourseOverview = new System.Windows.Forms.Label();
            this.btnOverviewAll = new System.Windows.Forms.Button();
            this.btnOverviewAllThatTakePlace = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.tbParticipantName = new System.Windows.Forms.TextBox();
            this.lblParticipantName = new System.Windows.Forms.Label();
            this.lblParticipantId = new System.Windows.Forms.Label();
            this.tbParticipantId = new System.Windows.Forms.TextBox();
            this.gbAddCourse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddCourse
            // 
            this.gbAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbAddCourse.Controls.Add(this.tbTotalPrice);
            this.gbAddCourse.Controls.Add(this.lblTotalPrice);
            this.gbAddCourse.Controls.Add(this.lblMaxNrOfParticipants);
            this.gbAddCourse.Controls.Add(this.tbMaxNrPart);
            this.gbAddCourse.Controls.Add(this.lblMinNrPart);
            this.gbAddCourse.Controls.Add(this.tbMinNrPart);
            this.gbAddCourse.Controls.Add(this.rbOnlineCourse);
            this.gbAddCourse.Controls.Add(this.rbClassroomCourse);
            this.gbAddCourse.Controls.Add(this.btnAddCourse);
            this.gbAddCourse.Controls.Add(this.lblCourseName);
            this.gbAddCourse.Controls.Add(this.tbCourseName);
            this.gbAddCourse.Controls.Add(this.lblCourseId);
            this.gbAddCourse.Controls.Add(this.tbCourseId);
            this.gbAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCourse.Location = new System.Drawing.Point(12, 26);
            this.gbAddCourse.Name = "gbAddCourse";
            this.gbAddCourse.Size = new System.Drawing.Size(327, 299);
            this.gbAddCourse.TabIndex = 0;
            this.gbAddCourse.TabStop = false;
            this.gbAddCourse.Text = "Add course";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(135, 108);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(133, 24);
            this.tbTotalPrice.TabIndex = 12;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(32, 111);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(77, 18);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "Total price";
            // 
            // lblMaxNrOfParticipants
            // 
            this.lblMaxNrOfParticipants.AutoSize = true;
            this.lblMaxNrOfParticipants.Location = new System.Drawing.Point(24, 233);
            this.lblMaxNrOfParticipants.Name = "lblMaxNrOfParticipants";
            this.lblMaxNrOfParticipants.Size = new System.Drawing.Size(149, 18);
            this.lblMaxNrOfParticipants.TabIndex = 10;
            this.lblMaxNrOfParticipants.Text = "Max nr of participants";
            // 
            // tbMaxNrPart
            // 
            this.tbMaxNrPart.Location = new System.Drawing.Point(173, 230);
            this.tbMaxNrPart.Name = "tbMaxNrPart";
            this.tbMaxNrPart.Size = new System.Drawing.Size(133, 24);
            this.tbMaxNrPart.TabIndex = 9;
            // 
            // lblMinNrPart
            // 
            this.lblMinNrPart.AutoSize = true;
            this.lblMinNrPart.Location = new System.Drawing.Point(22, 191);
            this.lblMinNrPart.Name = "lblMinNrPart";
            this.lblMinNrPart.Size = new System.Drawing.Size(145, 18);
            this.lblMinNrPart.TabIndex = 8;
            this.lblMinNrPart.Text = "Min nr of participants";
            // 
            // tbMinNrPart
            // 
            this.tbMinNrPart.Location = new System.Drawing.Point(173, 188);
            this.tbMinNrPart.Name = "tbMinNrPart";
            this.tbMinNrPart.Size = new System.Drawing.Size(133, 24);
            this.tbMinNrPart.TabIndex = 7;
            // 
            // rbOnlineCourse
            // 
            this.rbOnlineCourse.AutoSize = true;
            this.rbOnlineCourse.Location = new System.Drawing.Point(197, 148);
            this.rbOnlineCourse.Name = "rbOnlineCourse";
            this.rbOnlineCourse.Size = new System.Drawing.Size(118, 22);
            this.rbOnlineCourse.TabIndex = 6;
            this.rbOnlineCourse.TabStop = true;
            this.rbOnlineCourse.Text = "Online course";
            this.rbOnlineCourse.UseVisualStyleBackColor = true;
            // 
            // rbClassroomCourse
            // 
            this.rbClassroomCourse.AutoSize = true;
            this.rbClassroomCourse.Checked = true;
            this.rbClassroomCourse.Location = new System.Drawing.Point(35, 148);
            this.rbClassroomCourse.Name = "rbClassroomCourse";
            this.rbClassroomCourse.Size = new System.Drawing.Size(150, 22);
            this.rbClassroomCourse.TabIndex = 5;
            this.rbClassroomCourse.TabStop = true;
            this.rbClassroomCourse.Text = "Classroom course";
            this.rbClassroomCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Lime;
            this.btnAddCourse.Location = new System.Drawing.Point(95, 260);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(133, 31);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Add course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(32, 75);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(98, 18);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Course name";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(135, 72);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(133, 24);
            this.tbCourseName.TabIndex = 2;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(32, 39);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(72, 18);
            this.lblCourseId.TabIndex = 1;
            this.lblCourseId.Text = "Course id";
            // 
            // tbCourseId
            // 
            this.tbCourseId.Location = new System.Drawing.Point(135, 36);
            this.tbCourseId.Name = "tbCourseId";
            this.tbCourseId.Size = new System.Drawing.Size(133, 24);
            this.tbCourseId.TabIndex = 0;
            // 
            // lbCourseOverview
            // 
            this.lbCourseOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseOverview.FormattingEnabled = true;
            this.lbCourseOverview.ItemHeight = 16;
            this.lbCourseOverview.Location = new System.Drawing.Point(345, 48);
            this.lbCourseOverview.Name = "lbCourseOverview";
            this.lbCourseOverview.Size = new System.Drawing.Size(741, 340);
            this.lbCourseOverview.TabIndex = 1;
            // 
            // lblCourseOverview
            // 
            this.lblCourseOverview.AutoSize = true;
            this.lblCourseOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseOverview.Location = new System.Drawing.Point(357, 26);
            this.lblCourseOverview.Name = "lblCourseOverview";
            this.lblCourseOverview.Size = new System.Drawing.Size(144, 18);
            this.lblCourseOverview.TabIndex = 2;
            this.lblCourseOverview.Text = "Overview of courses";
            // 
            // btnOverviewAll
            // 
            this.btnOverviewAll.BackColor = System.Drawing.Color.Lime;
            this.btnOverviewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverviewAll.Location = new System.Drawing.Point(404, 409);
            this.btnOverviewAll.Name = "btnOverviewAll";
            this.btnOverviewAll.Size = new System.Drawing.Size(138, 63);
            this.btnOverviewAll.TabIndex = 3;
            this.btnOverviewAll.Text = "Overview of all courses";
            this.btnOverviewAll.UseVisualStyleBackColor = false;
            this.btnOverviewAll.Click += new System.EventHandler(this.btnOverviewAll_Click);
            // 
            // btnOverviewAllThatTakePlace
            // 
            this.btnOverviewAllThatTakePlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOverviewAllThatTakePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverviewAllThatTakePlace.Location = new System.Drawing.Point(651, 409);
            this.btnOverviewAllThatTakePlace.Name = "btnOverviewAllThatTakePlace";
            this.btnOverviewAllThatTakePlace.Size = new System.Drawing.Size(142, 63);
            this.btnOverviewAllThatTakePlace.TabIndex = 4;
            this.btnOverviewAllThatTakePlace.Text = "Overview of all courses that take place";
            this.btnOverviewAllThatTakePlace.UseVisualStyleBackColor = false;
            this.btnOverviewAllThatTakePlace.Click += new System.EventHandler(this.btnOverviewAllThatTakePlace_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(896, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 63);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save overview";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSaveOverview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnAddParticipant);
            this.groupBox1.Controls.Add(this.tbParticipantName);
            this.groupBox1.Controls.Add(this.lblParticipantName);
            this.groupBox1.Controls.Add(this.lblParticipantId);
            this.groupBox1.Controls.Add(this.tbParticipantId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add participant";
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddParticipant.Location = new System.Drawing.Point(69, 84);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(184, 36);
            this.btnAddParticipant.TabIndex = 4;
            this.btnAddParticipant.Text = "Add participant to course";
            this.btnAddParticipant.UseVisualStyleBackColor = false;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // tbParticipantName
            // 
            this.tbParticipantName.Location = new System.Drawing.Point(153, 54);
            this.tbParticipantName.Name = "tbParticipantName";
            this.tbParticipantName.Size = new System.Drawing.Size(100, 24);
            this.tbParticipantName.TabIndex = 3;
            // 
            // lblParticipantName
            // 
            this.lblParticipantName.AutoSize = true;
            this.lblParticipantName.Location = new System.Drawing.Point(24, 57);
            this.lblParticipantName.Name = "lblParticipantName";
            this.lblParticipantName.Size = new System.Drawing.Size(118, 18);
            this.lblParticipantName.TabIndex = 2;
            this.lblParticipantName.Text = "Participant name";
            // 
            // lblParticipantId
            // 
            this.lblParticipantId.AutoSize = true;
            this.lblParticipantId.Location = new System.Drawing.Point(24, 25);
            this.lblParticipantId.Name = "lblParticipantId";
            this.lblParticipantId.Size = new System.Drawing.Size(88, 18);
            this.lblParticipantId.TabIndex = 1;
            this.lblParticipantId.Text = "ParticipantId";
            // 
            // tbParticipantId
            // 
            this.tbParticipantId.Location = new System.Drawing.Point(153, 22);
            this.tbParticipantId.Name = "tbParticipantId";
            this.tbParticipantId.Size = new System.Drawing.Size(100, 24);
            this.tbParticipantId.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOverviewAllThatTakePlace);
            this.Controls.Add(this.btnOverviewAll);
            this.Controls.Add(this.lblCourseOverview);
            this.Controls.Add(this.lbCourseOverview);
            this.Controls.Add(this.gbAddCourse);
            this.Name = "Form1";
            this.Text = "Course management application";
            this.gbAddCourse.ResumeLayout(false);
            this.gbAddCourse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddCourse;
        private System.Windows.Forms.Label lblMaxNrOfParticipants;
        private System.Windows.Forms.TextBox tbMaxNrPart;
        private System.Windows.Forms.Label lblMinNrPart;
        private System.Windows.Forms.TextBox tbMinNrPart;
        private System.Windows.Forms.RadioButton rbOnlineCourse;
        private System.Windows.Forms.RadioButton rbClassroomCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.TextBox tbCourseId;
        private System.Windows.Forms.ListBox lbCourseOverview;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblCourseOverview;
        private System.Windows.Forms.Button btnOverviewAll;
        private System.Windows.Forms.Button btnOverviewAllThatTakePlace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.TextBox tbParticipantName;
        private System.Windows.Forms.Label lblParticipantName;
        private System.Windows.Forms.Label lblParticipantId;
        private System.Windows.Forms.TextBox tbParticipantId;
    }
}

