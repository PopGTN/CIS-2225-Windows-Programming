using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web_IDE.PresentationLayer;

namespace Web_IDE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {  

            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMenu fMenu = new frmMenu();
            fMenu.ShowDialog();
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
