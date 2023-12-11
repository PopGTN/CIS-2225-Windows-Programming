using System.Windows.Forms;
using Music_Album_Creater.BusinessObject;

namespace Music_Album_Creater.PresentationLayer
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, System.EventArgs e)
        {
            rtbView.Text = "";
            foreach (Album album in Album.Albums)
            {
                rtbView.Text += album.ToString() + "\n";

            }
        }

        private void refreshToolStripMenuItem1_Click_1(object sender, System.EventArgs e)
        {
            rtbView.Text = "";
            foreach (Album album in Album.Albums)
            {
                rtbView.Text += album.ToString() + "\n";
            }
        }
    }
}
