namespace Library.StudentsForms
{
    partial class StudentsDetailsForm
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
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.bookRentsListBox = new System.Windows.Forms.ListBox();
            this.isRentActiveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(38, 54);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // bookRentsListBox
            // 
            this.bookRentsListBox.FormattingEnabled = true;
            this.bookRentsListBox.ItemHeight = 16;
            this.bookRentsListBox.Location = new System.Drawing.Point(448, 54);
            this.bookRentsListBox.Name = "bookRentsListBox";
            this.bookRentsListBox.Size = new System.Drawing.Size(246, 260);
            this.bookRentsListBox.TabIndex = 1;
            // 
            // isRentActiveTextBox
            // 
            this.isRentActiveTextBox.Location = new System.Drawing.Point(38, 108);
            this.isRentActiveTextBox.Name = "isRentActiveTextBox";
            this.isRentActiveTextBox.Size = new System.Drawing.Size(256, 22);
            this.isRentActiveTextBox.TabIndex = 2;
            // 
            // StudentsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isRentActiveTextBox);
            this.Controls.Add(this.bookRentsListBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Name = "StudentsDetailsForm";
            this.Text = "StudentsDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.ListBox bookRentsListBox;
        private System.Windows.Forms.TextBox isRentActiveTextBox;
    }
}