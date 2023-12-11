using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace DataBaseConnectDemo
{
    public partial class frmInsertPerson : Form
    {
        public frmInsertPerson()
        {
            InitializeComponent();
        }
        //global of type frmMain
        frmMain mForm;

        public frmInsertPerson(frmMain passedForm)
        {
            InitializeComponent();
            mForm = passedForm;//refernce to frmMain form.
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //build connection to CISDB
                //create connection string for CISDB database
                string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=CISDB.accdb";
                //Create OldDbConnection
                OleDbConnection dbConn;
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to select all rows from Person table
                    string sql;
                    sql = "Insert into Person(FirstName, LastName) Values (@FirstName, @LastName);"; //note the two semicolons

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    dbCmd.Parameters.AddWithValue("@LastName", txtLastName.Text);

                    //execute insert. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully");
                        //this is where I want to update frmMain
                        mForm.PopulatePersonCombo();
                        this.Close();
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
        }

        private bool ValidateForm()
        {
            string errMsg = "";
            if (txtFirstName.Text == "")
            {
                errMsg = "Missing first name. \n"; 
            }
            if (txtLastName.Text == "")
            {
                errMsg = "Missing last name. \n";
            }
            if (errMsg.Length > 0)
            {
                MessageBox.Show(errMsg);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
