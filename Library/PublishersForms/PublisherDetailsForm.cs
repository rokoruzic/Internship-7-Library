using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.PublishersForms
{
    public partial class PublisherDetailsForm : Form
    {
        public PublisherRepository PublisherRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public Publisher SelectedPublisher { get; set; }
        public PublisherDetailsForm(PublisherRepository publisherRepository,BookRepository bookRepository)
        {
            InitializeComponent();
            PublisherRepository = publisherRepository;
            BookRepository = bookRepository;

        }

        public void AddRefreshList()
        {
            publisherNameTextBox.Text = SelectedPublisher.Name;
            BookRepository.GetAllBooks().Where(x => x.PublisherId == SelectedPublisher.PublisherId).ToList().ForEach(x=>publisherBooksListBox.Items.Add(x.PrintWithoutPublisher()));
            if (publisherBooksListBox.Items.Count == 0) publisherBooksListBox.Items.Add("No books by this publisher.");

        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
