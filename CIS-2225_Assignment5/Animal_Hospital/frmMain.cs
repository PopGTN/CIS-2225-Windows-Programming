﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHospitalLibrary;
namespace Animal_Hospital
{
    public partial class frmMain : Form
    {
        /*
         * Fix link to AnimalHospitalLibrary.dll
         * Fix tab order on Dog Tab
         * Build Cat and Horse tabs the same as dog tab but creating Cat and Horse objects
         * Build the refreshPatientDisplay method to display the animals saved in the Animal.animals list
         * 
         * 
         */
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //populate all animal type combo boxes here
            foreach (string dogType in Dog.DOG_TYPES)
            {
                cbDogType.Items.Add(dogType);
            }
            cbHorseType.DataSource = Horse.HORSE_TYPES;
            cbCatType.DataSource = Cat.CAT_TYPES;
            cbDogType.DataSource = Dog.DOG_TYPES;
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            if (validateDog())
            {
                Dog newDog = new Dog(txtDogName.Text, int.Parse(txtDogNumLegs.Text), dtpDogVisit.Text,
                    txtDogVisitReason.Text, txtDogColor.Text, cbDogType.SelectedItem.ToString());

                //Add dog to list of animals from Animal class
                Animal.animals.Add(newDog);

                //Refresh list of Patients
                refreshPatientDisplay();

                //Call the abstract method AnimalTalk
                MessageBox.Show(newDog.AnimalTalk());

                //Clear the Dog tab after creating a new dog and adding it to list of Animals
                clearDog();
            }

        }

        private void clearDog()
        {
            txtDogName.Text = "";
            txtDogColor.Text = "";
            cbDogType.SelectedIndex = -1;
            txtDogNumLegs.Text = "";
            txtDogVisitReason.Text = "";
        }

        private void refreshPatientDisplay()
        {
            //use a foreach to loop through list of animals from Animal class and diplay all saved animals
            foreach (Animal animal in Animal.animals)
            {
                rtxtPatients.Text += animal.ToString() + "\n";
            }

        }

        private bool validateDog()
        {
            //Validate the Dog tab. Add missing data messages to errors strings
            //If the errors string > 0 then there are issues to be reported
            //Display the issues in a message box
            //If errors is not > 0 then no issues reported
            string errors = "";
            int.TryParse(txtDogNumLegs.Text, out int dNumLegs);

            if (dNumLegs == 0)
            {
                errors += "Number of legs is not correct.\r";
            }
            if (txtDogColor.Text == "")
            {
                errors += "Color is missing. \r";
            }
            if (txtDogName.Text == "")
            {
                errors += "Name is missing. \r";
            }
            if (txtDogVisitReason.Text == "")
            {
                errors += "Reason is missing. \r";
            }
            if (cbDogType.SelectedIndex == -1)
            {
                errors += "Dog type is missing. \r";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors);
                return false;
            }
            else
            {
                return true;
            }
        }
        /**************************************
         * Cat Tab Methods
         **************************************/
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (validateCat())
            {
                Cat newCat = new Cat(txtCatName.Text, int.Parse(txtCatLegs.Text), dtpCat.Text,
                    txtCatReason.Text, txtCatColor.Text, cbCatType.SelectedItem.ToString());

                //Add dog to list of animals from Animal class
                Animal.animals.Add(newCat);

                //Refresh list of Patients
                refreshPatientDisplay();

                //Call the abstract method AnimalTalk
                MessageBox.Show(newCat.AnimalTalk());

                //Clear the Dog tab after creating a new dog and adding it to list of Animals
                clearCat();
            }
        }

        private void clearCat()
        {
            txtCatName.Text = "";
            txtCatColor.Text = "";
            cbCatType.SelectedIndex = -1;
            txtCatLegs.Text = "";
            txtCatReason.Text = "";
        }

        private bool validateCat()
        {
            //Validate the Dog tab. Add missing data messages to errors strings
            //If the errors string > 0 then there are issues to be reported
            //Display the issues in a message box
            //If errors is not > 0 then no issues reported
            string errors = "";
            int.TryParse(txtCatLegs.Text, out int dNumLegs);



            if (dNumLegs == 0)
            {
                errors += "Number of legs is not correct.\r";
            }
            if (txtCatColor.Text == "")
            {
                errors += "Color is missing. \r";
            }
            if (txtCatName.Text == "")
            {
                errors += "Name is missing. \r";
            }
            if (txtCatReason.Text == "")
            {
                errors += "Reason is missing. \r";
            }
            if (cbCatType.SelectedIndex == -1)
            {
                errors += "Cat type is missing. \r";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors);
                return false;
            }
            else
            {
                return true;
            }
        }

        /**************************************
           * Horse Tab Methods
           **************************************/
        private void btnAddHorse_Click(object sender, EventArgs e)
        {
            if (validateHorse())
            {
                Horse newHorse = new Horse(txtHorseName.Text, int.Parse(txtHorseLegs.Text), dtpHorse.Text,
                    txtHorseReason.Text, txtHorseColor.Text, cbHorseType.SelectedItem.ToString());

                //Add dog to list of animals from Animal class
                Animal.animals.Add(newHorse);

                //Refresh list of Patients
                refreshPatientDisplay();

                //Call the abstract method AnimalTalk
                MessageBox.Show(newHorse.AnimalTalk());

                //Clear the Dog tab after creating a new dog and adding it to list of Animals
                clearHorse();
            }

        }

        private void clearHorse()
        {
            txtHorseName.Text = "";
            txtHorseColor.Text = "";
            cbHorseType.SelectedIndex = -1;
            txtHorseLegs.Text = "";
            txtHorseReason.Text = "";
        }

        private bool validateHorse()
        {
            string errors = "";
            int.TryParse(txtHorseLegs.Text, out int dNumLegs);



            if (dNumLegs == 0)
            {
                errors += "Number of legs is not correct.\r";
            }
            if (txtHorseColor.Text == "")
            {
                errors += "Color is missing. \r";
            }
            if (txtHorseName.Text == "")
            {
                errors += "Name is missing. \r";
            }
            if (txtHorseReason.Text == "")
            {
                errors += "Reason is missing. \r";
            }
            if (cbHorseType.SelectedIndex == -1)
            {
                errors += "Horse type is missing. \r";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
