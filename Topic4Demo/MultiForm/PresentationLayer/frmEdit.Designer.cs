
namespace MultiForm.PresentationLayer
{
    partial class frmEdit
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
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEyeColor = new System.Windows.Forms.TextBox();
            this.txtHairColor = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbPeople = new System.Windows.Forms.ComboBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.btnPassObject = new System.Windows.Forms.Button();
            this.btnPassParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(155, 191);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(55, 13);
            this.lblEyeColor.TabIndex = 17;
            this.lblEyeColor.Text = "Eye Color:";
            // 
            // lblHairColor
            // 
            this.lblHairColor.AutoSize = true;
            this.lblHairColor.Location = new System.Drawing.Point(155, 165);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(56, 13);
            this.lblHairColor.TabIndex = 16;
            this.lblHairColor.Text = "Hair Color:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(155, 139);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 15;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(155, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // txtEyeColor
            // 
            this.txtEyeColor.Location = new System.Drawing.Point(220, 191);
            this.txtEyeColor.Name = "txtEyeColor";
            this.txtEyeColor.Size = new System.Drawing.Size(100, 20);
            this.txtEyeColor.TabIndex = 13;
            // 
            // txtHairColor
            // 
            this.txtHairColor.Location = new System.Drawing.Point(220, 165);
            this.txtHairColor.Name = "txtHairColor";
            this.txtHairColor.Size = new System.Drawing.Size(100, 20);
            this.txtHairColor.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(220, 139);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(220, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // cmbPeople
            // 
            this.cmbPeople.FormattingEnabled = true;
            this.cmbPeople.Location = new System.Drawing.Point(220, 48);
            this.cmbPeople.Name = "cmbPeople";
            this.cmbPeople.Size = new System.Drawing.Size(100, 21);
            this.cmbPeople.TabIndex = 18;
            this.cmbPeople.SelectedIndexChanged += new System.EventHandler(this.cmbPeople_SelectedIndexChanged);
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(155, 48);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(43, 13);
            this.lblPeople.TabIndex = 19;
            this.lblPeople.Text = "People:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(155, 217);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country:";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(220, 217);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(100, 21);
            this.cmbCountries.TabIndex = 21;
            // 
            // btnPassObject
            // 
            this.btnPassObject.Location = new System.Drawing.Point(158, 299);
            this.btnPassObject.Name = "btnPassObject";
            this.btnPassObject.Size = new System.Drawing.Size(75, 23);
            this.btnPassObject.TabIndex = 23;
            this.btnPassObject.Text = "Pass Object";
            this.btnPassObject.UseVisualStyleBackColor = true;
            this.btnPassObject.Click += new System.EventHandler(this.btnPassObject_Click);
            // 
            // btnPassParams
            // 
            this.btnPassParams.Location = new System.Drawing.Point(297, 299);
            this.btnPassParams.Name = "btnPassParams";
            this.btnPassParams.Size = new System.Drawing.Size(89, 23);
            this.btnPassParams.TabIndex = 24;
            this.btnPassParams.Text = "Pass Params";
            this.btnPassParams.UseVisualStyleBackColor = true;
            this.btnPassParams.Click += new System.EventHandler(this.btnPassParams_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 390);
            this.Controls.Add(this.btnPassParams);
            this.Controls.Add(this.btnPassObject);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.cmbPeople);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.lblHairColor);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEyeColor);
            this.Controls.Add(this.txtHairColor);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "frmEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEyeColor;
        private System.Windows.Forms.TextBox txtHairColor;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Button btnPassObject;
        private System.Windows.Forms.Button btnPassParams;
    }
}