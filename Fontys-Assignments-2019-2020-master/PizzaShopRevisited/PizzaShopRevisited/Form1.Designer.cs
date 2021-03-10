namespace PizzaShopRevisited
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lbxReceipt = new System.Windows.Forms.ListBox();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btEditExistingCustomer = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.panelManager = new System.Windows.Forms.Panel();
            this.btStatics = new System.Windows.Forms.Button();
            this.tabControlPdAndCustomers = new System.Windows.Forms.TabControl();
            this.tabPagePizzaAndDrinks = new System.Windows.Forms.TabPage();
            this.btReset = new System.Windows.Forms.Button();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.gbxTopping = new System.Windows.Forms.GroupBox();
            this.rbFilled = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.btAddDrink = new System.Windows.Forms.Button();
            this.btAddPizza = new System.Windows.Forms.Button();
            this.tbDrinkQuantity = new System.Windows.Forms.TextBox();
            this.btDrinkMinus = new System.Windows.Forms.Button();
            this.btDrinkPlus = new System.Windows.Forms.Button();
            this.tbPizzaQuantity = new System.Windows.Forms.TextBox();
            this.btnMinusPizza = new System.Windows.Forms.Button();
            this.btnPlusPizza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPizzasDisplay = new System.Windows.Forms.Label();
            this.lbxDrinks = new System.Windows.Forms.ListBox();
            this.lbxPizzas = new System.Windows.Forms.ListBox();
            this.tabPageNewCustomer = new System.Windows.Forms.TabPage();
            this.btRegisterOrderMenu = new System.Windows.Forms.Button();
            this.gbxNewCustomer = new System.Windows.Forms.GroupBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tabPageEditCustomer = new System.Windows.Forms.TabPage();
            this.btEditOrderMenu = new System.Windows.Forms.Button();
            this.gbxEditCustomer = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEditEmail = new System.Windows.Forms.TextBox();
            this.tbEditLastName = new System.Windows.Forms.TextBox();
            this.tbEditFirstName = new System.Windows.Forms.TextBox();
            this.tabPageEmpty = new System.Windows.Forms.TabPage();
            this.btNewOrder = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.tabControlPdAndCustomers.SuspendLayout();
            this.tabPagePizzaAndDrinks.SuspendLayout();
            this.gbxTopping.SuspendLayout();
            this.tabPageNewCustomer.SuspendLayout();
            this.gbxNewCustomer.SuspendLayout();
            this.tabPageEditCustomer.SuspendLayout();
            this.gbxEditCustomer.SuspendLayout();
            this.tabPageEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.panelTop.Controls.Add(this.pbxMinimize);
            this.panelTop.Controls.Add(this.pbxClose);
            this.panelTop.Controls.Add(this.pbxLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1128, 43);
            this.panelTop.TabIndex = 0;
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Image = global::PizzaShopRevisited.Properties.Resources.unnamed__1_;
            this.pbxMinimize.Location = new System.Drawing.Point(1023, 2);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(41, 41);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 2;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            this.pbxMinimize.MouseEnter += new System.EventHandler(this.pbxMinimize_MouseEnter);
            this.pbxMinimize.MouseLeave += new System.EventHandler(this.pbxMinimize_MouseLeave);
            // 
            // pbxClose
            // 
            this.pbxClose.Image = global::PizzaShopRevisited.Properties.Resources.unnamed;
            this.pbxClose.Location = new System.Drawing.Point(1066, 0);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(44, 44);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 1;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            this.pbxClose.MouseEnter += new System.EventHandler(this.pbxClose_MouseEnter);
            this.pbxClose.MouseLeave += new System.EventHandler(this.pbxClose_MouseLeave);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::PizzaShopRevisited.Properties.Resources.asd;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(50, 43);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReceipt.FormattingEnabled = true;
            this.lbxReceipt.ItemHeight = 20;
            this.lbxReceipt.Location = new System.Drawing.Point(762, 50);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(354, 604);
            this.lbxReceipt.TabIndex = 0;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.btEditExistingCustomer);
            this.panelCustomer.Controls.Add(this.lblOr);
            this.panelCustomer.Controls.Add(this.btnCreateCustomer);
            this.panelCustomer.Controls.Add(this.lblCustomers);
            this.panelCustomer.Controls.Add(this.cbxCustomers);
            this.panelCustomer.Location = new System.Drawing.Point(12, 50);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(369, 188);
            this.panelCustomer.TabIndex = 1;
            // 
            // btEditExistingCustomer
            // 
            this.btEditExistingCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btEditExistingCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditExistingCustomer.Location = new System.Drawing.Point(3, 124);
            this.btEditExistingCustomer.Name = "btEditExistingCustomer";
            this.btEditExistingCustomer.Size = new System.Drawing.Size(170, 61);
            this.btEditExistingCustomer.TabIndex = 4;
            this.btEditExistingCustomer.Text = "Edit customer!";
            this.btEditExistingCustomer.UseVisualStyleBackColor = false;
            this.btEditExistingCustomer.Click += new System.EventHandler(this.btEditExistingCustomer_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(156, 101);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(48, 20);
            this.lblOr.TabIndex = 3;
            this.lblOr.Text = "OR :";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomer.Location = new System.Drawing.Point(179, 124);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(185, 61);
            this.btnCreateCustomer.TabIndex = 2;
            this.btnCreateCustomer.Text = "Add new customer!";
            this.btnCreateCustomer.UseVisualStyleBackColor = false;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(104, 37);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(158, 20);
            this.lblCustomers.TabIndex = 1;
            this.lblCustomers.Text = "Select customer :";
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(79, 63);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(210, 26);
            this.cbxCustomers.TabIndex = 0;
            this.cbxCustomers.SelectedIndexChanged += new System.EventHandler(this.cbxCustomers_SelectedIndexChanged);
            // 
            // panelManager
            // 
            this.panelManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.panelManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManager.Controls.Add(this.btStatics);
            this.panelManager.Location = new System.Drawing.Point(387, 50);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(369, 188);
            this.panelManager.TabIndex = 2;
            // 
            // btStatics
            // 
            this.btStatics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btStatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btStatics.Location = new System.Drawing.Point(94, 63);
            this.btStatics.Name = "btStatics";
            this.btStatics.Size = new System.Drawing.Size(183, 65);
            this.btStatics.TabIndex = 16;
            this.btStatics.Text = "Statistics!";
            this.btStatics.UseVisualStyleBackColor = false;
            this.btStatics.Click += new System.EventHandler(this.btStatics_Click);
            // 
            // tabControlPdAndCustomers
            // 
            this.tabControlPdAndCustomers.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPdAndCustomers.Controls.Add(this.tabPagePizzaAndDrinks);
            this.tabControlPdAndCustomers.Controls.Add(this.tabPageNewCustomer);
            this.tabControlPdAndCustomers.Controls.Add(this.tabPageEditCustomer);
            this.tabControlPdAndCustomers.Controls.Add(this.tabPageEmpty);
            this.tabControlPdAndCustomers.Location = new System.Drawing.Point(12, 242);
            this.tabControlPdAndCustomers.Name = "tabControlPdAndCustomers";
            this.tabControlPdAndCustomers.SelectedIndex = 0;
            this.tabControlPdAndCustomers.Size = new System.Drawing.Size(744, 440);
            this.tabControlPdAndCustomers.TabIndex = 0;
            // 
            // tabPagePizzaAndDrinks
            // 
            this.tabPagePizzaAndDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tabPagePizzaAndDrinks.Controls.Add(this.btReset);
            this.tabPagePizzaAndDrinks.Controls.Add(this.lblCurrentPrice);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btnFinishOrder);
            this.tabPagePizzaAndDrinks.Controls.Add(this.gbxTopping);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btAddDrink);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btAddPizza);
            this.tabPagePizzaAndDrinks.Controls.Add(this.tbDrinkQuantity);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btDrinkMinus);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btDrinkPlus);
            this.tabPagePizzaAndDrinks.Controls.Add(this.tbPizzaQuantity);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btnMinusPizza);
            this.tabPagePizzaAndDrinks.Controls.Add(this.btnPlusPizza);
            this.tabPagePizzaAndDrinks.Controls.Add(this.label6);
            this.tabPagePizzaAndDrinks.Controls.Add(this.lblPizzasDisplay);
            this.tabPagePizzaAndDrinks.Controls.Add(this.lbxDrinks);
            this.tabPagePizzaAndDrinks.Controls.Add(this.lbxPizzas);
            this.tabPagePizzaAndDrinks.Location = new System.Drawing.Point(4, 4);
            this.tabPagePizzaAndDrinks.Name = "tabPagePizzaAndDrinks";
            this.tabPagePizzaAndDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePizzaAndDrinks.Size = new System.Drawing.Size(736, 411);
            this.tabPagePizzaAndDrinks.TabIndex = 0;
            this.tabPagePizzaAndDrinks.Text = "tabPage1";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(648, 380);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(82, 25);
            this.btReset.TabIndex = 15;
            this.btReset.Text = "Reset!";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Location = new System.Drawing.Point(323, 391);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(130, 17);
            this.lblCurrentPrice.TabIndex = 14;
            this.lblCurrentPrice.Text = "Current price : 0.00";
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinishOrder.Location = new System.Drawing.Point(296, 327);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(183, 65);
            this.btnFinishOrder.TabIndex = 13;
            this.btnFinishOrder.Text = "Finish!";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // gbxTopping
            // 
            this.gbxTopping.Controls.Add(this.rbFilled);
            this.gbxTopping.Controls.Add(this.rbThick);
            this.gbxTopping.Controls.Add(this.rbNone);
            this.gbxTopping.Location = new System.Drawing.Point(162, 252);
            this.gbxTopping.Name = "gbxTopping";
            this.gbxTopping.Size = new System.Drawing.Size(124, 100);
            this.gbxTopping.TabIndex = 12;
            this.gbxTopping.TabStop = false;
            this.gbxTopping.Text = "Toppings";
            // 
            // rbFilled
            // 
            this.rbFilled.AutoSize = true;
            this.rbFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilled.Location = new System.Drawing.Point(6, 73);
            this.rbFilled.Name = "rbFilled";
            this.rbFilled.Size = new System.Drawing.Size(110, 22);
            this.rbFilled.TabIndex = 5;
            this.rbFilled.Text = "Filled(+1.96)";
            this.rbFilled.UseVisualStyleBackColor = true;
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(6, 48);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(112, 22);
            this.rbThick.TabIndex = 4;
            this.rbThick.Text = "Thick(+0.51)";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNone.Location = new System.Drawing.Point(6, 21);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(65, 22);
            this.rbNone.TabIndex = 3;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // btAddDrink
            // 
            this.btAddDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btAddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAddDrink.Location = new System.Drawing.Point(490, 252);
            this.btAddDrink.Name = "btAddDrink";
            this.btAddDrink.Size = new System.Drawing.Size(151, 43);
            this.btAddDrink.TabIndex = 11;
            this.btAddDrink.Text = "Add!";
            this.btAddDrink.UseVisualStyleBackColor = false;
            this.btAddDrink.Click += new System.EventHandler(this.btAddDrink_Click);
            // 
            // btAddPizza
            // 
            this.btAddPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btAddPizza.Location = new System.Drawing.Point(36, 271);
            this.btAddPizza.Name = "btAddPizza";
            this.btAddPizza.Size = new System.Drawing.Size(120, 43);
            this.btAddPizza.TabIndex = 6;
            this.btAddPizza.Text = "Add!";
            this.btAddPizza.UseVisualStyleBackColor = false;
            this.btAddPizza.Click += new System.EventHandler(this.btAddPizza_Click);
            // 
            // tbDrinkQuantity
            // 
            this.tbDrinkQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrinkQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDrinkQuantity.Location = new System.Drawing.Point(544, 209);
            this.tbDrinkQuantity.Name = "tbDrinkQuantity";
            this.tbDrinkQuantity.ReadOnly = true;
            this.tbDrinkQuantity.Size = new System.Drawing.Size(44, 30);
            this.tbDrinkQuantity.TabIndex = 10;
            this.tbDrinkQuantity.Text = "1";
            this.tbDrinkQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDrinkMinus
            // 
            this.btDrinkMinus.BackColor = System.Drawing.Color.White;
            this.btDrinkMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btDrinkMinus.Location = new System.Drawing.Point(508, 210);
            this.btDrinkMinus.Name = "btDrinkMinus";
            this.btDrinkMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btDrinkMinus.Size = new System.Drawing.Size(36, 33);
            this.btDrinkMinus.TabIndex = 9;
            this.btDrinkMinus.Text = "-";
            this.btDrinkMinus.UseVisualStyleBackColor = false;
            this.btDrinkMinus.Click += new System.EventHandler(this.btDrinkMinus_Click);
            // 
            // btDrinkPlus
            // 
            this.btDrinkPlus.BackColor = System.Drawing.Color.White;
            this.btDrinkPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDrinkPlus.ForeColor = System.Drawing.Color.Black;
            this.btDrinkPlus.Location = new System.Drawing.Point(588, 210);
            this.btDrinkPlus.Name = "btDrinkPlus";
            this.btDrinkPlus.Size = new System.Drawing.Size(36, 33);
            this.btDrinkPlus.TabIndex = 8;
            this.btDrinkPlus.Text = "+";
            this.btDrinkPlus.UseVisualStyleBackColor = false;
            this.btDrinkPlus.Click += new System.EventHandler(this.btDrinkPlus_Click);
            // 
            // tbPizzaQuantity
            // 
            this.tbPizzaQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPizzaQuantity.Location = new System.Drawing.Point(135, 210);
            this.tbPizzaQuantity.Name = "tbPizzaQuantity";
            this.tbPizzaQuantity.ReadOnly = true;
            this.tbPizzaQuantity.Size = new System.Drawing.Size(44, 30);
            this.tbPizzaQuantity.TabIndex = 7;
            this.tbPizzaQuantity.Text = "1";
            this.tbPizzaQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinusPizza
            // 
            this.btnMinusPizza.BackColor = System.Drawing.Color.White;
            this.btnMinusPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinusPizza.Location = new System.Drawing.Point(99, 211);
            this.btnMinusPizza.Name = "btnMinusPizza";
            this.btnMinusPizza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinusPizza.Size = new System.Drawing.Size(36, 33);
            this.btnMinusPizza.TabIndex = 6;
            this.btnMinusPizza.Text = "-";
            this.btnMinusPizza.UseVisualStyleBackColor = false;
            this.btnMinusPizza.Click += new System.EventHandler(this.btnMinusPizza_Click);
            // 
            // btnPlusPizza
            // 
            this.btnPlusPizza.BackColor = System.Drawing.Color.White;
            this.btnPlusPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusPizza.ForeColor = System.Drawing.Color.Black;
            this.btnPlusPizza.Location = new System.Drawing.Point(179, 211);
            this.btnPlusPizza.Name = "btnPlusPizza";
            this.btnPlusPizza.Size = new System.Drawing.Size(36, 33);
            this.btnPlusPizza.TabIndex = 5;
            this.btnPlusPizza.Text = "+";
            this.btnPlusPizza.UseVisualStyleBackColor = false;
            this.btnPlusPizza.Click += new System.EventHandler(this.btnPlusPizza_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Drinks : ";
            // 
            // lblPizzasDisplay
            // 
            this.lblPizzasDisplay.AutoSize = true;
            this.lblPizzasDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPizzasDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzasDisplay.Location = new System.Drawing.Point(104, 13);
            this.lblPizzasDisplay.Name = "lblPizzasDisplay";
            this.lblPizzasDisplay.Size = new System.Drawing.Size(95, 25);
            this.lblPizzasDisplay.TabIndex = 3;
            this.lblPizzasDisplay.Text = "Pizzas : ";
            // 
            // lbxDrinks
            // 
            this.lbxDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDrinks.FormattingEnabled = true;
            this.lbxDrinks.ItemHeight = 25;
            this.lbxDrinks.Items.AddRange(new object[] {
            "Flat water - 2.50€",
            "Sparkling water - 2.50€",
            "Cola - 2.75€",
            "Ice tea - 2.75€",
            "Energy drink - 3.75€"});
            this.lbxDrinks.Location = new System.Drawing.Point(432, 42);
            this.lbxDrinks.Name = "lbxDrinks";
            this.lbxDrinks.Size = new System.Drawing.Size(260, 204);
            this.lbxDrinks.TabIndex = 2;
            // 
            // lbxPizzas
            // 
            this.lbxPizzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbxPizzas.FormattingEnabled = true;
            this.lbxPizzas.ItemHeight = 25;
            this.lbxPizzas.Items.AddRange(new object[] {
            "Margherita - 5.99€",
            "Quattro formaggi - 7.99€",
            "Quattro stagioni - 7.49€",
            "Pepperoni - 6.99€",
            "Bbq chicken - 6.99€"});
            this.lbxPizzas.Location = new System.Drawing.Point(36, 42);
            this.lbxPizzas.Name = "lbxPizzas";
            this.lbxPizzas.Size = new System.Drawing.Size(260, 204);
            this.lbxPizzas.TabIndex = 0;
            // 
            // tabPageNewCustomer
            // 
            this.tabPageNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tabPageNewCustomer.Controls.Add(this.btRegisterOrderMenu);
            this.tabPageNewCustomer.Controls.Add(this.gbxNewCustomer);
            this.tabPageNewCustomer.Location = new System.Drawing.Point(4, 4);
            this.tabPageNewCustomer.Name = "tabPageNewCustomer";
            this.tabPageNewCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewCustomer.Size = new System.Drawing.Size(736, 411);
            this.tabPageNewCustomer.TabIndex = 1;
            this.tabPageNewCustomer.Text = "tabPage2";
            // 
            // btRegisterOrderMenu
            // 
            this.btRegisterOrderMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btRegisterOrderMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegisterOrderMenu.Location = new System.Drawing.Point(599, 351);
            this.btRegisterOrderMenu.Name = "btRegisterOrderMenu";
            this.btRegisterOrderMenu.Size = new System.Drawing.Size(131, 45);
            this.btRegisterOrderMenu.TabIndex = 5;
            this.btRegisterOrderMenu.Text = "Order menu!";
            this.btRegisterOrderMenu.UseVisualStyleBackColor = false;
            this.btRegisterOrderMenu.Click += new System.EventHandler(this.btRegisterOrderMenu_Click);
            // 
            // gbxNewCustomer
            // 
            this.gbxNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbxNewCustomer.Controls.Add(this.btRegister);
            this.gbxNewCustomer.Controls.Add(this.label1);
            this.gbxNewCustomer.Controls.Add(this.lblEmail);
            this.gbxNewCustomer.Controls.Add(this.lblLastName);
            this.gbxNewCustomer.Controls.Add(this.lblFirstName);
            this.gbxNewCustomer.Controls.Add(this.tbEmail);
            this.gbxNewCustomer.Controls.Add(this.tbLastName);
            this.gbxNewCustomer.Controls.Add(this.tbFirstName);
            this.gbxNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNewCustomer.Location = new System.Drawing.Point(157, 20);
            this.gbxNewCustomer.Name = "gbxNewCustomer";
            this.gbxNewCustomer.Size = new System.Drawing.Size(414, 382);
            this.gbxNewCustomer.TabIndex = 0;
            this.gbxNewCustomer.TabStop = false;
            this.gbxNewCustomer.Text = "Register";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.btRegister.Location = new System.Drawing.Point(129, 265);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(151, 43);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "Register!";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "All fields marked with * are necessary";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(92, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(92, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name* :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(92, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(121, 20);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name* :";
            // 
            // tbEmail
            // 
            this.tbEmail.AccessibleDescription = "";
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tbEmail.CausesValidation = false;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(96, 209);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(217, 30);
            this.tbEmail.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.AccessibleDescription = "";
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tbLastName.CausesValidation = false;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(96, 141);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(217, 30);
            this.tbLastName.TabIndex = 7;
            // 
            // tbFirstName
            // 
            this.tbFirstName.AccessibleDescription = "";
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tbFirstName.CausesValidation = false;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(96, 77);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(217, 30);
            this.tbFirstName.TabIndex = 6;
            // 
            // tabPageEditCustomer
            // 
            this.tabPageEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tabPageEditCustomer.Controls.Add(this.btEditOrderMenu);
            this.tabPageEditCustomer.Controls.Add(this.gbxEditCustomer);
            this.tabPageEditCustomer.Location = new System.Drawing.Point(4, 4);
            this.tabPageEditCustomer.Name = "tabPageEditCustomer";
            this.tabPageEditCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditCustomer.Size = new System.Drawing.Size(736, 411);
            this.tabPageEditCustomer.TabIndex = 2;
            this.tabPageEditCustomer.Text = "tabPage1";
            // 
            // btEditOrderMenu
            // 
            this.btEditOrderMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btEditOrderMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditOrderMenu.Location = new System.Drawing.Point(599, 351);
            this.btEditOrderMenu.Name = "btEditOrderMenu";
            this.btEditOrderMenu.Size = new System.Drawing.Size(131, 45);
            this.btEditOrderMenu.TabIndex = 6;
            this.btEditOrderMenu.Text = "Order menu!";
            this.btEditOrderMenu.UseVisualStyleBackColor = false;
            this.btEditOrderMenu.Click += new System.EventHandler(this.btEditOrderMenu_Click);
            // 
            // gbxEditCustomer
            // 
            this.gbxEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbxEditCustomer.Controls.Add(this.btnEdit);
            this.gbxEditCustomer.Controls.Add(this.label2);
            this.gbxEditCustomer.Controls.Add(this.label3);
            this.gbxEditCustomer.Controls.Add(this.label4);
            this.gbxEditCustomer.Controls.Add(this.label5);
            this.gbxEditCustomer.Controls.Add(this.tbEditEmail);
            this.gbxEditCustomer.Controls.Add(this.tbEditLastName);
            this.gbxEditCustomer.Controls.Add(this.tbEditFirstName);
            this.gbxEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEditCustomer.Location = new System.Drawing.Point(161, 14);
            this.gbxEditCustomer.Name = "gbxEditCustomer";
            this.gbxEditCustomer.Size = new System.Drawing.Size(414, 382);
            this.gbxEditCustomer.TabIndex = 1;
            this.gbxEditCustomer.TabStop = false;
            this.gbxEditCustomer.Text = "Edit customer";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.btnEdit.Location = new System.Drawing.Point(129, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 43);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Update!";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "All fields marked with * are necessary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name* :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "First Name* :";
            // 
            // tbEditEmail
            // 
            this.tbEditEmail.AccessibleDescription = "";
            this.tbEditEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tbEditEmail.CausesValidation = false;
            this.tbEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditEmail.Location = new System.Drawing.Point(96, 209);
            this.tbEditEmail.Name = "tbEditEmail";
            this.tbEditEmail.Size = new System.Drawing.Size(217, 30);
            this.tbEditEmail.TabIndex = 8;
            // 
            // tbEditLastName
            // 
            this.tbEditLastName.AccessibleDescription = "";
            this.tbEditLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tbEditLastName.CausesValidation = false;
            this.tbEditLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditLastName.Location = new System.Drawing.Point(96, 141);
            this.tbEditLastName.Name = "tbEditLastName";
            this.tbEditLastName.Size = new System.Drawing.Size(217, 30);
            this.tbEditLastName.TabIndex = 7;
            // 
            // tbEditFirstName
            // 
            this.tbEditFirstName.AccessibleDescription = "";
            this.tbEditFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tbEditFirstName.CausesValidation = false;
            this.tbEditFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditFirstName.Location = new System.Drawing.Point(96, 77);
            this.tbEditFirstName.Name = "tbEditFirstName";
            this.tbEditFirstName.Size = new System.Drawing.Size(217, 30);
            this.tbEditFirstName.TabIndex = 6;
            // 
            // tabPageEmpty
            // 
            this.tabPageEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(110)))));
            this.tabPageEmpty.Controls.Add(this.btNewOrder);
            this.tabPageEmpty.Location = new System.Drawing.Point(4, 4);
            this.tabPageEmpty.Name = "tabPageEmpty";
            this.tabPageEmpty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmpty.Size = new System.Drawing.Size(736, 411);
            this.tabPageEmpty.TabIndex = 3;
            this.tabPageEmpty.Text = "tabPage1";
            // 
            // btNewOrder
            // 
            this.btNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewOrder.Location = new System.Drawing.Point(267, 176);
            this.btNewOrder.Name = "btNewOrder";
            this.btNewOrder.Size = new System.Drawing.Size(170, 61);
            this.btNewOrder.TabIndex = 5;
            this.btNewOrder.Text = "Make order!";
            this.btNewOrder.UseVisualStyleBackColor = false;
            this.btNewOrder.Click += new System.EventHandler(this.btNewOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1128, 660);
            this.Controls.Add(this.tabControlPdAndCustomers);
            this.Controls.Add(this.panelManager);
            this.Controls.Add(this.lbxReceipt);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelManager.ResumeLayout(false);
            this.tabControlPdAndCustomers.ResumeLayout(false);
            this.tabPagePizzaAndDrinks.ResumeLayout(false);
            this.tabPagePizzaAndDrinks.PerformLayout();
            this.gbxTopping.ResumeLayout(false);
            this.gbxTopping.PerformLayout();
            this.tabPageNewCustomer.ResumeLayout(false);
            this.gbxNewCustomer.ResumeLayout(false);
            this.gbxNewCustomer.PerformLayout();
            this.tabPageEditCustomer.ResumeLayout(false);
            this.gbxEditCustomer.ResumeLayout(false);
            this.gbxEditCustomer.PerformLayout();
            this.tabPageEmpty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.ListBox lbxReceipt;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.TabControl tabControlPdAndCustomers;
        private System.Windows.Forms.TabPage tabPagePizzaAndDrinks;
        private System.Windows.Forms.TabPage tabPageNewCustomer;
        private System.Windows.Forms.GroupBox gbxNewCustomer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditExistingCustomer;
        private System.Windows.Forms.TabPage tabPageEditCustomer;
        private System.Windows.Forms.GroupBox gbxEditCustomer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEditEmail;
        private System.Windows.Forms.TextBox tbEditLastName;
        private System.Windows.Forms.TextBox tbEditFirstName;
        private System.Windows.Forms.TextBox tbDrinkQuantity;
        private System.Windows.Forms.Button btDrinkMinus;
        private System.Windows.Forms.Button btDrinkPlus;
        private System.Windows.Forms.TextBox tbPizzaQuantity;
        private System.Windows.Forms.Button btnMinusPizza;
        private System.Windows.Forms.Button btnPlusPizza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPizzasDisplay;
        private System.Windows.Forms.ListBox lbxDrinks;
        private System.Windows.Forms.ListBox lbxPizzas;
        private System.Windows.Forms.Button btAddDrink;
        private System.Windows.Forms.Button btAddPizza;
        private System.Windows.Forms.TabPage tabPageEmpty;
        private System.Windows.Forms.Button btNewOrder;
        private System.Windows.Forms.GroupBox gbxTopping;
        private System.Windows.Forms.RadioButton rbFilled;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btRegisterOrderMenu;
        private System.Windows.Forms.Button btEditOrderMenu;
        private System.Windows.Forms.Button btStatics;
    }
}

