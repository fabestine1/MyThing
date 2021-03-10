namespace Garagemanagement
{
    partial class ControlPanelView
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
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.commandtxtbox = new System.Windows.Forms.TextBox();
            this.sendTSelf = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.targetIDbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.targetIDbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(361, 16);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(222, 238);
            this.lbDevices.TabIndex = 0;
            this.lbDevices.SelectedIndexChanged += new System.EventHandler(this.lbDevices_SelectedIndexChanged);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(5, 16);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(350, 212);
            this.lbLog.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connected Devices";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Send command";
            // 
            // commandtxtbox
            // 
            this.commandtxtbox.Location = new System.Drawing.Point(592, 16);
            this.commandtxtbox.Name = "commandtxtbox";
            this.commandtxtbox.Size = new System.Drawing.Size(203, 20);
            this.commandtxtbox.TabIndex = 6;
            this.commandtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandtxtbox_CheckKeys);
            // 
            // sendTSelf
            // 
            this.sendTSelf.AutoSize = true;
            this.sendTSelf.Checked = true;
            this.sendTSelf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendTSelf.Location = new System.Drawing.Point(592, 42);
            this.sendTSelf.Name = "sendTSelf";
            this.sendTSelf.Size = new System.Drawing.Size(15, 14);
            this.sendTSelf.TabIndex = 8;
            this.sendTSelf.Tag = "";
            this.sendTSelf.UseVisualStyleBackColor = true;
            this.sendTSelf.CheckedChanged += new System.EventHandler(this.sendTSelf_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(592, 68);
            this.textBox1.MaxLength = 50;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 83);
            this.textBox1.TabIndex = 9;
            // 
            // targetIDbox
            // 
            this.targetIDbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.targetIDbox.InterceptArrowKeys = false;
            this.targetIDbox.Location = new System.Drawing.Point(726, 42);
            this.targetIDbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.targetIDbox.Name = "targetIDbox";
            this.targetIDbox.Size = new System.Drawing.Size(69, 20);
            this.targetIDbox.TabIndex = 10;
            this.targetIDbox.Visible = false;
            // 
            // ControlPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 261);
            this.Controls.Add(this.targetIDbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendTSelf);
            this.Controls.Add(this.commandtxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lbDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanelView";
            this.ShowIcon = false;
            this.Text = "ControlPanelView";
            ((System.ComponentModel.ISupportInitialize)(this.targetIDbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commandtxtbox;
        private System.Windows.Forms.CheckBox sendTSelf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown targetIDbox;
    }
}