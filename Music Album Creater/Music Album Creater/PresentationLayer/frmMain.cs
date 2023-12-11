using Music_Album_Creater.BusinessObject;
using Music_Album_Creater.PresentationLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Music_Album_Creater
{
    public partial class frmMain : Form
    {
        // this is set to true which makes the to verify if they want to exit the program if they try to exit with one of other windows opened
        public static bool isEditing = false;


        public frmMain()
        {
            InitializeComponent();
            cmbPub.DataSource = Album.MusicPublishers;
            ddlGenre.DataSource = Album.MusicGenres;
            cmbPub.SelectedIndex = -1;
            ddlGenre.SelectedIndex = -1;
        }

        //Opens the page to view the created albums
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmView fView = new frmView();
            fView.Show();
        }

        //Away to the exit the program
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {

            
            bool isValid = true;

            //validates if txtTitle is filled out or else it would show message right beside the label of the requirment. it get turned off once filled out and submited again
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                lblTitleError.Visible = false;
            } 
            else
            {
                lblTitleError.Visible = true;
                isValid = false;
            }

            //validates if txtArtist is filled out or else it would show message right beside the label of the requirment. it get turned off once filled out and submited again

            if (!string.IsNullOrWhiteSpace(txtArtist.Text))
            {
                lblArtistError.Visible = false;
            }
            else
            {
                lblArtistError.Visible = true;
                isValid = false;
            }
            //validates if cmbPub is filled out or else it would show message right beside the label of the requirment. it get turned off once filled out and submited again

            if (!string.IsNullOrWhiteSpace(cmbPub.Text))
            {
                lblPubError.Visible = false;
            }
            else
            {
                lblPubError.Visible = true;
                isValid = false;
            }
            //validates if ddlGenre is filled out or else it would show message right beside the label of the requirment. it get turned off once filled out and submited again

            if (!string.IsNullOrWhiteSpace(ddlGenre.Text))
            {
                lblGenreError.Visible = false;

            }
            else
            {
                lblGenreError.Visible = true;
                isValid = false;
            }

            //validates if TempSongs has songs in it is filled out or else it would show message right beside the label of the requirment. it get turned off once filled out and submited again

            if (!(Song.TempSongs.Count() <= 0))
            {
                lblSongError.Visible = false;
            }
            else
            {
                lblSongError.Visible = true;
                isValid = false;
            }


            if (isValid)
            { 
                Album album = new Album(txtTitle.Text, txtArtist.Text, cmbPub.Text, ddlGenre.Text, Song.TempSongs);
                Album.Albums.Add(album);
                MessageBox.Show("Album " + album.AlbumTitle + " created successfully.");


                cmbPub.SelectedIndex = -1;
                ddlGenre.SelectedIndex = -1;
                cmbPub.Text = "";
                txtArtist.Text = "";
                txtTitle .Text = "";
                Song.TempSongs.Clear();
                lstSongs.Items.Clear();

            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            frmSong fSong = new frmSong();
            fSong.ShowDialog();
            //Checks if the song name and song lyrics isn't empty before adding
            if (!string.IsNullOrWhiteSpace(fSong.SongName) && !string.IsNullOrWhiteSpace(fSong.SongLyrics))
            {
                Song song = new Song(fSong.SongName, fSong.SongLyrics);
                Song.TempSongs.Add(song);
                lstSongs.Items.Add(song.title);
            }

        }
        //double clicking will open the lstSongsContextMenuStrip and displays the viewing, editing, deleting, and adding buttons
        private void lstSongs_DoubleClick(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                lstSongsContextMenuStrip.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }
        //This button picks up the opens a form and which always people to add a song

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddSong_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                DialogResult result = MessageBox.Show("Are your sure you want to delete this song? \n The song will be gone forever!!!", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string title = Song.TempSongs[index].title;
                    Song.TempSongs.RemoveAt(index);
                    lstSongs.Items.RemoveAt(index);
                    MessageBox.Show("The song " + title + "was Deleted!!!");
                }
            }
        }
        //This button picks up the opens a form and which always people to edit a song

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                //open the frmSong form page in editing mode. which is determent by the boolean in the constructor
                frmSong fSong = new frmSong(Song.TempSongs[index].title, Song.TempSongs[index].lyrics, true);
                fSong.ShowDialog();
                if (fSong.DialogResult == DialogResult.Yes)
                {
                    string title = Song.TempSongs[index].title;
                    Song song = new Song(fSong.SongName, fSong.SongLyrics);

                    Song.TempSongs[index] = song;
                    lstSongs.Items[index] = fSong.SongName;
                    MessageBox.Show("The song" + title + "'s changes were saved!!!");
                }
            }
        }
        //This button picks up the opens a form and view the song and gives a option to delete the song as well.

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                //open the frmSong form page in readonly mode. which is determent by the boolean in the constructor
                frmSong fSong = new frmSong(Song.TempSongs[index].title, Song.TempSongs[index].lyrics, false);
                fSong.ShowDialog();
                if (fSong.DialogResult == DialogResult.Yes)
                {
                    string title = Song.TempSongs[index].title;
                    Song.TempSongs.RemoveAt(index);
                    lstSongs.Items.RemoveAt(index);
                    MessageBox.Show("The song " + title + "was Deleted!!!");
                }
            }
        }


        //This is a safety stop for if someone is filling out a form it will stop the event from happing if they dont want to exit.
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Checks to see if there information filled out. if so then it will ask if there sure if they want to close the application
            if (!string.IsNullOrWhiteSpace(txtArtist.Text)
                || !string.IsNullOrWhiteSpace(txtTitle.Text)
                || !string.IsNullOrWhiteSpace(cmbPub.Text)
                || !string.IsNullOrWhiteSpace(ddlGenre.Text)
                || isEditing)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard these changes?", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEdit fEdit = new frmEdit();
            fEdit.Show();
        }
    }
}
