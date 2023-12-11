using Booking_Form.PresentationLayer;
using System;
using System.Windows.Forms;
using Booking_Form.BusinessLayer;
/*
 * Author: Joshua Mckenna 
 * Date: 2023/11/10
 * Description: 
 * this  main form and allow people to create the a booking object
 */
namespace Booking_Form
{
    public partial class frmMain : Form
    {
        //Holds the current create booking object
        private Booking booking;


        public frmMain()
        {
            InitializeComponent();
        }


        //This method is is activated on the click of the exit button on the menu strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Opens the Summary Page and passes in the a The Booking attrubute 
        private void processBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummary fSummary = new frmSummary(booking);
            fSummary.Show();
        }


        //Creates the booking object and calculates the cost
        private void priceBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtVenue.Text))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(ddlEventSize.Text))
            {
                isValid = false;
            }
            if (!rdoRock.Checked && !rdoPop.Checked && !rdoClassical.Checked)
            {
                isValid = false;
            }

            if (isValid)
            {
                string bandType = "";
                if (rdoClassical.Checked)
                {
                    bandType = "Classical";
                }
                if (rdoPop.Checked)
                {
                    bandType = "Pop";
                }
                if (rdoRock.Checked)
                {
                    bandType = "Rock";
                }
                booking = new Booking(txtVenue.Text, bandType, txtFName.Text, txtLName.Text, txtEmail.Text, ddlEventSize.Text);
                booking.CalculatePrice();
                lblFormTitle.Text = "Your Booking has been submitted. \n Click the Process Booking to see details";
            } 
            else
            {
                MessageBox.Show("You must fill in the form Completely");
            }
        }
    }
}