namespace Library.StudentsForms
{
    partial class StudentsCreateForm
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
            this.classLetterTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.classNumberNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classNumberNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(44, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(44, 106);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(197, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // classLetterTextBox
            // 
            this.classLetterTextBox.Location = new System.Drawing.Point(190, 255);
            this.classLetterTextBox.MaxLength = 1;
            this.classLetterTextBox.Name = "classLetterTextBox";
            this.classLetterTextBox.Size = new System.Drawing.Size(51, 22);
            this.classLetterTextBox.TabIndex = 2;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(44, 190);
            this.genderComboBox.MaxLength = 1000;
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 24);
            this.genderComboBox.TabIndex = 3;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(44, 341);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(357, 381);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // classNumberNumUpDown
            // 
            this.classNumberNumUpDown.Location = new System.Drawing.Point(44, 255);
            this.classNumberNumUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.classNumberNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.classNumberNumUpDown.Name = "classNumberNumUpDown";
            this.classNumberNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.classNumberNumUpDown.TabIndex = 6;
            this.classNumberNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(44, 2);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(108, 17);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "Enter first name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(44, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(107, 17);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Enter last name";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(47, 148);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(105, 17);
            this.genderLabel.TabIndex = 9;
            this.genderLabel.Text = "Choose gender";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(44, 232);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(144, 17);
            this.classLabel.TabIndex = 10;
            this.classLabel.Text = "Enter class ( eg. 1 b )";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(44, 299);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(125, 17);
            this.dateOfBirthLabel.TabIndex = 11;
            this.dateOfBirthLabel.Text = "select date of birth";
            // 
            // StudentsCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.classNumberNumUpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.classLetterTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "StudentsCreateForm";
            this.Text = "StudentsCreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.classNumberNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox classLetterTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown classNumberNumUpDown;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
    }
}