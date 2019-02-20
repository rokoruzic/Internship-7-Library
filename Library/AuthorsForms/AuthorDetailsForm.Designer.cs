namespace Library.AuthorsForms
{
    partial class AuthorDetailsForm
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
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.authorBooksListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(21, 38);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(409, 22);
            this.authorNameTextBox.TabIndex = 0;
            // 
            // authorBooksListBox
            // 
            this.authorBooksListBox.FormattingEnabled = true;
            this.authorBooksListBox.ItemHeight = 16;
            this.authorBooksListBox.Location = new System.Drawing.Point(21, 116);
            this.authorBooksListBox.Name = "authorBooksListBox";
            this.authorBooksListBox.Size = new System.Drawing.Size(395, 292);
            this.authorBooksListBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(603, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // AuthorDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.authorBooksListBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Name = "AuthorDetailsForm";
            this.Text = "AuthorDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.ListBox authorBooksListBox;
        private System.Windows.Forms.Button exitButton;
    }
}