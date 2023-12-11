using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_pay
{


    public partial class frmMain : Form
    {
        const double gFederalTax = 0.18;
        const double gOvertime = 1.5;
        const double gsocialSecuritytaxy = 0.6;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want exit?", "Exit Stopper", MessageBoxButtons.OKCancel); ;
            if (result == DialogResult.OK)
            {
                // Code to execute when the user clicks "OK"
            }
            else if (result == DialogResult.Cancel)
            {
                // Code to execute when the user clicks "Cancel"
                e.Cancel = true;
            }
        }

        private void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlEmployeeType.SelectedIndex == 0)
            { 
                this.lblMoney.Text = "Salary amount:";
                this.txtMoney.Visible = true;
                this.lblMoney.Visible = true;
                this.lblHours.Visible = false;
                this.txtHours.Visible = false;
            } 
            else if (this.ddlEmployeeType.SelectedIndex == 1)
            {
                this.lblMoney.Text = "Hourly rate:";
                this.txtMoney.Visible = true;
                this.lblMoney.Visible = true;
                this.lblHours.Visible = true;
                this.txtHours.Visible = true;
            } 
            else
            {
                this.txtMoney.Visible = false;
                this.lblMoney.Visible = false;
                this.lblHours.Visible = false;
                this.txtHours.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (    
                !(this.ddlEmployeeType.SelectedIndex == 0) &&
                !(this.ddlEmployeeType.SelectedIndex == 1) &&
                !String.IsNullOrWhiteSpace(txtEmployeeID.Text) &&
                !String.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !String.IsNullOrWhiteSpace(txtLastName.Text) &&
                !String.IsNullOrWhiteSpace(txtMoney.Text)
                )
            { 
            
            }
            else
            {
                MessageBox.Show("Please fill out the form completely before submitting!!!", "Form Submit");
            }
           
        }

    }
}
