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
            this.bookRentsListBox = new System.Windows.Forms.ListBox();
            this.studentDetailsLabel = new System.Windows.Forms.Label();
            this.isRentActiveLabel = new System.Windows.Forms.Label();
            this.studentDetailsExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookRentsListBox
            // 
            this.bookRentsListBox.FormattingEnabled = true;
            this.bookRentsListBox.ItemHeight = 16;
            this.bookRentsListBox.Location = new System.Drawing.Point(38, 138);
            this.bookRentsListBox.Name = "bookRentsListBox";
            this.bookRentsListBox.Size = new System.Drawing.Size(631, 260);
            this.bookRentsListBox.TabIndex = 1;
            // 
            // studentDetailsLabel
            // 
            this.studentDetailsLabel.AutoSize = true;
            this.studentDetailsLabel.Location = new System.Drawing.Point(38, 32);
            this.studentDetailsLabel.Name = "studentDetailsLabel";
            this.studentDetailsLabel.Size = new System.Drawing.Size(46, 17);
            this.studentDetailsLabel.TabIndex = 3;
            this.studentDetailsLabel.Text = "label1";
            // 
            // isRentActiveLabel
            // 
            this.isRentActiveLabel.AutoSize = true;
            this.isRentActiveLabel.Location = new System.Drawing.Point(35, 73);
            this.isRentActiveLabel.Name = "isRentActiveLabel";
            this.isRentActiveLabel.Size = new System.Drawing.Size(46, 17);
            this.isRentActiveLabel.TabIndex = 4;
            this.isRentActiveLabel.Text = "label1";
            // 
            // studentDetailsExitButton
            // 
            this.studentDetailsExitButton.Location = new System.Drawing.Point(702, 271);
            this.studentDetailsExitButton.Name = "studentDetailsExitButton";
            this.studentDetailsExitButton.Size = new System.Drawing.Size(75, 23);
            this.studentDetailsExitButton.TabIndex = 5;
            this.studentDetailsExitButton.Text = "Exit";
            this.studentDetailsExitButton.UseVisualStyleBackColor = true;
            this.studentDetailsExitButton.Click += new System.EventHandler(this.StudentDetailsExitButtonClick);
            // 
            // StudentsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentDetailsExitButton);
            this.Controls.Add(this.isRentActiveLabel);
            this.Controls.Add(this.studentDetailsLabel);
            this.Controls.Add(this.bookRentsListBox);
            this.Name = "StudentsDetailsForm";
            this.Text = "StudentsDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox bookRentsListBox;
        private System.Windows.Forms.Label studentDetailsLabel;
        private System.Windows.Forms.Label isRentActiveLabel;
        private System.Windows.Forms.Button studentDetailsExitButton;
    }
}