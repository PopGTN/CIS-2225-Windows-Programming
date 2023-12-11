
namespace CIS2225_Assignment6
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblSelector = new System.Windows.Forms.Label();
            this.ddlGuestsSelector = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLastVisitDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblGuestId = new System.Windows.Forms.Label();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpLastVisitDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFName.Location = new System.Drawing.Point(143, 165);
            this.txtFName.MaxLength = 25;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(114, 20);
            this.txtFName.TabIndex = 28;
            // 
            // lblFName
            // 
            this.lblFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(63, 168);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 20;
            this.lblFName.Text = "First Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhone.Location = new System.Drawing.Point(494, 164);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 20);
            this.txtPhone.TabIndex = 29;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(364, 171);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "Phone:";
            // 
            // txtZip
            // 
            this.txtZip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZip.Location = new System.Drawing.Point(494, 139);
            this.txtZip.MaxLength = 10;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(125, 20);
            this.txtZip.TabIndex = 30;
            // 
            // lblZip
            // 
            this.lblZip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(364, 146);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 22;
            this.lblZip.Text = "Zip:";
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtState.Location = new System.Drawing.Point(143, 243);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(114, 20);
            this.txtState.TabIndex = 31;
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(63, 246);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 23;
            this.lblState.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCity.Location = new System.Drawing.Point(143, 217);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(114, 20);
            this.txtCity.TabIndex = 32;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(63, 220);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStreet.Location = new System.Drawing.Point(143, 191);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(114, 20);
            this.txtStreet.TabIndex = 50;
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(63, 194);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 25;
            this.lblStreet.Text = "Street:";
            // 
            // txtLName
            // 
            this.txtLName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLName.Location = new System.Drawing.Point(143, 139);
            this.txtLName.MaxLength = 15;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(114, 20);
            this.txtLName.TabIndex = 34;
            // 
            // lblLName
            // 
            this.lblLName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(63, 142);
            this.lblLName.Name = "lblLName";
            this.lblLName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 26;
            this.lblLName.Text = "Last Name:";
            // 
            // lblSelector
            // 
            this.lblSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSelector.AutoSize = true;
            this.lblSelector.Location = new System.Drawing.Point(186, 65);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(71, 13);
            this.lblSelector.TabIndex = 27;
            this.lblSelector.Text = "Select Guest:";
            // 
            // ddlGuestsSelector
            // 
            this.ddlGuestsSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlGuestsSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGuestsSelector.FormattingEnabled = true;
            this.ddlGuestsSelector.Location = new System.Drawing.Point(293, 62);
            this.ddlGuestsSelector.Name = "ddlGuestsSelector";
            this.ddlGuestsSelector.Size = new System.Drawing.Size(128, 21);
            this.ddlGuestsSelector.TabIndex = 19;
            this.ddlGuestsSelector.SelectedIndexChanged += new System.EventHandler(this.ddlGuestsSelector_SelectedIndexChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(364, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(494, 191);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // lblLastVisitDate
            // 
            this.lblLastVisitDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastVisitDate.AutoSize = true;
            this.lblLastVisitDate.Location = new System.Drawing.Point(364, 220);
            this.lblLastVisitDate.Name = "lblLastVisitDate";
            this.lblLastVisitDate.Size = new System.Drawing.Size(78, 13);
            this.lblLastVisitDate.TabIndex = 21;
            this.lblLastVisitDate.Text = "Last Visit Date:";
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(364, 246);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 13);
            this.lblRoom.TabIndex = 21;
            this.lblRoom.Text = "Room:";
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoom.Location = new System.Drawing.Point(494, 243);
            this.txtRoom.MaxLength = 50;
            this.txtRoom.MinimumSize = new System.Drawing.Size(125, 20);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(125, 20);
            this.txtRoom.TabIndex = 29;
            // 
            // lblGuestId
            // 
            this.lblGuestId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGuestId.AutoSize = true;
            this.lblGuestId.Location = new System.Drawing.Point(186, 331);
            this.lblGuestId.Name = "lblGuestId";
            this.lblGuestId.Size = new System.Drawing.Size(46, 13);
            this.lblGuestId.TabIndex = 36;
            this.lblGuestId.Text = "GuestID";
            // 
            // txtGuestId
            // 
            this.txtGuestId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGuestId.Location = new System.Drawing.Point(293, 328);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.ReadOnly = true;
            this.txtGuestId.Size = new System.Drawing.Size(128, 20);
            this.txtGuestId.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(66, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Location = new System.Drawing.Point(293, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(494, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpLastVisitDate
            // 
            this.dtpLastVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastVisitDate.Location = new System.Drawing.Point(494, 217);
            this.dtpLastVisitDate.Name = "dtpLastVisitDate";
            this.dtpLastVisitDate.Size = new System.Drawing.Size(125, 20);
            this.dtpLastVisitDate.TabIndex = 38;
            this.dtpLastVisitDate.Value = new System.DateTime(2023, 12, 11, 16, 34, 22, 0);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 473);
            this.Controls.Add(this.dtpLastVisitDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGuestId);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtGuestId);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblLastVisitDate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblSelector);
            this.Controls.Add(this.ddlGuestsSelector);
            this.Name = "frmMain";
            this.Text = "SOMETHING";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.ComboBox ddlGuestsSelector;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLastVisitDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblGuestId;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpLastVisitDate;
    }
}

