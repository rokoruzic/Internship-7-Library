namespace Library.PublishersForms
{
    partial class PublisherListForm
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
            this.publishersListBox = new System.Windows.Forms.ListBox();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.publishersDetailsButton = new System.Windows.Forms.Button();
            this.publishersDeleteButton = new System.Windows.Forms.Button();
            this.editPublisherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publishersListBox
            // 
            this.publishersListBox.FormattingEnabled = true;
            this.publishersListBox.ItemHeight = 16;
            this.publishersListBox.Location = new System.Drawing.Point(34, 67);
            this.publishersListBox.Name = "publishersListBox";
            this.publishersListBox.Size = new System.Drawing.Size(424, 308);
            this.publishersListBox.TabIndex = 0;
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.Location = new System.Drawing.Point(616, 67);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(75, 23);
            this.addPublisherButton.TabIndex = 1;
            this.addPublisherButton.Text = "Add";
            this.addPublisherButton.UseVisualStyleBackColor = true;
            this.addPublisherButton.Click += new System.EventHandler(this.AddPublisherButtonClick);
            // 
            // publishersDetailsButton
            // 
            this.publishersDetailsButton.Location = new System.Drawing.Point(616, 254);
            this.publishersDetailsButton.Name = "publishersDetailsButton";
            this.publishersDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.publishersDetailsButton.TabIndex = 2;
            this.publishersDetailsButton.Text = "View";
            this.publishersDetailsButton.UseVisualStyleBackColor = true;
            this.publishersDetailsButton.Click += new System.EventHandler(this.PublishersDetailsButtonClick);
            // 
            // publishersDeleteButton
            // 
            this.publishersDeleteButton.Location = new System.Drawing.Point(616, 187);
            this.publishersDeleteButton.Name = "publishersDeleteButton";
            this.publishersDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.publishersDeleteButton.TabIndex = 3;
            this.publishersDeleteButton.Text = "Delete";
            this.publishersDeleteButton.UseVisualStyleBackColor = true;
            this.publishersDeleteButton.Click += new System.EventHandler(this.PublishersDeleteButtonClick);
            // 
            // editPublisherButton
            // 
            this.editPublisherButton.Location = new System.Drawing.Point(616, 117);
            this.editPublisherButton.Name = "editPublisherButton";
            this.editPublisherButton.Size = new System.Drawing.Size(75, 27);
            this.editPublisherButton.TabIndex = 4;
            this.editPublisherButton.Text = "Edit";
            this.editPublisherButton.UseVisualStyleBackColor = true;
            this.editPublisherButton.Click += new System.EventHandler(this.EditPublisherButtonClick);
            // 
            // PublisherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editPublisherButton);
            this.Controls.Add(this.publishersDeleteButton);
            this.Controls.Add(this.publishersDetailsButton);
            this.Controls.Add(this.addPublisherButton);
            this.Controls.Add(this.publishersListBox);
            this.Name = "PublisherListForm";
            this.Text = "PublisherListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox publishersListBox;
        private System.Windows.Forms.Button addPublisherButton;
        private System.Windows.Forms.Button publishersDetailsButton;
        private System.Windows.Forms.Button publishersDeleteButton;
        private System.Windows.Forms.Button editPublisherButton;
    }
}