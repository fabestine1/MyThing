namespace PCS2ExamApp
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
            this.panelAgencyOwner = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAORelevantInstrument = new System.Windows.Forms.TextBox();
            this.btAOAddRelevantInstrument = new System.Windows.Forms.Button();
            this.cmbAORelevantInstruments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMusician = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMIdNr = new System.Windows.Forms.TextBox();
            this.btMAddAnInstrumentToMyList = new System.Windows.Forms.Button();
            this.cmbMRelevantInstruments = new System.Windows.Forms.ComboBox();
            this.lbMAllMusicians = new System.Windows.Forms.ListBox();
            this.tbMAge = new System.Windows.Forms.TextBox();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.btMAddMe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAgencyOwner.SuspendLayout();
            this.panelMusician.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgencyOwner
            // 
            this.panelAgencyOwner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAgencyOwner.BackColor = System.Drawing.Color.DarkGray;
            this.panelAgencyOwner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAgencyOwner.Controls.Add(this.label6);
            this.panelAgencyOwner.Controls.Add(this.label5);
            this.panelAgencyOwner.Controls.Add(this.tbAORelevantInstrument);
            this.panelAgencyOwner.Controls.Add(this.btAOAddRelevantInstrument);
            this.panelAgencyOwner.Controls.Add(this.cmbAORelevantInstruments);
            this.panelAgencyOwner.Controls.Add(this.label1);
            this.panelAgencyOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAgencyOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAgencyOwner.Location = new System.Drawing.Point(0, 0);
            this.panelAgencyOwner.Margin = new System.Windows.Forms.Padding(2);
            this.panelAgencyOwner.Name = "panelAgencyOwner";
            this.panelAgencyOwner.Size = new System.Drawing.Size(700, 98);
            this.panelAgencyOwner.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "cmbAORelevantInstruments:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "tbAORelevantInstrument:";
            // 
            // tbAORelevantInstrument
            // 
            this.tbAORelevantInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAORelevantInstrument.Location = new System.Drawing.Point(238, 36);
            this.tbAORelevantInstrument.Margin = new System.Windows.Forms.Padding(2);
            this.tbAORelevantInstrument.Name = "tbAORelevantInstrument";
            this.tbAORelevantInstrument.Size = new System.Drawing.Size(224, 26);
            this.tbAORelevantInstrument.TabIndex = 3;
            this.tbAORelevantInstrument.TextChanged += new System.EventHandler(this.tbAORelevantInstrument_TextChanged);
            // 
            // btAOAddRelevantInstrument
            // 
            this.btAOAddRelevantInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAOAddRelevantInstrument.Location = new System.Drawing.Point(16, 33);
            this.btAOAddRelevantInstrument.Margin = new System.Windows.Forms.Padding(2);
            this.btAOAddRelevantInstrument.Name = "btAOAddRelevantInstrument";
            this.btAOAddRelevantInstrument.Size = new System.Drawing.Size(201, 27);
            this.btAOAddRelevantInstrument.TabIndex = 2;
            this.btAOAddRelevantInstrument.Text = "add relevant instrument";
            this.btAOAddRelevantInstrument.UseVisualStyleBackColor = true;
            this.btAOAddRelevantInstrument.Click += new System.EventHandler(this.btAOAddRelevantInstrument_Click);
            // 
            // cmbAORelevantInstruments
            // 
            this.cmbAORelevantInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAORelevantInstruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAORelevantInstruments.FormattingEnabled = true;
            this.cmbAORelevantInstruments.Location = new System.Drawing.Point(491, 34);
            this.cmbAORelevantInstruments.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAORelevantInstruments.Name = "cmbAORelevantInstruments";
            this.cmbAORelevantInstruments.Size = new System.Drawing.Size(130, 28);
            this.cmbAORelevantInstruments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "panelAgencyOwner";
            // 
            // panelMusician
            // 
            this.panelMusician.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMusician.BackColor = System.Drawing.Color.LightGray;
            this.panelMusician.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMusician.Controls.Add(this.label9);
            this.panelMusician.Controls.Add(this.label8);
            this.panelMusician.Controls.Add(this.label7);
            this.panelMusician.Controls.Add(this.label4);
            this.panelMusician.Controls.Add(this.label3);
            this.panelMusician.Controls.Add(this.tbMIdNr);
            this.panelMusician.Controls.Add(this.btMAddAnInstrumentToMyList);
            this.panelMusician.Controls.Add(this.cmbMRelevantInstruments);
            this.panelMusician.Controls.Add(this.lbMAllMusicians);
            this.panelMusician.Controls.Add(this.tbMAge);
            this.panelMusician.Controls.Add(this.tbMName);
            this.panelMusician.Controls.Add(this.btMAddMe);
            this.panelMusician.Controls.Add(this.label2);
            this.panelMusician.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMusician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMusician.Location = new System.Drawing.Point(0, 98);
            this.panelMusician.Margin = new System.Windows.Forms.Padding(2);
            this.panelMusician.Name = "panelMusician";
            this.panelMusician.Size = new System.Drawing.Size(700, 367);
            this.panelMusician.TabIndex = 1;
            this.panelMusician.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMusician_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "lbMAllMusicians:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "tbMIdNr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "cmbMRelevantInstruments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "tbMAge:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "tbMName:";
            // 
            // tbMIdNr
            // 
            this.tbMIdNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMIdNr.Location = new System.Drawing.Point(238, 132);
            this.tbMIdNr.Margin = new System.Windows.Forms.Padding(2);
            this.tbMIdNr.Name = "tbMIdNr";
            this.tbMIdNr.Size = new System.Drawing.Size(99, 26);
            this.tbMIdNr.TabIndex = 9;
            // 
            // btMAddAnInstrumentToMyList
            // 
            this.btMAddAnInstrumentToMyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMAddAnInstrumentToMyList.Location = new System.Drawing.Point(16, 131);
            this.btMAddAnInstrumentToMyList.Margin = new System.Windows.Forms.Padding(2);
            this.btMAddAnInstrumentToMyList.Name = "btMAddAnInstrumentToMyList";
            this.btMAddAnInstrumentToMyList.Size = new System.Drawing.Size(201, 27);
            this.btMAddAnInstrumentToMyList.TabIndex = 8;
            this.btMAddAnInstrumentToMyList.Text = "add an instrument";
            this.btMAddAnInstrumentToMyList.UseVisualStyleBackColor = true;
            this.btMAddAnInstrumentToMyList.Click += new System.EventHandler(this.btMAddAnInstrumentToMyList_Click);
            // 
            // cmbMRelevantInstruments
            // 
            this.cmbMRelevantInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMRelevantInstruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMRelevantInstruments.FormattingEnabled = true;
            this.cmbMRelevantInstruments.Location = new System.Drawing.Point(491, 94);
            this.cmbMRelevantInstruments.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMRelevantInstruments.Name = "cmbMRelevantInstruments";
            this.cmbMRelevantInstruments.Size = new System.Drawing.Size(130, 28);
            this.cmbMRelevantInstruments.TabIndex = 7;
            // 
            // lbMAllMusicians
            // 
            this.lbMAllMusicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMAllMusicians.FormattingEnabled = true;
            this.lbMAllMusicians.ItemHeight = 20;
            this.lbMAllMusicians.Location = new System.Drawing.Point(16, 216);
            this.lbMAllMusicians.Margin = new System.Windows.Forms.Padding(2);
            this.lbMAllMusicians.Name = "lbMAllMusicians";
            this.lbMAllMusicians.Size = new System.Drawing.Size(605, 104);
            this.lbMAllMusicians.TabIndex = 6;
            // 
            // tbMAge
            // 
            this.tbMAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMAge.Location = new System.Drawing.Point(413, 44);
            this.tbMAge.Margin = new System.Windows.Forms.Padding(2);
            this.tbMAge.Name = "tbMAge";
            this.tbMAge.Size = new System.Drawing.Size(50, 26);
            this.tbMAge.TabIndex = 3;
            // 
            // tbMName
            // 
            this.tbMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMName.Location = new System.Drawing.Point(238, 46);
            this.tbMName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(152, 26);
            this.tbMName.TabIndex = 2;
            // 
            // btMAddMe
            // 
            this.btMAddMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMAddMe.Location = new System.Drawing.Point(16, 43);
            this.btMAddMe.Margin = new System.Windows.Forms.Padding(2);
            this.btMAddMe.Name = "btMAddMe";
            this.btMAddMe.Size = new System.Drawing.Size(201, 27);
            this.btMAddMe.TabIndex = 1;
            this.btMAddMe.Text = "add me";
            this.btMAddMe.UseVisualStyleBackColor = true;
            this.btMAddMe.Click += new System.EventHandler(this.btMAddMe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "panelMusician";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 465);
            this.Controls.Add(this.panelMusician);
            this.Controls.Add(this.panelAgencyOwner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAgencyOwner.ResumeLayout(false);
            this.panelAgencyOwner.PerformLayout();
            this.panelMusician.ResumeLayout(false);
            this.panelMusician.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgencyOwner;
        private System.Windows.Forms.Panel panelMusician;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAOAddRelevantInstrument;
        private System.Windows.Forms.ComboBox cmbAORelevantInstruments;
        private System.Windows.Forms.TextBox tbAORelevantInstrument;
        private System.Windows.Forms.ListBox lbMAllMusicians;
        private System.Windows.Forms.TextBox tbMAge;
        private System.Windows.Forms.TextBox tbMName;
        private System.Windows.Forms.Button btMAddMe;
        private System.Windows.Forms.ComboBox cmbMRelevantInstruments;
        private System.Windows.Forms.Button btMAddAnInstrumentToMyList;
        private System.Windows.Forms.TextBox tbMIdNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

