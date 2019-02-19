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

namespace Library.BooksForms
{
    public partial class BookListForm : Form
    {
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public AuthorRepository AuthorRepository { get; set; }
        public PublisherRepository PublisherRepository { get; set; }
        public BookListForm(BookRentRepository bookRentRepository,BookRepository bookRepository,AuthorRepository authorRepository,PublisherRepository publisherRepository)
        {
            InitializeComponent();
            BookRentRepository = bookRentRepository;
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
            PublisherRepository = publisherRepository;
        }

        public void AddRefreshList()
        {
            var rentedBooks = BookRentRepository.GetAllBookRents().Where(x => x.DateOfReturn == null)
                .Select(x => x.Book).ToList();
            var notRentedBooks = BookRentRepository.GetAllBookRents().Where(x => x.DateOfReturn != null)
                .Select(x => x.Book).ToList();
            var allBooks = BookRepository.GetAllBooks();
            var allBooksWithBookRentHistory = BookRentRepository.GetAllBookRents().Select(x => x.Book).ToList();
            var newBooks = allBooks.Except(allBooksWithBookRentHistory);
            var newBooksNotRentedBooksUnion = notRentedBooks.Union(newBooks).ToList();
            rentedBooks.ForEach(x=>rentedBooksListBox.Items.Add(x));
            newBooksNotRentedBooksUnion.ForEach(x=>notRentedListBox.Items.Add(x));
            rentedBooksLabel.Text = $"Currently rented books: {rentedBooks.Count} ";
            notRentedBooksLabel.Text = $"Currently available books: {newBooksNotRentedBooksUnion.Count}";

        }

        private void AddBookButtonClick(object sender, EventArgs e)
        {
            if (AuthorRepository.GetAllAuthors().Count == 0) return;
            var bookCreateForm = new BookCreateForm(BookRepository,AuthorRepository,PublisherRepository);
            bookCreateForm.AddRefreshList();
            bookCreateForm.Show();

        }

        private void EditBookButtonClick(object sender, EventArgs e)
        {
            var selectedBook = notRentedListBox.SelectedItem as Book;
            if (rentedBooksListBox.SelectedItem != null)
                selectedBook = rentedBooksListBox.SelectedItem as Book;
            if (selectedBook == null) return;
            var bookEditForm = new BookEditForm(BookRepository, AuthorRepository, PublisherRepository){SelectedBook = selectedBook};
            bookEditForm.SetText();
            bookEditForm.AddRefreshList();
            bookEditForm.Show();
        }

        private void NotRentedListBoxClick(object sender, EventArgs e)
        {
            rentedBooksListBox.SelectedItem = null;
        }

        private void RentedBooksListBoxClick(object sender, EventArgs e)
        {
            notRentedListBox.SelectedItem = null;
        }
    }
}
