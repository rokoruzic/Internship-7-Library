using System;
using System.Linq;
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
            if (returnDateDateTimePicker.Value < rentDateDateTimePicker.Value && isReturnedCheckBox.Checked)
            {
                var errorForm = new ErrorForm("Date of return cant be before date of rent");
                errorForm.ShowDialog();
            }
            else
            {
                var bookRentToEdit = new BookRent
                {
                    DateOfRent = rentDateDateTimePicker.Value,
                    DateOfReturn = returnDateDateTimePicker.Value,
                    Student = SelectedBookRent.Student,
                    StudentId = SelectedBookRent.Student.StudentId,
                    BookId = SelectedBookRent.Book.BookId,
                    BookRentId = SelectedBookRent.BookRentId,
                    Book = SelectedBookRent.Book
                };
                if (!isReturnedCheckBox.Checked) bookRentToEdit.DateOfReturn = null;
                var specificBookRent = BookRentRepository.GetAllBookRents()
                    .Where(x => x.BookId == bookRentToEdit.Book.BookId).ToList();
                var wantedBookRent = BookRentRepository.GetAllBookRents()
                    .Where(x => x.BookRentId == bookRentToEdit.BookRentId).ToList();
                var specificBookRentFiltered = specificBookRent.Except(wantedBookRent).ToList();
                var specificBookRent2 = BookRentRepository.GetAllBookRents()
                    .Where(x => x.StudentId == bookRentToEdit.Student.StudentId).ToList();
                var specificBookRent2Filtered = specificBookRent2.Except(wantedBookRent).ToList();
                if (BookRentRepository.CheckAvailableDate(specificBookRentFiltered, bookRentToEdit) &&
                    BookRentRepository.CheckAvailableDate(specificBookRent2Filtered, bookRentToEdit))
                {
                    BookRentRepository.EditBookRent(bookRentToEdit);
                    Close();
                }

                else
                {
                    var errorForm = new ErrorForm("That date is already taken");
                    errorForm.ShowDialog();
                }
            }
        }
    }
}
