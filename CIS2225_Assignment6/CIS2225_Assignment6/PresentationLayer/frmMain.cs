using CIS2225_Assignment6.BusinessObjects;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CIS2225_Assignment6
{
    /*
     * Author: Joshua Mckenna 
     * Date: 12/11/2023
     * Description:
     * This holds all the function in frmMain. From validation to saving stuff to the local db
     */


    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadGuests();
        }

        public void loadGuests()
        {

            //build connection to Cottages
            //create connection string for Cottages database
            string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cottages.accdb";

            //Create OldDbConnection
            OleDbConnection dbConn;
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Person table
                string sql;
                sql = "SELECT GuestId, FirstName, LastName from Guests;"; //note the two semicolons

                OleDbCommand dbCmd = new OleDbCommand();
                //set command SQL string
                dbCmd.CommandText = sql;
                //set the command connection
                dbCmd.Connection = dbConn;

                //Read data into dbReader
                OleDbDataReader dbReader = dbCmd.ExecuteReader();
                //Clear item in ddl
                ddlGuestsSelector.Items.Clear();
                //Read first record
                while (dbReader.Read())
                {
                    //Create a person object populate the firstName and personId attibutes
                    Guest guest = new Guest((int)dbReader["GuestId"], dbReader["FirstName"].ToString(), dbReader["LastName"].ToString());
                    ddlGuestsSelector.Items.Add(guest);
                }
                dbReader.Close();
                //close database connection
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ddlGuestsSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlGuestsSelector.SelectedIndex != -1)
            {
                //build connection to Cottages
                //create connection string for Cottages database
                string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cottages.accdb";

                //Create OldDbConnection
                OleDbConnection dbConn;

                //the combobox is populated with Person objects. Cast the selected value as a Person and then you can 
                //access the public property PersonId;
                int guestSelection = ((Guest)ddlGuestsSelector.SelectedItem).GuestId;

                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();

                    //Add a subquery to get the record count
                    //Using a variable to identify the GuestID to search for

                    string sql = "SELECT(SELECT COUNT(GuestID) from Guests where GuestID = @GuestSelection) as rowCount, * FROM Guests WHERE GuestID = @GuestSelection;";



                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;

                    //set the command connection
                    dbCmd.Connection = dbConn;

                    dbCmd.Parameters.AddWithValue("@GuestSelection", guestSelection);
                    dbCmd.Parameters.AddWithValue("@GuestSelection", guestSelection);

                    //get number of rows
                    //ExecuteScalar just returns the value of the first column
                    int numRows = (Int32)dbCmd.ExecuteScalar();

                    //create OleDbDataReader dbReader
                    OleDbDataReader dbReader;

                    //Read data into dbReader
                    dbReader = dbCmd.ExecuteReader();

                    //Read first record
                    dbReader.Read();
                    if (dbReader.HasRows && numRows == 1)
                    {
                        txtFName.Text = dbReader["FirstName"].ToString();
                        txtLName.Text = dbReader["LastName"].ToString();
                        txtStreet.Text = dbReader["Street"].ToString();
                        txtCity.Text = dbReader["City"].ToString();
                        txtState.Text = dbReader["State"].ToString();
                        txtZip.Text = dbReader["Zip"].ToString();
                        txtPhone.Text = dbReader["Phone"].ToString();
                        txtEmail.Text = dbReader["Email"].ToString();
                        dtpLastVisitDate.Text = dbReader["LastVisitDate"].ToString();
                        txtRoom.Text = dbReader["Room"].ToString();
                        txtGuestId.Text = dbReader["GuestID"].ToString();

                    }
                    //Close open connections
                    dbReader.Close();
                    dbConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ddlGuestsSelector.SelectedIndex != -1)
            {
                ddlGuestsSelector.SelectedIndex = -1;
                clearForm();
            }
            else
            {
                addGuest();
            }
        }

        //Add a new guests
        private void addGuest()
        {
            if (ValidateForm())
            {
                //build connection to Cottages
                //create connection string for Cottages database
                string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cottages.accdb";
                //Create OldDbConnection
                OleDbConnection dbConn;
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to select all rows from Person table
                    string sql = "INSERT INTO Guests (LastName, FirstName, Street, City, State, Zip, Phone, email, LastVisitDate, Room) VALUES (@LastName, @FirstName, @Street, @City, @State, @Zip, @Phone, @Email, @LastVisitDate, @Room)"; //note the two semicolons

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    
                    dbCmd.Parameters.AddWithValue("@LastName", txtLName.Text);
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
                    dbCmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                    dbCmd.Parameters.AddWithValue("@City", txtCity.Text);
                    dbCmd.Parameters.AddWithValue("@State", txtState.Text);
                    dbCmd.Parameters.AddWithValue("@Zip", txtZip.Text);
                    dbCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    dbCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    dbCmd.Parameters.AddWithValue("@LastVisitDate", dtpLastVisitDate.Value); // Assuming LastVisitDate is a DateTime type
                    dbCmd.Parameters.AddWithValue("@Room", txtRoom.Text);

                    //execute insert. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully");
                        //this is where I want to update frmMain
                        loadGuests();
                    }
                    else
                    {
                        MessageBox.Show("Error inserting record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please double check the form inputs in red", "Invalid Input");
            }
        }

        //checks if  control holds a text or not else set passed in label to red text
        private bool isInputNotValid(Label label, Control control)
        {
            bool isValid = !String.IsNullOrEmpty(control.Text);

            if (!isValid)
            {
                label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Black;
            }

            return isValid;
        }

        //checks if  control holds a text or not
        private bool isInputNotValid(Control control)
        {
            bool isValid = !String.IsNullOrEmpty(control.Text);
            return isValid;
        }

        //Checks if everthing that is entered is valid to submitted
        private bool ValidateForm()
        {
            bool isValid = true;

            isValid &= isInputNotValid(lblLName, txtLName);
            isValid &= isInputNotValid(lblFName, txtFName);
            isValid &= isInputNotValid(lblStreet, txtStreet);
            isValid &= isInputNotValid(lblCity, txtCity);
            isValid &= isInputNotValid(lblZip, txtZip);

            if (double.TryParse(txtPhone.Text.Trim(), out double ouput) && (txtPhone.Text.Length != 0))
            {
                isValid &= true;
                lblPhone.ForeColor = System.Drawing.Color.Black;


            }
            else
            {
                isValid &= false;
                lblPhone.ForeColor = System.Drawing.Color.Red;
            }
            isValid &= isInputNotValid(lblState, txtPhone);
            isValid &= isInputNotValid(lblEmail, txtEmail);
            isValid &= isInputNotValid(lblState, txtState);
            isValid &= isInputNotValid(lblLastVisitDate, dtpLastVisitDate);
            isValid &= isInputNotValid(lblRoom, txtRoom);

            return isValid;
        }
        private void clearForm()
        {
            lblLName.ForeColor = System.Drawing.Color.Black;
            lblFName.ForeColor = System.Drawing.Color.Black;
            lblStreet.ForeColor = System.Drawing.Color.Black;
            lblState.ForeColor = System.Drawing.Color.Black;
            lblZip.ForeColor = System.Drawing.Color.Black;
            lblPhone.ForeColor = System.Drawing.Color.Black;
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblCity.ForeColor = System.Drawing.Color.Black;
            lblRoom.ForeColor = System.Drawing.Color.Black;
            lblGuestId.ForeColor = System.Drawing.Color.Black;

            txtLName.Text = "";
            txtFName.Text = "";
            txtStreet.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            dtpLastVisitDate.Value = DateTime.Now;
            txtRoom.Text = "";
            txtGuestId.Text = "";
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ddlGuestsSelector.SelectedIndex != -1)
            {
                if (ValidateForm())
                {
                    int guestSelection = ((Guest)ddlGuestsSelector.SelectedItem).GuestId;
                    //build connection to Cottages
                    //create connection string for Cottages database
                    string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cottages.accdb";
                    //Create OldDbConnection
                    OleDbConnection dbConn;
                    try
                    {
                        dbConn = new OleDbConnection(sConnection);
                        //open connection to database
                        dbConn.Open();
                        //create query to select all rows from Person table
                        string sql = "UPDATE Guests SET FirstName = @FirstName, LastName = @LastName, Street = @Street, City = @City, State = @State, Zip = @Zip, Phone = @Phone, Email = @Email, LastVisitDate = @LastVisitDate, Room = @Room WHERE GuestID = @GuestID";
                        //create database command
                        OleDbCommand dbCmd = new OleDbCommand();

                        //set command SQL string
                        dbCmd.CommandText = sql;
                        //set the command connection
                        dbCmd.Connection = dbConn;

                        //bind parameters
                        dbCmd.Parameters.AddWithValue("@LastName", txtLName.Text);
                        dbCmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
                        dbCmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                        dbCmd.Parameters.AddWithValue("@City", txtCity.Text);
                        dbCmd.Parameters.AddWithValue("@State", txtState.Text);
                        dbCmd.Parameters.AddWithValue("@Zip", txtZip.Text);
                        dbCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        dbCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        dbCmd.Parameters.AddWithValue("@LastVisitDate", dtpLastVisitDate.Value); // Assuming LastVisitDate is a DateTime type
                        dbCmd.Parameters.AddWithValue("@Room", txtRoom.Text);
                        dbCmd.Parameters.AddWithValue("@GuestID", guestSelection);

                        //execute insert. Check to see how many rows were affected
                        int rowCount = dbCmd.ExecuteNonQuery();

                        //close database connection
                        dbConn.Close();
                        if (rowCount == 1)
                        {
                            MessageBox.Show("Record inserted successfully");
                            //this is where I want to update frmMain
                        
                            loadGuests();
                        }
                        else
                        {
                            MessageBox.Show("Error inserting record. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                clearForm();
            }
            else
            {
                MessageBox.Show("You have to have a Guest Selected before to edit a Guest");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (ddlGuestsSelector.SelectedIndex != -1)
            {
                //Check to see if they want to update the curren record
                DialogResult result = MessageBox.Show("Do you want to delete this record?", "Delete Record",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int guestSelection = ((Guest)ddlGuestsSelector.SelectedItem).GuestId;
                    //build connection to Cottages
                    //create connection string for Cottages database
                    string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cottages.accdb";

                    //Create OldDbConnection
                    OleDbConnection dbConn;
                    try
                    {
                        dbConn = new OleDbConnection(sConnection);
                        //open connection to database
                        dbConn.Open();
                        //create query to update selected person record
                        string sql;
                        sql = "Delete from Guests where GuestID = @GuestId";

                        //create database command
                        OleDbCommand dbCmd = new OleDbCommand();

                        //set command SQL string
                        dbCmd.CommandText = sql;
                        //set the command connection
                        dbCmd.Connection = dbConn;

                        //bind parameters
                        dbCmd.Parameters.AddWithValue("@GuestId", guestSelection);

                        //execute update. Check to see how many rows were affected
                        int rowCount = dbCmd.ExecuteNonQuery();

                        //close database connection
                        dbConn.Close();

                        if (rowCount == 1)
                        {
                            MessageBox.Show("Record deleted successfully");
                            loadGuests();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting record. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    clearForm();
                }
            }
            else
            {
                MessageBox.Show("You have to have a Guest Selected before deleting a Guest");

            }
        }
    }
}
