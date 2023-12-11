
namespace Music_Album_Creater.PresentationLayer
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSongs = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleError = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblArtistError = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbPub = new System.Windows.Forms.ComboBox();
            this.lblPubError = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            this.lblGenreError = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblSongError = new System.Windows.Forms.Label();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lstSongsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ddlAlbum = new System.Windows.Forms.ComboBox();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlEdit.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.lstSongsContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit a Album";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.lblSongs);
            this.pnlEdit.Controls.Add(this.flowLayoutPanel2);
            this.pnlEdit.Controls.Add(this.btnAddSong);
            this.pnlEdit.Controls.Add(this.lblSongError);
            this.pnlEdit.Controls.Add(this.lstSongs);
            this.pnlEdit.Controls.Add(this.flowLayoutPanel1);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEdit.Location = new System.Drawing.Point(0, 98);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(507, 569);
            this.pnlEdit.TabIndex = 0;
            this.pnlEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(12, 511);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(483, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSongs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSongs.Location = new System.Drawing.Point(12, 128);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(48, 16);
            this.lblSongs.TabIndex = 16;
            this.lblSongs.Text = "Songs";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 22);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(449, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(449, 103);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblTitleError);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 42);
            this.panel1.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTitle.Location = new System.Drawing.Point(3, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Album Title";
            // 
            // lblTitleError
            // 
            this.lblTitleError.AutoSize = true;
            this.lblTitleError.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblTitleError.ForeColor = System.Drawing.Color.Red;
            this.lblTitleError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleError.Location = new System.Drawing.Point(77, 2);
            this.lblTitleError.Name = "lblTitleError";
            this.lblTitleError.Size = new System.Drawing.Size(87, 14);
            this.lblTitleError.TabIndex = 1;
            this.lblTitleError.Text = "- Title is required";
            this.lblTitleError.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.lblArtistError);
            this.panel3.Controls.Add(this.txtArtist);
            this.panel3.Controls.Add(this.lblArtist);
            this.panel3.Location = new System.Drawing.Point(227, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 42);
            this.panel3.TabIndex = 1;
            // 
            // lblArtistError
            // 
            this.lblArtistError.AutoSize = true;
            this.lblArtistError.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblArtistError.ForeColor = System.Drawing.Color.Red;
            this.lblArtistError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblArtistError.Location = new System.Drawing.Point(40, 2);
            this.lblArtistError.Name = "lblArtistError";
            this.lblArtistError.Size = new System.Drawing.Size(93, 14);
            this.lblArtistError.TabIndex = 1;
            this.lblArtistError.Text = "- Artist is required";
            this.lblArtistError.Visible = false;
            // 
            // txtArtist
            // 
            this.txtArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtist.Location = new System.Drawing.Point(3, 19);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(212, 20);
            this.txtArtist.TabIndex = 2;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Arial", 10F);
            this.lblArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblArtist.Location = new System.Drawing.Point(3, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(40, 16);
            this.lblArtist.TabIndex = 0;
            this.lblArtist.Text = "Artist";
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.cmbPub);
            this.panel4.Controls.Add(this.lblPubError);
            this.panel4.Controls.Add(this.lblPub);
            this.panel4.Location = new System.Drawing.Point(3, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 44);
            this.panel4.TabIndex = 9;
            // 
            // cmbPub
            // 
            this.cmbPub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPub.FormattingEnabled = true;
            this.cmbPub.Location = new System.Drawing.Point(3, 20);
            this.cmbPub.Name = "cmbPub";
            this.cmbPub.Size = new System.Drawing.Size(212, 21);
            this.cmbPub.TabIndex = 2;
            // 
            // lblPubError
            // 
            this.lblPubError.AutoSize = true;
            this.lblPubError.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblPubError.ForeColor = System.Drawing.Color.Red;
            this.lblPubError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPubError.Location = new System.Drawing.Point(67, 2);
            this.lblPubError.Name = "lblPubError";
            this.lblPubError.Size = new System.Drawing.Size(112, 14);
            this.lblPubError.TabIndex = 1;
            this.lblPubError.Text = "- Publisher is required";
            this.lblPubError.Visible = false;
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPub.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPub.Location = new System.Drawing.Point(3, 0);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(67, 16);
            this.lblPub.TabIndex = 0;
            this.lblPub.Text = "Publisher";
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.ddlGenre);
            this.panel5.Controls.Add(this.lblGenreError);
            this.panel5.Controls.Add(this.lblGenre);
            this.panel5.Location = new System.Drawing.Point(227, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 44);
            this.panel5.TabIndex = 10;
            // 
            // ddlGenre
            // 
            this.ddlGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Location = new System.Drawing.Point(3, 20);
            this.ddlGenre.Name = "ddlGenre";
            this.ddlGenre.Size = new System.Drawing.Size(212, 21);
            this.ddlGenre.TabIndex = 2;
            // 
            // lblGenreError
            // 
            this.lblGenreError.AutoSize = true;
            this.lblGenreError.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblGenreError.ForeColor = System.Drawing.Color.Red;
            this.lblGenreError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGenreError.Location = new System.Drawing.Point(48, 1);
            this.lblGenreError.Name = "lblGenreError";
            this.lblGenreError.Size = new System.Drawing.Size(98, 14);
            this.lblGenreError.TabIndex = 1;
            this.lblGenreError.Text = "- Genre is required";
            this.lblGenreError.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGenre.Location = new System.Drawing.Point(3, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 16);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSong.AutoSize = true;
            this.btnAddSong.CausesValidation = false;
            this.btnAddSong.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddSong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddSong.Location = new System.Drawing.Point(371, 457);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(111, 29);
            this.btnAddSong.TabIndex = 20;
            this.btnAddSong.Text = "Create Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblSongError
            // 
            this.lblSongError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongError.AutoSize = true;
            this.lblSongError.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblSongError.ForeColor = System.Drawing.Color.Red;
            this.lblSongError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSongError.Location = new System.Drawing.Point(63, 130);
            this.lblSongError.Name = "lblSongError";
            this.lblSongError.Size = new System.Drawing.Size(98, 14);
            this.lblSongError.TabIndex = 18;
            this.lblSongError.Text = "- At least one song";
            this.lblSongError.Visible = false;
            // 
            // lstSongs
            // 
            this.lstSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSongs.ContextMenuStrip = this.lstSongsContextMenuStrip;
            this.lstSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 16;
            this.lstSongs.Location = new System.Drawing.Point(12, 149);
            this.lstSongs.MinimumSize = new System.Drawing.Size(478, 212);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(483, 324);
            this.lstSongs.TabIndex = 19;
            this.lstSongs.DoubleClick += new System.EventHandler(this.lstSongs_DoubleClick);
            // 
            // lstSongsContextMenuStrip
            // 
            this.lstSongsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lstSongsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.lstSongsContextMenuStrip.Name = "lstSongsContextMenuStrip";
            this.lstSongsContextMenuStrip.Size = new System.Drawing.Size(108, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // ddlAlbum
            // 
            this.ddlAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlAlbum.FormattingEnabled = true;
            this.ddlAlbum.Location = new System.Drawing.Point(177, 63);
            this.ddlAlbum.Name = "ddlAlbum";
            this.ddlAlbum.Size = new System.Drawing.Size(145, 21);
            this.ddlAlbum.TabIndex = 9;
            this.ddlAlbum.SelectedIndexChanged += new System.EventHandler(this.ddlAlbum_SelectedIndexChanged);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.refreshToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 667);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ddlAlbum);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(523, 706);
            this.Name = "frmEdit";
            this.Text = " Edit Albums";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.lstSongsContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblArtistError;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbPub;
        private System.Windows.Forms.Label lblPubError;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox ddlGenre;
        private System.Windows.Forms.Label lblGenreError;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label lblSongError;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip lstSongsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox ddlAlbum;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}