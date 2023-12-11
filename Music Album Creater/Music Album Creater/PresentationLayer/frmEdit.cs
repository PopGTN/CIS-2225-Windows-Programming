using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Music_Album_Creater.BusinessObject;

namespace Music_Album_Creater.PresentationLayer
{
    public partial class frmEdit : Form
    {
        private int index;

        private List<Song> tempSongs = new List<Song>();

        public frmEdit()
        {
            InitializeComponent();
        }

        //loads all the important information in the ddls and CMBs
        private void frmEdit_Load(object sender, System.EventArgs e)
        {
            //ddlAlbum.DataSource = Album.Albums;

            foreach (Album album in Album.Albums)
            {
                ddlAlbum.Items.Add(album.AlbumTitle);
            }
            ddlAlbum.SelectedIndex = -1;
            cmbPub.DataSource = Album.MusicPublishers;
            ddlGenre.DataSource = Album.MusicGenres;
            cmbPub.SelectedIndex = -1;
            ddlGenre.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
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

            if (!(tempSongs.Count() <= 0))
            {
                lblSongError.Visible = false;
            }
            else
            {
                lblSongError.Visible = true;
                isValid = false;
            }


            //if everything is filled out the it updated and changes the album
            if (isValid)
            {
                string orginalTitle = Album.Albums[index].AlbumTitle;
                Album album = new Album(txtTitle.Text, txtArtist.Text, cmbPub.Text, ddlGenre.Text, tempSongs);
                Album.Albums[index] = album;
                MessageBox.Show("Album " + orginalTitle + " Edited successfully.");

                ddlAlbum.SelectedIndex = -1;
                frmMain.isEditing = false;
                pnlEdit.Visible = false;
                cmbPub.SelectedIndex = -1;
                ddlGenre.SelectedIndex = -1;
                cmbPub.Text = "";
                txtArtist.Text = "";
                txtTitle.Text = "";
                tempSongs.Clear();
                lstSongs.Items.Clear();

            }
        }
        //double clicking will open the lstSongsContextMenuStrip and displays the viewing, editing, deleting, and adding buttons
        private void lstSongs_DoubleClick(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                lstSongsContextMenuStrip.Show(new System.Drawing.Point(MousePosition.X, MousePosition.Y));
            }
        }


        // When the index change in ddlAlbum it grabs the album and displays the input feilds to edit it
        private void ddlAlbum_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           if (ddlAlbum.SelectedIndex != -1)
            {
               
                frmMain.isEditing = true;

                this.index = ddlAlbum.SelectedIndex;
                lstSongs.Items.Clear();
                tempSongs = Album.Albums[this.index].Songs;

                foreach (Song song in tempSongs)
                {
                    lstSongs.Items.Add(song.title);
                }

                txtArtist.Text = Album.Albums[index].Artist;
                txtTitle.Text = Album.Albums[index].AlbumTitle;
                cmbPub.Text = Album.Albums[index].Publisher;
                int genreIndex = Album.MusicGenres.IndexOf(Album.Albums[index].Genre);
                ddlGenre.SelectedIndex = genreIndex;
                //Enable the panel that holds all the input fields for editing
                pnlEdit.Visible = true;
            }
        }

        //This button picks up the opens a form and which always people create a song
        private void btnAddSong_Click(object sender, System.EventArgs e)
        {
            frmSong fSong = new frmSong();
            fSong.ShowDialog();
            //Checks if the song name and song lyrics isn't empty before adding
            if (!string.IsNullOrWhiteSpace(fSong.SongName) && !string.IsNullOrWhiteSpace(fSong.SongLyrics))
            {
                Song song = new Song(fSong.SongName, fSong.SongLyrics);
                tempSongs.Add(song);
                lstSongs.Items.Add(song.title);
            }
        }
        //This button picks up the opens a form and which always people to add a song
        private void addToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnAddSong_Click(sender, e);
        }
        //This button picks up the opens a Messagebox and which always people to delete a song
        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                DialogResult result = MessageBox.Show("Are your sure you want to delete this song? \n The song will be gone forever!!!", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string title = tempSongs[index].title;
                    tempSongs.RemoveAt(index);
                    lstSongs.Items.RemoveAt(index);
                    MessageBox.Show("The song " + title + "was Deleted!!!");
                }
            }
        }
        //This button picks up the opens a form and view the song and gives a option to delete the song as well.
        private void viewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                //open the frmSong form page in readonly mode. which is determent by the boolean in the constructor
                frmSong fSong = new frmSong(tempSongs[index].title, tempSongs[index].lyrics, false);
                fSong.ShowDialog();
                if (fSong.DialogResult == DialogResult.Yes)
                {
                    string title = tempSongs[index].title;
                    tempSongs.RemoveAt(index);
                    lstSongs.Items.RemoveAt(index);
                    MessageBox.Show("The song " + title + "was Deleted!!!");
                }
            }
        }
        //This button picks up the opens a form and which always people to edit a song

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int index = lstSongs.SelectedIndex;

            if (index != -1)
            {
                //open the frmSong form page in editing mode. which is determent by the boolean in the constructor
                frmSong fSong = new frmSong(tempSongs[index].title, tempSongs[index].lyrics, true);
                fSong.ShowDialog();
                if (fSong.DialogResult == DialogResult.Yes)
                {
                    string title = tempSongs[index].title;
                    Song song = new Song(fSong.SongName, fSong.SongLyrics);

                    Song.TempSongs[index] = song;
                    lstSongs.Items[index] = fSong.SongName;
                    MessageBox.Show("The song" + title + "'s changes were saved!!!");
                }
            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ddlAlbum.Items.Clear();
            foreach (Album album in Album.Albums)
            {
                ddlAlbum.Items.Add(album.AlbumTitle);
            }
        }
    }
}
