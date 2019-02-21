using System;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Publisher = Library.Data.Entities.Models.Publisher;

namespace Library.PublishersForms
{
    public partial class PublisherListForm : Form
    {
        public BookRepository BookRepository { get; set; }
        public PublisherRepository PublisherRepository { get; set; }
        public PublisherListForm(PublisherRepository publisherRepository,BookRepository bookRepository)
        {
            InitializeComponent();
            PublisherRepository = publisherRepository;
            BookRepository = bookRepository;
        }

        public void AddRefreshList()
        {
            publishersListBox.Items.Clear();
            PublisherRepository.GetAllPublishers().ForEach(x=>publishersListBox.Items.Add(x));
        }

        private void AddPublisherButtonClick(object sender, EventArgs e)
        {
            var publisherCreateForm = new PublisherCreateForm(PublisherRepository);
            publisherCreateForm.ShowDialog();
            AddRefreshList();
        }

        private void EditPublisherButtonClick(object sender, EventArgs e)
        {
            if (!(publishersListBox.SelectedItem is Publisher selectedPublisher))
            {
                var errorForm = new ErrorForm("You need to select publisher");
                errorForm.ShowDialog();
            }
            else
            {
                var publisherEditForm = new PublisherEditForm(PublisherRepository)
                    {SelectedPublisher = selectedPublisher};
                publisherEditForm.SetText();
                publisherEditForm.ShowDialog();
                AddRefreshList();
            }
        }

        private void PublishersDeleteButtonClick(object sender, EventArgs e)
        {
            if (!(publishersListBox.SelectedItem is Publisher selectedPublisher))
            {
                var errorForm = new ErrorForm("You need to select publisher");
                errorForm.ShowDialog();
            }
            else
            {
                PublisherRepository.RemovePublisher(selectedPublisher.PublisherId);
                AddRefreshList();
            }
        }

        private void PublishersDetailsButtonClick(object sender, EventArgs e)
        {
            if (!(publishersListBox.SelectedItem is Publisher selectedPublisher))
            {
                var errorForm = new ErrorForm("You need to select publisher");
                errorForm.ShowDialog();
            }
            else
            {
                var publisherDetailsForm = new PublisherDetailsForm(PublisherRepository, BookRepository)
                    {SelectedPublisher = selectedPublisher};
                publisherDetailsForm.AddRefreshList();
                publisherDetailsForm.ShowDialog();
                AddRefreshList();
            }

        }
    }
}
