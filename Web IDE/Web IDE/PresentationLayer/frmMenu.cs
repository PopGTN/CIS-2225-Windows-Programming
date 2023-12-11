using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_IDE.PresentationLayer
{
    public partial class frmMenu : Form
    {
        bool closeApp = true;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            closeApp = false;
            this.Close();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApp)
            {
                Application.Exit();
            }
        }
    }
}
