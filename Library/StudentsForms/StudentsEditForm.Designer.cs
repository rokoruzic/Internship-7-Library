namespace Library.StudentsForms
{
    partial class StudentsEditForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datOfRentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.removeRentButton = new System.Windows.Forms.Button();
            this.addRentButton = new System.Windows.Forms.Button();
            this.booksToRentComboBox = new System.Windows.Forms.ComboBox();
            this.isReturnedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(47, 62);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(47, 142);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(47, 283);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(178, 22);
            this.classTextBox.TabIndex = 2;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(47, 217);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(230, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 3;
            // 
            // datOfRentDateTimePicker
            // 
            this.datOfRentDateTimePicker.Location = new System.Drawing.Point(500, 131);
            this.datOfRentDateTimePicker.Name = "datOfRentDateTimePicker";
            this.datOfRentDateTimePicker.Size = new System.Drawing.Size(230, 22);
            this.datOfRentDateTimePicker.TabIndex = 6;
            // 
            // dateOfReturnDateTimePicker
            // 
            this.dateOfReturnDateTimePicker.Location = new System.Drawing.Point(500, 202);
            this.dateOfReturnDateTimePicker.Name = "dateOfReturnDateTimePicker";
            this.dateOfReturnDateTimePicker.Size = new System.Drawing.Size(230, 22);
            this.dateOfReturnDateTimePicker.TabIndex = 7;
            // 
            // booksComboBox
            // 
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(500, 58);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(230, 24);
            this.booksComboBox.TabIndex = 8;
            // 
            // removeRentButton
            // 
            this.removeRentButton.Location = new System.Drawing.Point(500, 88);
            this.removeRentButton.Name = "removeRentButton";
            this.removeRentButton.Size = new System.Drawing.Size(75, 23);
            this.removeRentButton.TabIndex = 9;
            this.removeRentButton.Text = "Remove rent";
            this.removeRentButton.UseVisualStyleBackColor = true;
            this.removeRentButton.Click += new System.EventHandler(this.RemoveRentButtonClick);
            // 
            // addRentButton
            // 
            this.addRentButton.Location = new System.Drawing.Point(500, 309);
            this.addRentButton.Name = "addRentButton";
            this.addRentButton.Size = new System.Drawing.Size(75, 23);
            this.addRentButton.TabIndex = 10;
            this.addRentButton.Text = "Add Rent";
            this.addRentButton.UseVisualStyleBackColor = true;
            this.addRentButton.Click += new System.EventHandler(this.AddRentButtonClick);
            // 
            // booksToRentComboBox
            // 
            this.booksToRentComboBox.FormattingEnabled = true;
            this.booksToRentComboBox.Location = new System.Drawing.Point(500, 244);
            this.booksToRentComboBox.Name = "booksToRentComboBox";
            this.booksToRentComboBox.Size = new System.Drawing.Size(230, 24);
            this.booksToRentComboBox.TabIndex = 11;
            this.booksToRentComboBox.SelectedIndexChanged += new System.EventHandler(this.BooksToRentComboBoxSelectedIndexChanged);
            // 
            // isReturnedCheckBox
            // 
            this.isReturnedCheckBox.AutoSize = true;
            this.isReturnedCheckBox.Location = new System.Drawing.Point(500, 175);
            this.isReturnedCheckBox.Name = "isReturnedCheckBox";
            this.isReturnedCheckBox.Size = new System.Drawing.Size(119, 21);
            this.isReturnedCheckBox.TabIndex = 12;
            this.isReturnedCheckBox.Text = "book returned";
            this.isReturnedCheckBox.UseVisualStyleBackColor = true;
            this.isReturnedCheckBox.CheckStateChanged += new System.EventHandler(this.IsReturnedCheckBox);
            // 
            // StudentsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isReturnedCheckBox);
            this.Controls.Add(this.booksToRentComboBox);
            this.Controls.Add(this.addRentButton);
            this.Controls.Add(this.removeRentButton);
            this.Controls.Add(this.booksComboBox);
            this.Controls.Add(this.dateOfReturnDateTimePicker);
            this.Controls.Add(this.datOfRentDateTimePicker);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "StudentsEditForm";
            this.Text = "StudentsEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.DateTimePicker datOfRentDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfReturnDateTimePicker;
        private System.Windows.Forms.ComboBox booksComboBox;
        private System.Windows.Forms.Button removeRentButton;
        private System.Windows.Forms.Button addRentButton;
        private System.Windows.Forms.ComboBox booksToRentComboBox;
        private System.Windows.Forms.CheckBox isReturnedCheckBox;
    }
}