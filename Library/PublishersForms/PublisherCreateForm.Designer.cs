namespace Library.PublishersForms
{
    partial class PublisherCreateForm
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
            this.publisherAddButton = new System.Windows.Forms.Button();
            this.publisherNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // publisherAddButton
            // 
            this.publisherAddButton.Location = new System.Drawing.Point(317, 233);
            this.publisherAddButton.Name = "publisherAddButton";
            this.publisherAddButton.Size = new System.Drawing.Size(75, 23);
            this.publisherAddButton.TabIndex = 0;
            this.publisherAddButton.Text = "Add";
            this.publisherAddButton.UseVisualStyleBackColor = true;
            this.publisherAddButton.Click += new System.EventHandler(this.PublisherAddButtonClick);
            // 
            // publisherNameTextBox
            // 
            this.publisherNameTextBox.Location = new System.Drawing.Point(210, 121);
            this.publisherNameTextBox.Name = "publisherNameTextBox";
            this.publisherNameTextBox.Size = new System.Drawing.Size(306, 22);
            this.publisherNameTextBox.TabIndex = 1;
            // 
            // PublisherCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publisherNameTextBox);
            this.Controls.Add(this.publisherAddButton);
            this.Name = "PublisherCreateForm";
            this.Text = "PublisherCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button publisherAddButton;
        private System.Windows.Forms.TextBox publisherNameTextBox;
    }
}