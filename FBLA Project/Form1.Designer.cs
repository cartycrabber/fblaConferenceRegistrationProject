namespace FBLA_Project
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.enterButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.conferencesComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.chaptNumTextBox = new System.Windows.Forms.TextBox();
            this.workshopComboBox = new System.Windows.Forms.ComboBox();
            this.workshopTextBox = new System.Windows.Forms.RichTextBox();
            this.chosenWorkBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.workButton = new System.Windows.Forms.Button();
            this.workshopDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(400, 416);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(110, 34);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter Information";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 370);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(249, 370);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Last Name";
            this.lastNameTextBox.Enter += new System.EventHandler(this.lastNameTextBox_Enter);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // conferencesComboBox
            // 
            this.conferencesComboBox.FormattingEnabled = true;
            this.conferencesComboBox.Location = new System.Drawing.Point(597, 370);
            this.conferencesComboBox.Name = "conferencesComboBox";
            this.conferencesComboBox.Size = new System.Drawing.Size(182, 21);
            this.conferencesComboBox.TabIndex = 4;
            this.conferencesComboBox.Text = "Conference";
            this.conferencesComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.conferencesComboBox_KeyPress);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(786, 370);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(186, 21);
            this.typeComboBox.TabIndex = 5;
            this.typeComboBox.Text = "Type";
            this.typeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typeComboBox_KeyPress);
            // 
            // chaptNumTextBox
            // 
            this.chaptNumTextBox.Location = new System.Drawing.Point(486, 370);
            this.chaptNumTextBox.Name = "chaptNumTextBox";
            this.chaptNumTextBox.Size = new System.Drawing.Size(105, 20);
            this.chaptNumTextBox.TabIndex = 3;
            this.chaptNumTextBox.Text = "Chapter #";
            this.chaptNumTextBox.Enter += new System.EventHandler(this.chaptNumTextBox_Enter);
            this.chaptNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chaptNumTextBox_KeyPress);
            this.chaptNumTextBox.Leave += new System.EventHandler(this.chaptNumTextBox_Leave);
            // 
            // workshopComboBox
            // 
            this.workshopComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopComboBox.FormattingEnabled = true;
            this.workshopComboBox.Location = new System.Drawing.Point(12, 12);
            this.workshopComboBox.Name = "workshopComboBox";
            this.workshopComboBox.Size = new System.Drawing.Size(417, 32);
            this.workshopComboBox.TabIndex = 6;
            this.workshopComboBox.Text = "Workshops";
            this.workshopComboBox.SelectedIndexChanged += new System.EventHandler(this.workshopComboBox_SelectedIndexChanged);
            // 
            // workshopTextBox
            // 
            this.workshopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopTextBox.Location = new System.Drawing.Point(12, 50);
            this.workshopTextBox.Name = "workshopTextBox";
            this.workshopTextBox.ReadOnly = true;
            this.workshopTextBox.Size = new System.Drawing.Size(620, 246);
            this.workshopTextBox.TabIndex = 8;
            this.workshopTextBox.Text = "";
            // 
            // chosenWorkBox
            // 
            this.chosenWorkBox.FormattingEnabled = true;
            this.chosenWorkBox.Location = new System.Drawing.Point(638, 52);
            this.chosenWorkBox.Name = "chosenWorkBox";
            this.chosenWorkBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chosenWorkBox.Size = new System.Drawing.Size(334, 277);
            this.chosenWorkBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chosen Workshops:";
            // 
            // workButton
            // 
            this.workButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workButton.Location = new System.Drawing.Point(436, 13);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(196, 30);
            this.workButton.TabIndex = 11;
            this.workButton.Text = "Add";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // workshopDateTime
            // 
            this.workshopDateTime.AutoSize = true;
            this.workshopDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopDateTime.Location = new System.Drawing.Point(12, 299);
            this.workshopDateTime.Name = "workshopDateTime";
            this.workshopDateTime.Size = new System.Drawing.Size(183, 29);
            this.workshopDateTime.TabIndex = 12;
            this.workshopDateTime.Text = "Date and Time: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.workshopDateTime);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chosenWorkBox);
            this.Controls.Add(this.workshopTextBox);
            this.Controls.Add(this.workshopComboBox);
            this.Controls.Add(this.chaptNumTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.conferencesComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.enterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "FBLA Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox conferencesComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox chaptNumTextBox;
        private System.Windows.Forms.ComboBox workshopComboBox;
        private System.Windows.Forms.RichTextBox workshopTextBox;
        private System.Windows.Forms.ListBox chosenWorkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Label workshopDateTime;
    }
}

