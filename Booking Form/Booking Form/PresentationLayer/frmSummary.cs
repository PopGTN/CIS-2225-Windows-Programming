using System.Windows.Forms;
using Booking_Form.BusinessLayer;
namespace Booking_Form.PresentationLayer
{
    public partial class frmSummary : Form
    {
        private Booking booking;

        public frmSummary()
        {
            InitializeComponent();
            Booking booking = new Booking();
        }

        public frmSummary(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
        }

        //loads the the passed in booking information if there is any and displatys it in the textboxs
        private void frmSummary_Load(object sender, System.EventArgs e)
        {
            if (booking != null)
            {
                txtVenue.Text = booking.VenueName;
                txtBandType.Text = booking.BandType;
                txtEmail.Text = booking.Email;
                txtEventSize.Text = booking.EventSize;
                txtFName.Text = booking.FirstName;
                txtLName.Text = booking.LastName;
                txtTotal.Text = "$" + booking.TotalCost.ToString();
            }
        }
    }
}
