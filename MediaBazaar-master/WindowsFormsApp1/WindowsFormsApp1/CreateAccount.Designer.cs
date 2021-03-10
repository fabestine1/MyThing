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
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnAssignShifts = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nHourlyWage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employment details";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(20, 110);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(213, 34);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TabStop = false;
            this.tbFirstName.Text = "First name";
            this.tbFirstName.Enter += new System.EventHandler(this.tbFirstName_Enter);
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.Location = new System.Drawing.Point(20, 163);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(213, 34);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TabStop = false;
            this.tbLastName.Text = "Last name";
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(20, 213);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthdate.Size = new System.Drawing.Size(213, 34);
            this.dtpBirthdate.TabIndex = 4;
            this.dtpBirthdate.Value = new System.DateTime(2020, 2, 29, 0, 51, 0, 0);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.tbPhoneNumber.Location = new System.Drawing.Point(18, 472);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(213, 34);
            this.tbPhoneNumber.TabIndex = 7;
            this.tbPhoneNumber.Text = "Phone number";
            this.tbPhoneNumber.Enter += new System.EventHandler(this.tbPhoneNumber_Enter);
            this.tbPhoneNumber.Leave += new System.EventHandler(this.tbPhoneNumber_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(18, 517);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(213, 34);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Text = "Email address";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account type:";
            // 
            // nHourlyWage
            // 
            this.nHourlyWage.DecimalPlaces = 2;
            this.nHourlyWage.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nHourlyWage.Location = new System.Drawing.Point(838, 57);
            this.nHourlyWage.Margin = new System.Windows.Forms.Padding(2);
            this.nHourlyWage.Name = "nHourlyWage";
            this.nHourlyWage.Size = new System.Drawing.Size(80, 34);
            this.nHourlyWage.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hourly wage:";
            // 
            // dtbContractStartDate
            // 
            this.dtbContractStartDate.CalendarFont = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbContractStartDate.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbContractStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbContractStartDate.Location = new System.Drawing.Point(697, 205);
            this.dtbContractStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtbContractStartDate.Name = "dtbContractStartDate";
            this.dtbContractStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtbContractStartDate.Size = new System.Drawing.Size(221, 34);
            this.dtbContractStartDate.TabIndex = 17;
            this.dtbContractStartDate.Value = new System.DateTime(2020, 2, 29, 0, 51, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contract start date:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(697, 255);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(221, 33);
            this.cmbDepartment.TabIndex = 18;
            this.cmbDepartment.Text = "Department";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.Location = new System.Drawing.Point(546, 517);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(390, 37);
            this.btnSendRequest.TabIndex = 25;
            this.btnSendRequest.Text = "Send request for account creation";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contacts:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(496, 517);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 37);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.Location = new System.Drawing.Point(20, 58);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(213, 34);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TabStop = false;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.ForeColor = System.Drawing.Color.Black;
            this.tbStreet.Location = new System.Drawing.Point(20, 258);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(2);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(213, 34);
            this.tbStreet.TabIndex = 5;
            this.tbStreet.Text = "street";
            this.tbStreet.Enter += new System.EventHandler(this.tbStreet_Enter);
            this.tbStreet.Leave += new System.EventHandler(this.tbStreet_Leave);
            // 
            // tbPostcode
            // 
            this.tbPostcode.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostcode.ForeColor = System.Drawing.Color.Black;
            this.tbPostcode.Location = new System.Drawing.Point(20, 301);
            this.tbPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(213, 34);
            this.tbPostcode.TabIndex = 88;
            this.tbPostcode.Text = "postcode";
            this.tbPostcode.Enter += new System.EventHandler(this.tbPostcode_Enter);
            this.tbPostcode.Leave += new System.EventHandler(this.tbPostcode_Leave);
            // 
            // tbRegion
            // 
            this.tbRegion.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegion.ForeColor = System.Drawing.Color.Black;
            this.tbRegion.Location = new System.Drawing.Point(19, 343);
            this.tbRegion.Margin = new System.Windows.Forms.Padding(2);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(213, 34);
            this.tbRegion.TabIndex = 5;
            this.tbRegion.Text = "region";
            this.tbRegion.Enter += new System.EventHandler(this.tbRegion_Enter);
            this.tbRegion.Leave += new System.EventHandler(this.tbRegion_Leave);
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.ForeColor = System.Drawing.Color.Black;
            this.tbCountry.Location = new System.Drawing.Point(18, 388);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(2);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(213, 34);
            this.tbCountry.TabIndex = 6;
            this.tbCountry.Text = "Country";
            this.tbCountry.Enter += new System.EventHandler(this.tbCountry_Enter);
            this.tbCountry.Leave += new System.EventHandler(this.tbCountry_Leave);
            // 
            // btnAddOtherContact
            // 
            this.btnAddOtherContact.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOtherContact.Location = new System.Drawing.Point(370, 187);
            this.btnAddOtherContact.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOtherContact.Name = "btnAddOtherContact";
            this.btnAddOtherContact.Size = new System.Drawing.Size(116, 37);
            this.btnAddOtherContact.TabIndex = 13;
            this.btnAddOtherContact.Text = "Save contact";
            this.btnAddOtherContact.UseVisualStyleBackColor = true;
            this.btnAddOtherContact.Click += new System.EventHandler(this.btnAddOtherContact_Click);
            // 
            // lbContacts
            // 
            this.lbContacts.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.HorizontalScrollbar = true;
            this.lbContacts.ItemHeight = 18;
            this.lbContacts.Location = new System.Drawing.Point(249, 236);
            this.lbContacts.Margin = new System.Windows.Forms.Padding(2);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbContacts.Size = new System.Drawing.Size(377, 166);
            this.lbContacts.TabIndex = 92;
            // 
            // btnOpenContact
            // 
            this.btnOpenContact.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenContact.Location = new System.Drawing.Point(250, 187);
            this.btnOpenContact.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenContact.Name = "btnOpenContact";
            this.btnOpenContact.Size = new System.Drawing.Size(116, 37);
            this.btnOpenContact.TabIndex = 12;
            this.btnOpenContact.Text = "Input contact";
            this.btnOpenContact.UseVisualStyleBackColor = true;
            this.btnOpenContact.Click += new System.EventHandler(this.btnOpenContact_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(260, 517);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(213, 34);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.Text = "Password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(255, 489);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 26);
            this.label10.TabIndex = 95;
            this.label10.Text = "User password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(659, 517);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(278, 37);
            this.btnCreateAccount.TabIndex = 97;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.Location = new System.Drawing.Point(531, 58);
            this.rbManager.Margin = new System.Windows.Forms.Padding(2);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(129, 31);
            this.rbManager.TabIndex = 9;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(268, 58);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(103, 31);
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
            this.rbEmployee.Location = new System.Drawing.Point(380, 58);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(142, 31);
            this.rbEmployee.TabIndex = 11;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Location = new System.Drawing.Point(491, 187);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(134, 37);
            this.btnDeleteContact.TabIndex = 100;
            this.btnDeleteContact.Text = "Delete contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnAssignShifts
            // 
            this.btnAssignShifts.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignShifts.Location = new System.Drawing.Point(697, 389);
            this.btnAssignShifts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignShifts.Name = "btnAssignShifts";
            this.btnAssignShifts.Size = new System.Drawing.Size(217, 63);
            this.btnAssignShifts.TabIndex = 101;
            this.btnAssignShifts.Text = "Assign shifts";
            this.btnAssignShifts.UseVisualStyleBackColor = true;
            this.btnAssignShifts.Click += new System.EventHandler(this.btnAssignShifts_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(695, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 26);
            this.label7.TabIndex = 102;
            this.label7.Text = "Employee shifts:";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAssignShifts);
            this.Controls.Add(this.btnDeleteContact);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSendRequest);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnAssignShifts;
        private System.Windows.Forms.Label label7;
    }
}