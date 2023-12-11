
namespace Calculation_pay
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
            this.ddlEmployeeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlEmployeeType
            // 
            this.ddlEmployeeType.AutoCompleteCustomSource.AddRange(new string[] {
            "Salary",
            "Hourly"});
            this.ddlEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmployeeType.FormattingEnabled = true;
            this.ddlEmployeeType.Items.AddRange(new object[] {
            "Salary",
            "Hourly"});
            this.ddlEmployeeType.Location = new System.Drawing.Point(15, 25);
            this.ddlEmployeeType.Name = "ddlEmployeeType";
            this.ddlEmployeeType.Size = new System.Drawing.Size(121, 21);
            this.ddlEmployeeType.TabIndex = 1;
            this.ddlEmployeeType.SelectedIndexChanged += new System.EventHandler(this.ddlEmployeeType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Employee:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(163, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(15, 125);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(121, 20);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Employee ID:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(15, 177);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(121, 20);
            this.txtMoney.TabIndex = 10;
            this.txtMoney.Visible = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(12, 161);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(86, 13);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "PlaceHolderText";
            this.lblMoney.Visible = false;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(163, 161);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(124, 13);
            this.lblHours.TabIndex = 9;
            this.lblHours.Text = "Hours worked this week:";
            this.lblHours.Visible = false;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(166, 177);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(121, 20);
            this.txtHours.TabIndex = 11;
            this.txtHours.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(109, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(314, 411);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlEmployeeType);
            this.Name = "frmMain";
            this.Text = "Calculate Pay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlEmployeeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnSubmit;
    }
}

