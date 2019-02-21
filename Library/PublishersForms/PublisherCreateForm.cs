using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Publisher = Library.Data.Entities.Models.Publisher;

namespace Library.PublishersForms
{
    public partial class PublisherCreateForm : Form
    {
        public PublisherRepository PublisherRepository { get; set; }
        public PublisherCreateForm(PublisherRepository publisherRepository)
        {
            InitializeComponent();
            PublisherRepository = publisherRepository;
        }

        private void PublisherAddButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(publisherNameTextBox.Text))
            {
                var errorForm = new ErrorForm("You need to fill al boxes");
                errorForm.ShowDialog();
            }
            else
            {
                var publisherToAdd = new Publisher {Name = publisherNameTextBox.Text};
                PublisherRepository.AddPublisher(publisherToAdd);
                Close();
            }

        }
    }
}
