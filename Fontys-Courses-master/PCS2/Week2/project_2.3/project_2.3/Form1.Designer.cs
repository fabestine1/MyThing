namespace project_2._3
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbxMarks = new System.Windows.Forms.ListBox();
            this.lblSufficient = new System.Windows.Forms.Label();
            this.lblIncsufficient = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.tbxInsufficient = new System.Windows.Forms.TextBox();
            this.tbxAverage = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxMark = new System.Windows.Forms.TextBox();
            this.tbxSufficient = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.tbxAverage);
            this.panel2.Controls.Add(this.tbxInsufficient);
            this.panel2.Controls.Add(this.tbxTotal);
            this.panel2.Controls.Add(this.lblAverage);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSufficient);
            this.panel2.Controls.Add(this.tbxSufficient);
            this.panel2.Controls.Add(this.lblIncsufficient);
            this.panel2.Location = new System.Drawing.Point(367, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 360);
            this.panel2.TabIndex = 0;
            // 
            // lbxMarks
            // 
            this.lbxMarks.FormattingEnabled = true;
            this.lbxMarks.Location = new System.Drawing.Point(39, 23);
            this.lbxMarks.Name = "lbxMarks";
            this.lbxMarks.Size = new System.Drawing.Size(195, 212);
            this.lbxMarks.TabIndex = 0;
            this.lbxMarks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblSufficient
            // 
            this.lblSufficient.AutoSize = true;
            this.lblSufficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSufficient.Location = new System.Drawing.Point(36, 26);
            this.lblSufficient.Name = "lblSufficient";
            this.lblSufficient.Size = new System.Drawing.Size(63, 13);
            this.lblSufficient.TabIndex = 1;
            this.lblSufficient.Text = "sufficient:";
            this.lblSufficient.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIncsufficient
            // 
            this.lblIncsufficient.AutoSize = true;
            this.lblIncsufficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIncsufficient.Location = new System.Drawing.Point(26, 73);
            this.lblIncsufficient.Name = "lblIncsufficient";
            this.lblIncsufficient.Size = new System.Drawing.Size(73, 13);
            this.lblIncsufficient.TabIndex = 2;
            this.lblIncsufficient.Text = "insufficient:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(46, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "total:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverage.Location = new System.Drawing.Point(42, 164);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(57, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "average:";
            // 
            // tbxInsufficient
            // 
            this.tbxInsufficient.BackColor = System.Drawing.Color.Red;
            this.tbxInsufficient.Enabled = false;
            this.tbxInsufficient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxInsufficient.Location = new System.Drawing.Point(105, 70);
            this.tbxInsufficient.Name = "tbxInsufficient";
            this.tbxInsufficient.Size = new System.Drawing.Size(100, 20);
            this.tbxInsufficient.TabIndex = 5;
            // 
            // tbxAverage
            // 
            this.tbxAverage.Enabled = false;
            this.tbxAverage.Location = new System.Drawing.Point(105, 161);
            this.tbxAverage.Name = "tbxAverage";
            this.tbxAverage.Size = new System.Drawing.Size(100, 20);
            this.tbxAverage.TabIndex = 6;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(105, 115);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 7;
            // 
            // tbxMark
            // 
            this.tbxMark.Location = new System.Drawing.Point(39, 279);
            this.tbxMark.Name = "tbxMark";
            this.tbxMark.Size = new System.Drawing.Size(100, 20);
            this.tbxMark.TabIndex = 8;
            // 
            // tbxSufficient
            // 
            this.tbxSufficient.Enabled = false;
            this.tbxSufficient.Location = new System.Drawing.Point(105, 23);
            this.tbxSufficient.Name = "tbxSufficient";
            this.tbxSufficient.Size = new System.Drawing.Size(100, 20);
            this.tbxSufficient.TabIndex = 9;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(49, 240);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(159, 279);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(75, 23);
            this.btnAddMark.TabIndex = 11;
            this.btnAddMark.Text = "add to list";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(130, 240);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbxMarks);
            this.panel1.Controls.Add(this.tbxMark);
            this.panel1.Controls.Add(this.btnAddMark);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(40, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 360);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 425);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Mark processing";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbxSufficient;
        private System.Windows.Forms.TextBox tbxMark;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.TextBox tbxAverage;
        private System.Windows.Forms.TextBox tbxInsufficient;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIncsufficient;
        private System.Windows.Forms.Label lblSufficient;
        private System.Windows.Forms.ListBox lbxMarks;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
    }
}

