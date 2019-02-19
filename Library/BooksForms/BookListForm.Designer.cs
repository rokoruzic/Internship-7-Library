namespace Library.BooksForms
{
    partial class BookListForm
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
            this.rentedBooksListBox = new System.Windows.Forms.ListBox();
            this.notRentedListBox = new System.Windows.Forms.ListBox();
            this.rentedBooksLabel = new System.Windows.Forms.Label();
            this.notRentedBooksLabel = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.viewBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.editBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rentedBooksListBox
            // 
            this.rentedBooksListBox.FormattingEnabled = true;
            this.rentedBooksListBox.ItemHeight = 16;
            this.rentedBooksListBox.Location = new System.Drawing.Point(12, 70);
            this.rentedBooksListBox.Name = "rentedBooksListBox";
            this.rentedBooksListBox.Size = new System.Drawing.Size(303, 308);
            this.rentedBooksListBox.TabIndex = 0;
            this.rentedBooksListBox.Click += new System.EventHandler(this.RentedBooksListBoxClick);
            // 
            // notRentedListBox
            // 
            this.notRentedListBox.FormattingEnabled = true;
            this.notRentedListBox.ItemHeight = 16;
            this.notRentedListBox.Location = new System.Drawing.Point(351, 70);
            this.notRentedListBox.Name = "notRentedListBox";
            this.notRentedListBox.Size = new System.Drawing.Size(292, 308);
            this.notRentedListBox.TabIndex = 1;
            this.notRentedListBox.Click += new System.EventHandler(this.NotRentedListBoxClick);
            // 
            // rentedBooksLabel
            // 
            this.rentedBooksLabel.AutoSize = true;
            this.rentedBooksLabel.Location = new System.Drawing.Point(12, 28);
            this.rentedBooksLabel.Name = "rentedBooksLabel";
            this.rentedBooksLabel.Size = new System.Drawing.Size(46, 17);
            this.rentedBooksLabel.TabIndex = 2;
            this.rentedBooksLabel.Text = "label1";
            // 
            // notRentedBooksLabel
            // 
            this.notRentedBooksLabel.AutoSize = true;
            this.notRentedBooksLabel.Location = new System.Drawing.Point(351, 28);
            this.notRentedBooksLabel.Name = "notRentedBooksLabel";
            this.notRentedBooksLabel.Size = new System.Drawing.Size(46, 17);
            this.notRentedBooksLabel.TabIndex = 3;
            this.notRentedBooksLabel.Text = "label2";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(692, 70);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 4;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookButtonClick);
            // 
            // viewBookButton
            // 
            this.viewBookButton.Location = new System.Drawing.Point(692, 228);
            this.viewBookButton.Name = "viewBookButton";
            this.viewBookButton.Size = new System.Drawing.Size(75, 23);
            this.viewBookButton.TabIndex = 5;
            this.viewBookButton.Text = "View";
            this.viewBookButton.UseVisualStyleBackColor = true;
            this.viewBookButton.Click += new System.EventHandler(this.ViewBookButtonClick);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(692, 176);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBookButton.TabIndex = 6;
            this.deleteBookButton.Text = "Delete";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.DeleteBookButtonClick);
            // 
            // editBookButton
            // 
            this.editBookButton.Location = new System.Drawing.Point(692, 122);
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(75, 23);
            this.editBookButton.TabIndex = 7;
            this.editBookButton.Text = "Edit";
            this.editBookButton.UseVisualStyleBackColor = true;
            this.editBookButton.Click += new System.EventHandler(this.EditBookButtonClick);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBookButton);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.viewBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.notRentedBooksLabel);
            this.Controls.Add(this.rentedBooksLabel);
            this.Controls.Add(this.notRentedListBox);
            this.Controls.Add(this.rentedBooksListBox);
            this.Name = "BookListForm";
            this.Text = "BookListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rentedBooksListBox;
        private System.Windows.Forms.ListBox notRentedListBox;
        private System.Windows.Forms.Label rentedBooksLabel;
        private System.Windows.Forms.Label notRentedBooksLabel;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button viewBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button editBookButton;
    }
}