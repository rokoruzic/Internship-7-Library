using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Publisher = Library.Data.Entities.Models.Publisher;

namespace Library.PublishersForms
{
    public partial class PublisherEditForm : Form
    {
        public PublisherRepository PublisherRepository { get; set; }
        public Publisher SelectedPublisher { get; set; }
        public PublisherEditForm(PublisherRepository publisherRepository)
        {
            InitializeComponent();
            PublisherRepository = publisherRepository;
        }

        public void SetText()
        {
            publisherNameTextBox.Text = SelectedPublisher.Name;
        }

        private void PublisherEditButtonClick(object sender, EventArgs e)
        {
            var publisherToEdit = new Publisher();
            publisherToEdit.Name = publisherNameTextBox.Text;
            publisherToEdit.PublisherId = SelectedPublisher.PublisherId;
            publisherToEdit.Books = SelectedPublisher.Books;
            PublisherRepository.EditPublisher(publisherToEdit);
            Close();

        }
    }
}
