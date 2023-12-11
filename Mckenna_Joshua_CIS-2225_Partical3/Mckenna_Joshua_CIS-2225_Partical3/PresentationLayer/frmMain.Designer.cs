
namespace Mckenna_Joshua_CIS_2225_Partical3
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
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalesAmount = new System.Windows.Forms.Label();
            this.grpAgentType = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComissionRated = new System.Windows.Forms.Label();
            this.lblComissionEarned = new System.Windows.Forms.Label();
            this.txtBoRe = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtEarned = new System.Windows.Forms.TextBox();
            this.rdoJunior = new System.Windows.Forms.RadioButton();
            this.rdoAgent = new System.Windows.Forms.RadioButton();
            this.rdoSenior = new System.Windows.Forms.RadioButton();
            this.grpAgentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFName.Location = new System.Drawing.Point(132, 41);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(116, 20);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLName.Location = new System.Drawing.Point(132, 80);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(116, 20);
            this.txtLName.TabIndex = 3;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSalesAmount.Location = new System.Drawing.Point(132, 160);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(116, 20);
            this.txtSalesAmount.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(132, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblFName
            // 
            this.lblFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(39, 44);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(39, 83);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblSalesAmount
            // 
            this.lblSalesAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalesAmount.AutoSize = true;
            this.lblSalesAmount.Location = new System.Drawing.Point(39, 163);
            this.lblSalesAmount.Name = "lblSalesAmount";
            this.lblSalesAmount.Size = new System.Drawing.Size(75, 13);
            this.lblSalesAmount.TabIndex = 6;
            this.lblSalesAmount.Text = "Sales Amount:";
            // 
            // grpAgentType
            // 
            this.grpAgentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpAgentType.Controls.Add(this.rdoSenior);
            this.grpAgentType.Controls.Add(this.rdoAgent);
            this.grpAgentType.Controls.Add(this.rdoJunior);
            this.grpAgentType.Location = new System.Drawing.Point(342, 41);
            this.grpAgentType.Name = "grpAgentType";
            this.grpAgentType.Size = new System.Drawing.Size(200, 100);
            this.grpAgentType.TabIndex = 8;
            this.grpAgentType.TabStop = false;
            this.grpAgentType.Text = "Agent Type";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalc.Location = new System.Drawing.Point(39, 209);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Location = new System.Drawing.Point(173, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bonus/Reduction:";
            // 
            // lblComissionRated
            // 
            this.lblComissionRated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComissionRated.AutoSize = true;
            this.lblComissionRated.Location = new System.Drawing.Point(326, 266);
            this.lblComissionRated.Name = "lblComissionRated";
            this.lblComissionRated.Size = new System.Drawing.Size(91, 13);
            this.lblComissionRated.TabIndex = 13;
            this.lblComissionRated.Text = "Commission Rate:";
            // 
            // lblComissionEarned
            // 
            this.lblComissionEarned.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComissionEarned.AutoSize = true;
            this.lblComissionEarned.Location = new System.Drawing.Point(326, 240);
            this.lblComissionEarned.Name = "lblComissionEarned";
            this.lblComissionEarned.Size = new System.Drawing.Size(94, 13);
            this.lblComissionEarned.TabIndex = 11;
            this.lblComissionEarned.Text = "Comission Earned:";
            // 
            // txtBoRe
            // 
            this.txtBoRe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoRe.Location = new System.Drawing.Point(426, 289);
            this.txtBoRe.Name = "txtBoRe";
            this.txtBoRe.ReadOnly = true;
            this.txtBoRe.Size = new System.Drawing.Size(116, 20);
            this.txtBoRe.TabIndex = 16;
            this.txtBoRe.TabStop = false;
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRate.Location = new System.Drawing.Point(426, 263);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(116, 20);
            this.txtRate.TabIndex = 14;
            this.txtRate.TabStop = false;
            // 
            // txtEarned
            // 
            this.txtEarned.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEarned.Location = new System.Drawing.Point(426, 237);
            this.txtEarned.Name = "txtEarned";
            this.txtEarned.ReadOnly = true;
            this.txtEarned.Size = new System.Drawing.Size(116, 20);
            this.txtEarned.TabIndex = 12;
            this.txtEarned.TabStop = false;
            // 
            // rdoJunior
            // 
            this.rdoJunior.AutoSize = true;
            this.rdoJunior.Location = new System.Drawing.Point(30, 24);
            this.rdoJunior.Name = "rdoJunior";
            this.rdoJunior.Size = new System.Drawing.Size(84, 17);
            this.rdoJunior.TabIndex = 0;
            this.rdoJunior.TabStop = true;
            this.rdoJunior.Text = "Junior Agent";
            this.rdoJunior.UseVisualStyleBackColor = true;
            // 
            // rdoAgent
            // 
            this.rdoAgent.AutoSize = true;
            this.rdoAgent.Location = new System.Drawing.Point(30, 47);
            this.rdoAgent.Name = "rdoAgent";
            this.rdoAgent.Size = new System.Drawing.Size(53, 17);
            this.rdoAgent.TabIndex = 1;
            this.rdoAgent.TabStop = true;
            this.rdoAgent.Text = "Agent";
            this.rdoAgent.UseVisualStyleBackColor = true;
            // 
            // rdoSenior
            // 
            this.rdoSenior.AutoSize = true;
            this.rdoSenior.Location = new System.Drawing.Point(30, 70);
            this.rdoSenior.Name = "rdoSenior";
            this.rdoSenior.Size = new System.Drawing.Size(86, 17);
            this.rdoSenior.TabIndex = 2;
            this.rdoSenior.TabStop = true;
            this.rdoSenior.Text = "Senior Agent";
            this.rdoSenior.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComissionRated);
            this.Controls.Add(this.lblComissionEarned);
            this.Controls.Add(this.txtBoRe);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtEarned);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpAgentType);
            this.Controls.Add(this.lblSalesAmount);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtSalesAmount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Name = "frmMain";
            this.Text = "Sales";
            this.grpAgentType.ResumeLayout(false);
            this.grpAgentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.GroupBox grpAgentType;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComissionRated;
        private System.Windows.Forms.Label lblComissionEarned;
        private System.Windows.Forms.TextBox txtBoRe;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtEarned;
        private System.Windows.Forms.RadioButton rdoSenior;
        private System.Windows.Forms.RadioButton rdoAgent;
        private System.Windows.Forms.RadioButton rdoJunior;
    }
}

