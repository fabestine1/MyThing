namespace MiniProject.OOD1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListOfAnimals = new System.Windows.Forms.Button();
            this.btn_Adopt_Claim = new System.Windows.Forms.Button();
            this.btnOwnerRegister = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_close = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.pnAddAnimal = new System.Windows.Forms.Panel();
            this.pnAdoptClaim = new System.Windows.Forms.Panel();
            this.btnUpdateExtraInfo_ACpn = new System.Windows.Forms.Button();
            this.btnAnimalSearch = new System.Windows.Forms.Button();
            this.btnUpdateMainInfo_ACpn = new System.Windows.Forms.Button();
            this.btnAdopt = new System.Windows.Forms.Button();
            this.gbOwnerInfo = new System.Windows.Forms.GroupBox();
            this.tbEmail_ACpn = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWalk = new System.Windows.Forms.Button();
            this.btnClaim = new System.Windows.Forms.Button();
            this.lbNoticeAnimalSearching = new System.Windows.Forms.Label();
            this.gbAnimalInfo = new System.Windows.Forms.GroupBox();
            this.DateTimePicker_ACpn = new System.Windows.Forms.DateTimePicker();
            this.tbExtraInfo_ACpn = new System.Windows.Forms.RichTextBox();
            this.lbExtraInfoTitle_ACpn = new System.Windows.Forms.Label();
            this.tbLocationOfFinding_ACpn = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLastWDateTitle = new System.Windows.Forms.Label();
            this.lbExtraInfoTitle = new System.Windows.Forms.Label();
            this.lbLastWalkingDate_ACpn = new System.Windows.Forms.Label();
            this.rbCat_ACpn = new System.Windows.Forms.RadioButton();
            this.rbDog_ACpn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription_ACpn = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker_AddingForm = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription_Add = new System.Windows.Forms.RichTextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbxExtraInfo_Add = new System.Windows.Forms.RichTextBox();
            this.lblFoundLocation = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnCat = new System.Windows.Forms.RadioButton();
            this.rbtnDog = new System.Windows.Forms.RadioButton();
            this.lblExtraInformation = new System.Windows.Forms.Label();
            this.tbxFoundLocation_Add = new System.Windows.Forms.TextBox();
            this.pnNotification = new System.Windows.Forms.Panel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.pnOwnerRegister = new System.Windows.Forms.Panel();
            this.tbEmail_pnOwnerRegister = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName_pnOwnerRegister = new System.Windows.Forms.RichTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.OwnerLastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.getByOwnerBtn = new System.Windows.Forms.Button();
            this.notAdoptableBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.adoptableBtn = new System.Windows.Forms.Button();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.AnimalslistBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.pnAddAnimal.SuspendLayout();
            this.pnAdoptClaim.SuspendLayout();
            this.gbOwnerInfo.SuspendLayout();
            this.gbAnimalInfo.SuspendLayout();
            this.pnNotification.SuspendLayout();
            this.pnOwnerRegister.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.listPanel);
            this.panel1.Controls.Add(this.btnListOfAnimals);
            this.panel1.Controls.Add(this.pnAdoptClaim);
            this.panel1.Controls.Add(this.btn_Adopt_Claim);
            this.panel1.Controls.Add(this.btnOwnerRegister);
            this.panel1.Controls.Add(this.btnAddAnimal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 525);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnListOfAnimals
            // 
            this.btnListOfAnimals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnListOfAnimals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListOfAnimals.FlatAppearance.BorderSize = 0;
            this.btnListOfAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfAnimals.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOfAnimals.ForeColor = System.Drawing.Color.White;
            this.btnListOfAnimals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfAnimals.Location = new System.Drawing.Point(12, 299);
            this.btnListOfAnimals.Name = "btnListOfAnimals";
            this.btnListOfAnimals.Size = new System.Drawing.Size(157, 44);
            this.btnListOfAnimals.TabIndex = 9;
            this.btnListOfAnimals.Text = "List Of Animals";
            this.btnListOfAnimals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListOfAnimals.UseVisualStyleBackColor = false;
            this.btnListOfAnimals.Click += new System.EventHandler(this.btnListOfAnimals_Click);
            // 
            // btn_Adopt_Claim
            // 
            this.btn_Adopt_Claim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Adopt_Claim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Adopt_Claim.FlatAppearance.BorderSize = 0;
            this.btn_Adopt_Claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adopt_Claim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adopt_Claim.ForeColor = System.Drawing.Color.White;
            this.btn_Adopt_Claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Adopt_Claim.Location = new System.Drawing.Point(12, 255);
            this.btn_Adopt_Claim.Name = "btn_Adopt_Claim";
            this.btn_Adopt_Claim.Size = new System.Drawing.Size(160, 44);
            this.btn_Adopt_Claim.TabIndex = 8;
            this.btn_Adopt_Claim.Text = "Adopt/ Claim";
            this.btn_Adopt_Claim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Adopt_Claim.UseVisualStyleBackColor = false;
            this.btn_Adopt_Claim.Click += new System.EventHandler(this.btn_Adopt_Claim_Click);
            // 
            // btnOwnerRegister
            // 
            this.btnOwnerRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnOwnerRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOwnerRegister.FlatAppearance.BorderSize = 0;
            this.btnOwnerRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerRegister.ForeColor = System.Drawing.Color.White;
            this.btnOwnerRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOwnerRegister.Location = new System.Drawing.Point(12, 205);
            this.btnOwnerRegister.Name = "btnOwnerRegister";
            this.btnOwnerRegister.Size = new System.Drawing.Size(160, 44);
            this.btnOwnerRegister.TabIndex = 7;
            this.btnOwnerRegister.Text = "Register Owner";
            this.btnOwnerRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOwnerRegister.UseVisualStyleBackColor = false;
            this.btnOwnerRegister.Click += new System.EventHandler(this.btnOwnerRegister_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAnimal.FlatAppearance.BorderSize = 0;
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnimal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAddAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 155);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(160, 44);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add Animal ";
            this.btnAddAnimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 21);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bt_close
            // 
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.Color.Black;
            this.bt_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_close.Location = new System.Drawing.Point(1051, 13);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(32, 35);
            this.bt_close.TabIndex = 5;
            this.bt_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(765, 25);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(31, 35);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(323, 25);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(302, 33);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "Shelter Management";
            // 
            // pnAddAnimal
            // 
            this.pnAddAnimal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnAddAnimal.Controls.Add(this.DateTimePicker_AddingForm);
            this.pnAddAnimal.Controls.Add(this.label5);
            this.pnAddAnimal.Controls.Add(this.label1);
            this.pnAddAnimal.Controls.Add(this.lblDescription);
            this.pnAddAnimal.Controls.Add(this.pnOwnerRegister);
            this.pnAddAnimal.Controls.Add(this.tbxDescription_Add);
            this.pnAddAnimal.Controls.Add(this.lblType);
            this.pnAddAnimal.Controls.Add(this.tbxExtraInfo_Add);
            this.pnAddAnimal.Controls.Add(this.lblFoundLocation);
            this.pnAddAnimal.Controls.Add(this.btnAdd);
            this.pnAddAnimal.Controls.Add(this.rbtnCat);
            this.pnAddAnimal.Controls.Add(this.rbtnDog);
            this.pnAddAnimal.Controls.Add(this.lblExtraInformation);
            this.pnAddAnimal.Controls.Add(this.tbxFoundLocation_Add);
            this.pnAddAnimal.Location = new System.Drawing.Point(172, 57);
            this.pnAddAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnAddAnimal.Name = "pnAddAnimal";
            this.pnAddAnimal.Size = new System.Drawing.Size(624, 369);
            this.pnAddAnimal.TabIndex = 10;
            this.pnAddAnimal.Visible = false;
            // 
            // pnAdoptClaim
            // 
            this.pnAdoptClaim.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnAdoptClaim.Controls.Add(this.btnUpdateExtraInfo_ACpn);
            this.pnAdoptClaim.Controls.Add(this.btnAnimalSearch);
            this.pnAdoptClaim.Controls.Add(this.btnUpdateMainInfo_ACpn);
            this.pnAdoptClaim.Controls.Add(this.btnAdopt);
            this.pnAdoptClaim.Controls.Add(this.gbOwnerInfo);
            this.pnAdoptClaim.Controls.Add(this.btnWalk);
            this.pnAdoptClaim.Controls.Add(this.btnClaim);
            this.pnAdoptClaim.Controls.Add(this.lbNoticeAnimalSearching);
            this.pnAdoptClaim.Controls.Add(this.gbAnimalInfo);
            this.pnAdoptClaim.Location = new System.Drawing.Point(172, 57);
            this.pnAdoptClaim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnAdoptClaim.Name = "pnAdoptClaim";
            this.pnAdoptClaim.Size = new System.Drawing.Size(617, 378);
            this.pnAdoptClaim.TabIndex = 25;
            this.pnAdoptClaim.Visible = false;
            this.pnAdoptClaim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnAdoptClaim_Paint);
            // 
            // btnUpdateExtraInfo_ACpn
            // 
            this.btnUpdateExtraInfo_ACpn.Enabled = false;
            this.btnUpdateExtraInfo_ACpn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExtraInfo_ACpn.Location = new System.Drawing.Point(458, 233);
            this.btnUpdateExtraInfo_ACpn.Name = "btnUpdateExtraInfo_ACpn";
            this.btnUpdateExtraInfo_ACpn.Size = new System.Drawing.Size(157, 37);
            this.btnUpdateExtraInfo_ACpn.TabIndex = 54;
            this.btnUpdateExtraInfo_ACpn.Text = "Update extra info";
            this.btnUpdateExtraInfo_ACpn.UseVisualStyleBackColor = true;
            this.btnUpdateExtraInfo_ACpn.Click += new System.EventHandler(this.btnUpdateExtraInfo_ACpn_Click);
            // 
            // btnAnimalSearch
            // 
            this.btnAnimalSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimalSearch.Location = new System.Drawing.Point(11, 5);
            this.btnAnimalSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnimalSearch.Name = "btnAnimalSearch";
            this.btnAnimalSearch.Size = new System.Drawing.Size(164, 32);
            this.btnAnimalSearch.TabIndex = 53;
            this.btnAnimalSearch.Text = "Search for Animal";
            this.btnAnimalSearch.UseVisualStyleBackColor = true;
            this.btnAnimalSearch.Click += new System.EventHandler(this.btnAnimalSearch_Click);
            // 
            // btnUpdateMainInfo_ACpn
            // 
            this.btnUpdateMainInfo_ACpn.Enabled = false;
            this.btnUpdateMainInfo_ACpn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMainInfo_ACpn.Location = new System.Drawing.Point(339, 306);
            this.btnUpdateMainInfo_ACpn.Name = "btnUpdateMainInfo_ACpn";
            this.btnUpdateMainInfo_ACpn.Size = new System.Drawing.Size(224, 37);
            this.btnUpdateMainInfo_ACpn.TabIndex = 50;
            this.btnUpdateMainInfo_ACpn.Text = "Update main info";
            this.btnUpdateMainInfo_ACpn.UseVisualStyleBackColor = true;
            this.btnUpdateMainInfo_ACpn.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdopt
            // 
            this.btnAdopt.Enabled = false;
            this.btnAdopt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdopt.Location = new System.Drawing.Point(455, 181);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(159, 36);
            this.btnAdopt.TabIndex = 38;
            this.btnAdopt.Text = "Adopt";
            this.btnAdopt.UseVisualStyleBackColor = true;
            this.btnAdopt.Click += new System.EventHandler(this.btnAdopt_Click);
            // 
            // gbOwnerInfo
            // 
            this.gbOwnerInfo.Controls.Add(this.tbEmail_ACpn);
            this.gbOwnerInfo.Controls.Add(this.label11);
            this.gbOwnerInfo.Enabled = false;
            this.gbOwnerInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOwnerInfo.Location = new System.Drawing.Point(320, 39);
            this.gbOwnerInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOwnerInfo.Name = "gbOwnerInfo";
            this.gbOwnerInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOwnerInfo.Size = new System.Drawing.Size(281, 119);
            this.gbOwnerInfo.TabIndex = 52;
            this.gbOwnerInfo.TabStop = false;
            this.gbOwnerInfo.Text = "Owner Input";
            // 
            // tbEmail_ACpn
            // 
            this.tbEmail_ACpn.Location = new System.Drawing.Point(36, 61);
            this.tbEmail_ACpn.Name = "tbEmail_ACpn";
            this.tbEmail_ACpn.Size = new System.Drawing.Size(219, 26);
            this.tbEmail_ACpn.TabIndex = 48;
            this.tbEmail_ACpn.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 48;
            this.label11.Text = "Email";
            // 
            // btnWalk
            // 
            this.btnWalk.Enabled = false;
            this.btnWalk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalk.Location = new System.Drawing.Point(300, 235);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(140, 36);
            this.btnWalk.TabIndex = 49;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.bnWalk_Click);
            // 
            // btnClaim
            // 
            this.btnClaim.Enabled = false;
            this.btnClaim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaim.Location = new System.Drawing.Point(300, 181);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(140, 36);
            this.btnClaim.TabIndex = 48;
            this.btnClaim.Text = "Claim";
            this.btnClaim.UseVisualStyleBackColor = true;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // lbNoticeAnimalSearching
            // 
            this.lbNoticeAnimalSearching.AutoSize = true;
            this.lbNoticeAnimalSearching.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoticeAnimalSearching.Location = new System.Drawing.Point(191, 10);
            this.lbNoticeAnimalSearching.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNoticeAnimalSearching.Name = "lbNoticeAnimalSearching";
            this.lbNoticeAnimalSearching.Size = new System.Drawing.Size(386, 21);
            this.lbNoticeAnimalSearching.TabIndex = 51;
            this.lbNoticeAnimalSearching.Text = "*Please put the RFID of animal under the scanner";
            this.lbNoticeAnimalSearching.Visible = false;
            // 
            // gbAnimalInfo
            // 
            this.gbAnimalInfo.Controls.Add(this.DateTimePicker_ACpn);
            this.gbAnimalInfo.Controls.Add(this.tbExtraInfo_ACpn);
            this.gbAnimalInfo.Controls.Add(this.lbExtraInfoTitle_ACpn);
            this.gbAnimalInfo.Controls.Add(this.tbLocationOfFinding_ACpn);
            this.gbAnimalInfo.Controls.Add(this.label8);
            this.gbAnimalInfo.Controls.Add(this.lbLastWDateTitle);
            this.gbAnimalInfo.Controls.Add(this.lbExtraInfoTitle);
            this.gbAnimalInfo.Controls.Add(this.lbLastWalkingDate_ACpn);
            this.gbAnimalInfo.Controls.Add(this.rbCat_ACpn);
            this.gbAnimalInfo.Controls.Add(this.rbDog_ACpn);
            this.gbAnimalInfo.Controls.Add(this.label2);
            this.gbAnimalInfo.Controls.Add(this.tbDescription_ACpn);
            this.gbAnimalInfo.Controls.Add(this.label4);
            this.gbAnimalInfo.Enabled = false;
            this.gbAnimalInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimalInfo.Location = new System.Drawing.Point(2, 39);
            this.gbAnimalInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAnimalInfo.Name = "gbAnimalInfo";
            this.gbAnimalInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAnimalInfo.Size = new System.Drawing.Size(293, 335);
            this.gbAnimalInfo.TabIndex = 36;
            this.gbAnimalInfo.TabStop = false;
            this.gbAnimalInfo.Text = "Animal Information";
            // 
            // DateTimePicker_ACpn
            // 
            this.DateTimePicker_ACpn.Location = new System.Drawing.Point(13, 197);
            this.DateTimePicker_ACpn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker_ACpn.Name = "DateTimePicker_ACpn";
            this.DateTimePicker_ACpn.Size = new System.Drawing.Size(278, 27);
            this.DateTimePicker_ACpn.TabIndex = 50;
            // 
            // tbExtraInfo_ACpn
            // 
            this.tbExtraInfo_ACpn.Location = new System.Drawing.Point(18, 298);
            this.tbExtraInfo_ACpn.Name = "tbExtraInfo_ACpn";
            this.tbExtraInfo_ACpn.Size = new System.Drawing.Size(188, 26);
            this.tbExtraInfo_ACpn.TabIndex = 49;
            this.tbExtraInfo_ACpn.Text = "";
            this.tbExtraInfo_ACpn.Visible = false;
            // 
            // lbExtraInfoTitle_ACpn
            // 
            this.lbExtraInfoTitle_ACpn.AutoSize = true;
            this.lbExtraInfoTitle_ACpn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraInfoTitle_ACpn.Location = new System.Drawing.Point(15, 276);
            this.lbExtraInfoTitle_ACpn.Name = "lbExtraInfoTitle_ACpn";
            this.lbExtraInfoTitle_ACpn.Size = new System.Drawing.Size(145, 21);
            this.lbExtraInfoTitle_ACpn.TabIndex = 48;
            this.lbExtraInfoTitle_ACpn.Text = "Extra Information";
            this.lbExtraInfoTitle_ACpn.Visible = false;
            // 
            // tbLocationOfFinding_ACpn
            // 
            this.tbLocationOfFinding_ACpn.Location = new System.Drawing.Point(13, 135);
            this.tbLocationOfFinding_ACpn.Name = "tbLocationOfFinding_ACpn";
            this.tbLocationOfFinding_ACpn.Size = new System.Drawing.Size(188, 26);
            this.tbLocationOfFinding_ACpn.TabIndex = 47;
            this.tbLocationOfFinding_ACpn.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Location of finding";
            // 
            // lbLastWDateTitle
            // 
            this.lbLastWDateTitle.AutoSize = true;
            this.lbLastWDateTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastWDateTitle.Location = new System.Drawing.Point(15, 234);
            this.lbLastWDateTitle.Name = "lbLastWDateTitle";
            this.lbLastWDateTitle.Size = new System.Drawing.Size(150, 21);
            this.lbLastWDateTitle.TabIndex = 44;
            this.lbLastWDateTitle.Text = "Last Walking Date";
            this.lbLastWDateTitle.Visible = false;
            // 
            // lbExtraInfoTitle
            // 
            this.lbExtraInfoTitle.AutoSize = true;
            this.lbExtraInfoTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraInfoTitle.Location = new System.Drawing.Point(9, 175);
            this.lbExtraInfoTitle.Name = "lbExtraInfoTitle";
            this.lbExtraInfoTitle.Size = new System.Drawing.Size(135, 21);
            this.lbExtraInfoTitle.TabIndex = 43;
            this.lbExtraInfoTitle.Text = "Brought In Date";
            this.lbExtraInfoTitle.Visible = false;
            // 
            // lbLastWalkingDate_ACpn
            // 
            this.lbLastWalkingDate_ACpn.AutoSize = true;
            this.lbLastWalkingDate_ACpn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastWalkingDate_ACpn.Location = new System.Drawing.Point(44, 260);
            this.lbLastWalkingDate_ACpn.Name = "lbLastWalkingDate_ACpn";
            this.lbLastWalkingDate_ACpn.Size = new System.Drawing.Size(0, 21);
            this.lbLastWalkingDate_ACpn.TabIndex = 45;
            this.lbLastWalkingDate_ACpn.Visible = false;
            // 
            // rbCat_ACpn
            // 
            this.rbCat_ACpn.AutoSize = true;
            this.rbCat_ACpn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCat_ACpn.Location = new System.Drawing.Point(152, 26);
            this.rbCat_ACpn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCat_ACpn.Name = "rbCat_ACpn";
            this.rbCat_ACpn.Size = new System.Drawing.Size(59, 25);
            this.rbCat_ACpn.TabIndex = 42;
            this.rbCat_ACpn.TabStop = true;
            this.rbCat_ACpn.Text = "Cat";
            this.rbCat_ACpn.UseVisualStyleBackColor = true;
            // 
            // rbDog_ACpn
            // 
            this.rbDog_ACpn.AutoSize = true;
            this.rbDog_ACpn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDog_ACpn.Location = new System.Drawing.Point(73, 25);
            this.rbDog_ACpn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDog_ACpn.Name = "rbDog_ACpn";
            this.rbDog_ACpn.Size = new System.Drawing.Size(61, 25);
            this.rbDog_ACpn.TabIndex = 41;
            this.rbDog_ACpn.TabStop = true;
            this.rbDog_ACpn.Text = "Dog";
            this.rbDog_ACpn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Type";
            // 
            // tbDescription_ACpn
            // 
            this.tbDescription_ACpn.Location = new System.Drawing.Point(13, 69);
            this.tbDescription_ACpn.Name = "tbDescription_ACpn";
            this.tbDescription_ACpn.Size = new System.Drawing.Size(188, 29);
            this.tbDescription_ACpn.TabIndex = 37;
            this.tbDescription_ACpn.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Description";
            // 
            // DateTimePicker_AddingForm
            // 
            this.DateTimePicker_AddingForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker_AddingForm.Location = new System.Drawing.Point(333, 213);
            this.DateTimePicker_AddingForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimePicker_AddingForm.Name = "DateTimePicker_AddingForm";
            this.DateTimePicker_AddingForm.Size = new System.Drawing.Size(293, 27);
            this.DateTimePicker_AddingForm.TabIndex = 26;
            this.DateTimePicker_AddingForm.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Brought In Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Please put an RFID under the scanner";
            this.label1.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(47, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 21);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description:";
            // 
            // tbxDescription_Add
            // 
            this.tbxDescription_Add.Location = new System.Drawing.Point(51, 77);
            this.tbxDescription_Add.Name = "tbxDescription_Add";
            this.tbxDescription_Add.Size = new System.Drawing.Size(245, 96);
            this.tbxDescription_Add.TabIndex = 19;
            this.tbxDescription_Add.Text = "";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(47, 23);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 21);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // tbxExtraInfo_Add
            // 
            this.tbxExtraInfo_Add.Location = new System.Drawing.Point(333, 79);
            this.tbxExtraInfo_Add.Name = "tbxExtraInfo_Add";
            this.tbxExtraInfo_Add.Size = new System.Drawing.Size(257, 95);
            this.tbxExtraInfo_Add.TabIndex = 22;
            this.tbxExtraInfo_Add.Text = "";
            // 
            // lblFoundLocation
            // 
            this.lblFoundLocation.AutoSize = true;
            this.lblFoundLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundLocation.Location = new System.Drawing.Point(49, 192);
            this.lblFoundLocation.Name = "lblFoundLocation";
            this.lblFoundLocation.Size = new System.Drawing.Size(158, 21);
            this.lblFoundLocation.TabIndex = 18;
            this.lblFoundLocation.Text = "Location of finding:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(51, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 36);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnCat
            // 
            this.rbtnCat.AutoSize = true;
            this.rbtnCat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCat.Location = new System.Drawing.Point(157, 23);
            this.rbtnCat.Name = "rbtnCat";
            this.rbtnCat.Size = new System.Drawing.Size(59, 25);
            this.rbtnCat.TabIndex = 14;
            this.rbtnCat.TabStop = true;
            this.rbtnCat.Text = "Cat";
            this.rbtnCat.UseVisualStyleBackColor = true;
            // 
            // rbtnDog
            // 
            this.rbtnDog.AutoSize = true;
            this.rbtnDog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDog.Location = new System.Drawing.Point(265, 21);
            this.rbtnDog.Name = "rbtnDog";
            this.rbtnDog.Size = new System.Drawing.Size(61, 25);
            this.rbtnDog.TabIndex = 15;
            this.rbtnDog.TabStop = true;
            this.rbtnDog.Text = "Dog";
            this.rbtnDog.UseVisualStyleBackColor = true;
            // 
            // lblExtraInformation
            // 
            this.lblExtraInformation.AutoSize = true;
            this.lblExtraInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraInformation.Location = new System.Drawing.Point(329, 56);
            this.lblExtraInformation.Name = "lblExtraInformation";
            this.lblExtraInformation.Size = new System.Drawing.Size(147, 21);
            this.lblExtraInformation.TabIndex = 21;
            this.lblExtraInformation.Text = "Extra information:";
            // 
            // tbxFoundLocation_Add
            // 
            this.tbxFoundLocation_Add.Location = new System.Drawing.Point(52, 219);
            this.tbxFoundLocation_Add.Name = "tbxFoundLocation_Add";
            this.tbxFoundLocation_Add.Size = new System.Drawing.Size(239, 20);
            this.tbxFoundLocation_Add.TabIndex = 13;
            // 
            // pnNotification
            // 
            this.pnNotification.BackColor = System.Drawing.Color.DarkRed;
            this.pnNotification.Controls.Add(this.lbNotification);
            this.pnNotification.Location = new System.Drawing.Point(172, 456);
            this.pnNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNotification.Name = "pnNotification";
            this.pnNotification.Size = new System.Drawing.Size(624, 33);
            this.pnNotification.TabIndex = 13;
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNotification.Location = new System.Drawing.Point(21, 5);
            this.lbNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(0, 22);
            this.lbNotification.TabIndex = 24;
            // 
            // pnOwnerRegister
            // 
            this.pnOwnerRegister.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnOwnerRegister.Controls.Add(this.tbEmail_pnOwnerRegister);
            this.pnOwnerRegister.Controls.Add(this.label3);
            this.pnOwnerRegister.Controls.Add(this.tbLastName_pnOwnerRegister);
            this.pnOwnerRegister.Controls.Add(this.btnRegister);
            this.pnOwnerRegister.Controls.Add(this.label6);
            this.pnOwnerRegister.Location = new System.Drawing.Point(0, 0);
            this.pnOwnerRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnOwnerRegister.Name = "pnOwnerRegister";
            this.pnOwnerRegister.Size = new System.Drawing.Size(624, 395);
            this.pnOwnerRegister.TabIndex = 24;
            this.pnOwnerRegister.Visible = false;
            this.pnOwnerRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tbEmail_pnOwnerRegister
            // 
            this.tbEmail_pnOwnerRegister.Location = new System.Drawing.Point(124, 146);
            this.tbEmail_pnOwnerRegister.Name = "tbEmail_pnOwnerRegister";
            this.tbEmail_pnOwnerRegister.Size = new System.Drawing.Size(256, 26);
            this.tbEmail_pnOwnerRegister.TabIndex = 24;
            this.tbEmail_pnOwnerRegister.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name";
            // 
            // tbLastName_pnOwnerRegister
            // 
            this.tbLastName_pnOwnerRegister.Location = new System.Drawing.Point(124, 71);
            this.tbLastName_pnOwnerRegister.Name = "tbLastName_pnOwnerRegister";
            this.tbLastName_pnOwnerRegister.Size = new System.Drawing.Size(256, 26);
            this.tbLastName_pnOwnerRegister.TabIndex = 19;
            this.tbLastName_pnOwnerRegister.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(157, 207);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(205, 36);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email";
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.OwnerLastNameTxtBox);
            this.listPanel.Controls.Add(this.label7);
            this.listPanel.Controls.Add(this.getByOwnerBtn);
            this.listPanel.Controls.Add(this.notAdoptableBtn);
            this.listPanel.Controls.Add(this.label9);
            this.listPanel.Controls.Add(this.adoptableBtn);
            this.listPanel.Controls.Add(this.descriptionLbl);
            this.listPanel.Controls.Add(this.AnimalslistBox);
            this.listPanel.Location = new System.Drawing.Point(172, 57);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(624, 395);
            this.listPanel.TabIndex = 55;
            this.listPanel.Visible = false;
            this.listPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.listPanel_Paint);
            // 
            // OwnerLastNameTxtBox
            // 
            this.OwnerLastNameTxtBox.Location = new System.Drawing.Point(14, 252);
            this.OwnerLastNameTxtBox.Name = "OwnerLastNameTxtBox";
            this.OwnerLastNameTxtBox.Size = new System.Drawing.Size(160, 20);
            this.OwnerLastNameTxtBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "owner\'s lastName:";
            // 
            // getByOwnerBtn
            // 
            this.getByOwnerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getByOwnerBtn.Location = new System.Drawing.Point(11, 280);
            this.getByOwnerBtn.Name = "getByOwnerBtn";
            this.getByOwnerBtn.Size = new System.Drawing.Size(163, 63);
            this.getByOwnerBtn.TabIndex = 5;
            this.getByOwnerBtn.Text = "Find owner\'s animal(s)";
            this.getByOwnerBtn.UseVisualStyleBackColor = true;
            this.getByOwnerBtn.Click += new System.EventHandler(this.getByOwnerBtn_Click);
            // 
            // notAdoptableBtn
            // 
            this.notAdoptableBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAdoptableBtn.Location = new System.Drawing.Point(14, 109);
            this.notAdoptableBtn.Name = "notAdoptableBtn";
            this.notAdoptableBtn.Size = new System.Drawing.Size(163, 63);
            this.notAdoptableBtn.TabIndex = 4;
            this.notAdoptableBtn.Text = "Not-yet-Adoptable Animals";
            this.notAdoptableBtn.UseVisualStyleBackColor = true;
            this.notAdoptableBtn.Click += new System.EventHandler(this.notAdoptableBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 3;
            // 
            // adoptableBtn
            // 
            this.adoptableBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptableBtn.Location = new System.Drawing.Point(14, 21);
            this.adoptableBtn.Name = "adoptableBtn";
            this.adoptableBtn.Size = new System.Drawing.Size(163, 63);
            this.adoptableBtn.TabIndex = 2;
            this.adoptableBtn.Text = "Adoptable Animals";
            this.adoptableBtn.UseVisualStyleBackColor = true;
            this.adoptableBtn.Click += new System.EventHandler(this.adoptableBtn_Click);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(348, 18);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(119, 21);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "List of animals:";
            // 
            // AnimalslistBox
            // 
            this.AnimalslistBox.FormattingEnabled = true;
            this.AnimalslistBox.Location = new System.Drawing.Point(183, 59);
            this.AnimalslistBox.Name = "AnimalslistBox";
            this.AnimalslistBox.Size = new System.Drawing.Size(436, 316);
            this.AnimalslistBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 525);
            this.Controls.Add(this.pnNotification);
            this.Controls.Add(this.pnAddAnimal);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnAddAnimal.ResumeLayout(false);
            this.pnAddAnimal.PerformLayout();
            this.pnAdoptClaim.ResumeLayout(false);
            this.pnAdoptClaim.PerformLayout();
            this.gbOwnerInfo.ResumeLayout(false);
            this.gbOwnerInfo.PerformLayout();
            this.gbAnimalInfo.ResumeLayout(false);
            this.gbAnimalInfo.PerformLayout();
            this.pnNotification.ResumeLayout(false);
            this.pnNotification.PerformLayout();
            this.pnOwnerRegister.ResumeLayout(false);
            this.pnOwnerRegister.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnOwnerRegister;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button btn_Adopt_Claim;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btnListOfAnimals;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Panel pnAddAnimal;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox tbxDescription_Add;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RichTextBox tbxExtraInfo_Add;
        private System.Windows.Forms.Label lblFoundLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnCat;
        private System.Windows.Forms.RadioButton rbtnDog;
        private System.Windows.Forms.Label lblExtraInformation;
        private System.Windows.Forms.TextBox tbxFoundLocation_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnNotification;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Panel pnOwnerRegister;
        private System.Windows.Forms.RichTextBox tbEmail_pnOwnerRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbLastName_pnOwnerRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnAdoptClaim;
        private System.Windows.Forms.GroupBox gbAnimalInfo;
        private System.Windows.Forms.Button btnUpdateMainInfo_ACpn;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.RichTextBox tbLocationOfFinding_ACpn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLastWalkingDate_ACpn;
        private System.Windows.Forms.Label lbLastWDateTitle;
        private System.Windows.Forms.Label lbExtraInfoTitle;
        private System.Windows.Forms.RadioButton rbCat_ACpn;
        private System.Windows.Forms.RadioButton rbDog_ACpn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescription_ACpn;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNoticeAnimalSearching;
        private System.Windows.Forms.GroupBox gbOwnerInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox tbEmail_ACpn;
        private System.Windows.Forms.Button btnAnimalSearch;
        private System.Windows.Forms.DateTimePicker DateTimePicker_AddingForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateExtraInfo_ACpn;
        private System.Windows.Forms.RichTextBox tbExtraInfo_ACpn;
        private System.Windows.Forms.Label lbExtraInfoTitle_ACpn;
        private System.Windows.Forms.DateTimePicker DateTimePicker_ACpn;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.TextBox OwnerLastNameTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button getByOwnerBtn;
        private System.Windows.Forms.Button notAdoptableBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button adoptableBtn;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.ListBox AnimalslistBox;
    }
}

