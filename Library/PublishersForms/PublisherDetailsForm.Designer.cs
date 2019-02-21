namespace Library.PublishersForms
{
    partial class PublisherDetailsForm
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
            this.publisherBooksListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.publisherDetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // publisherBooksListBox
            // 
            this.publisherBooksListBox.FormattingEnabled = true;
            this.publisherBooksListBox.ItemHeight = 16;
            this.publisherBooksListBox.Location = new System.Drawing.Point(36, 175);
            this.publisherBooksListBox.Name = "publisherBooksListBox";
            this.publisherBooksListBox.Size = new System.Drawing.Size(479, 228);
            this.publisherBooksListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(567, 279);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // publisherDetailsLabel
            // 
            this.publisherDetailsLabel.AutoSize = true;
            this.publisherDetailsLabel.Location = new System.Drawing.Point(36, 31);
            this.publisherDetailsLabel.Name = "publisherDetailsLabel";
            this.publisherDetailsLabel.Size = new System.Drawing.Size(46, 17);
            this.publisherDetailsLabel.TabIndex = 3;
            this.publisherDetailsLabel.Text = "label1";
            // 
            // PublisherDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publisherDetailsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publisherBooksListBox);
            this.Name = "PublisherDetailsForm";
            this.Text = "PublisherDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox publisherBooksListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label publisherDetailsLabel;
    }
}