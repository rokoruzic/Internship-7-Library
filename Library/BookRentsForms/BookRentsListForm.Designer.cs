namespace Library.BookRentsForms
{
    partial class BookRentsListForm
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
            this.bookRentActiveListBox = new System.Windows.Forms.ListBox();
            this.currentlyRentedBooksLabel = new System.Windows.Forms.Label();
            this.booksToRentLabel = new System.Windows.Forms.Label();
            this.booksRentNotActiveListBox = new System.Windows.Forms.ListBox();
            this.addBookRentButton = new System.Windows.Forms.Button();
            this.viewBookRentButton = new System.Windows.Forms.Button();
            this.deleteBookRentButton = new System.Windows.Forms.Button();
            this.editBookRentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookRentActiveListBox
            // 
            this.bookRentActiveListBox.FormattingEnabled = true;
            this.bookRentActiveListBox.ItemHeight = 16;
            this.bookRentActiveListBox.Location = new System.Drawing.Point(12, 54);
            this.bookRentActiveListBox.Name = "bookRentActiveListBox";
            this.bookRentActiveListBox.Size = new System.Drawing.Size(260, 308);
            this.bookRentActiveListBox.TabIndex = 0;
            this.bookRentActiveListBox.Click += new System.EventHandler(this.BookRentActiveListBoxReset);
            // 
            // currentlyRentedBooksLabel
            // 
            this.currentlyRentedBooksLabel.AutoSize = true;
            this.currentlyRentedBooksLabel.Location = new System.Drawing.Point(12, 23);
            this.currentlyRentedBooksLabel.Name = "currentlyRentedBooksLabel";
            this.currentlyRentedBooksLabel.Size = new System.Drawing.Size(46, 17);
            this.currentlyRentedBooksLabel.TabIndex = 1;
            this.currentlyRentedBooksLabel.Text = "label1";
            // 
            // booksToRentLabel
            // 
            this.booksToRentLabel.AutoSize = true;
            this.booksToRentLabel.Location = new System.Drawing.Point(314, 23);
            this.booksToRentLabel.Name = "booksToRentLabel";
            this.booksToRentLabel.Size = new System.Drawing.Size(46, 17);
            this.booksToRentLabel.TabIndex = 2;
            this.booksToRentLabel.Text = "label1";
            // 
            // booksRentNotActiveListBox
            // 
            this.booksRentNotActiveListBox.FormattingEnabled = true;
            this.booksRentNotActiveListBox.ItemHeight = 16;
            this.booksRentNotActiveListBox.Location = new System.Drawing.Point(317, 54);
            this.booksRentNotActiveListBox.Name = "booksRentNotActiveListBox";
            this.booksRentNotActiveListBox.Size = new System.Drawing.Size(303, 308);
            this.booksRentNotActiveListBox.TabIndex = 3;
            this.booksRentNotActiveListBox.Click += new System.EventHandler(this.BooksRentNotActiveListBoxReset);
            // 
            // addBookRentButton
            // 
            this.addBookRentButton.Location = new System.Drawing.Point(677, 54);
            this.addBookRentButton.Name = "addBookRentButton";
            this.addBookRentButton.Size = new System.Drawing.Size(75, 23);
            this.addBookRentButton.TabIndex = 4;
            this.addBookRentButton.Text = "Add";
            this.addBookRentButton.UseVisualStyleBackColor = true;
            this.addBookRentButton.Click += new System.EventHandler(this.AddBookRentButtonClick);
            // 
            // viewBookRentButton
            // 
            this.viewBookRentButton.Location = new System.Drawing.Point(677, 241);
            this.viewBookRentButton.Name = "viewBookRentButton";
            this.viewBookRentButton.Size = new System.Drawing.Size(75, 23);
            this.viewBookRentButton.TabIndex = 5;
            this.viewBookRentButton.Text = "View";
            this.viewBookRentButton.UseVisualStyleBackColor = true;
            // 
            // deleteBookRentButton
            // 
            this.deleteBookRentButton.Location = new System.Drawing.Point(677, 179);
            this.deleteBookRentButton.Name = "deleteBookRentButton";
            this.deleteBookRentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBookRentButton.TabIndex = 6;
            this.deleteBookRentButton.Text = "Delete";
            this.deleteBookRentButton.UseVisualStyleBackColor = true;
            // 
            // editBookRentButton
            // 
            this.editBookRentButton.Location = new System.Drawing.Point(677, 114);
            this.editBookRentButton.Name = "editBookRentButton";
            this.editBookRentButton.Size = new System.Drawing.Size(75, 23);
            this.editBookRentButton.TabIndex = 7;
            this.editBookRentButton.Text = "Edit";
            this.editBookRentButton.UseVisualStyleBackColor = true;
            this.editBookRentButton.Click += new System.EventHandler(this.EditBookRentButtonClick);
            // 
            // BookRentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBookRentButton);
            this.Controls.Add(this.deleteBookRentButton);
            this.Controls.Add(this.viewBookRentButton);
            this.Controls.Add(this.addBookRentButton);
            this.Controls.Add(this.booksRentNotActiveListBox);
            this.Controls.Add(this.booksToRentLabel);
            this.Controls.Add(this.currentlyRentedBooksLabel);
            this.Controls.Add(this.bookRentActiveListBox);
            this.Name = "BookRentsListForm";
            this.Text = "BookRentsListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookRentActiveListBox;
        private System.Windows.Forms.Label currentlyRentedBooksLabel;
        private System.Windows.Forms.Label booksToRentLabel;
        private System.Windows.Forms.ListBox booksRentNotActiveListBox;
        private System.Windows.Forms.Button addBookRentButton;
        private System.Windows.Forms.Button viewBookRentButton;
        private System.Windows.Forms.Button deleteBookRentButton;
        private System.Windows.Forms.Button editBookRentButton;
    }
}