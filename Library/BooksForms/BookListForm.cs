using System;
using System.Linq;
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
            rentedBooksListBox.Items.Clear();
            notRentedListBox.Items.Clear();
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
            rentedBooksLabel.Text = $@"Currently rented books: {rentedBooks.Count} ";
            notRentedBooksLabel.Text = $@"Currently available books: {newBooksNotRentedBooksUnion.Count}";

        }

        private void AddBookButtonClick(object sender, EventArgs e)
        {
            if (AuthorRepository.GetAllAuthors().Count == 0 || PublisherRepository.GetAllPublishers().Count==0)
            {
                var errorForm = new ErrorForm("There is no author or publisher in database so you cant create book.");
                errorForm.ShowDialog();
            }
            else
            {
                var bookCreateForm = new BookCreateForm(BookRepository, AuthorRepository, PublisherRepository);
                bookCreateForm.AddRefreshList();
                bookCreateForm.ShowDialog();
                AddRefreshList();
            }
        }

        private void EditBookButtonClick(object sender, EventArgs e)
        {
            var selectedBook = notRentedListBox.SelectedItem as Book;
            if (rentedBooksListBox.SelectedItem != null)
                selectedBook = rentedBooksListBox.SelectedItem as Book;
            if (selectedBook == null)
            {
               var errorForm = new ErrorForm("You need to select book");
               errorForm.ShowDialog();
            }
            else
            {
                var bookEditForm = new BookEditForm(BookRepository, AuthorRepository, PublisherRepository)
                    {SelectedBook = selectedBook};
                bookEditForm.SetText();
                bookEditForm.AddRefreshList();
                bookEditForm.ShowDialog();
                AddRefreshList();
            }
        }

        private void NotRentedListBoxClick(object sender, EventArgs e)
        {
            rentedBooksListBox.SelectedItem = null;
        }

        private void RentedBooksListBoxClick(object sender, EventArgs e)
        {
            notRentedListBox.SelectedItem = null;
        }

        private void DeleteBookButtonClick(object sender, EventArgs e)
        {
            var selectedBook = notRentedListBox.SelectedItem as Book;
            if (rentedBooksListBox.SelectedItem != null)
                selectedBook = rentedBooksListBox.SelectedItem as Book;
            if (selectedBook == null)
            {
                var errorForm = new ErrorForm("You need to select book");
                errorForm.ShowDialog();
            }
            else
            {
                BookRepository.RemoveBook(selectedBook.BookId);
                AddRefreshList();
            }

        }

        private void ViewBookButtonClick(object sender, EventArgs e)
        {
            var selectedBook = notRentedListBox.SelectedItem as Book;
            if (rentedBooksListBox.SelectedItem != null)
                selectedBook = rentedBooksListBox.SelectedItem as Book;
            if (selectedBook == null)
            {
                var errorForm = new ErrorForm("You need to select book");
                errorForm.ShowDialog();
            }
            else
            {
                var bookDetailsForm = new BookDetailsForm(BookRentRepository, BookRepository)
                    {SelectedBook = selectedBook};
                bookDetailsForm.SetText();
                bookDetailsForm.AddRefreshList();
                bookDetailsForm.ShowDialog();
            }
        }
    }
}
