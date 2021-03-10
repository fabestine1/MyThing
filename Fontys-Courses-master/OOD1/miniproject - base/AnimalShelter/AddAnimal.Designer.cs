namespace AnimalShelter
{
    partial class AddAnimal
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
            this.tbxFoundDate = new System.Windows.Forms.TextBox();
            this.tbxFoundLocation = new System.Windows.Forms.TextBox();
            this.rbtnCat = new System.Windows.Forms.RadioButton();
            this.rbtnDog = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFoundDate = new System.Windows.Forms.Label();
            this.lblFoundLocation = new System.Windows.Forms.Label();
            this.rtbxDescription = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbxExtraInfo = new System.Windows.Forms.RichTextBox();
            this.lblExtraInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxFoundDate
            // 
            this.tbxFoundDate.Location = new System.Drawing.Point(35, 308);
            this.tbxFoundDate.Name = "tbxFoundDate";
            this.tbxFoundDate.Size = new System.Drawing.Size(256, 20);
            this.tbxFoundDate.TabIndex = 0;
            // 
            // tbxFoundLocation
            // 
            this.tbxFoundLocation.Location = new System.Drawing.Point(35, 359);
            this.tbxFoundLocation.Name = "tbxFoundLocation";
            this.tbxFoundLocation.Size = new System.Drawing.Size(256, 20);
            this.tbxFoundLocation.TabIndex = 1;
            // 
            // rbtnCat
            // 
            this.rbtnCat.AutoSize = true;
            this.rbtnCat.Location = new System.Drawing.Point(73, 19);
            this.rbtnCat.Name = "rbtnCat";
            this.rbtnCat.Size = new System.Drawing.Size(41, 17);
            this.rbtnCat.TabIndex = 2;
            this.rbtnCat.TabStop = true;
            this.rbtnCat.Text = "Cat";
            this.rbtnCat.UseVisualStyleBackColor = true;
            // 
            // rbtnDog
            // 
            this.rbtnDog.AutoSize = true;
            this.rbtnDog.Location = new System.Drawing.Point(120, 19);
            this.rbtnDog.Name = "rbtnDog";
            this.rbtnDog.Size = new System.Drawing.Size(45, 17);
            this.rbtnDog.TabIndex = 3;
            this.rbtnDog.TabStop = true;
            this.rbtnDog.Text = "Dog";
            this.rbtnDog.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(32, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(32, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblFoundDate
            // 
            this.lblFoundDate.AutoSize = true;
            this.lblFoundDate.Location = new System.Drawing.Point(32, 292);
            this.lblFoundDate.Name = "lblFoundDate";
            this.lblFoundDate.Size = new System.Drawing.Size(79, 13);
            this.lblFoundDate.TabIndex = 6;
            this.lblFoundDate.Text = "Date of finding:";
            // 
            // lblFoundLocation
            // 
            this.lblFoundLocation.AutoSize = true;
            this.lblFoundLocation.Location = new System.Drawing.Point(32, 343);
            this.lblFoundLocation.Name = "lblFoundLocation";
            this.lblFoundLocation.Size = new System.Drawing.Size(97, 13);
            this.lblFoundLocation.TabIndex = 7;
            this.lblFoundLocation.Text = "Location of finding:";
            // 
            // rtbxDescription
            // 
            this.rtbxDescription.Location = new System.Drawing.Point(35, 71);
            this.rtbxDescription.Name = "rtbxDescription";
            this.rtbxDescription.Size = new System.Drawing.Size(256, 96);
            this.rtbxDescription.TabIndex = 8;
            this.rtbxDescription.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // rtbxExtraInfo
            // 
            this.rtbxExtraInfo.Location = new System.Drawing.Point(35, 204);
            this.rtbxExtraInfo.Name = "rtbxExtraInfo";
            this.rtbxExtraInfo.Size = new System.Drawing.Size(256, 65);
            this.rtbxExtraInfo.TabIndex = 11;
            this.rtbxExtraInfo.Text = "";
            // 
            // lblExtraInformation
            // 
            this.lblExtraInformation.AutoSize = true;
            this.lblExtraInformation.Location = new System.Drawing.Point(32, 188);
            this.lblExtraInformation.Name = "lblExtraInformation";
            this.lblExtraInformation.Size = new System.Drawing.Size(88, 13);
            this.lblExtraInformation.TabIndex = 10;
            this.lblExtraInformation.Text = "Extra information:";
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 474);
            this.Controls.Add(this.rtbxExtraInfo);
            this.Controls.Add(this.lblExtraInformation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbxDescription);
            this.Controls.Add(this.lblFoundLocation);
            this.Controls.Add(this.lblFoundDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.rbtnDog);
            this.Controls.Add(this.rbtnCat);
            this.Controls.Add(this.tbxFoundLocation);
            this.Controls.Add(this.tbxFoundDate);
            this.Name = "AddAnimal";
            this.Text = "Add animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFoundDate;
        private System.Windows.Forms.TextBox tbxFoundLocation;
        private System.Windows.Forms.RadioButton rbtnCat;
        private System.Windows.Forms.RadioButton rbtnDog;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFoundDate;
        private System.Windows.Forms.Label lblFoundLocation;
        private System.Windows.Forms.RichTextBox rtbxDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbxExtraInfo;
        private System.Windows.Forms.Label lblExtraInformation;
    }
}