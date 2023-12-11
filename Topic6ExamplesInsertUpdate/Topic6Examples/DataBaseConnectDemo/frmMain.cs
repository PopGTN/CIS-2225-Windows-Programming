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
using DataBaseConnectDemo.BusinessObjects;

/*
 * Add using System.Data.OleDb;
 * Install accessdatabaseengine_X64
   Change build architecture to x64
 */
namespace DataBaseConnectDemo
{
    /* November 23 Class
     *Remember CISDB gets copied to X64 debug directory each time you run. It will overwrite changes in that database.
        1.	Make person id combo box update with latest person id
        2.	Add Age, Middle Name and Date of Birth to Person table
        3.	Update application to insert, update and display all the columns from Person table.
    How do you delete a record?
     */
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //build connection to CISDB
        //create connection string for CISDB database
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=CISDB.accdb";
        //Create OldDbConnection
        OleDbConnection dbConn;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Populate the select person combo box with the person id from Person table
            
            PopulatePersonCombo();
        }

        public void PopulatePersonCombo()
        {
            ClearForm();
            
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Person table
                string sql;
                sql = "SELECT PersonId, FirstName from Person;"; //note the two semicolons

                OleDbCommand dbCmd = new OleDbCommand();
                //set command SQL string
                dbCmd.CommandText = sql;
                //set the command connection
                dbCmd.Connection = dbConn;
                //create OleDbDataReader dbReader
                OleDbDataReader dbReader;
                //Read data into dbReader
                dbReader = dbCmd.ExecuteReader();
                //Read first record
                while (dbReader.Read())
                {
                    //Create a person object populate the firstName and personId attibutes
                    Person per = new Person(dbReader["FirstName"].ToString(), (int)dbReader["PersonId"]);
                    
                    //load the Person object per into the combobox
                    //when displayed the combo box will call toString by default on the Person object.
                    //the toString only displays the FirstName of the person.
                    cbPersonSelector.Items.Add(per);
                }
                //close Reader
                dbReader.Close();
                //close database connection
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearForm()
        {
            cbPersonSelector.Items.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPersonId.Clear();
        }

        private void cbPersonSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Call method to populate the form based off the selection from cbPersonSelector
            PopulatePerson();
        }

        private void PopulatePerson()
        {
            //the combobox is populated with Person objects. Cast the selected value as a Person and then you can 
            //access the public property PersonId;
            int personSelection = ((Person)cbPersonSelector.SelectedItem).PersonId;
            
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Person table
                string sql;

                //Add a subquery to get the record count
                //Using a variable to identify the PersonId to search for
                sql = "SELECT(Select count(PersonId) from Person where PersonId = " + personSelection + ") " +
                        "as rowCount, * from Person where PersonId = " + personSelection + ";"; //note the two semicolons
                OleDbCommand dbCmd = new OleDbCommand();
                
                //set command SQL string
                dbCmd.CommandText = sql;
                
                //set the command connection
                dbCmd.Connection = dbConn;

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
                    //get data from dbReader by column name and assing to text boxes
                    txtFirstName.Text = dbReader["FirstName"].ToString();
                    txtLastName.Text = dbReader["LastName"].ToString();
                    txtPersonId.Text = dbReader["PersonId"].ToString();
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

        private void createNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertPerson frmInsert = new frmInsertPerson(this);
            frmInsert.Show();
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check to see if they want to update the curren record
            DialogResult result = MessageBox.Show("Do you want to update this record?", "Update Record", 
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //update the record
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to update selected person record
                    string sql;
                    sql = "Update Person set FirstName = @FirstName, LastName = @LastName where PersonId = @PersonId";

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    dbCmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    dbCmd.Parameters.AddWithValue("@PersonId", txtPersonId.Text);

                    //execute update. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error updating record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check to see if they want to update the curren record
            DialogResult result = MessageBox.Show("Do you want to delete this record?", "Delete Record",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //update the record
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to update selected person record
                    string sql;
                    sql = "Delete from Person where PersonId = @PersonId";

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@PersonId", txtPersonId.Text);

                    //execute update. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record deleted successfully");
                        PopulatePersonCombo();
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
            }
        }
    }
}
