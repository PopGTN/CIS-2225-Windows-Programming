
namespace CIS2225_Assignment2
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
            this.ddlCatergory = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.txtItemsSold = new System.Windows.Forms.TextBox();
            this.ddlItem = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lstSales = new System.Windows.Forms.ListBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblCatergory = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lablSales = new System.Windows.Forms.Label();
            this.lblItemsSold = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ddlCatergory
            // 
            this.ddlCatergory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCatergory.FormattingEnabled = true;
            this.ddlCatergory.Items.AddRange(new object[] {
            "Home Theatre",
            "Computers",
            "Video Games",
            "Appliances",
            "Car Audio"});
            this.ddlCatergory.Location = new System.Drawing.Point(89, 100);
            this.ddlCatergory.Name = "ddlCatergory";
            this.ddlCatergory.Size = new System.Drawing.Size(160, 21);
            this.ddlCatergory.TabIndex = 4;
            this.ddlCatergory.SelectedIndexChanged += new System.EventHandler(this.ddlCatergory_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(367, 327);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 48);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(612, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(148, 368);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSales.TabIndex = 16;
            this.txtTotalSales.TabStop = false;
            // 
            // txtItemsSold
            // 
            this.txtItemsSold.Location = new System.Drawing.Point(148, 336);
            this.txtItemsSold.Name = "txtItemsSold";
            this.txtItemsSold.ReadOnly = true;
            this.txtItemsSold.Size = new System.Drawing.Size(62, 20);
            this.txtItemsSold.TabIndex = 12;
            this.txtItemsSold.TabStop = false;
            // 
            // ddlItem
            // 
            this.ddlItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlItem.FormattingEnabled = true;
            this.ddlItem.Location = new System.Drawing.Point(367, 101);
            this.ddlItem.Name = "ddlItem";
            this.ddlItem.Size = new System.Drawing.Size(160, 21);
            this.ddlItem.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(504, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 48);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Salesperson";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(367, 36);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(167, 20);
            this.txtLName.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(89, 36);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(160, 20);
            this.txtFName.TabIndex = 1;
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(89, 177);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(637, 108);
            this.lstSales.TabIndex = 10;
            this.lstSales.TabStop = false;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(1, 36);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(277, 39);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblCatergory
            // 
            this.lblCatergory.AutoSize = true;
            this.lblCatergory.Location = new System.Drawing.Point(1, 100);
            this.lblCatergory.Name = "lblCatergory";
            this.lblCatergory.Size = new System.Drawing.Size(52, 13);
            this.lblCatergory.TabIndex = 4;
            this.lblCatergory.Text = "Category:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(277, 103);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Item:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(559, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            // 
            // lablSales
            // 
            this.lablSales.AutoSize = true;
            this.lablSales.Location = new System.Drawing.Point(75, 142);
            this.lablSales.Name = "lablSales";
            this.lablSales.Size = new System.Drawing.Size(36, 13);
            this.lablSales.TabIndex = 9;
            this.lablSales.Text = "Sales:";
            // 
            // lblItemsSold
            // 
            this.lblItemsSold.AutoSize = true;
            this.lblItemsSold.Location = new System.Drawing.Point(16, 340);
            this.lblItemsSold.Name = "lblItemsSold";
            this.lblItemsSold.Size = new System.Drawing.Size(59, 13);
            this.lblItemsSold.TabIndex = 11;
            this.lblItemsSold.Text = "Items Sold:";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(16, 372);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(63, 13);
            this.lblSales.TabIndex = 15;
            this.lblSales.Text = "Total Sales:";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(16, 404);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(92, 13);
            this.lblCommission.TabIndex = 17;
            this.lblCommission.Text = "Total Commission:";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(148, 400);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.ReadOnly = true;
            this.txtCommission.Size = new System.Drawing.Size(100, 20);
            this.txtCommission.TabIndex = 18;
            this.txtCommission.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 466);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblItemsSold);
            this.Controls.Add(this.lablSales);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCatergory);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ddlItem);
            this.Controls.Add(this.txtItemsSold);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.ddlCatergory);
            this.Name = "frmMain";
            this.Text = "Electronic Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlCatergory;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox txtItemsSold;
        private System.Windows.Forms.ComboBox ddlItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblCatergory;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lablSales;
        private System.Windows.Forms.Label lblItemsSold;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtCommission;
    }
}

