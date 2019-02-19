using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BookRentsForms;
using Library.Data.Entities.Enums;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.BooksForms
{
    public partial class BookEditForm : Form
    {
        public BookRepository BookRepository { get; set; }
        public AuthorRepository AuthorRepository { get; set; }
        public PublisherRepository PublisherRepository { get; set; }
        public Book SelectedBook { get; set; }
        public BookEditForm(BookRepository bookRepository, AuthorRepository authorRepository, PublisherRepository publisherRepository)
        {
            InitializeComponent();
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
            PublisherRepository = publisherRepository;
        }
        public void AddRefreshList()
        {
            AuthorRepository.GetAllAuthors().ForEach(x => authorsComboBox.Items.Add(x));
            PublisherRepository.GetAllPublishers().ForEach(x => publishersComboBox.Items.Add(x));
            foreach (var bookGenre in (BookGenre[])Enum.GetValues(typeof(BookGenre)))
            {
                genresComboBox.Items.Add(bookGenre);
            }
        }

        public void SetText()
        {
            bookNameTextBox.Text = SelectedBook.Name;
            publishersComboBox.SelectedItem = SelectedBook.Publisher.Name;
            authorsComboBox.SelectedItem = SelectedBook.Author.ToString();
            genresComboBox.SelectedItem = SelectedBook.Genre;

        }
        private void SaveButtonClick(object sender, EventArgs e)
        {
            var bookToEdit = new Book();
            bookToEdit.Author = authorsComboBox.SelectedItem as Author;
            bookToEdit.BookId = SelectedBook.BookId;
            bookToEdit.Publisher = publishersComboBox.SelectedItem as Publisher;
            bookToEdit.Genre = (BookGenre)genresComboBox.SelectedItem;
            bookToEdit.Name = bookNameTextBox.Text;
            bookToEdit.Pages = (int)bookPagesNumUpDown.Value;
            bookToEdit.PublisherId = bookToEdit.Publisher.PublisherId;
            BookRepository.EditBook(bookToEdit);
            Close();
            
        }

        private void SaveAllCopiesButtonClick(object sender, EventArgs e)
        {
            
            var bookCopies = BookRepository.GetAllBooks().Where(x => x.Name == SelectedBook.Name).ToList();

            foreach (var bookToEdit in bookCopies)
            {
                
                bookToEdit.Author = authorsComboBox.SelectedItem as Author;
                bookToEdit.Publisher = publishersComboBox.SelectedItem as Publisher;
                bookToEdit.Genre = (BookGenre)genresComboBox.SelectedItem;
                bookToEdit.Name = bookNameTextBox.Text;
                bookToEdit.Pages = (int)bookPagesNumUpDown.Value;
                bookToEdit.PublisherId = bookToEdit.Publisher.PublisherId;
            }
            bookCopies.ForEach(x=>BookRepository.EditBook(x));
            Close();
        }
    }
}
