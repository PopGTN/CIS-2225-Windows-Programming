
namespace MultiForm.PresentationLayer
{
    partial class frmView
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
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.rtbCounter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lstPeople
            // 
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.Location = new System.Drawing.Point(-1, 63);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(511, 95);
            this.lstPeople.TabIndex = 0;
            // 
            // rtbCounter
            // 
            this.rtbCounter.Location = new System.Drawing.Point(12, 187);
            this.rtbCounter.Name = "rtbCounter";
            this.rtbCounter.Size = new System.Drawing.Size(486, 96);
            this.rtbCounter.TabIndex = 1;
            this.rtbCounter.Text = "";
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.rtbCounter);
            this.Controls.Add(this.lstPeople);
            this.Name = "frmView";
            this.Text = "View";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.RichTextBox rtbCounter;
    }
}