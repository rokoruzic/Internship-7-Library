using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.BookRentsForms
{
    public partial class BookRentCreateForm : Form
    {
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public BookRentCreateForm(BookRentRepository bookRentRepository,BookRepository bookRepository,StudentRepository studentRepository)
        {
            InitializeComponent();
            BookRentRepository = bookRentRepository;
            BookRepository = bookRepository;
            StudentRepository = studentRepository;
            dateOfReturnDateTimePicker.Hide();
            dateOfReturnDateTimePicker.MaxDate=DateTime.Now;
            dateOfReturnDateTimePicker.MinDate = DateTime.Now.AddYears(-8);
        }

        public void AddRefreshList()
        {
            var allBooks = BookRepository.GetAllBooks();
            var studentsNotToAdd = new List<Student>();
            var booksNotToAdd = new List<Book>();
            foreach (var student in StudentRepository.GetAllStudents())
            {
                foreach (var allBookRent in BookRentRepository.GetAllBookRents())
                {
                    if
                       (!allBookRent.DateOfReturn.HasValue && student.StudentId==allBookRent.StudentId) studentsNotToAdd.Add(student);
                }
            }

            foreach (var book in allBooks)
            {
                foreach (var bookRent in BookRentRepository.GetAllBookRents())
                {
                    if(!bookRent.DateOfReturn.HasValue && book.BookId==bookRent.BookId) booksNotToAdd.Add(book);
                }
            }

            var availableStudents = StudentRepository.GetAllStudents().Except(studentsNotToAdd).ToList();
            var availableBooks = BookRepository.GetAllBooks().Except(booksNotToAdd).ToList();
           availableBooks.ForEach(x=>availableBookRentsComboBox.Items.Add(x));
          availableStudents.ForEach(x=>availableStudentsComboBox.Items.Add(x));

        }

        private void IsReturnedCheckBoxChanged(object sender, EventArgs e)
        {
            dateOfReturnDateTimePicker.Show();
            isReturnedCheckBox.Hide();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (availableBookRentsComboBox.SelectedItem == null || availableStudentsComboBox.SelectedItem == null)
            {
                var errorForm = new ErrorForm("You need to select student and book");
                errorForm.ShowDialog();
            }
            else
            {
                if (dateOfReturnDateTimePicker.Value < dateOfRentDateTimePicker.Value && isReturnedCheckBox.Checked)
                {
                    var errorForm = new ErrorForm("Date of return cant be before date of rent");
                    errorForm.ShowDialog();
                }
                else
                {

                    var bookRentToAdd = new BookRent
                    {
                        Student = availableStudentsComboBox.SelectedItem as Student,
                        Book = availableBookRentsComboBox.SelectedItem as Book,
                        DateOfRent = dateOfRentDateTimePicker.Value,
                        DateOfReturn = dateOfReturnDateTimePicker.Value
                    };
                    if (!isReturnedCheckBox.Checked) bookRentToAdd.DateOfReturn = null;
                    var specificBookRent = BookRentRepository.GetAllBookRents()
                        .Where(x => x.BookId == bookRentToAdd.Book.BookId).ToList();
                    var specificBookRent2 = BookRentRepository.GetAllBookRents()
                        .Where(x => x.StudentId == bookRentToAdd.Student.StudentId).ToList();
                    if (BookRentRepository.CheckAvailableDate(specificBookRent, bookRentToAdd) &&
                        BookRentRepository.CheckAvailableDate(specificBookRent2, bookRentToAdd))
                    {
                        BookRentRepository.AddBookRent(bookRentToAdd);
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
}
