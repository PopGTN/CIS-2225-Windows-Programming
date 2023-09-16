using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Author: Joshua Mckenna
 * DAte: 2023/09/15
 * Class: CIS-2225
 * Description: This is code to proccess button input from frmMain. It also calculates the averages of grades.
 */
namespace CIS2225Assignment1
{
    public partial class frmMain : Form
    {
        int gNumberOfCourse = 0;
        List<double> gListOfGrades = new List<double>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                //txtInputOne was empty or null
                MessageBox.Show("Please enter a course name.");
                txtCourse.Focus();
            } 
            else if (double.TryParse(txtGrade.Text, out double grade) == false)
            {
                MessageBox.Show("Please enter a number for the Grade");
                txtGrade.Focus();
            } 
            /* not sure if there is suppose to be a limit*/
            else if (grade < 0 /*|| grade > 100*/) 
            {
                MessageBox.Show("Please enter a grade as a number and not less than 0");
                txtGrade.Focus();
            } 
            else
            {
             
                lstOuputBox.Items.Add(txtCourse.Text + " - " + grade + " - " + GetGradeLetter(grade));
                gListOfGrades.Add(grade);
                txtCourse.Clear();
                txtGrade.Clear();
                
            }
        }


        private static char GetGradeLetter(double percentage)
        {
            if (percentage > 89)
            {
                return 'A';
            }
            else if (percentage > 79)
            {
                return 'B';
            }
            else if (percentage > 69)
            {
                return 'C';
            }
            else if (percentage > 59)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double listOfGrades = 0.0;
            foreach (double grades in gListOfGrades)
            {
                listOfGrades += grades;
            }
            double average = Math.Round(listOfGrades / gListOfGrades.Count, 2);

            MessageBox.Show("Average grade for " + gListOfGrades.Count + " courses is " + GetGradeLetter(average));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourse.Clear();
            txtGrade.Clear();
            lstOuputBox.Items.Clear();
            gListOfGrades.Clear();
        }
    }
}
