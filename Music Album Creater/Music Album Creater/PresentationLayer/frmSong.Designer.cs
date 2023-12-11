
namespace Music_Album_Creater.PresentationLayer
{
    partial class frmSong
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
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.lblLyricsError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.AcceptsTab = true;
            this.rtbLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLyrics.AutoWordSelection = true;
            this.rtbLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbLyrics.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbLyrics.Location = new System.Drawing.Point(12, 127);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(312, 263);
            this.rtbLyrics.TabIndex = 0;
            this.rtbLyrics.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(312, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add song";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyrics.Location = new System.Drawing.Point(12, 105);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(44, 16);
            this.lblLyrics.TabIndex = 3;
            this.lblLyrics.Text = "Lyrics";
            // 
            // lblLyricsError
            // 
            this.lblLyricsError.AutoSize = true;
            this.lblLyricsError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyricsError.ForeColor = System.Drawing.Color.Red;
            this.lblLyricsError.Location = new System.Drawing.Point(54, 107);
            this.lblLyricsError.Name = "lblLyricsError";
            this.lblLyricsError.Size = new System.Drawing.Size(133, 14);
            this.lblLyricsError.TabIndex = 2;
            this.lblLyricsError.Text = "- You need to enter Lyrics";
            this.lblLyricsError.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add a Song";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSongTitle.Location = new System.Drawing.Point(12, 47);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(44, 16);
            this.lblSongTitle.TabIndex = 5;
            this.lblSongTitle.Text = "Name";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(54, 49);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(165, 14);
            this.lblNameError.TabIndex = 6;
            this.lblNameError.Text = "- You need to enter a song name";
            this.lblNameError.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(15, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 7;
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 435);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.lblLyricsError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbLyrics);
            this.Controls.Add(this.txtName);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 474);
            this.Name = "frmSong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSong_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.Label lblLyricsError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.TextBox txtName;
    }
}