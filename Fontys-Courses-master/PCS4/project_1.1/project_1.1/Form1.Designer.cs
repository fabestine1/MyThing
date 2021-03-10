namespace project_1._1
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
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.rbtnToCapitals = new System.Windows.Forms.RadioButton();
            this.rbtnToNextCharacter = new System.Windows.Forms.RadioButton();
            this.rbtnToFormerCharacter = new System.Windows.Forms.RadioButton();
            this.rbtnToLettersOnly = new System.Windows.Forms.RadioButton();
            this.rbtnToUnderscoreCharacter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(352, 147);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(179, 20);
            this.tbxOutput.TabIndex = 0;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(34, 144);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(156, 20);
            this.tbxInput.TabIndex = 1;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(230, 144);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = ">>";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // rbtnToCapitals
            // 
            this.rbtnToCapitals.AutoSize = true;
            this.rbtnToCapitals.Location = new System.Drawing.Point(34, 18);
            this.rbtnToCapitals.Name = "rbtnToCapitals";
            this.rbtnToCapitals.Size = new System.Drawing.Size(73, 17);
            this.rbtnToCapitals.TabIndex = 3;
            this.rbtnToCapitals.Text = "to capitals";
            this.rbtnToCapitals.UseVisualStyleBackColor = true;
            this.rbtnToCapitals.CheckedChanged += new System.EventHandler(this.rbtnToCapitals_CheckedChanged);
            // 
            // rbtnToNextCharacter
            // 
            this.rbtnToNextCharacter.AutoSize = true;
            this.rbtnToNextCharacter.Location = new System.Drawing.Point(34, 41);
            this.rbtnToNextCharacter.Name = "rbtnToNextCharacter";
            this.rbtnToNextCharacter.Size = new System.Drawing.Size(105, 17);
            this.rbtnToNextCharacter.TabIndex = 4;
            this.rbtnToNextCharacter.Text = "to next character";
            this.rbtnToNextCharacter.UseVisualStyleBackColor = true;
            this.rbtnToNextCharacter.CheckedChanged += new System.EventHandler(this.rbtnToNextCharacter_CheckedChanged);
            // 
            // rbtnToFormerCharacter
            // 
            this.rbtnToFormerCharacter.AutoSize = true;
            this.rbtnToFormerCharacter.Location = new System.Drawing.Point(34, 64);
            this.rbtnToFormerCharacter.Name = "rbtnToFormerCharacter";
            this.rbtnToFormerCharacter.Size = new System.Drawing.Size(114, 17);
            this.rbtnToFormerCharacter.TabIndex = 5;
            this.rbtnToFormerCharacter.Text = "to former character";
            this.rbtnToFormerCharacter.UseVisualStyleBackColor = true;
            this.rbtnToFormerCharacter.CheckedChanged += new System.EventHandler(this.rbtnToFormerCharacter_CheckedChanged);
            // 
            // rbtnToLettersOnly
            // 
            this.rbtnToLettersOnly.AutoSize = true;
            this.rbtnToLettersOnly.Location = new System.Drawing.Point(34, 110);
            this.rbtnToLettersOnly.Name = "rbtnToLettersOnly";
            this.rbtnToLettersOnly.Size = new System.Drawing.Size(87, 17);
            this.rbtnToLettersOnly.TabIndex = 6;
            this.rbtnToLettersOnly.Text = "to letters only";
            this.rbtnToLettersOnly.UseVisualStyleBackColor = true;
            this.rbtnToLettersOnly.CheckedChanged += new System.EventHandler(this.rbtnToLettersOnly_CheckedChanged);
            // 
            // rbtnToUnderscoreCharacter
            // 
            this.rbtnToUnderscoreCharacter.AutoSize = true;
            this.rbtnToUnderscoreCharacter.Location = new System.Drawing.Point(34, 87);
            this.rbtnToUnderscoreCharacter.Name = "rbtnToUnderscoreCharacter";
            this.rbtnToUnderscoreCharacter.Size = new System.Drawing.Size(138, 17);
            this.rbtnToUnderscoreCharacter.TabIndex = 7;
            this.rbtnToUnderscoreCharacter.TabStop = true;
            this.rbtnToUnderscoreCharacter.Text = "to underscore character";
            this.rbtnToUnderscoreCharacter.UseVisualStyleBackColor = true;
            this.rbtnToUnderscoreCharacter.CheckedChanged += new System.EventHandler(this.rbtnToUnderscoreCharacter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 209);
            this.Controls.Add(this.rbtnToUnderscoreCharacter);
            this.Controls.Add(this.rbtnToLettersOnly);
            this.Controls.Add(this.rbtnToFormerCharacter);
            this.Controls.Add(this.rbtnToNextCharacter);
            this.Controls.Add(this.rbtnToCapitals);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.tbxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.RadioButton rbtnToCapitals;
        private System.Windows.Forms.RadioButton rbtnToNextCharacter;
        private System.Windows.Forms.RadioButton rbtnToFormerCharacter;
        private System.Windows.Forms.RadioButton rbtnToLettersOnly;
        private System.Windows.Forms.RadioButton rbtnToUnderscoreCharacter;
    }
}

