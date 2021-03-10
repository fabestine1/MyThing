namespace Week2_ExtraPractical
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
            this.components = new System.ComponentModel.Container();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnStill = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.drawGraphics = new System.Windows.Forms.Timer(this.components);
            this.btnJump = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(12, 332);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(791, 121);
            this.logListBox.TabIndex = 0;
            this.logListBox.SelectedIndexChanged += new System.EventHandler(this.logListBox_SelectedIndexChanged);
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.Location = new System.Drawing.Point(138, 12);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(665, 286);
            this.canvasPictureBox.TabIndex = 1;
            this.canvasPictureBox.TabStop = false;
            this.canvasPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPictureBox_Paint);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 138);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.nameTextBox);
            this.settingsGroupBox.Controls.Add(this.nameLabel);
            this.settingsGroupBox.Controls.Add(this.sizeLabel);
            this.settingsGroupBox.Controls.Add(this.startButton);
            this.settingsGroupBox.Controls.Add(this.colorLabel);
            this.settingsGroupBox.Controls.Add(this.sizeComboBox);
            this.settingsGroupBox.Controls.Add(this.colorComboBox);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(120, 169);
            this.settingsGroupBox.TabIndex = 4;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(108, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(6, 95);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(35, 13);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Size:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(6, 55);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(40, 13);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color:";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Small",
            "Normal",
            "Large"});
            this.sizeComboBox.Location = new System.Drawing.Point(6, 111);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(108, 21);
            this.sizeComboBox.TabIndex = 5;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colorComboBox.Location = new System.Drawing.Point(6, 71);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(108, 21);
            this.colorComboBox.TabIndex = 4;
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.btnJump);
            this.actionsGroupBox.Controls.Add(this.btnMoveRight);
            this.actionsGroupBox.Controls.Add(this.btnStill);
            this.actionsGroupBox.Controls.Add(this.btnMoveLeft);
            this.actionsGroupBox.Controls.Add(this.infoButton);
            this.actionsGroupBox.Controls.Add(this.scoreButton);
            this.actionsGroupBox.Enabled = false;
            this.actionsGroupBox.Location = new System.Drawing.Point(12, 187);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(120, 139);
            this.actionsGroupBox.TabIndex = 8;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(86, 48);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(25, 23);
            this.btnMoveRight.TabIndex = 7;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnStill
            // 
            this.btnStill.Location = new System.Drawing.Point(46, 48);
            this.btnStill.Name = "btnStill";
            this.btnStill.Size = new System.Drawing.Size(25, 23);
            this.btnStill.TabIndex = 6;
            this.btnStill.Text = "||";
            this.btnStill.UseVisualStyleBackColor = true;
            this.btnStill.Click += new System.EventHandler(this.btnStill_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(6, 48);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(25, 23);
            this.btnMoveLeft.TabIndex = 8;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(3, 106);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(108, 23);
            this.infoButton.TabIndex = 5;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(3, 77);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(108, 23);
            this.scoreButton.TabIndex = 3;
            this.scoreButton.Text = "Update score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 457);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(793, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear log";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // drawGraphics
            // 
            this.drawGraphics.Interval = 30;
            this.drawGraphics.Tick += new System.EventHandler(this.drawGraphics_Tick);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(46, 19);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(25, 23);
            this.btnJump.TabIndex = 9;
            this.btnJump.Text = "^";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 505);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.canvasPictureBox);
            this.Controls.Add(this.logListBox);
            this.Name = "Form1";
            this.Text = "PCS2 Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.actionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Timer drawGraphics;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnStill;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnJump;
    }
}

