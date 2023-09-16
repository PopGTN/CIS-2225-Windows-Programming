
namespace CIS2225Assignment1
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
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOuputBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(109, 290);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(28, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(105, 77);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(79, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(105, 51);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(79, 20);
            this.txtCourse.TabIndex = 0;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(25, 54);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 5;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(25, 80);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(63, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstOuputBox
            // 
            this.lstOuputBox.FormattingEnabled = true;
            this.lstOuputBox.Location = new System.Drawing.Point(28, 150);
            this.lstOuputBox.Name = "lstOuputBox";
            this.lstOuputBox.Size = new System.Drawing.Size(156, 134);
            this.lstOuputBox.TabIndex = 2;
            this.lstOuputBox.TabStop = false;
            this.lstOuputBox.UseTabStops = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 400);
            this.Controls.Add(this.lstOuputBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAverage);
            this.Name = "frmMain";
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOuputBox;
    }
}

