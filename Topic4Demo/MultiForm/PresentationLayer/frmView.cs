using MultiForm.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm.PresentationLayer
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            if (Person.people.Count > 0)
            {
                lstPeople.Items.Clear();
                int counter = 0;
                foreach (Person p in Person.people)
                {
                    lstPeople.Items.Add(p.ToString());
                    counter++;
                    //each time an object is added to the 
                    rtbCounter.Text += counter + " times adding objects. \n";
                }
            }
        }
    }
}
