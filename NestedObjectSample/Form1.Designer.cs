namespace NestedObjectSample
{
    partial class Form1
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
            this.lstInstructor = new System.Windows.Forms.ListBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstInstructor
            // 
            this.lstInstructor.FormattingEnabled = true;
            this.lstInstructor.Location = new System.Drawing.Point(29, 36);
            this.lstInstructor.Name = "lstInstructor";
            this.lstInstructor.Size = new System.Drawing.Size(220, 368);
            this.lstInstructor.TabIndex = 0;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(285, 36);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(213, 368);
            this.lstCourses.TabIndex = 3;
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(540, 36);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(222, 368);
            this.lstStudents.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lstInstructor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInstructor;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.ListBox lstStudents;
    }
}

