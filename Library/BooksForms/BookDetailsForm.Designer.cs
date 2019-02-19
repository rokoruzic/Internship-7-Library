namespace Library.BooksForms
{
    partial class BookDetailsForm
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
            this.bookCopiesLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.currentlyRentedBooksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookCopiesLabel
            // 
            this.bookCopiesLabel.AutoSize = true;
            this.bookCopiesLabel.Location = new System.Drawing.Point(13, 148);
            this.bookCopiesLabel.Name = "bookCopiesLabel";
            this.bookCopiesLabel.Size = new System.Drawing.Size(46, 17);
            this.bookCopiesLabel.TabIndex = 1;
            this.bookCopiesLabel.Text = "label1";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(12, 51);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(46, 17);
            this.bookNameLabel.TabIndex = 2;
            this.bookNameLabel.Text = "label1";
            // 
            // currentlyRentedBooksListBox
            // 
            this.currentlyRentedBooksListBox.FormattingEnabled = true;
            this.currentlyRentedBooksListBox.ItemHeight = 16;
            this.currentlyRentedBooksListBox.Location = new System.Drawing.Point(15, 193);
            this.currentlyRentedBooksListBox.Name = "currentlyRentedBooksListBox";
            this.currentlyRentedBooksListBox.Size = new System.Drawing.Size(727, 228);
            this.currentlyRentedBooksListBox.TabIndex = 3;
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentlyRentedBooksListBox);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.bookCopiesLabel);
            this.Name = "BookDetailsForm";
            this.Text = "BookDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookCopiesLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.ListBox currentlyRentedBooksListBox;
    }
}