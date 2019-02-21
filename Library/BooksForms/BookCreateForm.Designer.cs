namespace Library.BooksForms
{
    partial class BookCreateForm
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
            this.addBookButton = new System.Windows.Forms.Button();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookPagesLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookPagesNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(45, 48);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(285, 22);
            this.bookNameTextBox.TabIndex = 0;
            // 
            // bookPagesNumUpDown
            // 
            this.bookPagesNumUpDown.Location = new System.Drawing.Point(45, 117);
            this.bookPagesNumUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.bookPagesNumUpDown.Name = "bookPagesNumUpDown";
            this.bookPagesNumUpDown.Size = new System.Drawing.Size(120, 22);
            this.bookPagesNumUpDown.TabIndex = 1;
            this.bookPagesNumUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // genresComboBox
            // 
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Location = new System.Drawing.Point(45, 188);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(285, 24);
            this.genresComboBox.TabIndex = 2;
            // 
            // authorsComboBox
            // 
            this.authorsComboBox.FormattingEnabled = true;
            this.authorsComboBox.Location = new System.Drawing.Point(45, 262);
            this.authorsComboBox.Name = "authorsComboBox";
            this.authorsComboBox.Size = new System.Drawing.Size(285, 24);
            this.authorsComboBox.TabIndex = 3;
            // 
            // publishersComboBox
            // 
            this.publishersComboBox.FormattingEnabled = true;
            this.publishersComboBox.Location = new System.Drawing.Point(45, 338);
            this.publishersComboBox.Name = "publishersComboBox";
            this.publishersComboBox.Size = new System.Drawing.Size(285, 24);
            this.publishersComboBox.TabIndex = 4;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(421, 370);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(95, 23);
            this.addBookButton.TabIndex = 5;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookButtonClick);
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(42, 18);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(72, 17);
            this.bookNameLabel.TabIndex = 6;
            this.bookNameLabel.Text = "Add name";
            // 
            // bookPagesLabel
            // 
            this.bookPagesLabel.AutoSize = true;
            this.bookPagesLabel.Location = new System.Drawing.Point(45, 94);
            this.bookPagesLabel.Name = "bookPagesLabel";
            this.bookPagesLabel.Size = new System.Drawing.Size(76, 17);
            this.bookPagesLabel.TabIndex = 7;
            this.bookPagesLabel.Text = "Add pages";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Location = new System.Drawing.Point(45, 165);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(74, 17);
            this.genresLabel.TabIndex = 8;
            this.genresLabel.Text = "Add genre";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(45, 219);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(78, 17);
            this.authorLabel.TabIndex = 9;
            this.authorLabel.Text = "add Author";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(45, 293);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(95, 17);
            this.publisherLabel.TabIndex = 10;
            this.publisherLabel.Text = "Add publisher";
            // 
            // BookCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.bookPagesLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.publishersComboBox);
            this.Controls.Add(this.authorsComboBox);
            this.Controls.Add(this.genresComboBox);
            this.Controls.Add(this.bookPagesNumUpDown);
            this.Controls.Add(this.bookNameTextBox);
            this.Name = "BookCreateForm";
            this.Text = "BookCreateForm";
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
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label bookPagesLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
    }
}