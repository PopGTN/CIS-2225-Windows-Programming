using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiForm.BusinessLayer;

namespace MultiForm.PresentationLayer
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            PopulatecmbPeople();
            cmbCountries.Items.AddRange(Person.countries);
        }

        private void cmbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeople.SelectedIndex >= 0)
            {
                txtName.Text = Person.people[cmbPeople.SelectedIndex].Name;
                txtAge.Text = Person.people[cmbPeople.SelectedIndex].Age.ToString();
                txtEyeColor.Text = Person.people[cmbPeople.SelectedIndex].EyeColor;
                txtHairColor.Text = Person.people[cmbPeople.SelectedIndex].HairColor;
                cmbCountries.Text = Person.people[cmbPeople.SelectedIndex].Country;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ValidateForm
            Person.people[cmbPeople.SelectedIndex].Name = txtName.Text;
            Person.people[cmbPeople.SelectedIndex].Age = int.Parse(txtAge.Text);
            Person.people[cmbPeople.SelectedIndex].EyeColor = txtEyeColor.Text;
            Person.people[cmbPeople.SelectedIndex].HairColor = txtHairColor.Text;
            Person.people[cmbPeople.SelectedIndex].Country = cmbCountries.Text;
            ClearForm();
            ResetcmbPeople();

        }

        private void ResetcmbPeople()
        {
            cmbPeople.SelectedIndex = -1;
            cmbPeople.Items.Clear();
            //cmbPeople.Text = "";
            PopulatecmbPeople();
            
        }

        private void PopulatecmbPeople()
        {
            if (Person.people.Count > 0)
            {
                foreach (Person p in Person.people)
                {
                    cmbPeople.Items.Add(p.Name);
                }
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAge.Clear();
            txtHairColor.Clear();
            txtEyeColor.Clear();
            cmbCountries.Text = "";
            cmbCountries.SelectedIndex = -1;
        }

        private void btnPassObject_Click(object sender, EventArgs e)
        {
            //Make sure a person is selected
            frmViewSingle fVSingle = new frmViewSingle(Person.people[cmbPeople.SelectedIndex]);
            fVSingle.Show();
        }

        private void btnPassParams_Click(object sender, EventArgs e)
        {
            frmViewSingle fVSingle = new frmViewSingle(txtName.Text, int.Parse(txtAge.Text), txtHairColor.Text, txtEyeColor.Text, cmbCountries.Text);
            fVSingle.Show();
        }
    }
}
