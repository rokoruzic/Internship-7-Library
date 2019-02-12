namespace Library
{
    partial class MenuForm
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
            this.authorButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.bookRentsButton = new System.Windows.Forms.Button();
            this.publishersButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(97, 112);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(146, 98);
            this.authorButton.TabIndex = 0;
            this.authorButton.Text = "Authors";
            this.authorButton.UseVisualStyleBackColor = true;
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(339, 112);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(123, 98);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            // 
            // bookRentsButton
            // 
            this.bookRentsButton.Location = new System.Drawing.Point(339, 242);
            this.bookRentsButton.Name = "bookRentsButton";
            this.bookRentsButton.Size = new System.Drawing.Size(123, 79);
            this.bookRentsButton.TabIndex = 2;
            this.bookRentsButton.Text = "Book rents";
            this.bookRentsButton.UseVisualStyleBackColor = true;
            // 
            // publishersButton
            // 
            this.publishersButton.Location = new System.Drawing.Point(97, 242);
            this.publishersButton.Name = "publishersButton";
            this.publishersButton.Size = new System.Drawing.Size(146, 79);
            this.publishersButton.TabIndex = 3;
            this.publishersButton.Text = "Publishers";
            this.publishersButton.UseVisualStyleBackColor = true;
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(520, 112);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(137, 98);
            this.studentsButton.TabIndex = 4;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.StudentsButtonClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.publishersButton);
            this.Controls.Add(this.bookRentsButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.authorButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button bookRentsButton;
        private System.Windows.Forms.Button publishersButton;
        private System.Windows.Forms.Button studentsButton;
    }
}