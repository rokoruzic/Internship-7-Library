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
            var rentedBookRents = BookRentRepository.GetAllBookRents().Where(x => x.DateOfReturn==null).ToList();
            rentedBookRents.ForEach(x => bookRentActiveListBox.Items.Add(x));
            var notRentedBookRents = BookRentRepository.GetAllBookRents().Where(x => x.DateOfReturn != null).ToList();
            notRentedBookRents.ForEach(x=>booksRentNotActiveListBox.Items.Add(x));
            currentlyRentedBooksLabel.Text = $"Current rents : {rentedBookRents.Count}";
            booksToRentLabel.Text = $"Rents from past : {notRentedBookRents.Count}";
            
        }

        private void AddBookRentButtonClick(object sender, EventArgs e)
        {
            var bookRentCreateForm = new BookRentCreateForm(BookRentRepository,BookRepository,StudentRepository);
            bookRentCreateForm.AddRefreshList();
            bookRentCreateForm.ShowDialog();
        }

        private void EditBookRentButtonClick(object sender, EventArgs e)
        {
            var selectedBookRent = booksRentNotActiveListBox.SelectedItem as BookRent;
            if(bookRentActiveListBox.SelectedItem!=null)
            selectedBookRent=bookRentActiveListBox.SelectedItem as BookRent;
            var bookRentEditForm = new BookRentEditForm(BookRentRepository,BookRepository,StudentRepository) { SelectedBookRent = selectedBookRent };
            bookRentEditForm.SetText();
            bookRentEditForm.Show();
        }

        private void BooksRentNotActiveListBoxReset(object sender, EventArgs e)
        {
            bookRentActiveListBox.SelectedItem = null;
        }

        private void BookRentActiveListBoxReset(object sender, EventArgs e)
        {
            booksRentNotActiveListBox.SelectedItem = null;
        }
    }
}
