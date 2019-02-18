using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        }

        public void AddRefreshList()
        {
            var allBooks = BookRepository.GetAllBooks();
            var studentsNotToadd = new List<Student>();
            var booksNotToAdd = new List<Book>();
            foreach (var student in StudentRepository.GetAllStudents())
            {
                foreach (var allBookRent in BookRentRepository.GetAllBookRents())
                {
                    if
                       (!allBookRent.DateOfReturn.HasValue && student.StudentId==allBookRent.StudentId) studentsNotToadd.Add(student);
                    
                }
            }

            var listOfStudents = new List<Student>();
            foreach (var student in StudentRepository.GetAllStudents())
            {
                foreach (var bookRent in student.BookRents)
                {
                    if (student.StudentId!=bookRent.StudentId) listOfStudents.Add(student);
                }
            }

            foreach (var book in allBooks)
            {
                foreach (var bookRent in BookRentRepository.GetAllBookRents())
                {
                    if(!bookRent.DateOfReturn.HasValue && book.BookId==bookRent.BookId) booksNotToAdd.Add(book);
                }
            }

            var nebuloza = StudentRepository.GetAllStudents().Except(studentsNotToadd).ToList();
            var nebuloza2 = BookRepository.GetAllBooks().Except(booksNotToAdd).ToList();
           nebuloza2.ForEach(x=>availableBookRentsComboBox.Items.Add(x));
          nebuloza.ForEach(x=>availableStudentsComboBox.Items.Add(x));
           

        }

        private void IsReturnedCheckBoxChanged(object sender, EventArgs e)
        {
            dateOfReturnDateTimePicker.Show();
            isReturnedCheckBox.Hide();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var bookRentToAdd = new BookRent();
            bookRentToAdd.Student=availableStudentsComboBox.SelectedItem as Student;
            bookRentToAdd.Book=availableBookRentsComboBox.SelectedItem as Book;
            bookRentToAdd.DateOfRent = dateOfRentDateTimePicker.Value;
            bookRentToAdd.DateOfReturn = dateOfReturnDateTimePicker.Value;
            if (!isReturnedCheckBox.Checked) bookRentToAdd.DateOfReturn = null;
            var specificBookRent = BookRentRepository.GetAllBookRents()
                .Where(x => x.BookId == bookRentToAdd.Book.BookId).ToList();
            var specificBookRent2 = BookRentRepository.GetAllBookRents()
                .Where(x => x.StudentId == bookRentToAdd.Student.StudentId).ToList();

            if (specificBookRent.Count==0 || specificBookRent2.Count==0) BookRentRepository.AddBookRent(bookRentToAdd);
            if (BookRentRepository.CheckAvailableDate(specificBookRent, bookRentToAdd) && BookRentRepository.CheckAvailableDate(specificBookRent2,bookRentToAdd))
                BookRentRepository.AddBookRent(bookRentToAdd);



        }
    }
}
