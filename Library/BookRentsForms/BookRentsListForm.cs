using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.BookRentsForms
{
    public partial class BookRentsListForm : Form
    {
        public BookRentRepository BookRentRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public BookRentsListForm(BookRentRepository bookRentRepository,StudentRepository studentRepository, BookRepository bookRepository)
        {
            InitializeComponent();
            BookRentRepository = bookRentRepository;
            StudentRepository = studentRepository;
            BookRepository = bookRepository;
        }

        public void AddRefreshList()
        {
            bookRentActiveListBox.Items.Clear();
            booksRentNotActiveListBox.Items.Clear();
            var rentedBookRents = BookRentRepository.GetAllBookRents().Where(x => x.DateOfReturn==null).ToList();
            rentedBookRents.ForEach(x => bookRentActiveListBox.Items.Add(x));
            var notRentedBookRents = BookRentRepository.GetAllBookRents().Where(x => x.DateOfReturn != null).ToList();
            notRentedBookRents.ForEach(x=>booksRentNotActiveListBox.Items.Add(x));
            currentlyRentedBooksLabel.Text = $@"Current rents : {rentedBookRents.Count}";
            booksToRentLabel.Text = $@"Rents from past : {notRentedBookRents.Count}";
            
        }

        private void AddBookRentButtonClick(object sender, EventArgs e)
        {
            if (StudentRepository.GetAllStudents().Count == 0 || BookRepository.GetAllBooks().Count == 0)
            {
                var errorForm = new ErrorForm("You cant add book rent as there is no book or student");
                errorForm.ShowDialog();
            }
            else
            {
                var bookRentCreateForm = new BookRentCreateForm(BookRentRepository, BookRepository, StudentRepository);
                bookRentCreateForm.AddRefreshList();
                bookRentCreateForm.ShowDialog();
                AddRefreshList();
            }
        }

        private void EditBookRentButtonClick(object sender, EventArgs e)
        {
            var selectedBookRent = booksRentNotActiveListBox.SelectedItem as BookRent;
            if(bookRentActiveListBox.SelectedItem!=null)
            selectedBookRent=bookRentActiveListBox.SelectedItem as BookRent;
            if (selectedBookRent == null)
            {
                var errorForm = new ErrorForm("You need to select bookrent.");
                errorForm.ShowDialog();
            }
            else
            {
                var bookRentEditForm = new BookRentEditForm(BookRentRepository, BookRepository, StudentRepository)
                    {SelectedBookRent = selectedBookRent};
                bookRentEditForm.SetText();
                bookRentEditForm.ShowDialog();
                AddRefreshList();
            }
        }

        private void BooksRentNotActiveListBoxReset(object sender, EventArgs e)
        {
            bookRentActiveListBox.SelectedItem = null;
        }

        private void BookRentActiveListBoxReset(object sender, EventArgs e)
        {
            booksRentNotActiveListBox.SelectedItem = null;
        }

        private void DeleteBookRentButtonClick(object sender, EventArgs e)
        {
            var selectedBookRent = booksRentNotActiveListBox.SelectedItem as BookRent;
            if (bookRentActiveListBox.SelectedItem != null)
                selectedBookRent = bookRentActiveListBox.SelectedItem as BookRent;
            if (selectedBookRent == null)
            {
                var errorForm = new ErrorForm("You need to select bookrent.");
                errorForm.ShowDialog();
            }
            else
            {
                BookRentRepository.RemoveBookRent(selectedBookRent.BookRentId);
                AddRefreshList();
            }

        }

        private void ViewBookRentButtonClick(object sender, EventArgs e)
        {
            var selectedBookRent = booksRentNotActiveListBox.SelectedItem as BookRent;
            if (bookRentActiveListBox.SelectedItem != null)
                selectedBookRent = bookRentActiveListBox.SelectedItem as BookRent;
            if (selectedBookRent == null)
            {
                var errorForm = new ErrorForm("You need to select bookrent.");
                errorForm.ShowDialog();
            }
            else
            {
                var bookRentDetailsForm = new BookRentDetailsForm(BookRentRepository, BookRepository, StudentRepository)
                    {SelectedBookRent = selectedBookRent};
                bookRentDetailsForm.SetText();
                bookRentDetailsForm.ShowDialog();
            }

        }
    }
}
