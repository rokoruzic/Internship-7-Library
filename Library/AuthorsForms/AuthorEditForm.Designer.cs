namespace Library.AuthorsForms
{
    partial class AuthorEditForm
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
            this.editAuthorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorFirstNameTextBox
            // 
            this.authorFirstNameTextBox.Location = new System.Drawing.Point(65, 81);
            this.authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            this.authorFirstNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.authorFirstNameTextBox.TabIndex = 1;
            // 
            // authorLastNameTextBox
            // 
            this.authorLastNameTextBox.Location = new System.Drawing.Point(65, 171);
            this.authorLastNameTextBox.Name = "authorLastNameTextBox";
            this.authorLastNameTextBox.Size = new System.Drawing.Size(233, 22);
            this.authorLastNameTextBox.TabIndex = 2;
            // 
            // editAuthorButton
            // 
            this.editAuthorButton.Location = new System.Drawing.Point(269, 336);
            this.editAuthorButton.Name = "editAuthorButton";
            this.editAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.editAuthorButton.TabIndex = 3;
            this.editAuthorButton.Text = "Edit";
            this.editAuthorButton.UseVisualStyleBackColor = true;
            this.editAuthorButton.Click += new System.EventHandler(this.EditAuthorButtonClick);
            // 
            // AuthorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editAuthorButton);
            this.Controls.Add(this.authorLastNameTextBox);
            this.Controls.Add(this.authorFirstNameTextBox);
            this.Name = "AuthorEditForm";
            this.Text = "AuthorEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorFirstNameTextBox;
        private System.Windows.Forms.TextBox authorLastNameTextBox;
        private System.Windows.Forms.Button editAuthorButton;
    }
}