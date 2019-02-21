namespace Library.BookRentsForms
{
    partial class BookRentDetailsForm
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
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.dateOfRentLabel = new System.Windows.Forms.Label();
            this.dateOfReturnLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(328, 75);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(46, 17);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "label1";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(328, 143);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(46, 17);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "label2";
            // 
            // dateOfRentLabel
            // 
            this.dateOfRentLabel.AutoSize = true;
            this.dateOfRentLabel.Location = new System.Drawing.Point(328, 214);
            this.dateOfRentLabel.Name = "dateOfRentLabel";
            this.dateOfRentLabel.Size = new System.Drawing.Size(46, 17);
            this.dateOfRentLabel.TabIndex = 2;
            this.dateOfRentLabel.Text = "label3";
            // 
            // dateOfReturnLabel
            // 
            this.dateOfReturnLabel.AutoSize = true;
            this.dateOfReturnLabel.Location = new System.Drawing.Point(328, 285);
            this.dateOfReturnLabel.Name = "dateOfReturnLabel";
            this.dateOfReturnLabel.Size = new System.Drawing.Size(46, 17);
            this.dateOfReturnLabel.TabIndex = 3;
            this.dateOfReturnLabel.Text = "label4";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(311, 360);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.BookRentDetailsExitButtonClick);
            // 
            // BookRentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dateOfReturnLabel);
            this.Controls.Add(this.dateOfRentLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Name = "BookRentDetailsForm";
            this.Text = "BookRentsDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label dateOfRentLabel;
        private System.Windows.Forms.Label dateOfReturnLabel;
        private System.Windows.Forms.Button closeButton;
    }
}