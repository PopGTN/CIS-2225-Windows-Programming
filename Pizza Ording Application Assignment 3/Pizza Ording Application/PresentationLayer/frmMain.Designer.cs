
namespace Pizza_Ording_Application
{
    partial class FrmMain
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
            this.tcHome = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.lblTile = new System.Windows.Forms.Label();
            this.tpPizza = new System.Windows.Forms.TabPage();
            this.btnAddTop = new System.Windows.Forms.Button();
            this.ddlToppings = new System.Windows.Forms.ComboBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lstTopping = new System.Windows.Forms.ListBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSause = new System.Windows.Forms.Label();
            this.ddlSause = new System.Windows.Forms.ComboBox();
            this.ddlSize = new System.Windows.Forms.ComboBox();
            this.lblPizzaTabTitle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tpSummary = new System.Windows.Forms.TabPage();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.tcHome.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpPizza.SuspendLayout();
            this.tpSummary.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHome
            // 
            this.tcHome.Controls.Add(this.tpHome);
            this.tcHome.Controls.Add(this.tpPizza);
            this.tcHome.Controls.Add(this.tpSummary);
            this.tcHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHome.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tcHome.Location = new System.Drawing.Point(0, 0);
            this.tcHome.Margin = new System.Windows.Forms.Padding(0);
            this.tcHome.Name = "tcHome";
            this.tcHome.SelectedIndex = 0;
            this.tcHome.Size = new System.Drawing.Size(638, 450);
            this.tcHome.TabIndex = 0;
            this.tcHome.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpHome
            // 
            this.tpHome.BackgroundImage = global::Pizza_Ording_Application.Properties.Resources._56b8edb8_3890_4bc9_958b_01ac7483991d;
            this.tpHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHome.Controls.Add(this.lblTile);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Size = new System.Drawing.Size(630, 424);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // lblTile
            // 
            this.lblTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTile.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.Color.Black;
            this.lblTile.Image = global::Pizza_Ording_Application.Properties.Resources._56b8edb8_3890_4bc9_958b_01ac7483991d;
            this.lblTile.Location = new System.Drawing.Point(0, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(628, 422);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "Joshua\'s Pizzaria";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpPizza
            // 
            this.tpPizza.Controls.Add(this.btnAddTop);
            this.tpPizza.Controls.Add(this.ddlToppings);
            this.tpPizza.Controls.Add(this.btnAddToOrder);
            this.tpPizza.Controls.Add(this.lstTopping);
            this.tpPizza.Controls.Add(this.lblToppings);
            this.tpPizza.Controls.Add(this.lblSause);
            this.tpPizza.Controls.Add(this.ddlSause);
            this.tpPizza.Controls.Add(this.ddlSize);
            this.tpPizza.Controls.Add(this.lblPizzaTabTitle);
            this.tpPizza.Controls.Add(this.lblSize);
            this.tpPizza.Location = new System.Drawing.Point(4, 22);
            this.tpPizza.Name = "tpPizza";
            this.tpPizza.Size = new System.Drawing.Size(630, 424);
            this.tpPizza.TabIndex = 1;
            this.tpPizza.Text = "Pizza";
            this.tpPizza.UseVisualStyleBackColor = true;
            // 
            // btnAddTop
            // 
            this.btnAddTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTop.Location = new System.Drawing.Point(187, 261);
            this.btnAddTop.Name = "btnAddTop";
            this.btnAddTop.Size = new System.Drawing.Size(85, 23);
            this.btnAddTop.TabIndex = 7;
            this.btnAddTop.Text = "Add topping";
            this.btnAddTop.UseVisualStyleBackColor = true;
            this.btnAddTop.Visible = false;
            this.btnAddTop.Click += new System.EventHandler(this.btnAddTop_Click);
            // 
            // ddlToppings
            // 
            this.ddlToppings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlToppings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlToppings.FormattingEnabled = true;
            this.ddlToppings.Items.AddRange(new object[] {
            "Regular",
            "Spicy"});
            this.ddlToppings.Location = new System.Drawing.Point(277, 261);
            this.ddlToppings.Name = "ddlToppings";
            this.ddlToppings.Size = new System.Drawing.Size(121, 21);
            this.ddlToppings.TabIndex = 8;
            this.ddlToppings.SelectedIndexChanged += new System.EventHandler(this.ddlToppings_SelectedIndexChanged);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddToOrder.Location = new System.Drawing.Point(277, 333);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(79, 23);
            this.btnAddToOrder.TabIndex = 9;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lstTopping
            // 
            this.lstTopping.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstTopping.FormattingEnabled = true;
            this.lstTopping.Location = new System.Drawing.Point(277, 134);
            this.lstTopping.Name = "lstTopping";
            this.lstTopping.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTopping.Size = new System.Drawing.Size(121, 121);
            this.lstTopping.TabIndex = 6;
            this.lstTopping.TabStop = false;
            // 
            // lblToppings
            // 
            this.lblToppings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(220, 134);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(51, 13);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Toppings";
            // 
            // lblSause
            // 
            this.lblSause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSause.AutoSize = true;
            this.lblSause.Location = new System.Drawing.Point(234, 110);
            this.lblSause.Name = "lblSause";
            this.lblSause.Size = new System.Drawing.Size(37, 13);
            this.lblSause.TabIndex = 3;
            this.lblSause.Text = "Sause";
            // 
            // ddlSause
            // 
            this.ddlSause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlSause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSause.FormattingEnabled = true;
            this.ddlSause.Items.AddRange(new object[] {
            "Regular",
            "Spicy"});
            this.ddlSause.Location = new System.Drawing.Point(277, 107);
            this.ddlSause.Name = "ddlSause";
            this.ddlSause.Size = new System.Drawing.Size(121, 21);
            this.ddlSause.TabIndex = 4;
            // 
            // ddlSize
            // 
            this.ddlSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSize.FormattingEnabled = true;
            this.ddlSize.Items.AddRange(new object[] {
            "10\"",
            "12\'",
            "14\""});
            this.ddlSize.Location = new System.Drawing.Point(277, 80);
            this.ddlSize.Name = "ddlSize";
            this.ddlSize.Size = new System.Drawing.Size(121, 21);
            this.ddlSize.TabIndex = 2;
            // 
            // lblPizzaTabTitle
            // 
            this.lblPizzaTabTitle.CausesValidation = false;
            this.lblPizzaTabTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPizzaTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTabTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPizzaTabTitle.Name = "lblPizzaTabTitle";
            this.lblPizzaTabTitle.Size = new System.Drawing.Size(630, 33);
            this.lblPizzaTabTitle.TabIndex = 0;
            this.lblPizzaTabTitle.Text = "Order a Pizza";
            this.lblPizzaTabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(244, 83);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size";
            // 
            // tpSummary
            // 
            this.tpSummary.Controls.Add(this.lstSummary);
            this.tpSummary.Controls.Add(this.panel1);
            this.tpSummary.Location = new System.Drawing.Point(4, 22);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(630, 424);
            this.tpSummary.TabIndex = 2;
            this.tpSummary.Text = "Summary";
            this.tpSummary.UseVisualStyleBackColor = true;
            // 
            // lstSummary
            // 
            this.lstSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.Location = new System.Drawing.Point(0, 0);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(630, 390);
            this.lstSummary.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearOrder.Location = new System.Drawing.Point(273, 5);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrder.TabIndex = 0;
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.tcHome);
            this.Name = "FrmMain";
            this.Text = "Pizza Application";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcHome.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpPizza.ResumeLayout(false);
            this.tpPizza.PerformLayout();
            this.tpSummary.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHome;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpPizza;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPizzaTabTitle;
        private System.Windows.Forms.ComboBox ddlSize;
        private System.Windows.Forms.ComboBox ddlSause;
        private System.Windows.Forms.Label lblSause;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.ListBox lstTopping;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.ComboBox ddlToppings;
        private System.Windows.Forms.TabPage tpSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.Button btnAddTop;
    }
}

