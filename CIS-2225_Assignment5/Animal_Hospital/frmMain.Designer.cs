namespace Animal_Hospital
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
            this.tcAnimal = new System.Windows.Forms.TabControl();
            this.tpWelcome = new System.Windows.Forms.TabPage();
            this.lblPatients = new System.Windows.Forms.Label();
            this.rtxtPatients = new System.Windows.Forms.RichTextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tpDog = new System.Windows.Forms.TabPage();
            this.txtDogColor = new System.Windows.Forms.TextBox();
            this.txtDogNumLegs = new System.Windows.Forms.TextBox();
            this.txtDogVisitReason = new System.Windows.Forms.TextBox();
            this.dtpDogVisit = new System.Windows.Forms.DateTimePicker();
            this.cbDogType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDogType = new System.Windows.Forms.Label();
            this.lblDateVisit = new System.Windows.Forms.Label();
            this.lblVisitReason = new System.Windows.Forms.Label();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpCat = new System.Windows.Forms.TabPage();
            this.tpHorse = new System.Windows.Forms.TabPage();
            this.btnAddDog = new System.Windows.Forms.Button();
            this.tcAnimal.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpDog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAnimal
            // 
            this.tcAnimal.Controls.Add(this.tpWelcome);
            this.tcAnimal.Controls.Add(this.tpDog);
            this.tcAnimal.Controls.Add(this.tpCat);
            this.tcAnimal.Controls.Add(this.tpHorse);
            this.tcAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAnimal.Location = new System.Drawing.Point(0, 0);
            this.tcAnimal.Name = "tcAnimal";
            this.tcAnimal.SelectedIndex = 0;
            this.tcAnimal.Size = new System.Drawing.Size(441, 296);
            this.tcAnimal.TabIndex = 0;
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.lblPatients);
            this.tpWelcome.Controls.Add(this.rtxtPatients);
            this.tpWelcome.Controls.Add(this.txtDisplay);
            this.tpWelcome.Location = new System.Drawing.Point(4, 22);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tpWelcome.Size = new System.Drawing.Size(433, 270);
            this.tpWelcome.TabIndex = 0;
            this.tpWelcome.Text = "Home";
            this.tpWelcome.UseVisualStyleBackColor = true;
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Location = new System.Drawing.Point(8, 129);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(85, 13);
            this.lblPatients.TabIndex = 2;
            this.lblPatients.Text = "Current Patients:";
            // 
            // rtxtPatients
            // 
            this.rtxtPatients.Location = new System.Drawing.Point(8, 145);
            this.rtxtPatients.Name = "rtxtPatients";
            this.rtxtPatients.Size = new System.Drawing.Size(417, 104);
            this.rtxtPatients.TabIndex = 1;
            this.rtxtPatients.Text = "";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(8, 54);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(417, 22);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "CIS Animal Hospital";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpDog
            // 
            this.tpDog.Controls.Add(this.btnAddDog);
            this.tpDog.Controls.Add(this.txtDogColor);
            this.tpDog.Controls.Add(this.txtDogNumLegs);
            this.tpDog.Controls.Add(this.txtDogVisitReason);
            this.tpDog.Controls.Add(this.dtpDogVisit);
            this.tpDog.Controls.Add(this.cbDogType);
            this.tpDog.Controls.Add(this.label3);
            this.tpDog.Controls.Add(this.label1);
            this.tpDog.Controls.Add(this.lblDogType);
            this.tpDog.Controls.Add(this.lblDateVisit);
            this.tpDog.Controls.Add(this.lblVisitReason);
            this.tpDog.Controls.Add(this.txtDogName);
            this.tpDog.Controls.Add(this.label2);
            this.tpDog.Location = new System.Drawing.Point(4, 22);
            this.tpDog.Name = "tpDog";
            this.tpDog.Padding = new System.Windows.Forms.Padding(3);
            this.tpDog.Size = new System.Drawing.Size(433, 270);
            this.tpDog.TabIndex = 1;
            this.tpDog.Text = "Dog";
            this.tpDog.UseVisualStyleBackColor = true;
            // 
            // txtDogColor
            // 
            this.txtDogColor.Location = new System.Drawing.Point(135, 105);
            this.txtDogColor.Name = "txtDogColor";
            this.txtDogColor.Size = new System.Drawing.Size(100, 20);
            this.txtDogColor.TabIndex = 11;
            // 
            // txtDogNumLegs
            // 
            this.txtDogNumLegs.Location = new System.Drawing.Point(135, 131);
            this.txtDogNumLegs.Name = "txtDogNumLegs";
            this.txtDogNumLegs.Size = new System.Drawing.Size(100, 20);
            this.txtDogNumLegs.TabIndex = 10;
            // 
            // txtDogVisitReason
            // 
            this.txtDogVisitReason.Location = new System.Drawing.Point(135, 157);
            this.txtDogVisitReason.Name = "txtDogVisitReason";
            this.txtDogVisitReason.Size = new System.Drawing.Size(100, 20);
            this.txtDogVisitReason.TabIndex = 9;
            // 
            // dtpDogVisit
            // 
            this.dtpDogVisit.Location = new System.Drawing.Point(135, 183);
            this.dtpDogVisit.Name = "dtpDogVisit";
            this.dtpDogVisit.Size = new System.Drawing.Size(200, 20);
            this.dtpDogVisit.TabIndex = 8;
            // 
            // cbDogType
            // 
            this.cbDogType.FormattingEnabled = true;
            this.cbDogType.Location = new System.Drawing.Point(135, 78);
            this.cbDogType.Name = "cbDogType";
            this.cbDogType.Size = new System.Drawing.Size(121, 21);
            this.cbDogType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dog Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Legs:";
            // 
            // lblDogType
            // 
            this.lblDogType.AutoSize = true;
            this.lblDogType.Location = new System.Drawing.Point(12, 81);
            this.lblDogType.Name = "lblDogType";
            this.lblDogType.Size = new System.Drawing.Size(57, 13);
            this.lblDogType.TabIndex = 4;
            this.lblDogType.Text = "Dog Type:";
            // 
            // lblDateVisit
            // 
            this.lblDateVisit.AutoSize = true;
            this.lblDateVisit.Location = new System.Drawing.Point(13, 190);
            this.lblDateVisit.Name = "lblDateVisit";
            this.lblDateVisit.Size = new System.Drawing.Size(64, 13);
            this.lblDateVisit.TabIndex = 3;
            this.lblDateVisit.Text = "Date of Visit";
            // 
            // lblVisitReason
            // 
            this.lblVisitReason.AutoSize = true;
            this.lblVisitReason.Location = new System.Drawing.Point(12, 160);
            this.lblVisitReason.Name = "lblVisitReason";
            this.lblVisitReason.Size = new System.Drawing.Size(84, 13);
            this.lblVisitReason.TabIndex = 2;
            this.lblVisitReason.Text = "Reason for Visit:";
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(135, 52);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(123, 20);
            this.txtDogName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dog Name:";
            // 
            // tpCat
            // 
            this.tpCat.Location = new System.Drawing.Point(4, 22);
            this.tpCat.Name = "tpCat";
            this.tpCat.Size = new System.Drawing.Size(433, 270);
            this.tpCat.TabIndex = 2;
            this.tpCat.Text = "Cat";
            this.tpCat.UseVisualStyleBackColor = true;
            // 
            // tpHorse
            // 
            this.tpHorse.Location = new System.Drawing.Point(4, 22);
            this.tpHorse.Name = "tpHorse";
            this.tpHorse.Size = new System.Drawing.Size(433, 270);
            this.tpHorse.TabIndex = 3;
            this.tpHorse.Text = "Horse";
            this.tpHorse.UseVisualStyleBackColor = true;
            // 
            // btnAddDog
            // 
            this.btnAddDog.Location = new System.Drawing.Point(114, 223);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(75, 23);
            this.btnAddDog.TabIndex = 12;
            this.btnAddDog.Text = "Add Dog";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 296);
            this.Controls.Add(this.tcAnimal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Animal Hospital";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcAnimal.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpWelcome.PerformLayout();
            this.tpDog.ResumeLayout(false);
            this.tpDog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAnimal;
        private System.Windows.Forms.TabPage tpWelcome;
        private System.Windows.Forms.TabPage tpDog;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.RichTextBox rtxtPatients;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDogType;
        private System.Windows.Forms.Label lblDateVisit;
        private System.Windows.Forms.Label lblVisitReason;
        private System.Windows.Forms.TextBox txtDogColor;
        private System.Windows.Forms.TextBox txtDogNumLegs;
        private System.Windows.Forms.TextBox txtDogVisitReason;
        private System.Windows.Forms.DateTimePicker dtpDogVisit;
        private System.Windows.Forms.ComboBox cbDogType;
        private System.Windows.Forms.TabPage tpCat;
        private System.Windows.Forms.TabPage tpHorse;
        private System.Windows.Forms.Button btnAddDog;
    }
}

