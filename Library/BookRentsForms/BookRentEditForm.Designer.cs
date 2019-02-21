namespace Library.BookRentsForms
{
    partial class BookRentEditForm
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
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.isReturnedCheckBox = new System.Windows.Forms.CheckBox();
            this.dateOfRentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(44, 223);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(305, 22);
            this.returnDateDateTimePicker.TabIndex = 0;
            // 
            // rentDateDateTimePicker
            // 
            this.rentDateDateTimePicker.Location = new System.Drawing.Point(44, 131);
            this.rentDateDateTimePicker.Name = "rentDateDateTimePicker";
            this.rentDateDateTimePicker.Size = new System.Drawing.Size(305, 22);
            this.rentDateDateTimePicker.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(111, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // isReturnedCheckBox
            // 
            this.isReturnedCheckBox.AutoSize = true;
            this.isReturnedCheckBox.Location = new System.Drawing.Point(44, 181);
            this.isReturnedCheckBox.Name = "isReturnedCheckBox";
            this.isReturnedCheckBox.Size = new System.Drawing.Size(277, 21);
            this.isReturnedCheckBox.TabIndex = 3;
            this.isReturnedCheckBox.Text = "check if returned and select date below";
            this.isReturnedCheckBox.UseVisualStyleBackColor = true;
            this.isReturnedCheckBox.CheckedChanged += new System.EventHandler(this.IsReturnedCheckBoxChanged);
            // 
            // dateOfRentLabel
            // 
            this.dateOfRentLabel.AutoSize = true;
            this.dateOfRentLabel.Location = new System.Drawing.Point(41, 92);
            this.dateOfRentLabel.Name = "dateOfRentLabel";
            this.dateOfRentLabel.Size = new System.Drawing.Size(129, 17);
            this.dateOfRentLabel.TabIndex = 9;
            this.dateOfRentLabel.Text = "select Date of Rent";
            // 
            // BookRentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateOfRentLabel);
            this.Controls.Add(this.isReturnedCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rentDateDateTimePicker);
            this.Controls.Add(this.returnDateDateTimePicker);
            this.Name = "BookRentEditForm";
            this.Text = "BookRentsEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker rentDateDateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox isReturnedCheckBox;
        private System.Windows.Forms.Label dateOfRentLabel;
    }
}