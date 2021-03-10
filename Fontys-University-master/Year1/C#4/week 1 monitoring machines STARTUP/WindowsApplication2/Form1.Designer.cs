namespace WindowsApplication2
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
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWarnings = new System.Windows.Forms.ListBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSimulateTemperature = new System.Windows.Forms.Button();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogging = new System.Windows.Forms.Button();
            this.btnSimulatePressuse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(11, 23);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(536, 44);
            this.btnShowInfo.TabIndex = 0;
            this.btnShowInfo.Text = "Show info of manufacturing company and all machines";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbWarnings);
            this.panel1.Controls.Add(this.btnShowInfo);
            this.panel1.Controls.Add(this.lbInfo);
            this.panel1.Location = new System.Drawing.Point(12, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 356);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "warnings";
            // 
            // lbWarnings
            // 
            this.lbWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarnings.FormattingEnabled = true;
            this.lbWarnings.ItemHeight = 20;
            this.lbWarnings.Location = new System.Drawing.Point(557, 36);
            this.lbWarnings.Name = "lbWarnings";
            this.lbWarnings.Size = new System.Drawing.Size(325, 284);
            this.lbWarnings.TabIndex = 4;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(11, 73);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(540, 244);
            this.lbInfo.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(732, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(187, 34);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load from file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSimulateTemperature
            // 
            this.btnSimulateTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateTemperature.Location = new System.Drawing.Point(388, 54);
            this.btnSimulateTemperature.Name = "btnSimulateTemperature";
            this.btnSimulateTemperature.Size = new System.Drawing.Size(316, 43);
            this.btnSimulateTemperature.TabIndex = 6;
            this.btnSimulateTemperature.Text = "Simulate temperature data from machine";
            this.btnSimulateTemperature.UseVisualStyleBackColor = true;
            this.btnSimulateTemperature.Click += new System.EventHandler(this.btnSimulateTemperature_Click);
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemp.Location = new System.Drawing.Point(148, 53);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(87, 26);
            this.tbTemp.TabIndex = 6;
            // 
            // tbPressure
            // 
            this.tbPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPressure.Location = new System.Drawing.Point(147, 92);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(87, 26);
            this.tbPressure.TabIndex = 4;
            // 
            // tbMachineName
            // 
            this.tbMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMachineName.Location = new System.Drawing.Point(148, 16);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(150, 26);
            this.tbMachineName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "name of machine";
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.Location = new System.Drawing.Point(388, 12);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(316, 36);
            this.btnAddMachine.TabIndex = 7;
            this.btnAddMachine.Text = "Add machine";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.tbMachineName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbPressure);
            this.panel2.Controls.Add(this.tbTemp);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 130);
            this.panel2.TabIndex = 10;
            // 
            // btnLogging
            // 
            this.btnLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogging.Location = new System.Drawing.Point(732, 13);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(187, 53);
            this.btnLogging.TabIndex = 13;
            this.btnLogging.Text = "Start logging";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // btnSimulatePressuse
            // 
            this.btnSimulatePressuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulatePressuse.Location = new System.Drawing.Point(388, 107);
            this.btnSimulatePressuse.Name = "btnSimulatePressuse";
            this.btnSimulatePressuse.Size = new System.Drawing.Size(316, 43);
            this.btnSimulatePressuse.TabIndex = 14;
            this.btnSimulatePressuse.Text = "Simulate pressure data from machine";
            this.btnSimulatePressuse.UseVisualStyleBackColor = true;
            this.btnSimulatePressuse.Click += new System.EventHandler(this.btnSimulatePressure_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(732, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(931, 488);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSimulatePressuse);
            this.Controls.Add(this.btnLogging);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSimulateTemperature);
            this.Controls.Add(this.btnAddMachine);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1,Teachers solution";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.Button btnSimulateTemperature;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbWarnings;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.Button btnSimulatePressuse;
        private System.Windows.Forms.Button btnSave;
    }
}

