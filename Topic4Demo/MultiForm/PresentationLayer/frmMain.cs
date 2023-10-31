using MultiForm.BusinessLayer;
using MultiForm.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmView fView = new frmView();
            fView.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit fEdit = new frmEdit();
            fEdit.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //create Person object
                Person personOne = new Person();
                personOne.Name = txtName.Text;
                personOne.HairColor = txtHairColor.Text;
                personOne.EyeColor = txtEyeColor.Text;
                personOne.Age = int.Parse(txtAge.Text);
                personOne.Country = cmbCountries.Text;

                Person.people.Add(personOne);
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtAge.Clear();
            txtName.Clear();
            txtHairColor.Clear();
            txtEyeColor.Clear();
            cmbCountries.Text = "";
            cmbCountries.SelectedIndex = -1;
        }

        private bool ValidateForm()
        {
            bool formOK = true;
            if (String.IsNullOrEmpty(txtName.Text))
            {
                formOK = false;
                lblName.ForeColor = Color.Red;
            }
            else 
            {
                lblName.ForeColor = Color.Black;
            }
            if (String.IsNullOrEmpty(txtHairColor.Text))
            {
                formOK = false;
                lblHairColor.ForeColor = Color.Red;
            }
            else
            {
                lblHairColor.ForeColor = Color.Black;
            }
            if (String.IsNullOrEmpty(txtEyeColor.Text))
            {
                formOK = false;
                lblEyeColor.ForeColor = Color.Red;
            }
            else
            {
                lblEyeColor.ForeColor = Color.Black;
            }
            if (!int.TryParse(txtAge.Text, out int age))
            {
                formOK = false;
                lblAge.ForeColor = Color.Red;
            }
            else
            {
                lblAge.ForeColor = Color.Black;
            }
            if (cmbCountries.SelectedIndex < 0)
            {
                formOK = false;
                lblCountry.ForeColor = Color.Red;
            }
            else
            {
                lblCountry.ForeColor = Color.Black;
            }

            return formOK;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbCountries.Items.AddRange(Person.countries);
        }
    }
}
