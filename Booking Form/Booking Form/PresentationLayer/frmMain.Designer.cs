
namespace Booking_Form
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpBandType = new System.Windows.Forms.GroupBox();
            this.rdoClassical = new System.Windows.Forms.RadioButton();
            this.rdoPop = new System.Windows.Forms.RadioButton();
            this.rdoRock = new System.Windows.Forms.RadioButton();
            this.lblEventSize = new System.Windows.Forms.Label();
            this.ddlEventSize = new System.Windows.Forms.ComboBox();
            this.mnuMain.SuspendLayout();
            this.grpBandType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(0, 24);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(495, 53);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Book Your Event";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVenue
            // 
            this.lblVenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(48, 95);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(112, 20);
            this.lblVenue.TabIndex = 1;
            this.lblVenue.Text = "Venue Name";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(495, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceBookingToolStripMenuItem,
            this.processBookingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // priceBookingToolStripMenuItem
            // 
            this.priceBookingToolStripMenuItem.Name = "priceBookingToolStripMenuItem";
            this.priceBookingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.priceBookingToolStripMenuItem.Text = "Price Booking";
            this.priceBookingToolStripMenuItem.Click += new System.EventHandler(this.priceBookingToolStripMenuItem_Click);
            // 
            // processBookingToolStripMenuItem
            // 
            this.processBookingToolStripMenuItem.Name = "processBookingToolStripMenuItem";
            this.processBookingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.processBookingToolStripMenuItem.Text = "Process Booking";
            this.processBookingToolStripMenuItem.Click += new System.EventHandler(this.processBookingToolStripMenuItem_Click);
            // 
            // lblFName
            // 
            this.lblFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(48, 128);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(96, 20);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(48, 163);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(95, 20);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name";
            // 
            // txtVenue
            // 
            this.txtVenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenue.Location = new System.Drawing.Point(241, 95);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(200, 20);
            this.txtVenue.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFName.Location = new System.Drawing.Point(241, 128);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 20);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLName.Location = new System.Drawing.Point(241, 163);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(241, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(48, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // grpBandType
            // 
            this.grpBandType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBandType.Controls.Add(this.rdoClassical);
            this.grpBandType.Controls.Add(this.rdoPop);
            this.grpBandType.Controls.Add(this.rdoRock);
            this.grpBandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBandType.Location = new System.Drawing.Point(241, 257);
            this.grpBandType.Name = "grpBandType";
            this.grpBandType.Size = new System.Drawing.Size(200, 139);
            this.grpBandType.TabIndex = 10;
            this.grpBandType.TabStop = false;
            this.grpBandType.Text = "Band Type";
            // 
            // rdoClassical
            // 
            this.rdoClassical.Location = new System.Drawing.Point(6, 94);
            this.rdoClassical.Name = "rdoClassical";
            this.rdoClassical.Size = new System.Drawing.Size(188, 27);
            this.rdoClassical.TabIndex = 2;
            this.rdoClassical.TabStop = true;
            this.rdoClassical.Text = "Classical: $1,200.00";
            this.rdoClassical.UseVisualStyleBackColor = true;
            // 
            // rdoPop
            // 
            this.rdoPop.Location = new System.Drawing.Point(6, 61);
            this.rdoPop.Name = "rdoPop";
            this.rdoPop.Size = new System.Drawing.Size(155, 24);
            this.rdoPop.TabIndex = 1;
            this.rdoPop.TabStop = true;
            this.rdoPop.Text = "Pop: $2,000.00";
            this.rdoPop.UseVisualStyleBackColor = true;
            // 
            // rdoRock
            // 
            this.rdoRock.Location = new System.Drawing.Point(6, 29);
            this.rdoRock.Name = "rdoRock";
            this.rdoRock.Size = new System.Drawing.Size(131, 24);
            this.rdoRock.TabIndex = 0;
            this.rdoRock.TabStop = true;
            this.rdoRock.Text = "Rock: $1500";
            this.rdoRock.UseVisualStyleBackColor = true;
            // 
            // lblEventSize
            // 
            this.lblEventSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventSize.AutoSize = true;
            this.lblEventSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventSize.Location = new System.Drawing.Point(48, 257);
            this.lblEventSize.Name = "lblEventSize";
            this.lblEventSize.Size = new System.Drawing.Size(95, 20);
            this.lblEventSize.TabIndex = 11;
            this.lblEventSize.Text = "Event Size";
            // 
            // ddlEventSize
            // 
            this.ddlEventSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEventSize.FormattingEnabled = true;
            this.ddlEventSize.Items.AddRange(new object[] {
            "300 and under",
            "301 to 600 spectators",
            "601 to 1200 spectators"});
            this.ddlEventSize.Location = new System.Drawing.Point(48, 289);
            this.ddlEventSize.Name = "ddlEventSize";
            this.ddlEventSize.Size = new System.Drawing.Size(174, 21);
            this.ddlEventSize.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 486);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.ddlEventSize);
            this.Controls.Add(this.lblEventSize);
            this.Controls.Add(this.grpBandType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(511, 525);
            this.Name = "frmMain";
            this.Text = "Booking Form";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpBandType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpBandType;
        private System.Windows.Forms.RadioButton rdoClassical;
        private System.Windows.Forms.RadioButton rdoPop;
        private System.Windows.Forms.RadioButton rdoRock;
        private System.Windows.Forms.Label lblEventSize;
        private System.Windows.Forms.ComboBox ddlEventSize;
        private System.Windows.Forms.ToolStripMenuItem priceBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processBookingToolStripMenuItem;
    }
}

