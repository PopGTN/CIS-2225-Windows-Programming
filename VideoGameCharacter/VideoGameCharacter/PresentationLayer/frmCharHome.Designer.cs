
namespace VideoGameCharacter
{
    partial class frmCharHome
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
            this.tcChar = new System.Windows.Forms.TabControl();
            this.tpCharBase = new System.Windows.Forms.TabPage();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.clbStats = new System.Windows.Forms.CheckedListBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.gpRaceSelection = new System.Windows.Forms.GroupBox();
            this.rbElf = new System.Windows.Forms.RadioButton();
            this.rbDwarf = new System.Windows.Forms.RadioButton();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tpJester = new System.Windows.Forms.TabPage();
            this.tpSummary = new System.Windows.Forms.TabPage();
            this.cmbHats = new System.Windows.Forms.ComboBox();
            this.lblJHats = new System.Windows.Forms.Label();
            this.btnJCreate = new System.Windows.Forms.Button();
            this.rtxDisplay = new System.Windows.Forms.RichTextBox();
            this.tcChar.SuspendLayout();
            this.tpCharBase.SuspendLayout();
            this.gpRaceSelection.SuspendLayout();
            this.tpJester.SuspendLayout();
            this.tpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcChar
            // 
            this.tcChar.Controls.Add(this.tpCharBase);
            this.tcChar.Controls.Add(this.tpJester);
            this.tcChar.Controls.Add(this.tpSummary);
            this.tcChar.Location = new System.Drawing.Point(12, 12);
            this.tcChar.Name = "tcChar";
            this.tcChar.SelectedIndex = 0;
            this.tcChar.Size = new System.Drawing.Size(482, 426);
            this.tcChar.TabIndex = 0;
            this.tcChar.SelectedIndexChanged += new System.EventHandler(this.tcChar_SelectedIndexChanged);
            // 
            // tpCharBase
            // 
            this.tpCharBase.Controls.Add(this.lblStats);
            this.tpCharBase.Controls.Add(this.lblAge);
            this.tpCharBase.Controls.Add(this.lblName);
            this.tpCharBase.Controls.Add(this.clbStats);
            this.tpCharBase.Controls.Add(this.txtAge);
            this.tpCharBase.Controls.Add(this.gpRaceSelection);
            this.tpCharBase.Controls.Add(this.txtName);
            this.tpCharBase.Location = new System.Drawing.Point(4, 22);
            this.tpCharBase.Name = "tpCharBase";
            this.tpCharBase.Padding = new System.Windows.Forms.Padding(3);
            this.tpCharBase.Size = new System.Drawing.Size(474, 400);
            this.tpCharBase.TabIndex = 0;
            this.tpCharBase.Text = "Character Base";
            this.tpCharBase.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(59, 257);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(34, 13);
            this.lblStats.TabIndex = 9;
            this.lblStats.Text = "Stats:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(59, 206);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // clbStats
            // 
            this.clbStats.FormattingEnabled = true;
            this.clbStats.Location = new System.Drawing.Point(121, 257);
            this.clbStats.Name = "clbStats";
            this.clbStats.Size = new System.Drawing.Size(120, 94);
            this.clbStats.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(121, 206);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            // 
            // gpRaceSelection
            // 
            this.gpRaceSelection.Controls.Add(this.rbElf);
            this.gpRaceSelection.Controls.Add(this.rbDwarf);
            this.gpRaceSelection.Controls.Add(this.rbHuman);
            this.gpRaceSelection.Location = new System.Drawing.Point(121, 76);
            this.gpRaceSelection.Name = "gpRaceSelection";
            this.gpRaceSelection.Size = new System.Drawing.Size(214, 110);
            this.gpRaceSelection.TabIndex = 4;
            this.gpRaceSelection.TabStop = false;
            this.gpRaceSelection.Text = "Select Race";
            // 
            // rbElf
            // 
            this.rbElf.AutoSize = true;
            this.rbElf.Location = new System.Drawing.Point(55, 40);
            this.rbElf.Name = "rbElf";
            this.rbElf.Size = new System.Drawing.Size(37, 17);
            this.rbElf.TabIndex = 2;
            this.rbElf.TabStop = true;
            this.rbElf.Text = "Elf";
            this.rbElf.UseVisualStyleBackColor = true;
            this.rbElf.CheckedChanged += new System.EventHandler(this.rbElf_CheckedChanged);
            // 
            // rbDwarf
            // 
            this.rbDwarf.AutoSize = true;
            this.rbDwarf.Location = new System.Drawing.Point(55, 63);
            this.rbDwarf.Name = "rbDwarf";
            this.rbDwarf.Size = new System.Drawing.Size(53, 17);
            this.rbDwarf.TabIndex = 3;
            this.rbDwarf.TabStop = true;
            this.rbDwarf.Text = "Dwarf";
            this.rbDwarf.UseVisualStyleBackColor = true;
            this.rbDwarf.CheckedChanged += new System.EventHandler(this.rbDwarf_CheckedChanged);
            // 
            // rbHuman
            // 
            this.rbHuman.AutoSize = true;
            this.rbHuman.Location = new System.Drawing.Point(55, 17);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(59, 17);
            this.rbHuman.TabIndex = 1;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Human";
            this.rbHuman.UseVisualStyleBackColor = true;
            this.rbHuman.CheckedChanged += new System.EventHandler(this.rbHuman_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // tpJester
            // 
            this.tpJester.Controls.Add(this.btnJCreate);
            this.tpJester.Controls.Add(this.lblJHats);
            this.tpJester.Controls.Add(this.cmbHats);
            this.tpJester.Location = new System.Drawing.Point(4, 22);
            this.tpJester.Name = "tpJester";
            this.tpJester.Padding = new System.Windows.Forms.Padding(3);
            this.tpJester.Size = new System.Drawing.Size(474, 400);
            this.tpJester.TabIndex = 1;
            this.tpJester.Text = "Jester";
            this.tpJester.UseVisualStyleBackColor = true;
            // 
            // tpSummary
            // 
            this.tpSummary.Controls.Add(this.rtxDisplay);
            this.tpSummary.Location = new System.Drawing.Point(4, 22);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(474, 400);
            this.tpSummary.TabIndex = 2;
            this.tpSummary.Text = "Summary";
            this.tpSummary.UseVisualStyleBackColor = true;
            // 
            // cmbHats
            // 
            this.cmbHats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHats.FormattingEnabled = true;
            this.cmbHats.Items.AddRange(new object[] {
            "Funny",
            "Scary",
            "Large"});
            this.cmbHats.Location = new System.Drawing.Point(149, 89);
            this.cmbHats.Name = "cmbHats";
            this.cmbHats.Size = new System.Drawing.Size(121, 21);
            this.cmbHats.TabIndex = 0;
            // 
            // lblJHats
            // 
            this.lblJHats.AutoSize = true;
            this.lblJHats.Location = new System.Drawing.Point(75, 89);
            this.lblJHats.Name = "lblJHats";
            this.lblJHats.Size = new System.Drawing.Size(63, 13);
            this.lblJHats.TabIndex = 1;
            this.lblJHats.Text = "Jester Hats:";
            // 
            // btnJCreate
            // 
            this.btnJCreate.Location = new System.Drawing.Point(149, 175);
            this.btnJCreate.Name = "btnJCreate";
            this.btnJCreate.Size = new System.Drawing.Size(105, 23);
            this.btnJCreate.TabIndex = 2;
            this.btnJCreate.Text = "Create Jester";
            this.btnJCreate.UseVisualStyleBackColor = true;
            this.btnJCreate.Click += new System.EventHandler(this.btnJCreate_Click);
            // 
            // rtxDisplay
            // 
            this.rtxDisplay.Location = new System.Drawing.Point(15, 76);
            this.rtxDisplay.Name = "rtxDisplay";
            this.rtxDisplay.ReadOnly = true;
            this.rtxDisplay.Size = new System.Drawing.Size(434, 290);
            this.rtxDisplay.TabIndex = 0;
            this.rtxDisplay.Text = "";
            // 
            // frmCharHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.tcChar);
            this.Name = "frmCharHome";
            this.Text = "Character Home";
            this.Load += new System.EventHandler(this.frmCharHome_Load);
            this.tcChar.ResumeLayout(false);
            this.tpCharBase.ResumeLayout(false);
            this.tpCharBase.PerformLayout();
            this.gpRaceSelection.ResumeLayout(false);
            this.gpRaceSelection.PerformLayout();
            this.tpJester.ResumeLayout(false);
            this.tpJester.PerformLayout();
            this.tpSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcChar;
        private System.Windows.Forms.TabPage tpCharBase;
        private System.Windows.Forms.TabPage tpJester;
        private System.Windows.Forms.TabPage tpSummary;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckedListBox clbStats;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox gpRaceSelection;
        private System.Windows.Forms.RadioButton rbElf;
        private System.Windows.Forms.RadioButton rbDwarf;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblJHats;
        private System.Windows.Forms.ComboBox cmbHats;
        private System.Windows.Forms.Button btnJCreate;
        private System.Windows.Forms.RichTextBox rtxDisplay;
    }
}

