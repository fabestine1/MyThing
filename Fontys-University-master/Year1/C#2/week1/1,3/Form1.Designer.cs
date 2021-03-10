namespace _1_3
{
    partial class Dividing
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
            this.Divide = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.TextBox();
            this.reminder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipFirstNumber = new System.Windows.Forms.ToolTip(this.components);
            this.tipSecondNumber = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Maroon;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.ForeColor = System.Drawing.Color.Chartreuse;
            this.Divide.Location = new System.Drawing.Point(93, 224);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(91, 46);
            this.Divide.TabIndex = 0;
            this.Divide.Text = "Result";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Maroon;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Chartreuse;
            this.Exit.Location = new System.Drawing.Point(274, 224);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 46);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // firstValue
            // 
            this.firstValue.BackColor = System.Drawing.Color.Maroon;
            this.firstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstValue.ForeColor = System.Drawing.Color.Chartreuse;
            this.firstValue.Location = new System.Drawing.Point(84, 39);
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(100, 29);
            this.firstValue.TabIndex = 3;
            this.tipFirstNumber.SetToolTip(this.firstValue, "Enter Whole Number");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(232, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "B:";
            // 
            // secondValue
            // 
            this.secondValue.BackColor = System.Drawing.Color.Maroon;
            this.secondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondValue.ForeColor = System.Drawing.Color.Chartreuse;
            this.secondValue.Location = new System.Drawing.Point(265, 39);
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(100, 29);
            this.secondValue.TabIndex = 5;
            this.tipSecondNumber.SetToolTip(this.secondValue, "Enter Whole Number Different Than 0");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "A/B:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Maroon;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.ForeColor = System.Drawing.Color.Chartreuse;
            this.division.Location = new System.Drawing.Point(84, 126);
            this.division.Name = "division";
            this.division.ReadOnly = true;
            this.division.Size = new System.Drawing.Size(100, 29);
            this.division.TabIndex = 7;
            // 
            // reminder
            // 
            this.reminder.BackColor = System.Drawing.Color.Maroon;
            this.reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminder.ForeColor = System.Drawing.Color.Chartreuse;
            this.reminder.Location = new System.Drawing.Point(265, 126);
            this.reminder.Name = "reminder";
            this.reminder.ReadOnly = true;
            this.reminder.Size = new System.Drawing.Size(100, 29);
            this.reminder.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(204, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "A%B:";
            // 
            // Dividing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(428, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reminder);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Divide);
            this.Name = "Dividing";
            this.Text = "Dividing";
            this.Load += new System.EventHandler(this.Dividing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox division;
        private System.Windows.Forms.TextBox reminder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tipFirstNumber;
        private System.Windows.Forms.ToolTip tipSecondNumber;
    }
}

