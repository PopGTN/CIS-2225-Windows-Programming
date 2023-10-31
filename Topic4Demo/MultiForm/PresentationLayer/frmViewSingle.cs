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
    public partial class frmViewSingle : Form
    {
        public frmViewSingle()
        {
            InitializeComponent();
        }

        public frmViewSingle(Person person)
        {
            InitializeComponent();
            txtName.Text = person.Name;
            txtAge.Text = person.Age.ToString();
            txtHairColor.Text = person.HairColor;
            txtEyeColor.Text = person.EyeColor;
            txtCountry.Text = person.Country;
        }

        public frmViewSingle(string name, int age, string hColor, string eColor, string country)
        {
            InitializeComponent();
            txtName.Text = name;
            txtAge.Text = age.ToString();
            txtHairColor.Text = hColor;
            txtEyeColor.Text = eColor;
            txtCountry.Text = country;
        }
    }
}
