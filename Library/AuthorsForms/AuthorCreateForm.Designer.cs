namespace Library.AuthorsForms
{
    partial class AuthorCreateForm
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
            this.authorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.authorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorFirstNameTextBox
            // 
            this.authorFirstNameTextBox.Location = new System.Drawing.Point(65, 75);
            this.authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            this.authorFirstNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.authorFirstNameTextBox.TabIndex = 0;
            // 
            // authorLastNameTextBox
            // 
            this.authorLastNameTextBox.Location = new System.Drawing.Point(65, 145);
            this.authorLastNameTextBox.Name = "authorLastNameTextBox";
            this.authorLastNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.authorLastNameTextBox.TabIndex = 1;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(310, 316);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorButton.TabIndex = 2;
            this.addAuthorButton.Text = "Add";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.AddAuthorButtonClick);
            // 
            // AuthorCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.authorLastNameTextBox);
            this.Controls.Add(this.authorFirstNameTextBox);
            this.Name = "AuthorCreateForm";
            this.Text = "AuthorCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorFirstNameTextBox;
        private System.Windows.Forms.TextBox authorLastNameTextBox;
        private System.Windows.Forms.Button addAuthorButton;
    }
}