namespace AnimalShelter
{
    partial class MainInterface
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
            this.lbxAnimals = new System.Windows.Forms.ListBox();
            this.tbtnAdoptable = new System.Windows.Forms.RadioButton();
            this.rbtnNotYetAdoptable = new System.Windows.Forms.RadioButton();
            this.tbxOwnerLastName = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.rbtnOwnerLastName = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxAnimals
            // 
            this.lbxAnimals.FormattingEnabled = true;
            this.lbxAnimals.Location = new System.Drawing.Point(43, 63);
            this.lbxAnimals.Name = "lbxAnimals";
            this.lbxAnimals.Size = new System.Drawing.Size(472, 95);
            this.lbxAnimals.TabIndex = 0;
            // 
            // tbtnAdoptable
            // 
            this.tbtnAdoptable.AutoSize = true;
            this.tbtnAdoptable.Location = new System.Drawing.Point(78, 17);
            this.tbtnAdoptable.Name = "tbtnAdoptable";
            this.tbtnAdoptable.Size = new System.Drawing.Size(73, 17);
            this.tbtnAdoptable.TabIndex = 2;
            this.tbtnAdoptable.TabStop = true;
            this.tbtnAdoptable.Text = "Adobtable";
            this.tbtnAdoptable.UseVisualStyleBackColor = true;
            // 
            // rbtnNotYetAdoptable
            // 
            this.rbtnNotYetAdoptable.AutoSize = true;
            this.rbtnNotYetAdoptable.Location = new System.Drawing.Point(157, 17);
            this.rbtnNotYetAdoptable.Name = "rbtnNotYetAdoptable";
            this.rbtnNotYetAdoptable.Size = new System.Drawing.Size(109, 17);
            this.rbtnNotYetAdoptable.TabIndex = 3;
            this.rbtnNotYetAdoptable.TabStop = true;
            this.rbtnNotYetAdoptable.Text = "Not-yet-adobtable";
            this.rbtnNotYetAdoptable.UseVisualStyleBackColor = true;
            // 
            // tbxOwnerLastName
            // 
            this.tbxOwnerLastName.Location = new System.Drawing.Point(389, 16);
            this.tbxOwnerLastName.Name = "tbxOwnerLastName";
            this.tbxOwnerLastName.Size = new System.Drawing.Size(126, 20);
            this.tbxOwnerLastName.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(40, 19);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter:";
            // 
            // rbtnOwnerLastName
            // 
            this.rbtnOwnerLastName.AutoSize = true;
            this.rbtnOwnerLastName.Location = new System.Drawing.Point(272, 17);
            this.rbtnOwnerLastName.Name = "rbtnOwnerLastName";
            this.rbtnOwnerLastName.Size = new System.Drawing.Size(111, 17);
            this.rbtnOwnerLastName.TabIndex = 6;
            this.rbtnOwnerLastName.TabStop = true;
            this.rbtnOwnerLastName.Text = "Owner\'s last name";
            this.rbtnOwnerLastName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animals:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(472, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 232);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnOwnerLastName);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.tbxOwnerLastName);
            this.Controls.Add(this.rbtnNotYetAdoptable);
            this.Controls.Add(this.tbtnAdoptable);
            this.Controls.Add(this.lbxAnimals);
            this.Name = "MainInterface";
            this.Text = "Animal Shelter - <ShelterName>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAnimals;
        private System.Windows.Forms.RadioButton tbtnAdoptable;
        private System.Windows.Forms.RadioButton rbtnNotYetAdoptable;
        private System.Windows.Forms.TextBox tbxOwnerLastName;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.RadioButton rbtnOwnerLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}

