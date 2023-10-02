using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author: Joshua Mckenna
 * Date: 2023/10/02
 * Description This application was made for Assignment 2 to calculate a Sale's rep 
 * commission made on each sale entered in to this calulator
 */
namespace CIS2225_Assignment2
{
    public partial class frmMain : Form
    {
        double[] gRates = { 0.03, 0.02, 0.01, 0.07, 0.05 };

        int gSalesCount = 0;

        double gTotalSales = 0;

        double gTotalCommission = 0;

        public frmMain()
        {
            InitializeComponent();
            ddlCatergory.SelectedIndex = 0;
        }

        /*
         * This method fills out the options for item drop down list when a catergory is choosen in the 
         * catergory drop downlist
         */
        private void ddlCatergory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] homeTheatre = { "TV", "Sound Bar", "Reciever", "Stream Box" };
            string[] videoGames = { "XBOX", "PS5", "Switch", "Game" };
            string[] carAudio = { "Car Stereo", "Speakers", "Subwoofer" };
            string[] computers = { "PC Desktop", "PC Laptop", "Mac Desktop", "Mac Laptop" };
            string[] appliances = { "Dish Washer", "Fridge", "Air Conditioner" };

            if (ddlCatergory.SelectedIndex == 0)
            {
                ddlItem.Items.Clear();
                ddlItem.Items.AddRange(homeTheatre);
                ddlItem.SelectedIndex = 0;
            }
            if (ddlCatergory.SelectedIndex == 1)
            {
                ddlItem.Items.Clear();
                ddlItem.Items.AddRange(computers);
                ddlItem.SelectedIndex = 0;
            }
            if (ddlCatergory.SelectedIndex == 2)
            {
                ddlItem.Items.Clear();
                ddlItem.Items.AddRange(videoGames);
                ddlItem.SelectedIndex = 0;
            }
            if (ddlCatergory.SelectedIndex == 3)
            {
                ddlItem.Items.Clear();
                ddlItem.Items.AddRange(appliances);
                ddlItem.SelectedIndex = 0;
            }
            if (ddlCatergory.SelectedIndex == 4)
            {
                ddlItem.Items.Clear();
                ddlItem.Items.AddRange(carAudio);
                ddlItem.SelectedIndex = 0;
            }
        }


       
       
        /*
         * Checks if the form is valid to submitted and check if everything is filled out properly 
         */
        private bool ValidateForm()
        {
            bool isValid = true;
            if (String.IsNullOrWhiteSpace(txtFName.Text))
            {
                isValid = false;
                lblFName.ForeColor = System.Drawing.Color.Red;
            } 
            else
            {
                lblFName.ForeColor = System.Drawing.Color.Black;
            }
            if (String.IsNullOrWhiteSpace(txtLName.Text))
            {
                isValid = false;
                lblLName.ForeColor = System.Drawing.Color.Red; 
            }
            else
            {
                lblLName.ForeColor = System.Drawing.Color.Black;
            }
            if (String.IsNullOrWhiteSpace(ddlCatergory.Text))
            {
                isValid = false;
                lblCatergory.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblCatergory.ForeColor = System.Drawing.Color.Black;
            }
            if (String.IsNullOrWhiteSpace(ddlItem.Text))
            {
                isValid = false;
                lblItem.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblItem.ForeColor = System.Drawing.Color.Black;
            } 
            
            double price;
            if (String.IsNullOrWhiteSpace(txtPrice.Text) || !Double.TryParse(txtPrice.Text, out price) || price < 0)
            {
                isValid = false;
                lblPrice.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Value for price is non numeric or less than 0");
            }
            else
            {
                lblPrice.ForeColor = System.Drawing.Color.Black;
            }
          
         
            return isValid;
      
        }
        /*
         * Calculates The Commission made and total price and addes it the item to the listSales along with the sales information
         */
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                txtFName.ReadOnly = true;
                txtLName.ReadOnly = true;
                double commissionEarned = Math.Round(Math.Round(double.Parse(txtPrice.Text), 2) * gRates[ddlCatergory.SelectedIndex], 2);
                lstSales.Items.Add("Category: " + ddlCatergory.SelectedItem + " Item: " + ddlItem.Text + " Price: " + Math.Round(double.Parse(txtPrice.Text), 2) + " Commission Rate: " + gRates[ddlCatergory.SelectedIndex] + " Commission earned: " + commissionEarned);
                txtCommission.Text = "" + (gTotalCommission += commissionEarned);
                txtItemsSold.Text = "" + (++gSalesCount);
                txtTotalSales.Text = "" + (gTotalSales += Math.Round(double.Parse(txtPrice.Text), 2));
                txtPrice.Text = "";

            } 
        }
        
        /**
         * Clears the all the information inputted in the form.
         */

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Stop entered sales for: " + txtFName.Text + " " + txtLName.Text + "?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Total Commission Earned: " + gTotalCommission + " for " + txtFName.Text + " " + txtLName.Text);
                txtFName.ReadOnly = false;
                txtLName.ReadOnly = false;
                txtFName.Text = "";
                txtLName.Text = "";
                txtPrice.Text = "";
                gSalesCount = 0;
                txtItemsSold.Text = "";
                gTotalCommission = 0;
                txtCommission.Text = "";
                gTotalSales = 0;
                txtTotalSales.Text = "";
                lstSales.Items.Clear();
               
            }
        }
    }
}

