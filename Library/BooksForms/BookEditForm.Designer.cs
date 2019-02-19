namespace Library.BooksForms
{
    partial class BookEditForm
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
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookPagesNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.genresComboBox = new System.Windows.Forms.ComboBox();
            this.authorsComboBox = new System.Windows.Forms.ComboBox();
            this.publishersComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAllCopiesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookPagesNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(31, 56);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(285, 22);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // bookPagesNumUpDown
            // 
            this.bookPagesNumUpDown.Location = new System.Drawing.Point(31, 132);
            this.bookPagesNumUpDown.Name = "bookPagesNumUpDown";
            this.bookPagesNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.bookPagesNumUpDown.TabIndex = 2;
            // 
            // genresComboBox
            // 
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Location = new System.Drawing.Point(31, 208);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(285, 24);
            this.genresComboBox.TabIndex = 3;
            // 
            // authorsComboBox
            // 
            this.authorsComboBox.FormattingEnabled = true;
            this.authorsComboBox.Location = new System.Drawing.Point(31, 283);
            this.authorsComboBox.Name = "authorsComboBox";
            this.authorsComboBox.Size = new System.Drawing.Size(285, 24);
            this.authorsComboBox.TabIndex = 4;
            // 
            // publishersComboBox
            // 
            this.publishersComboBox.FormattingEnabled = true;
            this.publishersComboBox.Location = new System.Drawing.Point(31, 367);
            this.publishersComboBox.Name = "publishersComboBox";
            this.publishersComboBox.Size = new System.Drawing.Size(285, 24);
            this.publishersComboBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(382, 403);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // saveAllCopiesButton
            // 
            this.saveAllCopiesButton.Location = new System.Drawing.Point(566, 403);
            this.saveAllCopiesButton.Name = "saveAllCopiesButton";
            this.saveAllCopiesButton.Size = new System.Drawing.Size(190, 23);
            this.saveAllCopiesButton.TabIndex = 7;
            this.saveAllCopiesButton.Text = "Save to all copies";
            this.saveAllCopiesButton.UseVisualStyleBackColor = true;
            this.saveAllCopiesButton.Click += new System.EventHandler(this.SaveAllCopiesButtonClick);
            // 
            // BookEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveAllCopiesButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.publishersComboBox);
            this.Controls.Add(this.authorsComboBox);
            this.Controls.Add(this.genresComboBox);
            this.Controls.Add(this.bookPagesNumUpDown);
            this.Controls.Add(this.bookNameTextBox);
            this.Name = "BookEditForm";
            this.Text = "BookEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookPagesNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.NumericUpDown bookPagesNumUpDown;
        private System.Windows.Forms.ComboBox genresComboBox;
        private System.Windows.Forms.ComboBox authorsComboBox;
        private System.Windows.Forms.ComboBox publishersComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAllCopiesButton;
    }
}