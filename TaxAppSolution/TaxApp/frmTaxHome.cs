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
 * Date: Sep 13/23
 * Class: CIS-2225
 * Description: App that accepts name, income and calculates tax amount to be deducted.
 */
namespace TaxApp
{
    public partial class frmTaxHome : Form
    {
        //Globals used to keep running totals.
        double gTotalTax = 0.0;
        double gTotalIncome = 0.0;
        public frmTaxHome()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double taxAmount = 0.0;
            //use a tryParse to see if value in txtIncome can be converted to a double
            if (double.TryParse(txtIncome.Text, out double income) == false)
            {
                MessageBox.Show("Please enter a numeric value for income. ");
                txtIncome.Focus();
            }
            else
            {
                taxAmount = calcTax(income);
                //MessageBox.Show("The tax amount: " + taxAmount);//used for debugging
                string outPut = txtName.Text + " total income: " + income 
                    + " Total taxes pay: " + taxAmount + ". Total after taxes: "+ 
                    (income - taxAmount);
                lstDisplay.Items.Add(outPut);
                txtName.Text = "";
                txtIncome.Text = "";
                gTotalTax += taxAmount;
                gTotalIncome += income;

            }
        }
        
        private double calcTax(double amt)
        {
            double returnValue = 0.0;
            if (amt > 50000)
            {
                returnValue = amt * 0.2;
            }
            else if (amt > 25000)
            {
                returnValue = amt * 0.15;
            }
            else
            {
                returnValue = amt * 0.1;
            }
            return returnValue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total income: " + gTotalIncome + " total taxes: " + gTotalTax);
            lstDisplay.Items.Clear();
            txtIncome.Text = "";
            txtName.Text = "";
            gTotalIncome = 0.0;
            gTotalTax = 0.0;
        }
    }
}
