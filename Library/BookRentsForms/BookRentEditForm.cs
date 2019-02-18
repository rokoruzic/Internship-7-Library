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
    public partial class BookRentEditForm : Form
    {
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public BookRent SelectedBookRent { get; set; }
        public BookRentEditForm(BookRentRepository bookRentRepository,BookRepository bookRepository,StudentRepository studentRepository)
        {
            InitializeComponent();
            BookRentRepository = bookRentRepository;
            BookRepository = bookRepository;
            StudentRepository = studentRepository;
            returnDateDateTimePicker.Hide();
        }

        public void SetText()
        {
            rentDateDateTimePicker.Value = SelectedBookRent.DateOfRent;
        }

        private void IsReturnedCheckBoxChanged(object sender, EventArgs e)
        {
            returnDateDateTimePicker.Show();
            isReturnedCheckBox.Hide();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var bookRentToEdit = new BookRent();
            bookRentToEdit.DateOfRent = rentDateDateTimePicker.Value;
            bookRentToEdit.DateOfReturn = returnDateDateTimePicker.Value;
            bookRentToEdit.Student = SelectedBookRent.Student;
            bookRentToEdit.StudentId = SelectedBookRent.Student.StudentId;
            bookRentToEdit.BookId = SelectedBookRent.Book.BookId;
            bookRentToEdit.BookRentId = SelectedBookRent.BookRentId;
            bookRentToEdit.Book = SelectedBookRent.Book;
            if (!isReturnedCheckBox.Checked) bookRentToEdit.DateOfReturn = null;
            var specificBookRent = BookRentRepository.GetAllBookRents()
                .Where(x => x.BookId == bookRentToEdit.Book.BookId).ToList();
            var macka = new List<BookRent>();
            macka.Add(bookRentToEdit);
            var wantedBookRent = BookRentRepository.GetAllBookRents()
                .Where(x => x.BookRentId == bookRentToEdit.BookRentId).ToList();
            var spec = specificBookRent.Except(wantedBookRent).ToList();
            var specificBookRent2 = BookRentRepository.GetAllBookRents()
                .Where(x => x.StudentId == bookRentToEdit.Student.StudentId).ToList();
            var spec2 = specificBookRent2.Except(wantedBookRent).ToList();
            if (spec.Count == 0 || spec2.Count == 0) BookRentRepository.EditBookRent(bookRentToEdit);
            if (BookRentRepository.CheckAvailableDate(spec, bookRentToEdit) && BookRentRepository.CheckAvailableDate(spec2, bookRentToEdit))
                BookRentRepository.EditBookRent(bookRentToEdit);
        }
    }
}
