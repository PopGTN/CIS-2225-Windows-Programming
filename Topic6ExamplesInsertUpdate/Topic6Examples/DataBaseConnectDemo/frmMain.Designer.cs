namespace DataBaseConnectDemo
{
    partial class frmMain
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonSelector = new System.Windows.Forms.ComboBox();
            this.lblPersonDisplay = new System.Windows.Forms.Label();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(161, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 167);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(161, 205);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.ReadOnly = true;
            this.txtPersonId.Size = new System.Drawing.Size(100, 20);
            this.txtPersonId.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(34, 135);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(34, 170);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(34, 212);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(57, 13);
            this.lblPersonId.TabIndex = 5;
            this.lblPersonId.Text = "Person ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show Single Record from Database";
            // 
            // cbPersonSelector
            // 
            this.cbPersonSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonSelector.FormattingEnabled = true;
            this.cbPersonSelector.Location = new System.Drawing.Point(161, 88);
            this.cbPersonSelector.Name = "cbPersonSelector";
            this.cbPersonSelector.Size = new System.Drawing.Size(75, 21);
            this.cbPersonSelector.TabIndex = 7;
            this.cbPersonSelector.SelectedIndexChanged += new System.EventHandler(this.cbPersonSelector_SelectedIndexChanged);
            // 
            // lblPersonDisplay
            // 
            this.lblPersonDisplay.AutoSize = true;
            this.lblPersonDisplay.Location = new System.Drawing.Point(34, 91);
            this.lblPersonDisplay.Name = "lblPersonDisplay";
            this.lblPersonDisplay.Size = new System.Drawing.Size(76, 13);
            this.lblPersonDisplay.TabIndex = 8;
            this.lblPersonDisplay.Text = "Select Person:";
            // 
            // msOptions
            // 
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msOptions.Location = new System.Drawing.Point(0, 0);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(338, 24);
            this.msOptions.TabIndex = 9;
            this.msOptions.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewPersonToolStripMenuItem,
            this.updatePersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewPersonToolStripMenuItem
            // 
            this.createNewPersonToolStripMenuItem.Name = "createNewPersonToolStripMenuItem";
            this.createNewPersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewPersonToolStripMenuItem.Text = "Create New Person";
            this.createNewPersonToolStripMenuItem.Click += new System.EventHandler(this.createNewPersonToolStripMenuItem_Click);
            // 
            // updatePersonToolStripMenuItem
            // 
            this.updatePersonToolStripMenuItem.Name = "updatePersonToolStripMenuItem";
            this.updatePersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updatePersonToolStripMenuItem.Text = "Update Person";
            this.updatePersonToolStripMenuItem.Click += new System.EventHandler(this.updatePersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 277);
            this.Controls.Add(this.lblPersonDisplay);
            this.Controls.Add(this.cbPersonSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.msOptions);
            this.MainMenuStrip = this.msOptions;
            this.Name = "frmMain";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonSelector;
        private System.Windows.Forms.Label lblPersonDisplay;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
    }
}

