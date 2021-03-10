namespace Garagemanagement
{
    partial class ControlPanel
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAddAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddCash = new System.Windows.Forms.Button();
            this.tbAddBalanceCardNumber = new System.Windows.Forms.TextBox();
            this.tbAddBalanceCardName = new System.Windows.Forms.TextBox();
            this.tbAddBalance = new System.Windows.Forms.TextBox();
            this.btnStopAddBalance = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabShowCard = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.adminPASS = new System.Windows.Forms.TextBox();
            this.HiddenLogin = new System.Windows.Forms.Label();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.tbStatusParkingPlace = new System.Windows.Forms.TextBox();
            this.tbStatusArrivalTime = new System.Windows.Forms.TextBox();
            this.tbStatusBalance = new System.Windows.Forms.TextBox();
            this.tbStatusCardNumber = new System.Windows.Forms.TextBox();
            this.tbStatusCardName = new System.Windows.Forms.TextBox();
            this.tbStatusAmountDue = new System.Windows.Forms.TextBox();
            this.btnStopStatus = new System.Windows.Forms.Button();
            this.btnPayCreditcard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.btnPayWithBalance = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPayCredit = new System.Windows.Forms.Button();
            this.tbPaymentCardNumber = new System.Windows.Forms.TextBox();
            this.tbPaymentCardName = new System.Windows.Forms.TextBox();
            this.tbPaymentAmountDue = new System.Windows.Forms.TextBox();
            this.btnStopPayment = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.lblTime4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAmount)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabShowCard.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.tabBalance.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAddAmount);
            this.groupBox1.Controls.Add(this.btnAddCash);
            this.groupBox1.Controls.Add(this.tbAddBalanceCardNumber);
            this.groupBox1.Controls.Add(this.tbAddBalanceCardName);
            this.groupBox1.Controls.Add(this.tbAddBalance);
            this.groupBox1.Controls.Add(this.btnStopAddBalance);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.lblTime3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1003, 443);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // nudAddAmount
            // 
            this.nudAddAmount.BackColor = System.Drawing.SystemColors.MenuText;
            this.nudAddAmount.DecimalPlaces = 2;
            this.nudAddAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.nudAddAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAddAmount.Location = new System.Drawing.Point(351, 212);
            this.nudAddAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAddAmount.Name = "nudAddAmount";
            this.nudAddAmount.Size = new System.Drawing.Size(120, 27);
            this.nudAddAmount.TabIndex = 30;
            // 
            // btnAddCash
            // 
            this.btnAddCash.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCash.Location = new System.Drawing.Point(351, 258);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(118, 35);
            this.btnAddCash.TabIndex = 29;
            this.btnAddCash.Text = "Add";
            this.btnAddCash.UseVisualStyleBackColor = true;
            this.btnAddCash.Click += new System.EventHandler(this.btnAddCash_Click);
            // 
            // tbAddBalanceCardNumber
            // 
            this.tbAddBalanceCardNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddBalanceCardNumber.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbAddBalanceCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddBalanceCardNumber.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddBalanceCardNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAddBalanceCardNumber.Location = new System.Drawing.Point(319, 125);
            this.tbAddBalanceCardNumber.Name = "tbAddBalanceCardNumber";
            this.tbAddBalanceCardNumber.Size = new System.Drawing.Size(266, 34);
            this.tbAddBalanceCardNumber.TabIndex = 27;
            // 
            // tbAddBalanceCardName
            // 
            this.tbAddBalanceCardName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddBalanceCardName.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbAddBalanceCardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddBalanceCardName.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddBalanceCardName.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAddBalanceCardName.Location = new System.Drawing.Point(319, 89);
            this.tbAddBalanceCardName.Name = "tbAddBalanceCardName";
            this.tbAddBalanceCardName.Size = new System.Drawing.Size(266, 34);
            this.tbAddBalanceCardName.TabIndex = 26;
            // 
            // tbAddBalance
            // 
            this.tbAddBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddBalance.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbAddBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddBalance.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddBalance.ForeColor = System.Drawing.SystemColors.Info;
            this.tbAddBalance.Location = new System.Drawing.Point(319, 53);
            this.tbAddBalance.Name = "tbAddBalance";
            this.tbAddBalance.Size = new System.Drawing.Size(266, 34);
            this.tbAddBalance.TabIndex = 25;
            // 
            // btnStopAddBalance
            // 
            this.btnStopAddBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopAddBalance.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAddBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopAddBalance.Location = new System.Drawing.Point(8, 363);
            this.btnStopAddBalance.Name = "btnStopAddBalance";
            this.btnStopAddBalance.Size = new System.Drawing.Size(125, 72);
            this.btnStopAddBalance.TabIndex = 24;
            this.btnStopAddBalance.Text = "Stop";
            this.btnStopAddBalance.UseVisualStyleBackColor = true;
            this.btnStopAddBalance.Click += new System.EventHandler(this.btnStopAddBalance_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(85, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 36);
            this.label14.TabIndex = 23;
            this.label14.Text = "Amount to add in €:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 36);
            this.label9.TabIndex = 20;
            this.label9.Text = "Balance: €";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 36);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cardnumber:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 36);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cardname:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(870, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 72);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTime3
            // 
            this.lblTime3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime3.AutoSize = true;
            this.lblTime3.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.Location = new System.Drawing.Point(830, 25);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(36, 17);
            this.lblTime3.TabIndex = 7;
            this.lblTime3.Text = "Time";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabShowCard);
            this.tabControl.Controls.Add(this.tabStatus);
            this.tabControl.Controls.Add(this.tabBalance);
            this.tabControl.Controls.Add(this.tabPayment);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1017, 507);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 14;
            this.tabControl.TabStop = false;
            this.tabControl.Tag = "";
            // 
            // tabShowCard
            // 
            this.tabShowCard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabShowCard.Controls.Add(this.groupBox3);
            this.tabShowCard.Location = new System.Drawing.Point(4, 54);
            this.tabShowCard.Name = "tabShowCard";
            this.tabShowCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowCard.Size = new System.Drawing.Size(1009, 449);
            this.tabShowCard.TabIndex = 3;
            this.tabShowCard.Text = "tabShowCard";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.adminPASS);
            this.groupBox3.Controls.Add(this.HiddenLogin);
            this.groupBox3.Controls.Add(this.btnPowerOff);
            this.groupBox3.Controls.Add(this.lblTime2);
            this.groupBox3.Controls.Add(this.lblScan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(1003, 443);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // adminPASS
            // 
            this.adminPASS.AcceptsTab = true;
            this.adminPASS.Location = new System.Drawing.Point(8, 55);
            this.adminPASS.MaxLength = 400;
            this.adminPASS.Name = "adminPASS";
            this.adminPASS.PasswordChar = '*';
            this.adminPASS.Size = new System.Drawing.Size(125, 27);
            this.adminPASS.TabIndex = 26;
            this.adminPASS.Visible = false;
            this.adminPASS.TextChanged += new System.EventHandler(this.adminPASS_TextChanged);
            this.adminPASS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminPASS_CheckKeys);
            // 
            // HiddenLogin
            // 
            this.HiddenLogin.Location = new System.Drawing.Point(3, 13);
            this.HiddenLogin.Name = "HiddenLogin";
            this.HiddenLogin.Size = new System.Drawing.Size(130, 29);
            this.HiddenLogin.TabIndex = 25;
            this.HiddenLogin.Click += new System.EventHandler(this.HiddenLogin_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPowerOff.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPowerOff.Location = new System.Drawing.Point(8, 363);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(125, 72);
            this.btnPowerOff.TabIndex = 24;
            this.btnPowerOff.Text = "Power Off";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // lblTime2
            // 
            this.lblTime2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(830, 25);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(36, 17);
            this.lblTime2.TabIndex = 7;
            this.lblTime2.Text = "Time";
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Bodoni MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.Location = new System.Drawing.Point(400, 300);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(459, 56);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "Scan your card please";
            // 
            // tabStatus
            // 
            this.tabStatus.BackColor = System.Drawing.Color.Black;
            this.tabStatus.Controls.Add(this.gbStatus);
            this.tabStatus.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatus.Location = new System.Drawing.Point(4, 54);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(1009, 449);
            this.tabStatus.TabIndex = 0;
            this.tabStatus.Text = "Status";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.tbStatusParkingPlace);
            this.gbStatus.Controls.Add(this.tbStatusArrivalTime);
            this.gbStatus.Controls.Add(this.tbStatusBalance);
            this.gbStatus.Controls.Add(this.tbStatusCardNumber);
            this.gbStatus.Controls.Add(this.tbStatusCardName);
            this.gbStatus.Controls.Add(this.tbStatusAmountDue);
            this.gbStatus.Controls.Add(this.btnStopStatus);
            this.gbStatus.Controls.Add(this.btnPayCreditcard);
            this.gbStatus.Controls.Add(this.label3);
            this.gbStatus.Controls.Add(this.label2);
            this.gbStatus.Controls.Add(this.label7);
            this.gbStatus.Controls.Add(this.lblTime);
            this.gbStatus.Controls.Add(this.btnAddBalance);
            this.gbStatus.Controls.Add(this.btnPayWithBalance);
            this.gbStatus.Controls.Add(this.label5);
            this.gbStatus.Controls.Add(this.label4);
            this.gbStatus.Controls.Add(this.label1);
            this.gbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatus.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbStatus.Location = new System.Drawing.Point(3, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(5);
            this.gbStatus.Size = new System.Drawing.Size(1003, 443);
            this.gbStatus.TabIndex = 0;
            this.gbStatus.TabStop = false;
            // 
            // tbStatusParkingPlace
            // 
            this.tbStatusParkingPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatusParkingPlace.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbStatusParkingPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusParkingPlace.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusParkingPlace.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStatusParkingPlace.Location = new System.Drawing.Point(310, 281);
            this.tbStatusParkingPlace.Name = "tbStatusParkingPlace";
            this.tbStatusParkingPlace.Size = new System.Drawing.Size(266, 34);
            this.tbStatusParkingPlace.TabIndex = 29;
            // 
            // tbStatusArrivalTime
            // 
            this.tbStatusArrivalTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatusArrivalTime.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbStatusArrivalTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusArrivalTime.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusArrivalTime.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStatusArrivalTime.Location = new System.Drawing.Point(310, 245);
            this.tbStatusArrivalTime.Name = "tbStatusArrivalTime";
            this.tbStatusArrivalTime.Size = new System.Drawing.Size(266, 34);
            this.tbStatusArrivalTime.TabIndex = 28;
            // 
            // tbStatusBalance
            // 
            this.tbStatusBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatusBalance.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbStatusBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusBalance.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusBalance.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStatusBalance.Location = new System.Drawing.Point(310, 178);
            this.tbStatusBalance.Name = "tbStatusBalance";
            this.tbStatusBalance.Size = new System.Drawing.Size(266, 34);
            this.tbStatusBalance.TabIndex = 27;
            // 
            // tbStatusCardNumber
            // 
            this.tbStatusCardNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatusCardNumber.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbStatusCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusCardNumber.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusCardNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStatusCardNumber.Location = new System.Drawing.Point(310, 142);
            this.tbStatusCardNumber.Name = "tbStatusCardNumber";
            this.tbStatusCardNumber.Size = new System.Drawing.Size(266, 34);
            this.tbStatusCardNumber.TabIndex = 26;
            // 
            // tbStatusCardName
            // 
            this.tbStatusCardName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatusCardName.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbStatusCardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusCardName.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusCardName.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStatusCardName.Location = new System.Drawing.Point(310, 106);
            this.tbStatusCardName.Name = "tbStatusCardName";
            this.tbStatusCardName.Size = new System.Drawing.Size(266, 34);
            this.tbStatusCardName.TabIndex = 25;
            // 
            // tbStatusAmountDue
            // 
            this.tbStatusAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatusAmountDue.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbStatusAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusAmountDue.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusAmountDue.ForeColor = System.Drawing.SystemColors.Info;
            this.tbStatusAmountDue.Location = new System.Drawing.Point(310, 53);
            this.tbStatusAmountDue.Name = "tbStatusAmountDue";
            this.tbStatusAmountDue.Size = new System.Drawing.Size(254, 34);
            this.tbStatusAmountDue.TabIndex = 24;
            // 
            // btnStopStatus
            // 
            this.btnStopStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopStatus.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopStatus.Location = new System.Drawing.Point(8, 363);
            this.btnStopStatus.Name = "btnStopStatus";
            this.btnStopStatus.Size = new System.Drawing.Size(125, 72);
            this.btnStopStatus.TabIndex = 23;
            this.btnStopStatus.Text = "Stop";
            this.btnStopStatus.UseVisualStyleBackColor = true;
            this.btnStopStatus.Click += new System.EventHandler(this.btnStopStatus_Click);
            // 
            // btnPayCreditcard
            // 
            this.btnPayCreditcard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPayCreditcard.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCreditcard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPayCreditcard.Location = new System.Drawing.Point(438, 316);
            this.btnPayCreditcard.Name = "btnPayCreditcard";
            this.btnPayCreditcard.Size = new System.Drawing.Size(250, 60);
            this.btnPayCreditcard.TabIndex = 14;
            this.btnPayCreditcard.Text = "Pay with creditcard";
            this.btnPayCreditcard.UseVisualStyleBackColor = true;
            this.btnPayCreditcard.Click += new System.EventHandler(this.btnPayWithCreditcard_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance: €";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cardnumber:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cardname:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(830, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBalance.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddBalance.Location = new System.Drawing.Point(707, 316);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(250, 60);
            this.btnAddBalance.TabIndex = 6;
            this.btnAddBalance.Text = "Add balance";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            this.btnAddBalance.Click += new System.EventHandler(this.btnAddBalance_Click);
            // 
            // btnPayWithBalance
            // 
            this.btnPayWithBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPayWithBalance.AutoSize = true;
            this.btnPayWithBalance.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayWithBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPayWithBalance.Location = new System.Drawing.Point(167, 316);
            this.btnPayWithBalance.Name = "btnPayWithBalance";
            this.btnPayWithBalance.Size = new System.Drawing.Size(250, 60);
            this.btnPayWithBalance.TabIndex = 5;
            this.btnPayWithBalance.Text = "Pay with balance";
            this.btnPayWithBalance.UseVisualStyleBackColor = true;
            this.btnPayWithBalance.Click += new System.EventHandler(this.btnPayWithBalance_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parking place:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival time:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount due: €";
            // 
            // tabBalance
            // 
            this.tabBalance.BackColor = System.Drawing.Color.Black;
            this.tabBalance.Controls.Add(this.groupBox1);
            this.tabBalance.Location = new System.Drawing.Point(4, 54);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBalance.Size = new System.Drawing.Size(1009, 449);
            this.tabBalance.TabIndex = 1;
            this.tabBalance.Text = "Add balance";
            // 
            // tabPayment
            // 
            this.tabPayment.BackColor = System.Drawing.Color.Black;
            this.tabPayment.Controls.Add(this.groupBox2);
            this.tabPayment.Location = new System.Drawing.Point(4, 54);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(1009, 449);
            this.tabPayment.TabIndex = 2;
            this.tabPayment.Text = "Payment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPayCredit);
            this.groupBox2.Controls.Add(this.tbPaymentCardNumber);
            this.groupBox2.Controls.Add(this.tbPaymentCardName);
            this.groupBox2.Controls.Add(this.tbPaymentAmountDue);
            this.groupBox2.Controls.Add(this.btnStopPayment);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnBack2);
            this.groupBox2.Controls.Add(this.lblTime4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1003, 443);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnPayCredit
            // 
            this.btnPayCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPayCredit.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCredit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPayCredit.Location = new System.Drawing.Point(86, 210);
            this.btnPayCredit.Name = "btnPayCredit";
            this.btnPayCredit.Size = new System.Drawing.Size(478, 82);
            this.btnPayCredit.TabIndex = 30;
            this.btnPayCredit.Text = "Pay";
            this.btnPayCredit.UseVisualStyleBackColor = true;
            this.btnPayCredit.Click += new System.EventHandler(this.btnPayCredit_Click);
            // 
            // tbPaymentCardNumber
            // 
            this.tbPaymentCardNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPaymentCardNumber.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbPaymentCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPaymentCardNumber.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaymentCardNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPaymentCardNumber.Location = new System.Drawing.Point(298, 150);
            this.tbPaymentCardNumber.Name = "tbPaymentCardNumber";
            this.tbPaymentCardNumber.Size = new System.Drawing.Size(266, 34);
            this.tbPaymentCardNumber.TabIndex = 28;
            // 
            // tbPaymentCardName
            // 
            this.tbPaymentCardName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPaymentCardName.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbPaymentCardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPaymentCardName.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaymentCardName.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPaymentCardName.Location = new System.Drawing.Point(298, 114);
            this.tbPaymentCardName.Name = "tbPaymentCardName";
            this.tbPaymentCardName.Size = new System.Drawing.Size(266, 34);
            this.tbPaymentCardName.TabIndex = 27;
            // 
            // tbPaymentAmountDue
            // 
            this.tbPaymentAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPaymentAmountDue.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbPaymentAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPaymentAmountDue.Font = new System.Drawing.Font("Bodoni MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaymentAmountDue.ForeColor = System.Drawing.SystemColors.Info;
            this.tbPaymentAmountDue.Location = new System.Drawing.Point(298, 53);
            this.tbPaymentAmountDue.Name = "tbPaymentAmountDue";
            this.tbPaymentAmountDue.Size = new System.Drawing.Size(266, 34);
            this.tbPaymentAmountDue.TabIndex = 26;
            // 
            // btnStopPayment
            // 
            this.btnStopPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopPayment.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopPayment.Location = new System.Drawing.Point(8, 363);
            this.btnStopPayment.Name = "btnStopPayment";
            this.btnStopPayment.Size = new System.Drawing.Size(125, 72);
            this.btnStopPayment.TabIndex = 22;
            this.btnStopPayment.Text = "Stop";
            this.btnStopPayment.UseVisualStyleBackColor = true;
            this.btnStopPayment.Click += new System.EventHandler(this.btnStopPayment_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(117, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 36);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cardnumber:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(146, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 36);
            this.label15.TabIndex = 21;
            this.label15.Text = "Cardname:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(117, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 36);
            this.label16.TabIndex = 18;
            this.label16.Text = "Amount due:";
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack2.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack2.Location = new System.Drawing.Point(870, 363);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(125, 72);
            this.btnBack2.TabIndex = 17;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // lblTime4
            // 
            this.lblTime4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime4.AutoSize = true;
            this.lblTime4.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime4.Location = new System.Drawing.Point(830, 25);
            this.lblTime4.Name = "lblTime4";
            this.lblTime4.Size = new System.Drawing.Size(36, 17);
            this.lblTime4.TabIndex = 7;
            this.lblTime4.Text = "Time";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1017, 507);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.Text = "Garagemanagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddAmount)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabShowCard.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabStatus.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.tabBalance.ResumeLayout(false);
            this.tabPayment.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAddBalance;
        private System.Windows.Forms.Button btnPayWithBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime4;
        private System.Windows.Forms.Button btnPayCreditcard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabShowCard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Button btnStopAddBalance;
        private System.Windows.Forms.Button btnStopStatus;
        private System.Windows.Forms.Button btnStopPayment;
        private System.Windows.Forms.TextBox tbAddBalanceCardNumber;
        private System.Windows.Forms.TextBox tbAddBalanceCardName;
        private System.Windows.Forms.TextBox tbAddBalance;
        private System.Windows.Forms.TextBox tbStatusParkingPlace;
        private System.Windows.Forms.TextBox tbStatusArrivalTime;
        private System.Windows.Forms.TextBox tbStatusBalance;
        private System.Windows.Forms.TextBox tbStatusCardNumber;
        private System.Windows.Forms.TextBox tbStatusCardName;
        private System.Windows.Forms.TextBox tbStatusAmountDue;
        private System.Windows.Forms.TextBox tbPaymentCardNumber;
        private System.Windows.Forms.TextBox tbPaymentCardName;
        private System.Windows.Forms.TextBox tbPaymentAmountDue;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnAddCash;
        private System.Windows.Forms.Button btnPayCredit;
        private System.Windows.Forms.NumericUpDown nudAddAmount;
        private System.Windows.Forms.Label HiddenLogin;
        private System.Windows.Forms.TextBox adminPASS;
    }
}
