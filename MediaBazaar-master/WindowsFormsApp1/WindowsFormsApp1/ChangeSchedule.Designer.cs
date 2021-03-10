namespace MediaBazar
{
    partial class ChangeSchedule
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
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.gbMondayShift = new System.Windows.Forms.GroupBox();
            this.cbMondayEvening = new System.Windows.Forms.CheckBox();
            this.cbMondayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbMondayMorning = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.gbTuesdayShift = new System.Windows.Forms.GroupBox();
            this.cbTuesdayEvening = new System.Windows.Forms.CheckBox();
            this.cbTuesdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbTuesdayMorning = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.gbWednesdayShift = new System.Windows.Forms.GroupBox();
            this.cbWednesdayEvening = new System.Windows.Forms.CheckBox();
            this.cbWednesdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbWednesdayMorning = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.gbThursdayShift = new System.Windows.Forms.GroupBox();
            this.cbThursdayEvening = new System.Windows.Forms.CheckBox();
            this.cbThursdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbThursdayMorning = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.gbFridayShift = new System.Windows.Forms.GroupBox();
            this.cbFridayEvening = new System.Windows.Forms.CheckBox();
            this.cbFridayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbFridayMorning = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.gbSaturdayShift = new System.Windows.Forms.GroupBox();
            this.cbSaturdayEvening = new System.Windows.Forms.CheckBox();
            this.cbSaturdayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbSaturdayMorning = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.gbSundayShift = new System.Windows.Forms.GroupBox();
            this.cbSundayEvening = new System.Windows.Forms.CheckBox();
            this.cbSundayAfternoon = new System.Windows.Forms.CheckBox();
            this.cbSundayMorning = new System.Windows.Forms.CheckBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.gbMondayShift.SuspendLayout();
            this.gbTuesdayShift.SuspendLayout();
            this.gbWednesdayShift.SuspendLayout();
            this.gbThursdayShift.SuspendLayout();
            this.gbFridayShift.SuspendLayout();
            this.gbSaturdayShift.SuspendLayout();
            this.gbSundayShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(13, 13);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(576, 40);
            this.cbEmployee.TabIndex = 85;
            this.cbEmployee.Text = "Employee";
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.CbEmployee_SelectedIndexChanged);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(596, 13);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(334, 459);
            this.rtbMessage.TabIndex = 86;
            this.rtbMessage.Text = "Message";
            this.rtbMessage.Enter += new System.EventHandler(this.RtbMessage_Enter);
            this.rtbMessage.Leave += new System.EventHandler(this.RtbMessage_Leave);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(16, 490);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(914, 40);
            this.btnSaveChanges.TabIndex = 87;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // gbMondayShift
            // 
            this.gbMondayShift.Controls.Add(this.cbMondayEvening);
            this.gbMondayShift.Controls.Add(this.cbMondayAfternoon);
            this.gbMondayShift.Controls.Add(this.cbMondayMorning);
            this.gbMondayShift.Controls.Add(this.cbMonday);
            this.gbMondayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMondayShift.Location = new System.Drawing.Point(16, 70);
            this.gbMondayShift.Name = "gbMondayShift";
            this.gbMondayShift.Size = new System.Drawing.Size(288, 102);
            this.gbMondayShift.TabIndex = 88;
            this.gbMondayShift.TabStop = false;
            this.gbMondayShift.Text = "Monday Shift";
            // 
            // cbMondayEvening
            // 
            this.cbMondayEvening.AutoSize = true;
            this.cbMondayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMondayEvening.Location = new System.Drawing.Point(144, 66);
            this.cbMondayEvening.Name = "cbMondayEvening";
            this.cbMondayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbMondayEvening.TabIndex = 12;
            this.cbMondayEvening.Text = "Evening";
            this.cbMondayEvening.UseVisualStyleBackColor = true;
            // 
            // cbMondayAfternoon
            // 
            this.cbMondayAfternoon.AutoSize = true;
            this.cbMondayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMondayAfternoon.Location = new System.Drawing.Point(144, 43);
            this.cbMondayAfternoon.Name = "cbMondayAfternoon";
            this.cbMondayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbMondayAfternoon.TabIndex = 11;
            this.cbMondayAfternoon.Text = "Afternoon";
            this.cbMondayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbMondayMorning
            // 
            this.cbMondayMorning.AutoSize = true;
            this.cbMondayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMondayMorning.Location = new System.Drawing.Point(144, 22);
            this.cbMondayMorning.Name = "cbMondayMorning";
            this.cbMondayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbMondayMorning.TabIndex = 10;
            this.cbMondayMorning.Text = "Morning";
            this.cbMondayMorning.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonday.Location = new System.Drawing.Point(6, 43);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(100, 24);
            this.cbMonday.TabIndex = 8;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // gbTuesdayShift
            // 
            this.gbTuesdayShift.Controls.Add(this.cbTuesdayEvening);
            this.gbTuesdayShift.Controls.Add(this.cbTuesdayAfternoon);
            this.gbTuesdayShift.Controls.Add(this.cbTuesdayMorning);
            this.gbTuesdayShift.Controls.Add(this.cbTuesday);
            this.gbTuesdayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTuesdayShift.Location = new System.Drawing.Point(310, 70);
            this.gbTuesdayShift.Name = "gbTuesdayShift";
            this.gbTuesdayShift.Size = new System.Drawing.Size(280, 102);
            this.gbTuesdayShift.TabIndex = 89;
            this.gbTuesdayShift.TabStop = false;
            this.gbTuesdayShift.Text = "Tuesday Shift";
            // 
            // cbTuesdayEvening
            // 
            this.cbTuesdayEvening.AutoSize = true;
            this.cbTuesdayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesdayEvening.Location = new System.Drawing.Point(133, 66);
            this.cbTuesdayEvening.Name = "cbTuesdayEvening";
            this.cbTuesdayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbTuesdayEvening.TabIndex = 12;
            this.cbTuesdayEvening.Text = "Evening";
            this.cbTuesdayEvening.UseVisualStyleBackColor = true;
            // 
            // cbTuesdayAfternoon
            // 
            this.cbTuesdayAfternoon.AutoSize = true;
            this.cbTuesdayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesdayAfternoon.Location = new System.Drawing.Point(133, 43);
            this.cbTuesdayAfternoon.Name = "cbTuesdayAfternoon";
            this.cbTuesdayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbTuesdayAfternoon.TabIndex = 11;
            this.cbTuesdayAfternoon.Text = "Afternoon";
            this.cbTuesdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbTuesdayMorning
            // 
            this.cbTuesdayMorning.AutoSize = true;
            this.cbTuesdayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesdayMorning.Location = new System.Drawing.Point(133, 22);
            this.cbTuesdayMorning.Name = "cbTuesdayMorning";
            this.cbTuesdayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbTuesdayMorning.TabIndex = 10;
            this.cbTuesdayMorning.Text = "Morning";
            this.cbTuesdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuesday.Location = new System.Drawing.Point(6, 43);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(102, 24);
            this.cbTuesday.TabIndex = 8;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // gbWednesdayShift
            // 
            this.gbWednesdayShift.Controls.Add(this.cbWednesdayEvening);
            this.gbWednesdayShift.Controls.Add(this.cbWednesdayAfternoon);
            this.gbWednesdayShift.Controls.Add(this.cbWednesdayMorning);
            this.gbWednesdayShift.Controls.Add(this.cbWednesday);
            this.gbWednesdayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWednesdayShift.Location = new System.Drawing.Point(16, 171);
            this.gbWednesdayShift.Name = "gbWednesdayShift";
            this.gbWednesdayShift.Size = new System.Drawing.Size(288, 102);
            this.gbWednesdayShift.TabIndex = 90;
            this.gbWednesdayShift.TabStop = false;
            this.gbWednesdayShift.Text = "Wednesday Shift";
            // 
            // cbWednesdayEvening
            // 
            this.cbWednesdayEvening.AutoSize = true;
            this.cbWednesdayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesdayEvening.Location = new System.Drawing.Point(144, 66);
            this.cbWednesdayEvening.Name = "cbWednesdayEvening";
            this.cbWednesdayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbWednesdayEvening.TabIndex = 12;
            this.cbWednesdayEvening.Text = "Evening";
            this.cbWednesdayEvening.UseVisualStyleBackColor = true;
            // 
            // cbWednesdayAfternoon
            // 
            this.cbWednesdayAfternoon.AutoSize = true;
            this.cbWednesdayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesdayAfternoon.Location = new System.Drawing.Point(144, 43);
            this.cbWednesdayAfternoon.Name = "cbWednesdayAfternoon";
            this.cbWednesdayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbWednesdayAfternoon.TabIndex = 11;
            this.cbWednesdayAfternoon.Text = "Afternoon";
            this.cbWednesdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbWednesdayMorning
            // 
            this.cbWednesdayMorning.AutoSize = true;
            this.cbWednesdayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesdayMorning.Location = new System.Drawing.Point(144, 22);
            this.cbWednesdayMorning.Name = "cbWednesdayMorning";
            this.cbWednesdayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbWednesdayMorning.TabIndex = 10;
            this.cbWednesdayMorning.Text = "Morning";
            this.cbWednesdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWednesday.Location = new System.Drawing.Point(6, 43);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(132, 24);
            this.cbWednesday.TabIndex = 8;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // gbThursdayShift
            // 
            this.gbThursdayShift.Controls.Add(this.cbThursdayEvening);
            this.gbThursdayShift.Controls.Add(this.cbThursdayAfternoon);
            this.gbThursdayShift.Controls.Add(this.cbThursdayMorning);
            this.gbThursdayShift.Controls.Add(this.cbThursday);
            this.gbThursdayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThursdayShift.Location = new System.Drawing.Point(310, 171);
            this.gbThursdayShift.Name = "gbThursdayShift";
            this.gbThursdayShift.Size = new System.Drawing.Size(280, 102);
            this.gbThursdayShift.TabIndex = 91;
            this.gbThursdayShift.TabStop = false;
            this.gbThursdayShift.Text = "Thursday Shift";
            // 
            // cbThursdayEvening
            // 
            this.cbThursdayEvening.AutoSize = true;
            this.cbThursdayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursdayEvening.Location = new System.Drawing.Point(133, 66);
            this.cbThursdayEvening.Name = "cbThursdayEvening";
            this.cbThursdayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbThursdayEvening.TabIndex = 12;
            this.cbThursdayEvening.Text = "Evening";
            this.cbThursdayEvening.UseVisualStyleBackColor = true;
            // 
            // cbThursdayAfternoon
            // 
            this.cbThursdayAfternoon.AutoSize = true;
            this.cbThursdayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursdayAfternoon.Location = new System.Drawing.Point(133, 43);
            this.cbThursdayAfternoon.Name = "cbThursdayAfternoon";
            this.cbThursdayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbThursdayAfternoon.TabIndex = 11;
            this.cbThursdayAfternoon.Text = "Afternoon";
            this.cbThursdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbThursdayMorning
            // 
            this.cbThursdayMorning.AutoSize = true;
            this.cbThursdayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursdayMorning.Location = new System.Drawing.Point(133, 22);
            this.cbThursdayMorning.Name = "cbThursdayMorning";
            this.cbThursdayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbThursdayMorning.TabIndex = 10;
            this.cbThursdayMorning.Text = "Morning";
            this.cbThursdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThursday.Location = new System.Drawing.Point(6, 43);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(110, 24);
            this.cbThursday.TabIndex = 8;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // gbFridayShift
            // 
            this.gbFridayShift.Controls.Add(this.cbFridayEvening);
            this.gbFridayShift.Controls.Add(this.cbFridayAfternoon);
            this.gbFridayShift.Controls.Add(this.cbFridayMorning);
            this.gbFridayShift.Controls.Add(this.cbFriday);
            this.gbFridayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFridayShift.Location = new System.Drawing.Point(16, 274);
            this.gbFridayShift.Name = "gbFridayShift";
            this.gbFridayShift.Size = new System.Drawing.Size(288, 102);
            this.gbFridayShift.TabIndex = 92;
            this.gbFridayShift.TabStop = false;
            this.gbFridayShift.Text = "Friday Shift";
            // 
            // cbFridayEvening
            // 
            this.cbFridayEvening.AutoSize = true;
            this.cbFridayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFridayEvening.Location = new System.Drawing.Point(144, 66);
            this.cbFridayEvening.Name = "cbFridayEvening";
            this.cbFridayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbFridayEvening.TabIndex = 12;
            this.cbFridayEvening.Text = "Evening";
            this.cbFridayEvening.UseVisualStyleBackColor = true;
            // 
            // cbFridayAfternoon
            // 
            this.cbFridayAfternoon.AutoSize = true;
            this.cbFridayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFridayAfternoon.Location = new System.Drawing.Point(144, 43);
            this.cbFridayAfternoon.Name = "cbFridayAfternoon";
            this.cbFridayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbFridayAfternoon.TabIndex = 11;
            this.cbFridayAfternoon.Text = "Afternoon";
            this.cbFridayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbFridayMorning
            // 
            this.cbFridayMorning.AutoSize = true;
            this.cbFridayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFridayMorning.Location = new System.Drawing.Point(144, 22);
            this.cbFridayMorning.Name = "cbFridayMorning";
            this.cbFridayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbFridayMorning.TabIndex = 10;
            this.cbFridayMorning.Text = "Morning";
            this.cbFridayMorning.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFriday.Location = new System.Drawing.Point(6, 43);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(84, 24);
            this.cbFriday.TabIndex = 8;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // gbSaturdayShift
            // 
            this.gbSaturdayShift.Controls.Add(this.cbSaturdayEvening);
            this.gbSaturdayShift.Controls.Add(this.cbSaturdayAfternoon);
            this.gbSaturdayShift.Controls.Add(this.cbSaturdayMorning);
            this.gbSaturdayShift.Controls.Add(this.cbSaturday);
            this.gbSaturdayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaturdayShift.Location = new System.Drawing.Point(310, 274);
            this.gbSaturdayShift.Name = "gbSaturdayShift";
            this.gbSaturdayShift.Size = new System.Drawing.Size(280, 102);
            this.gbSaturdayShift.TabIndex = 93;
            this.gbSaturdayShift.TabStop = false;
            this.gbSaturdayShift.Text = "Saturday Shift";
            // 
            // cbSaturdayEvening
            // 
            this.cbSaturdayEvening.AutoSize = true;
            this.cbSaturdayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturdayEvening.Location = new System.Drawing.Point(133, 66);
            this.cbSaturdayEvening.Name = "cbSaturdayEvening";
            this.cbSaturdayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbSaturdayEvening.TabIndex = 12;
            this.cbSaturdayEvening.Text = "Evening";
            this.cbSaturdayEvening.UseVisualStyleBackColor = true;
            // 
            // cbSaturdayAfternoon
            // 
            this.cbSaturdayAfternoon.AutoSize = true;
            this.cbSaturdayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturdayAfternoon.Location = new System.Drawing.Point(133, 43);
            this.cbSaturdayAfternoon.Name = "cbSaturdayAfternoon";
            this.cbSaturdayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbSaturdayAfternoon.TabIndex = 11;
            this.cbSaturdayAfternoon.Text = "Afternoon";
            this.cbSaturdayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbSaturdayMorning
            // 
            this.cbSaturdayMorning.AutoSize = true;
            this.cbSaturdayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturdayMorning.Location = new System.Drawing.Point(133, 22);
            this.cbSaturdayMorning.Name = "cbSaturdayMorning";
            this.cbSaturdayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbSaturdayMorning.TabIndex = 10;
            this.cbSaturdayMorning.Text = "Morning";
            this.cbSaturdayMorning.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaturday.Location = new System.Drawing.Point(6, 43);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(108, 24);
            this.cbSaturday.TabIndex = 8;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // gbSundayShift
            // 
            this.gbSundayShift.Controls.Add(this.cbSundayEvening);
            this.gbSundayShift.Controls.Add(this.cbSundayAfternoon);
            this.gbSundayShift.Controls.Add(this.cbSundayMorning);
            this.gbSundayShift.Controls.Add(this.cbSunday);
            this.gbSundayShift.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSundayShift.Location = new System.Drawing.Point(16, 382);
            this.gbSundayShift.Name = "gbSundayShift";
            this.gbSundayShift.Size = new System.Drawing.Size(288, 102);
            this.gbSundayShift.TabIndex = 94;
            this.gbSundayShift.TabStop = false;
            this.gbSundayShift.Text = "Sunday Shift";
            // 
            // cbSundayEvening
            // 
            this.cbSundayEvening.AutoSize = true;
            this.cbSundayEvening.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSundayEvening.Location = new System.Drawing.Point(144, 66);
            this.cbSundayEvening.Name = "cbSundayEvening";
            this.cbSundayEvening.Size = new System.Drawing.Size(101, 24);
            this.cbSundayEvening.TabIndex = 12;
            this.cbSundayEvening.Text = "Evening";
            this.cbSundayEvening.UseVisualStyleBackColor = true;
            // 
            // cbSundayAfternoon
            // 
            this.cbSundayAfternoon.AutoSize = true;
            this.cbSundayAfternoon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSundayAfternoon.Location = new System.Drawing.Point(144, 43);
            this.cbSundayAfternoon.Name = "cbSundayAfternoon";
            this.cbSundayAfternoon.Size = new System.Drawing.Size(120, 24);
            this.cbSundayAfternoon.TabIndex = 11;
            this.cbSundayAfternoon.Text = "Afternoon";
            this.cbSundayAfternoon.UseVisualStyleBackColor = true;
            // 
            // cbSundayMorning
            // 
            this.cbSundayMorning.AutoSize = true;
            this.cbSundayMorning.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSundayMorning.Location = new System.Drawing.Point(144, 22);
            this.cbSundayMorning.Name = "cbSundayMorning";
            this.cbSundayMorning.Size = new System.Drawing.Size(103, 24);
            this.cbSundayMorning.TabIndex = 10;
            this.cbSundayMorning.Text = "Morning";
            this.cbSundayMorning.UseVisualStyleBackColor = true;
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSunday.Location = new System.Drawing.Point(6, 43);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(95, 24);
            this.cbSunday.TabIndex = 8;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // ChangeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 542);
            this.Controls.Add(this.gbSundayShift);
            this.Controls.Add(this.gbSaturdayShift);
            this.Controls.Add(this.gbFridayShift);
            this.Controls.Add(this.gbThursdayShift);
            this.Controls.Add(this.gbWednesdayShift);
            this.Controls.Add(this.gbTuesdayShift);
            this.Controls.Add(this.gbMondayShift);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.cbEmployee);
            this.Name = "ChangeSchedule";
            this.Text = "ChangeSchedule";
            this.gbMondayShift.ResumeLayout(false);
            this.gbMondayShift.PerformLayout();
            this.gbTuesdayShift.ResumeLayout(false);
            this.gbTuesdayShift.PerformLayout();
            this.gbWednesdayShift.ResumeLayout(false);
            this.gbWednesdayShift.PerformLayout();
            this.gbThursdayShift.ResumeLayout(false);
            this.gbThursdayShift.PerformLayout();
            this.gbFridayShift.ResumeLayout(false);
            this.gbFridayShift.PerformLayout();
            this.gbSaturdayShift.ResumeLayout(false);
            this.gbSaturdayShift.PerformLayout();
            this.gbSundayShift.ResumeLayout(false);
            this.gbSundayShift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox gbMondayShift;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.GroupBox gbTuesdayShift;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.GroupBox gbWednesdayShift;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.GroupBox gbThursdayShift;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.GroupBox gbFridayShift;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.GroupBox gbSaturdayShift;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.GroupBox gbSundayShift;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbMondayEvening;
        private System.Windows.Forms.CheckBox cbMondayAfternoon;
        private System.Windows.Forms.CheckBox cbMondayMorning;
        private System.Windows.Forms.CheckBox cbTuesdayEvening;
        private System.Windows.Forms.CheckBox cbTuesdayAfternoon;
        private System.Windows.Forms.CheckBox cbTuesdayMorning;
        private System.Windows.Forms.CheckBox cbWednesdayEvening;
        private System.Windows.Forms.CheckBox cbWednesdayAfternoon;
        private System.Windows.Forms.CheckBox cbWednesdayMorning;
        private System.Windows.Forms.CheckBox cbThursdayEvening;
        private System.Windows.Forms.CheckBox cbThursdayAfternoon;
        private System.Windows.Forms.CheckBox cbThursdayMorning;
        private System.Windows.Forms.CheckBox cbFridayEvening;
        private System.Windows.Forms.CheckBox cbFridayAfternoon;
        private System.Windows.Forms.CheckBox cbFridayMorning;
        private System.Windows.Forms.CheckBox cbSaturdayEvening;
        private System.Windows.Forms.CheckBox cbSaturdayAfternoon;
        private System.Windows.Forms.CheckBox cbSaturdayMorning;
        private System.Windows.Forms.CheckBox cbSundayEvening;
        private System.Windows.Forms.CheckBox cbSundayAfternoon;
        private System.Windows.Forms.CheckBox cbSundayMorning;
    }
}