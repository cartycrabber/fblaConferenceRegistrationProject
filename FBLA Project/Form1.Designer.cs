namespace FBLA_Project
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
            this.enterButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.conferencesComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.chaptNumTextBox = new System.Windows.Forms.TextBox();
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
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 336);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(249, 336);
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
            this.conferencesComboBox.Location = new System.Drawing.Point(598, 335);
            this.conferencesComboBox.Name = "conferencesComboBox";
            this.conferencesComboBox.Size = new System.Drawing.Size(182, 21);
            this.conferencesComboBox.TabIndex = 4;
            this.conferencesComboBox.Text = "Conference";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(786, 336);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(186, 21);
            this.typeComboBox.TabIndex = 5;
            this.typeComboBox.Text = "Type";
            // 
            // chaptNumTextBox
            // 
            this.chaptNumTextBox.Location = new System.Drawing.Point(487, 335);
            this.chaptNumTextBox.Name = "chaptNumTextBox";
            this.chaptNumTextBox.Size = new System.Drawing.Size(105, 20);
            this.chaptNumTextBox.TabIndex = 3;
            this.chaptNumTextBox.Text = "Chapter #";
            this.chaptNumTextBox.Enter += new System.EventHandler(this.chaptNumTextBox_Enter);
            this.chaptNumTextBox.Leave += new System.EventHandler(this.chaptNumTextBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.chaptNumTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.conferencesComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.enterButton);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

