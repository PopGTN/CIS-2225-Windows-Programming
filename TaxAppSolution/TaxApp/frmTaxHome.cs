using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Donnie McKinnon
 * Date: Sept 15 2023
 * Class: CIS-2225
 * Description: App used to calculate tax.
 * 
 */

namespace TaxApp
{
    public partial class frmTaxHome : Form
    {
        double gTotalTax = 0.0;
        double gTotalIncome = 0.0;
        public frmTaxHome()
        {
            InitializeComponent();
            //check user account
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                //txtInputOne was empty or null
                MessageBox.Show("Please enter a name.");
                txtName.Focus();
            }
            else if (double.TryParse(txtIncome.Text, out double income) == false)
            {
                MessageBox.Show("Please enter a numeric value for income.");
                txtIncome.Focus();
            }
            else
            {
                double taxAmount = calcTax(income);
                //MessageBox.Show("Taxamount: " + taxAmount);
                string outPut = txtName.Text + " total income: " + income + ". Total taxes to pay: " + taxAmount + ". Total after taxes: "
                    + (income - taxAmount);
                lstDisplay.Items.Add(outPut);
                gTotalIncome += income;
                gTotalTax += taxAmount;
                txtIncome.Clear();
                txtName.Clear();
            }
        }

        private double calcTax(double amt)
        {
            double returnValue = 0.0;
            if (amt > 50000)
            {
                returnValue = amt * 0.2;
                return returnValue;
            }
            if (amt > 25000)
            {
                returnValue = amt * 0.15;
                return returnValue;
            }
            returnValue = amt * 0.1;
            return returnValue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total income: " + gTotalIncome + " total taxes to be paid: " + gTotalTax);
            txtName.Clear();
            txtIncome.Clear();
            lstDisplay.Items.Clear();
            gTotalTax = 0.0;
            gTotalIncome = 0.0;
        }
    }
}
