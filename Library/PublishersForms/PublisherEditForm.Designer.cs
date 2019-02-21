namespace Library.PublishersForms
{
    partial class PublisherEditForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.publisherNameTextBox = new System.Windows.Forms.TextBox();
            this.publisherEditButton = new System.Windows.Forms.Button();
            this.publisherNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 9);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // publisherNameTextBox
            // 
            this.publisherNameTextBox.Location = new System.Drawing.Point(236, 122);
            this.publisherNameTextBox.Name = "publisherNameTextBox";
            this.publisherNameTextBox.Size = new System.Drawing.Size(306, 22);
            this.publisherNameTextBox.TabIndex = 3;
            // 
            // publisherEditButton
            // 
            this.publisherEditButton.Location = new System.Drawing.Point(348, 299);
            this.publisherEditButton.Name = "publisherEditButton";
            this.publisherEditButton.Size = new System.Drawing.Size(75, 23);
            this.publisherEditButton.TabIndex = 4;
            this.publisherEditButton.Text = "Edit";
            this.publisherEditButton.UseVisualStyleBackColor = true;
            this.publisherEditButton.Click += new System.EventHandler(this.PublisherEditButtonClick);
            // 
            // publisherNameLabel
            // 
            this.publisherNameLabel.AutoSize = true;
            this.publisherNameLabel.Location = new System.Drawing.Point(233, 80);
            this.publisherNameLabel.Name = "publisherNameLabel";
            this.publisherNameLabel.Size = new System.Drawing.Size(85, 17);
            this.publisherNameLabel.TabIndex = 5;
            this.publisherNameLabel.Text = "Enter name:";
            // 
            // PublisherEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.publisherNameLabel);
            this.Controls.Add(this.publisherEditButton);
            this.Controls.Add(this.publisherNameTextBox);
            this.Controls.Add(this.button2);
            this.Name = "PublisherEditForm";
            this.Text = "PublisherEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox publisherNameTextBox;
        private System.Windows.Forms.Button publisherEditButton;
        private System.Windows.Forms.Label publisherNameLabel;
    }
}