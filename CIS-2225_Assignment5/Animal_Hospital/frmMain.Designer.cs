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
            this.btnAddDog = new System.Windows.Forms.Button();
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
            this.btnAddCat = new System.Windows.Forms.Button();
            this.txtCatColor = new System.Windows.Forms.TextBox();
            this.txtCatLegs = new System.Windows.Forms.TextBox();
            this.txtCatReason = new System.Windows.Forms.TextBox();
            this.dtpCat = new System.Windows.Forms.DateTimePicker();
            this.cbCatType = new System.Windows.Forms.ComboBox();
            this.lblCatColor = new System.Windows.Forms.Label();
            this.lblCatLegs = new System.Windows.Forms.Label();
            this.lblCatType = new System.Windows.Forms.Label();
            this.lblCatDate = new System.Windows.Forms.Label();
            this.lblCatReason = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.tpHorse = new System.Windows.Forms.TabPage();
            this.btnAddHorse = new System.Windows.Forms.Button();
            this.txtHorseColor = new System.Windows.Forms.TextBox();
            this.txtHorseLegs = new System.Windows.Forms.TextBox();
            this.txtHorseReason = new System.Windows.Forms.TextBox();
            this.dtpHorse = new System.Windows.Forms.DateTimePicker();
            this.cbHorseType = new System.Windows.Forms.ComboBox();
            this.lblHorseColor = new System.Windows.Forms.Label();
            this.lblHorseLegs = new System.Windows.Forms.Label();
            this.lblHorseType = new System.Windows.Forms.Label();
            this.lblHorseDate = new System.Windows.Forms.Label();
            this.lblHorseReason = new System.Windows.Forms.Label();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.lblHorseName = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tcAnimal.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpDog.SuspendLayout();
            this.tpCat.SuspendLayout();
            this.tpHorse.SuspendLayout();
            this.Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAnimal
            // 
            this.tcAnimal.Controls.Add(this.tpWelcome);
            this.tcAnimal.Controls.Add(this.tpDog);
            this.tcAnimal.Controls.Add(this.tpCat);
            this.tcAnimal.Controls.Add(this.tpHorse);
            this.tcAnimal.Controls.Add(this.Test);
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
            this.lblPatients.TabIndex = 1;
            this.lblPatients.Text = "Current Patients:";
            // 
            // rtxtPatients
            // 
            this.rtxtPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtPatients.Location = new System.Drawing.Point(8, 145);
            this.rtxtPatients.Name = "rtxtPatients";
            this.rtxtPatients.Size = new System.Drawing.Size(417, 104);
            this.rtxtPatients.TabIndex = 2;
            this.rtxtPatients.Text = "";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // btnAddDog
            // 
            this.btnAddDog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddDog.Location = new System.Drawing.Point(157, 209);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(75, 23);
            this.btnAddDog.TabIndex = 25;
            this.btnAddDog.Text = "Add Dog";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // txtDogColor
            // 
            this.txtDogColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDogColor.Location = new System.Drawing.Point(178, 91);
            this.txtDogColor.Name = "txtDogColor";
            this.txtDogColor.Size = new System.Drawing.Size(100, 20);
            this.txtDogColor.TabIndex = 18;
            // 
            // txtDogNumLegs
            // 
            this.txtDogNumLegs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDogNumLegs.Location = new System.Drawing.Point(178, 117);
            this.txtDogNumLegs.Name = "txtDogNumLegs";
            this.txtDogNumLegs.Size = new System.Drawing.Size(100, 20);
            this.txtDogNumLegs.TabIndex = 20;
            // 
            // txtDogVisitReason
            // 
            this.txtDogVisitReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDogVisitReason.Location = new System.Drawing.Point(178, 143);
            this.txtDogVisitReason.Name = "txtDogVisitReason";
            this.txtDogVisitReason.Size = new System.Drawing.Size(100, 20);
            this.txtDogVisitReason.TabIndex = 22;
            // 
            // dtpDogVisit
            // 
            this.dtpDogVisit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDogVisit.Location = new System.Drawing.Point(178, 169);
            this.dtpDogVisit.Name = "dtpDogVisit";
            this.dtpDogVisit.Size = new System.Drawing.Size(200, 20);
            this.dtpDogVisit.TabIndex = 24;
            // 
            // cbDogType
            // 
            this.cbDogType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDogType.FormattingEnabled = true;
            this.cbDogType.Location = new System.Drawing.Point(178, 64);
            this.cbDogType.Name = "cbDogType";
            this.cbDogType.Size = new System.Drawing.Size(121, 21);
            this.cbDogType.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dog Color:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number of Legs:";
            // 
            // lblDogType
            // 
            this.lblDogType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDogType.AutoSize = true;
            this.lblDogType.Location = new System.Drawing.Point(55, 67);
            this.lblDogType.Name = "lblDogType";
            this.lblDogType.Size = new System.Drawing.Size(57, 13);
            this.lblDogType.TabIndex = 15;
            this.lblDogType.Text = "Dog Type:";
            // 
            // lblDateVisit
            // 
            this.lblDateVisit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateVisit.AutoSize = true;
            this.lblDateVisit.Location = new System.Drawing.Point(56, 176);
            this.lblDateVisit.Name = "lblDateVisit";
            this.lblDateVisit.Size = new System.Drawing.Size(64, 13);
            this.lblDateVisit.TabIndex = 23;
            this.lblDateVisit.Text = "Date of Visit";
            // 
            // lblVisitReason
            // 
            this.lblVisitReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVisitReason.AutoSize = true;
            this.lblVisitReason.Location = new System.Drawing.Point(55, 146);
            this.lblVisitReason.Name = "lblVisitReason";
            this.lblVisitReason.Size = new System.Drawing.Size(84, 13);
            this.lblVisitReason.TabIndex = 21;
            this.lblVisitReason.Text = "Reason for Visit:";
            // 
            // txtDogName
            // 
            this.txtDogName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDogName.Location = new System.Drawing.Point(178, 38);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(123, 20);
            this.txtDogName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dog Name:";
            // 
            // tpCat
            // 
            this.tpCat.Controls.Add(this.btnAddCat);
            this.tpCat.Controls.Add(this.txtCatColor);
            this.tpCat.Controls.Add(this.txtCatLegs);
            this.tpCat.Controls.Add(this.txtCatReason);
            this.tpCat.Controls.Add(this.dtpCat);
            this.tpCat.Controls.Add(this.cbCatType);
            this.tpCat.Controls.Add(this.lblCatColor);
            this.tpCat.Controls.Add(this.lblCatLegs);
            this.tpCat.Controls.Add(this.lblCatType);
            this.tpCat.Controls.Add(this.lblCatDate);
            this.tpCat.Controls.Add(this.lblCatReason);
            this.tpCat.Controls.Add(this.txtCatName);
            this.tpCat.Controls.Add(this.lblCatName);
            this.tpCat.Location = new System.Drawing.Point(4, 22);
            this.tpCat.Name = "tpCat";
            this.tpCat.Size = new System.Drawing.Size(433, 270);
            this.tpCat.TabIndex = 2;
            this.tpCat.Text = "Cat";
            this.tpCat.UseVisualStyleBackColor = true;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCat.Location = new System.Drawing.Point(157, 209);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddCat.TabIndex = 25;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // txtCatColor
            // 
            this.txtCatColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCatColor.Location = new System.Drawing.Point(178, 91);
            this.txtCatColor.Name = "txtCatColor";
            this.txtCatColor.Size = new System.Drawing.Size(100, 20);
            this.txtCatColor.TabIndex = 18;
            // 
            // txtCatLegs
            // 
            this.txtCatLegs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCatLegs.Location = new System.Drawing.Point(178, 117);
            this.txtCatLegs.Name = "txtCatLegs";
            this.txtCatLegs.Size = new System.Drawing.Size(100, 20);
            this.txtCatLegs.TabIndex = 20;
            // 
            // txtCatReason
            // 
            this.txtCatReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCatReason.Location = new System.Drawing.Point(178, 143);
            this.txtCatReason.Name = "txtCatReason";
            this.txtCatReason.Size = new System.Drawing.Size(100, 20);
            this.txtCatReason.TabIndex = 22;
            // 
            // dtpCat
            // 
            this.dtpCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCat.Location = new System.Drawing.Point(178, 169);
            this.dtpCat.Name = "dtpCat";
            this.dtpCat.Size = new System.Drawing.Size(200, 20);
            this.dtpCat.TabIndex = 24;
            // 
            // cbCatType
            // 
            this.cbCatType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCatType.FormattingEnabled = true;
            this.cbCatType.Location = new System.Drawing.Point(178, 64);
            this.cbCatType.Name = "cbCatType";
            this.cbCatType.Size = new System.Drawing.Size(121, 21);
            this.cbCatType.TabIndex = 16;
            // 
            // lblCatColor
            // 
            this.lblCatColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatColor.AutoSize = true;
            this.lblCatColor.Location = new System.Drawing.Point(56, 94);
            this.lblCatColor.Name = "lblCatColor";
            this.lblCatColor.Size = new System.Drawing.Size(53, 13);
            this.lblCatColor.TabIndex = 17;
            this.lblCatColor.Text = "Cat Color:";
            // 
            // lblCatLegs
            // 
            this.lblCatLegs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatLegs.AutoSize = true;
            this.lblCatLegs.Location = new System.Drawing.Point(56, 120);
            this.lblCatLegs.Name = "lblCatLegs";
            this.lblCatLegs.Size = new System.Drawing.Size(85, 13);
            this.lblCatLegs.TabIndex = 19;
            this.lblCatLegs.Text = "Number of Legs:";
            // 
            // lblCatType
            // 
            this.lblCatType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatType.AutoSize = true;
            this.lblCatType.Location = new System.Drawing.Point(55, 67);
            this.lblCatType.Name = "lblCatType";
            this.lblCatType.Size = new System.Drawing.Size(53, 13);
            this.lblCatType.TabIndex = 15;
            this.lblCatType.Text = "Cat Type:";
            // 
            // lblCatDate
            // 
            this.lblCatDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatDate.AutoSize = true;
            this.lblCatDate.Location = new System.Drawing.Point(56, 176);
            this.lblCatDate.Name = "lblCatDate";
            this.lblCatDate.Size = new System.Drawing.Size(64, 13);
            this.lblCatDate.TabIndex = 23;
            this.lblCatDate.Text = "Date of Visit";
            // 
            // lblCatReason
            // 
            this.lblCatReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatReason.AutoSize = true;
            this.lblCatReason.Location = new System.Drawing.Point(55, 146);
            this.lblCatReason.Name = "lblCatReason";
            this.lblCatReason.Size = new System.Drawing.Size(84, 13);
            this.lblCatReason.TabIndex = 21;
            this.lblCatReason.Text = "Reason for Visit:";
            // 
            // txtCatName
            // 
            this.txtCatName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCatName.Location = new System.Drawing.Point(178, 38);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(123, 20);
            this.txtCatName.TabIndex = 14;
            // 
            // lblCatName
            // 
            this.lblCatName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(55, 38);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(57, 13);
            this.lblCatName.TabIndex = 13;
            this.lblCatName.Text = "Cat Name:";
            // 
            // tpHorse
            // 
            this.tpHorse.Controls.Add(this.btnAddHorse);
            this.tpHorse.Controls.Add(this.txtHorseColor);
            this.tpHorse.Controls.Add(this.txtHorseLegs);
            this.tpHorse.Controls.Add(this.txtHorseReason);
            this.tpHorse.Controls.Add(this.dtpHorse);
            this.tpHorse.Controls.Add(this.cbHorseType);
            this.tpHorse.Controls.Add(this.lblHorseColor);
            this.tpHorse.Controls.Add(this.lblHorseLegs);
            this.tpHorse.Controls.Add(this.lblHorseType);
            this.tpHorse.Controls.Add(this.lblHorseDate);
            this.tpHorse.Controls.Add(this.lblHorseReason);
            this.tpHorse.Controls.Add(this.txtHorseName);
            this.tpHorse.Controls.Add(this.lblHorseName);
            this.tpHorse.Location = new System.Drawing.Point(4, 22);
            this.tpHorse.Name = "tpHorse";
            this.tpHorse.Size = new System.Drawing.Size(433, 270);
            this.tpHorse.TabIndex = 3;
            this.tpHorse.Text = "Horse";
            this.tpHorse.UseVisualStyleBackColor = true;
            // 
            // btnAddHorse
            // 
            this.btnAddHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddHorse.Location = new System.Drawing.Point(157, 209);
            this.btnAddHorse.Name = "btnAddHorse";
            this.btnAddHorse.Size = new System.Drawing.Size(75, 23);
            this.btnAddHorse.TabIndex = 25;
            this.btnAddHorse.Text = "Add Horse";
            this.btnAddHorse.UseVisualStyleBackColor = true;
            this.btnAddHorse.Click += new System.EventHandler(this.btnAddHorse_Click);
            // 
            // txtHorseColor
            // 
            this.txtHorseColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorseColor.Location = new System.Drawing.Point(178, 91);
            this.txtHorseColor.Name = "txtHorseColor";
            this.txtHorseColor.Size = new System.Drawing.Size(100, 20);
            this.txtHorseColor.TabIndex = 18;
            // 
            // txtHorseLegs
            // 
            this.txtHorseLegs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorseLegs.Location = new System.Drawing.Point(178, 117);
            this.txtHorseLegs.Name = "txtHorseLegs";
            this.txtHorseLegs.Size = new System.Drawing.Size(100, 20);
            this.txtHorseLegs.TabIndex = 20;
            // 
            // txtHorseReason
            // 
            this.txtHorseReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorseReason.Location = new System.Drawing.Point(178, 143);
            this.txtHorseReason.Name = "txtHorseReason";
            this.txtHorseReason.Size = new System.Drawing.Size(100, 20);
            this.txtHorseReason.TabIndex = 22;
            // 
            // dtpHorse
            // 
            this.dtpHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpHorse.Location = new System.Drawing.Point(178, 169);
            this.dtpHorse.Name = "dtpHorse";
            this.dtpHorse.Size = new System.Drawing.Size(200, 20);
            this.dtpHorse.TabIndex = 24;
            // 
            // cbHorseType
            // 
            this.cbHorseType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHorseType.FormattingEnabled = true;
            this.cbHorseType.Location = new System.Drawing.Point(178, 64);
            this.cbHorseType.Name = "cbHorseType";
            this.cbHorseType.Size = new System.Drawing.Size(121, 21);
            this.cbHorseType.TabIndex = 16;
            // 
            // lblHorseColor
            // 
            this.lblHorseColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorseColor.AutoSize = true;
            this.lblHorseColor.Location = new System.Drawing.Point(56, 94);
            this.lblHorseColor.Name = "lblHorseColor";
            this.lblHorseColor.Size = new System.Drawing.Size(65, 13);
            this.lblHorseColor.TabIndex = 17;
            this.lblHorseColor.Text = "Horse Color:";
            // 
            // lblHorseLegs
            // 
            this.lblHorseLegs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorseLegs.AutoSize = true;
            this.lblHorseLegs.Location = new System.Drawing.Point(56, 120);
            this.lblHorseLegs.Name = "lblHorseLegs";
            this.lblHorseLegs.Size = new System.Drawing.Size(85, 13);
            this.lblHorseLegs.TabIndex = 19;
            this.lblHorseLegs.Text = "Number of Legs:";
            // 
            // lblHorseType
            // 
            this.lblHorseType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorseType.AutoSize = true;
            this.lblHorseType.Location = new System.Drawing.Point(55, 67);
            this.lblHorseType.Name = "lblHorseType";
            this.lblHorseType.Size = new System.Drawing.Size(65, 13);
            this.lblHorseType.TabIndex = 15;
            this.lblHorseType.Text = "Horse Type:";
            // 
            // lblHorseDate
            // 
            this.lblHorseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorseDate.AutoSize = true;
            this.lblHorseDate.Location = new System.Drawing.Point(56, 176);
            this.lblHorseDate.Name = "lblHorseDate";
            this.lblHorseDate.Size = new System.Drawing.Size(64, 13);
            this.lblHorseDate.TabIndex = 23;
            this.lblHorseDate.Text = "Date of Visit";
            // 
            // lblHorseReason
            // 
            this.lblHorseReason.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorseReason.AutoSize = true;
            this.lblHorseReason.Location = new System.Drawing.Point(55, 146);
            this.lblHorseReason.Name = "lblHorseReason";
            this.lblHorseReason.Size = new System.Drawing.Size(84, 13);
            this.lblHorseReason.TabIndex = 21;
            this.lblHorseReason.Text = "Reason for Visit:";
            // 
            // txtHorseName
            // 
            this.txtHorseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorseName.Location = new System.Drawing.Point(178, 38);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(123, 20);
            this.txtHorseName.TabIndex = 14;
            // 
            // lblHorseName
            // 
            this.lblHorseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Location = new System.Drawing.Point(55, 38);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(69, 13);
            this.lblHorseName.TabIndex = 13;
            this.lblHorseName.Text = "Horse Name:";
            // 
            // Test
            // 
            this.Test.Controls.Add(this.dateTimePicker1);
            this.Test.Location = new System.Drawing.Point(4, 22);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(433, 270);
            this.Test.TabIndex = 4;
            this.Test.Text = "tabPage1";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd a";
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 0;
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
            this.tpCat.ResumeLayout(false);
            this.tpCat.PerformLayout();
            this.tpHorse.ResumeLayout(false);
            this.tpHorse.PerformLayout();
            this.Test.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAnimal;
        private System.Windows.Forms.TabPage tpWelcome;
        private System.Windows.Forms.TabPage tpDog;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.RichTextBox rtxtPatients;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TabPage tpCat;
        private System.Windows.Forms.TabPage tpHorse;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.TextBox txtCatColor;
        private System.Windows.Forms.TextBox txtCatLegs;
        private System.Windows.Forms.TextBox txtCatReason;
        private System.Windows.Forms.DateTimePicker dtpCat;
        private System.Windows.Forms.ComboBox cbCatType;
        private System.Windows.Forms.Label lblCatColor;
        private System.Windows.Forms.Label lblCatLegs;
        private System.Windows.Forms.Label lblCatType;
        private System.Windows.Forms.Label lblCatDate;
        private System.Windows.Forms.Label lblCatReason;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Button btnAddHorse;
        private System.Windows.Forms.TextBox txtHorseColor;
        private System.Windows.Forms.TextBox txtHorseLegs;
        private System.Windows.Forms.TextBox txtHorseReason;
        private System.Windows.Forms.DateTimePicker dtpHorse;
        private System.Windows.Forms.ComboBox cbHorseType;
        private System.Windows.Forms.Label lblHorseColor;
        private System.Windows.Forms.Label lblHorseLegs;
        private System.Windows.Forms.Label lblHorseType;
        private System.Windows.Forms.Label lblHorseDate;
        private System.Windows.Forms.Label lblHorseReason;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.Label lblHorseName;
        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.TextBox txtDogColor;
        private System.Windows.Forms.TextBox txtDogNumLegs;
        private System.Windows.Forms.TextBox txtDogVisitReason;
        private System.Windows.Forms.DateTimePicker dtpDogVisit;
        private System.Windows.Forms.ComboBox cbDogType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDogType;
        private System.Windows.Forms.Label lblDateVisit;
        private System.Windows.Forms.Label lblVisitReason;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Test;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

