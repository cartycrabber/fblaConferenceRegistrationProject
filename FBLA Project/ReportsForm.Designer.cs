namespace FBLA_Project
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.sortingMenuStrip = new System.Windows.Forms.MenuStrip();
            this.conferenceParticipantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workshopParticipantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportListBox = new System.Windows.Forms.ListBox();
            this.sortTypeButton = new System.Windows.Forms.Button();
            this.sortChapterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.sortingMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortingMenuStrip
            // 
            this.sortingMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conferenceParticipantsToolStripMenuItem,
            this.workshopParticipantsToolStripMenuItem});
            this.sortingMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.sortingMenuStrip.Name = "sortingMenuStrip";
            this.sortingMenuStrip.Size = new System.Drawing.Size(984, 24);
            this.sortingMenuStrip.TabIndex = 0;
            this.sortingMenuStrip.Text = "menuStrip1";
            // 
            // conferenceParticipantsToolStripMenuItem
            // 
            this.conferenceParticipantsToolStripMenuItem.Name = "conferenceParticipantsToolStripMenuItem";
            this.conferenceParticipantsToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.conferenceParticipantsToolStripMenuItem.Text = "Conference Participants";
            // 
            // workshopParticipantsToolStripMenuItem
            // 
            this.workshopParticipantsToolStripMenuItem.Name = "workshopParticipantsToolStripMenuItem";
            this.workshopParticipantsToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.workshopParticipantsToolStripMenuItem.Text = "Workshop Participants";
            // 
            // reportListBox
            // 
            this.reportListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportListBox.FormattingEnabled = true;
            this.reportListBox.ItemHeight = 20;
            this.reportListBox.Location = new System.Drawing.Point(12, 67);
            this.reportListBox.Name = "reportListBox";
            this.reportListBox.Size = new System.Drawing.Size(960, 364);
            this.reportListBox.TabIndex = 1;
            // 
            // sortTypeButton
            // 
            this.sortTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTypeButton.Location = new System.Drawing.Point(114, 27);
            this.sortTypeButton.Name = "sortTypeButton";
            this.sortTypeButton.Size = new System.Drawing.Size(121, 34);
            this.sortTypeButton.TabIndex = 2;
            this.sortTypeButton.Text = "Participant Type";
            this.sortTypeButton.UseVisualStyleBackColor = true;
            this.sortTypeButton.Visible = false;
            this.sortTypeButton.Click += new System.EventHandler(this.sortTypeButton_Click);
            // 
            // sortChapterButton
            // 
            this.sortChapterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortChapterButton.Location = new System.Drawing.Point(241, 27);
            this.sortChapterButton.Name = "sortChapterButton";
            this.sortChapterButton.Size = new System.Drawing.Size(129, 34);
            this.sortChapterButton.TabIndex = 3;
            this.sortChapterButton.Text = "Chapter Number";
            this.sortChapterButton.UseVisualStyleBackColor = true;
            this.sortChapterButton.Visible = false;
            this.sortChapterButton.Click += new System.EventHandler(this.sortChapterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort By:";
            this.label1.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(915, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextbox.Location = new System.Drawing.Point(516, 30);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(333, 31);
            this.searchTextbox.TabIndex = 6;
            this.searchTextbox.Text = "Search Participant Name";
            this.searchTextbox.Enter += new System.EventHandler(this.searchTextbox_Enter);
            this.searchTextbox.Leave += new System.EventHandler(this.searchTextbox_Leave);
            // 
            // partSearchButton
            // 
            this.partSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchButton.Location = new System.Drawing.Point(432, 27);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(78, 34);
            this.partSearchButton.TabIndex = 7;
            this.partSearchButton.Text = "Go";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortChapterButton);
            this.Controls.Add(this.sortTypeButton);
            this.Controls.Add(this.reportListBox);
            this.Controls.Add(this.sortingMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.sortingMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.sortingMenuStrip.ResumeLayout(false);
            this.sortingMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip sortingMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem conferenceParticipantsToolStripMenuItem;
        private System.Windows.Forms.ListBox reportListBox;
        private System.Windows.Forms.Button sortTypeButton;
        private System.Windows.Forms.Button sortChapterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem workshopParticipantsToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button partSearchButton;
    }
}