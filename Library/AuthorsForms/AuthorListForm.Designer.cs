namespace Library.AuthorsForms
{
    partial class AuthorListForm
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
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.authorAddButton = new System.Windows.Forms.Button();
            this.authorEditButton = new System.Windows.Forms.Button();
            this.authorDeleteButton = new System.Windows.Forms.Button();
            this.authorViewDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorListBox
            // 
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.ItemHeight = 16;
            this.authorListBox.Location = new System.Drawing.Point(28, 89);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.Size = new System.Drawing.Size(416, 292);
            this.authorListBox.TabIndex = 0;
            // 
            // authorAddButton
            // 
            this.authorAddButton.Location = new System.Drawing.Point(610, 114);
            this.authorAddButton.Name = "authorAddButton";
            this.authorAddButton.Size = new System.Drawing.Size(75, 23);
            this.authorAddButton.TabIndex = 1;
            this.authorAddButton.Text = "Add";
            this.authorAddButton.UseVisualStyleBackColor = true;
            this.authorAddButton.Click += new System.EventHandler(this.AuthorAddButtonClick);
            // 
            // authorEditButton
            // 
            this.authorEditButton.Location = new System.Drawing.Point(610, 196);
            this.authorEditButton.Name = "authorEditButton";
            this.authorEditButton.Size = new System.Drawing.Size(75, 23);
            this.authorEditButton.TabIndex = 2;
            this.authorEditButton.Text = "Edit";
            this.authorEditButton.UseVisualStyleBackColor = true;
            this.authorEditButton.Click += new System.EventHandler(this.AuthorEditButtonClick);
            // 
            // authorDeleteButton
            // 
            this.authorDeleteButton.Location = new System.Drawing.Point(610, 273);
            this.authorDeleteButton.Name = "authorDeleteButton";
            this.authorDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.authorDeleteButton.TabIndex = 3;
            this.authorDeleteButton.Text = "Delete";
            this.authorDeleteButton.UseVisualStyleBackColor = true;
            this.authorDeleteButton.Click += new System.EventHandler(this.AuthorDeleteButtonClick);
            // 
            // authorViewDetails
            // 
            this.authorViewDetails.Location = new System.Drawing.Point(610, 349);
            this.authorViewDetails.Name = "authorViewDetails";
            this.authorViewDetails.Size = new System.Drawing.Size(75, 23);
            this.authorViewDetails.TabIndex = 4;
            this.authorViewDetails.Text = "View";
            this.authorViewDetails.UseVisualStyleBackColor = true;
            this.authorViewDetails.Click += new System.EventHandler(this.AuthorViewDetailsClick);
            // 
            // AuthorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorViewDetails);
            this.Controls.Add(this.authorDeleteButton);
            this.Controls.Add(this.authorEditButton);
            this.Controls.Add(this.authorAddButton);
            this.Controls.Add(this.authorListBox);
            this.Name = "AuthorListForm";
            this.Text = "AuthorListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox authorListBox;
        private System.Windows.Forms.Button authorAddButton;
        private System.Windows.Forms.Button authorEditButton;
        private System.Windows.Forms.Button authorDeleteButton;
        private System.Windows.Forms.Button authorViewDetails;
    }
}