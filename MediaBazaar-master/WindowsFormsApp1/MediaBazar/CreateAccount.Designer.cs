namespace MediaBazar
{
    partial class CreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nHourlyWage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtbContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbMorningShift = new System.Windows.Forms.CheckBox();
            this.cbAfternoonShift = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEveningShift = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.btnAddOtherContact = new System.Windows.Forms.Button();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.btnOpenContact = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.btnChangeShifts = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nHourlyWage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(946, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employment details";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(26, 136);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(283, 40);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.Text = "First name";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(26, 201);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(283, 40);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.Text = "Last name";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(26, 262);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthdate.Size = new System.Drawing.Size(283, 40);
            this.dtpBirthdate.TabIndex = 4;
            this.dtpBirthdate.Value = new System.DateTime(2020, 2, 29, 0, 51, 0, 0);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(24, 581);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(283, 40);
            this.tbPhoneNumber.TabIndex = 7;
            this.tbPhoneNumber.Text = "Phone number";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(24, 636);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(283, 40);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Text = "Email address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account type:";
            // 
            // nHourlyWage
            // 
            this.nHourlyWage.DecimalPlaces = 2;
            this.nHourlyWage.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHourlyWage.Location = new System.Drawing.Point(1141, 76);
            this.nHourlyWage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nHourlyWage.Name = "nHourlyWage";
            this.nHourlyWage.Size = new System.Drawing.Size(107, 40);
            this.nHourlyWage.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(952, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hourly wage:";
            // 
            // dtbContractStartDate
            // 
            this.dtbContractStartDate.CalendarFont = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbContractStartDate.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbContractStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbContractStartDate.Location = new System.Drawing.Point(958, 156);
            this.dtbContractStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtbContractStartDate.Name = "dtbContractStartDate";
            this.dtbContractStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtbContractStartDate.Size = new System.Drawing.Size(290, 40);
            this.dtbContractStartDate.TabIndex = 17;
            this.dtbContractStartDate.Value = new System.DateTime(2020, 2, 29, 0, 51, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(952, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contract start date:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(960, 206);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(288, 41);
            this.cmbDepartment.TabIndex = 18;
            this.cmbDepartment.Text = "Department";
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonday.Location = new System.Drawing.Point(855, 325);
            this.cbMonday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(135, 33);
            this.cbMonday.TabIndex = 19;
            this.cbMonday.Text = "Monday";
            this.cbMonday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbMonday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesday.Location = new System.Drawing.Point(855, 361);
            this.cbTuesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(135, 33);
            this.cbTuesday.TabIndex = 20;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbTuesday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursday.Location = new System.Drawing.Point(856, 438);
            this.cbThursday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(147, 33);
            this.cbThursday.TabIndex = 21;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbThursday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFriday.Location = new System.Drawing.Point(855, 478);
            this.cbFriday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(110, 33);
            this.cbFriday.TabIndex = 22;
            this.cbFriday.Text = "Friday";
            this.cbFriday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbFriday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesday.Location = new System.Drawing.Point(855, 400);
            this.cbWednesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(178, 33);
            this.cbWednesday.TabIndex = 22;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbWednesday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.Location = new System.Drawing.Point(830, 630);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(520, 46);
            this.btnSendRequest.TabIndex = 25;
            this.btnSendRequest.Text = "Send request for account creation";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(996, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Available days:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(523, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contacts:";
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturday.Location = new System.Drawing.Point(1033, 325);
            this.cbSaturday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(144, 33);
            this.cbSaturday.TabIndex = 23;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbSaturday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSunday.Location = new System.Drawing.Point(1033, 364);
            this.cbSunday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(126, 33);
            this.cbSunday.TabIndex = 24;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbSunday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // cbMorningShift
            // 
            this.cbMorningShift.AutoSize = true;
            this.cbMorningShift.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMorningShift.Location = new System.Drawing.Point(1189, 377);
            this.cbMorningShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMorningShift.Name = "cbMorningShift";
            this.cbMorningShift.Size = new System.Drawing.Size(140, 33);
            this.cbMorningShift.TabIndex = 83;
            this.cbMorningShift.Text = "Morning";
            this.cbMorningShift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbMorningShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbMorningShift.UseVisualStyleBackColor = true;
            // 
            // cbAfternoonShift
            // 
            this.cbAfternoonShift.AutoSize = true;
            this.cbAfternoonShift.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfternoonShift.Location = new System.Drawing.Point(1189, 428);
            this.cbAfternoonShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAfternoonShift.Name = "cbAfternoonShift";
            this.cbAfternoonShift.Size = new System.Drawing.Size(161, 33);
            this.cbAfternoonShift.TabIndex = 82;
            this.cbAfternoonShift.Text = "Afternoon";
            this.cbAfternoonShift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbAfternoonShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbAfternoonShift.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1183, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 81;
            this.label9.Text = "Work shift:";
            // 
            // cbEveningShift
            // 
            this.cbEveningShift.AutoSize = true;
            this.cbEveningShift.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEveningShift.Location = new System.Drawing.Point(1189, 473);
            this.cbEveningShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEveningShift.Name = "cbEveningShift";
            this.cbEveningShift.Size = new System.Drawing.Size(135, 33);
            this.cbEveningShift.TabIndex = 80;
            this.cbEveningShift.Text = "Evening";
            this.cbEveningShift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbEveningShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbEveningShift.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(763, 630);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 46);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(26, 72);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(283, 40);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.Location = new System.Drawing.Point(26, 318);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(283, 40);
            this.tbStreet.TabIndex = 5;
            this.tbStreet.Text = "street";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostcode.Location = new System.Drawing.Point(26, 371);
            this.tbPostcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(283, 40);
            this.tbPostcode.TabIndex = 88;
            this.tbPostcode.Text = "postcode";
            // 
            // tbRegion
            // 
            this.tbRegion.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegion.Location = new System.Drawing.Point(25, 422);
            this.tbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(283, 40);
            this.tbRegion.TabIndex = 5;
            this.tbRegion.Text = "region";
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(24, 478);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(283, 40);
            this.tbCountry.TabIndex = 6;
            this.tbCountry.Text = "Country";
            // 
            // btnAddOtherContact
            // 
            this.btnAddOtherContact.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOtherContact.Location = new System.Drawing.Point(507, 230);
            this.btnAddOtherContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOtherContact.Name = "btnAddOtherContact";
            this.btnAddOtherContact.Size = new System.Drawing.Size(142, 46);
            this.btnAddOtherContact.TabIndex = 13;
            this.btnAddOtherContact.Text = "Add contact";
            this.btnAddOtherContact.UseVisualStyleBackColor = true;
            this.btnAddOtherContact.Click += new System.EventHandler(this.btnAddOtherContact_Click);
            // 
            // lbContacts
            // 
            this.lbContacts.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.HorizontalScrollbar = true;
            this.lbContacts.ItemHeight = 20;
            this.lbContacts.Location = new System.Drawing.Point(346, 290);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbContacts.Size = new System.Drawing.Size(487, 204);
            this.lbContacts.TabIndex = 92;
            // 
            // btnOpenContact
            // 
            this.btnOpenContact.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenContact.Location = new System.Drawing.Point(346, 230);
            this.btnOpenContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenContact.Name = "btnOpenContact";
            this.btnOpenContact.Size = new System.Drawing.Size(155, 46);
            this.btnOpenContact.TabIndex = 12;
            this.btnOpenContact.Text = "Input contact";
            this.btnOpenContact.UseVisualStyleBackColor = true;
            this.btnOpenContact.Click += new System.EventHandler(this.btnOpenContact_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(346, 636);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(283, 40);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 31);
            this.label10.TabIndex = 95;
            this.label10.Text = "User password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(980, 630);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(370, 46);
            this.btnCreateAccount.TabIndex = 97;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.Location = new System.Drawing.Point(685, 72);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(160, 38);
            this.rbManager.TabIndex = 9;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(358, 72);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(130, 38);
            this.rbAdmin.TabIndex = 10;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Checked = true;
            this.rbEmployee.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployee.Location = new System.Drawing.Point(502, 72);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(177, 38);
            this.rbEmployee.TabIndex = 11;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // btnChangeShifts
            // 
            this.btnChangeShifts.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeShifts.Location = new System.Drawing.Point(1181, 517);
            this.btnChangeShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeShifts.Name = "btnChangeShifts";
            this.btnChangeShifts.Size = new System.Drawing.Size(150, 77);
            this.btnChangeShifts.TabIndex = 99;
            this.btnChangeShifts.Text = "Change current shifts";
            this.btnChangeShifts.UseVisualStyleBackColor = true;
            this.btnChangeShifts.Click += new System.EventHandler(this.btnChangeShifts_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Location = new System.Drawing.Point(655, 230);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(178, 46);
            this.btnDeleteContact.TabIndex = 100;
            this.btnDeleteContact.Text = "Delete contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 705);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnChangeShifts);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnOpenContact);
            this.Controls.Add(this.lbContacts);
            this.Controls.Add(this.btnAddOtherContact);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbMorningShift);
            this.Controls.Add(this.cbAfternoonShift);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbEveningShift);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.cbSunday);
            this.Controls.Add(this.cbSaturday);
            this.Controls.Add(this.cbWednesday);
            this.Controls.Add(this.cbFriday);
            this.Controls.Add(this.cbThursday);
            this.Controls.Add(this.cbTuesday);
            this.Controls.Add(this.cbMonday);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtbContractStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nHourlyWage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateAccount";
            this.Text = "Create/Edit Account";
            ((System.ComponentModel.ISupportInitialize)(this.nHourlyWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nHourlyWage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtbContractStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbMorningShift;
        private System.Windows.Forms.CheckBox cbAfternoonShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbEveningShift;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Button btnAddOtherContact;
        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.Button btnOpenContact;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCreateAccount;

        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbEmployee;

        private System.Windows.Forms.Button btnChangeShifts;
        private System.Windows.Forms.Button btnDeleteContact;
    }
}