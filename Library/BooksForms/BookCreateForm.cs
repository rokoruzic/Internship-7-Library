using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Enums;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.BooksForms
{
    public partial class BookCreateForm : Form
    {
        public BookRepository BookRepository { get; set; }
        public AuthorRepository AuthorRepository { get; set; }
        public PublisherRepository PublisherRepository { get; set; }
        public BookCreateForm(BookRepository bookRepository,AuthorRepository authorRepository, PublisherRepository publisherRepository)
        {
            InitializeComponent();
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
            PublisherRepository = publisherRepository;
        }

        public void AddRefreshList()
        {
            AuthorRepository.GetAllAuthors().ForEach(x=>authorsComboBox.Items.Add(x));
            PublisherRepository.GetAllPublishers().ForEach(x=>publishersComboBox.Items.Add(x));
            foreach (var bookGenre in (BookGenre[])Enum.GetValues(typeof(BookGenre)))
            {
                genresComboBox.Items.Add(bookGenre);
            }
        }

        private void AddBookButtonClick(object sender, EventArgs e)
        {
            var bookToAdd = new Book();
            bookToAdd.Author=authorsComboBox.SelectedItem as Author;
            bookToAdd.Publisher=publishersComboBox.SelectedItem as Publisher;
            bookToAdd.Genre = (BookGenre) genresComboBox.SelectedItem;
            bookToAdd.Name = bookNameTextBox.Text;
            bookToAdd.Pages = (int) bookPagesNumUpDown.Value;
            bookToAdd.PublisherId = bookToAdd.Publisher.PublisherId;
            BookRepository.AddBook(bookToAdd);
        }
    }
}
