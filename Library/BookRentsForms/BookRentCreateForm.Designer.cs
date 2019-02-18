namespace Library.BookRentsForms
{
    partial class BookRentCreateForm
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
            this.availableBookRentsComboBox = new System.Windows.Forms.ComboBox();
            this.availableStudentsComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfRentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.isReturnedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // availableBookRentsComboBox
            // 
            this.availableBookRentsComboBox.FormattingEnabled = true;
            this.availableBookRentsComboBox.Location = new System.Drawing.Point(40, 78);
            this.availableBookRentsComboBox.Name = "availableBookRentsComboBox";
            this.availableBookRentsComboBox.Size = new System.Drawing.Size(277, 24);
            this.availableBookRentsComboBox.TabIndex = 0;
            // 
            // availableStudentsComboBox
            // 
            this.availableStudentsComboBox.FormattingEnabled = true;
            this.availableStudentsComboBox.Location = new System.Drawing.Point(40, 137);
            this.availableStudentsComboBox.Name = "availableStudentsComboBox";
            this.availableStudentsComboBox.Size = new System.Drawing.Size(277, 24);
            this.availableStudentsComboBox.TabIndex = 1;
            // 
            // dateOfRentDateTimePicker
            // 
            this.dateOfRentDateTimePicker.Location = new System.Drawing.Point(40, 221);
            this.dateOfRentDateTimePicker.Name = "dateOfRentDateTimePicker";
            this.dateOfRentDateTimePicker.Size = new System.Drawing.Size(277, 22);
            this.dateOfRentDateTimePicker.TabIndex = 2;
            // 
            // dateOfReturnDateTimePicker
            // 
            this.dateOfReturnDateTimePicker.Location = new System.Drawing.Point(40, 300);
            this.dateOfReturnDateTimePicker.Name = "dateOfReturnDateTimePicker";
            this.dateOfReturnDateTimePicker.Size = new System.Drawing.Size(277, 22);
            this.dateOfReturnDateTimePicker.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 361);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // isReturnedCheckBox
            // 
            this.isReturnedCheckBox.AutoSize = true;
            this.isReturnedCheckBox.Location = new System.Drawing.Point(40, 273);
            this.isReturnedCheckBox.Name = "isReturnedCheckBox";
            this.isReturnedCheckBox.Size = new System.Drawing.Size(98, 21);
            this.isReturnedCheckBox.TabIndex = 5;
            this.isReturnedCheckBox.Text = "is returned";
            this.isReturnedCheckBox.UseVisualStyleBackColor = true;
            this.isReturnedCheckBox.CheckedChanged += new System.EventHandler(this.IsReturnedCheckBoxChanged);
            // 
            // BookRentCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isReturnedCheckBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dateOfReturnDateTimePicker);
            this.Controls.Add(this.dateOfRentDateTimePicker);
            this.Controls.Add(this.availableStudentsComboBox);
            this.Controls.Add(this.availableBookRentsComboBox);
            this.Name = "BookRentCreateForm";
            this.Text = "BookRentsCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox availableBookRentsComboBox;
        private System.Windows.Forms.ComboBox availableStudentsComboBox;
        private System.Windows.Forms.DateTimePicker dateOfRentDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfReturnDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox isReturnedCheckBox;
    }
}