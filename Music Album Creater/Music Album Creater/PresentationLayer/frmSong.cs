using System;
using System.Windows.Forms;

namespace Music_Album_Creater.PresentationLayer
{
    public partial class frmSong : Form
    {
        enum ViewingMode
        {
            Edit,
            Add,
            View
        }

        private ViewingMode Mode { get; set; }
        public string SongName { get; set; }
        public string SongLyrics { get; set; }

        public frmSong()
        {
            InitializeComponent();
            this.Text = "Adding a Song";
            Mode = ViewingMode.Add;
            DialogResult = DialogResult.None;
        }


        public frmSong(string songName, string SongLyrics, bool editing)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            if (editing)
            {
                Mode = ViewingMode.Edit;
                this.Text = "Edit Song";
                txtName.Text = songName;
                rtbLyrics.Text = SongLyrics;
                btnAdd.Text = "Save Changes";
            }
            else
            {
                Mode = ViewingMode.View;
                this.Text = "View Song";
                txtName.ReadOnly = true;
                rtbLyrics.ReadOnly = true;
                txtName.Text = songName;
                rtbLyrics.Text = SongLyrics;
                btnAdd.Text = "Delete Song";
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {

                lblNameError.Visible = false;
            }
            else
            {
                isValid = false;
                lblNameError.Visible = true;

            }

            if (!string.IsNullOrWhiteSpace(rtbLyrics.Text))
            {

                lblLyricsError.Visible = false;
            }
            else
            {
                isValid = false;
                lblLyricsError.Visible = true;

            }


            if (isValid && (Mode == ViewingMode.Add)) //if the page is in adding mode the button is clicked
            {
                DialogResult = DialogResult.OK;
                this.SongName = txtName.Text;
                this.SongLyrics = rtbLyrics.Text;
                this.Close();
            }
            else if (isValid && Mode == ViewingMode.Edit) //if the page is in editing mode the button is clicked
            {
                DialogResult result = MessageBox.Show("Are your sure you ok with these changes?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    DialogResult = result;
                    this.SongName = txtName.Text;
                    this.SongLyrics = rtbLyrics.Text;
                    this.Close();
                }

                this.DialogResult = result;
                this.Close();

            }
            else if (isValid && (Mode == ViewingMode.View))
            {
                DialogResult result = MessageBox.Show("Are your sure you want to delete this song? \n The song will be gone forever!!!", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {   
                    DialogResult = result;
                    this.Close();
                }

                DialogResult = result;
                this.Close();

            }
        }

        private void frmSong_FormClosing(object sender, FormClosingEventArgs e)
        {
 
            if ((DialogResult != DialogResult.Yes) && (Mode == ViewingMode.Edit) || (DialogResult != DialogResult.OK) && (Mode == ViewingMode.Add))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard these changes?", "", MessageBoxButtons.YesNo);

               
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                } 
            }
        }
    }
}
