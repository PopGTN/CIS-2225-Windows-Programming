
namespace Music_Album_Creater
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lstSongsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArtistError = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPub = new System.Windows.Forms.ComboBox();
            this.lblPubError = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            this.lblGenreError = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSongError = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMenu.SuspendLayout();
            this.lstSongsContextMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.mnuMenu, "mnuMenu");
            this.mnuMenu.Name = "mnuMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            resources.ApplyResources(this.viewToolStripMenuItem1, "viewToolStripMenuItem1");
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            resources.ApplyResources(this.editToolStripMenuItem1, "editToolStripMenuItem1");
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            resources.ApplyResources(this.exitToolStripMenuItem1, "exitToolStripMenuItem1");
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lstSongs
            // 
            resources.ApplyResources(this.lstSongs, "lstSongs");
            this.lstSongs.ContextMenuStrip = this.lstSongsContextMenuStrip;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Name = "lstSongs";
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
            resources.ApplyResources(this.lstSongsContextMenuStrip, "lstSongsContextMenuStrip");
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblArtist
            // 
            resources.ApplyResources(this.lblArtist, "lblArtist");
            this.lblArtist.Name = "lblArtist";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblTitleError);
            this.panel2.Name = "panel2";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblTitleError
            // 
            resources.ApplyResources(this.lblTitleError, "lblTitleError");
            this.lblTitleError.ForeColor = System.Drawing.Color.Red;
            this.lblTitleError.Name = "lblTitleError";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lblArtistError);
            this.panel1.Controls.Add(this.txtArtist);
            this.panel1.Controls.Add(this.lblArtist);
            this.panel1.Name = "panel1";
            // 
            // lblArtistError
            // 
            resources.ApplyResources(this.lblArtistError, "lblArtistError");
            this.lblArtistError.ForeColor = System.Drawing.Color.Red;
            this.lblArtistError.Name = "lblArtistError";
            // 
            // txtArtist
            // 
            resources.ApplyResources(this.txtArtist, "txtArtist");
            this.txtArtist.Name = "txtArtist";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.cmbPub);
            this.panel3.Controls.Add(this.lblPubError);
            this.panel3.Controls.Add(this.lblPub);
            this.panel3.Name = "panel3";
            // 
            // cmbPub
            // 
            resources.ApplyResources(this.cmbPub, "cmbPub");
            this.cmbPub.FormattingEnabled = true;
            this.cmbPub.Name = "cmbPub";
            // 
            // lblPubError
            // 
            resources.ApplyResources(this.lblPubError, "lblPubError");
            this.lblPubError.ForeColor = System.Drawing.Color.Red;
            this.lblPubError.Name = "lblPubError";
            // 
            // lblPub
            // 
            resources.ApplyResources(this.lblPub, "lblPub");
            this.lblPub.Name = "lblPub";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.ddlGenre);
            this.panel4.Controls.Add(this.lblGenreError);
            this.panel4.Controls.Add(this.lblGenre);
            this.panel4.Name = "panel4";
            // 
            // ddlGenre
            // 
            resources.ApplyResources(this.ddlGenre, "ddlGenre");
            this.ddlGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Name = "ddlGenre";
            // 
            // lblGenreError
            // 
            resources.ApplyResources(this.lblGenreError, "lblGenreError");
            this.lblGenreError.ForeColor = System.Drawing.Color.Red;
            this.lblGenreError.Name = "lblGenreError";
            // 
            // lblGenre
            // 
            resources.ApplyResources(this.lblGenre, "lblGenre");
            this.lblGenre.Name = "lblGenre";
            // 
            // lblSongError
            // 
            resources.ApplyResources(this.lblSongError, "lblSongError");
            this.lblSongError.ForeColor = System.Drawing.Color.Red;
            this.lblSongError.Name = "lblSongError";
            // 
            // lblSongs
            // 
            resources.ApplyResources(this.lblSongs, "lblSongs");
            this.lblSongs.Name = "lblSongs";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAddSong
            // 
            resources.ApplyResources(this.btnAddSong, "btnAddSong");
            this.btnAddSong.CausesValidation = false;
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblSongError);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.lstSongsContextMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleError;
        private System.Windows.Forms.Label lblArtistError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPubError;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.ComboBox cmbPub;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox ddlGenre;
        private System.Windows.Forms.Label lblGenreError;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblSongError;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip lstSongsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

