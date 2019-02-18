using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Enums;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.StudentsForms
{
    public partial class StudentsEditForm : Form
    {
        public Student SelectedStudent { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public LibraryContext LibraryContext { get; set; }



        public StudentsEditForm(StudentRepository studentRepository)
        {
            InitializeComponent();
            StudentRepository = studentRepository;
            LibraryContext= new LibraryContext();
            BookRentRepository= new BookRentRepository(LibraryContext);
            BookRepository= new BookRepository(LibraryContext);
            dateOfReturnDateTimePicker.Hide();
            datOfRentDateTimePicker.Hide();
           isReturnedCheckBox.Hide();
          
        }

        public void SetText()
        {
            firstNameTextBox.Text = SelectedStudent.FirstName;
            lastNameTextBox.Text = SelectedStudent.LastName;
            classTextBox.Text = SelectedStudent.Class;
           
           
        }

        public void AddRefreshList()
        {
            //var macka =BookRentRepository.GetAllBookRents().FirstOrDefault(x => x.StudentId != SelectedStudent.StudentId && x.DateOfReturn !=null);
            //if(macka!=null
            //    )
               
            //booksToRentComboBox.Items.Add(macka);
            //var pas = BookRentRepository.GetAllBookRents()
            //    .FirstOrDefault(x => x.StudentId == SelectedStudent.StudentId);
            //if(pas!=null)
            //booksComboBox.Items.Add(pas);
            //var bookRentOfStudent = BookRentRepository.GetAllBookRents()
            //    .FirstOrDefault(x => x.StudentId == SelectedStudent.StudentId);
            //if (bookRentOfStudent != null)
            //{
            //    var getBookRentOfStudent = BookRentRepository.GetBookRent(bookRentOfStudent.BookId, bookRentOfStudent.StudentId);
            //    booksComboBox.Items.Add(getBookRentOfStudent);
            //}


            //var availableBookRent = BookRentRepository.GetAllBookRents().FirstOrDefault((x =>
            //    (x.DateOfReturn != null && x.StudentId != SelectedStudent.StudentId)));
            //if (availableBookRent != null)
            //{
            //    var getAvailableBookRent =
            //        BookRentRepository.GetBookRent(availableBookRent.BookId, availableBookRent.StudentId);
            //    if (getAvailableBookRent != null)
            //        booksToRentComboBox.Items.Add(getAvailableBookRent);
            //}
            var books = BookRentRepository.GetAllBookRents().Where(x => x.StudentId == SelectedStudent.StudentId)
                .ToList();
            books.ForEach(x=>booksComboBox.Items.Add(x));
            var books2 = BookRentRepository.GetAllBookRents()
                .Where(x =>x.DateOfReturn!=null&& x.StudentId != SelectedStudent.StudentId).ToList();
            books2.ForEach(x=>booksToRentComboBox.Items.Add(x));
            //var bookRentOfStudent = BookRentRepository.GetAllBookRents()
            //    .FirstOrDefault(x => x.StudentId == SelectedStudent.StudentId);
            //if (bookRentOfStudent == null) return;
            //var getBookRentOfStudent = BookRentRepository.GetBookRentBookId(bookRentOfStudent.BookId);
            //booksComboBox.Items.Add(bookRentOfStudent);

            //var availableBookRent = BookRentRepository.GetAllBookRents().FirstOrDefault((x =>
            //    (x.DateOfReturn != null && x.StudentId != SelectedStudent.StudentId)));
            //if (availableBookRent == null) return;
            //var getAvailableBookRent = BookRentRepository.GetBookRentBookId(availableBookRent.BookId);
            //booksToRentComboBox.Items.Add(availableBookRent);


        }

        private void RemoveRentButtonClick(object sender, EventArgs e)
        {
            booksToRentComboBox.Items.Add(booksComboBox.SelectedItem as BookRent);
            booksComboBox.Items.Remove(booksComboBox.SelectedItem as BookRent);
            booksComboBox.ResetText();
            
        }

       

        private void AddRentButtonClick(object sender, EventArgs e)
        {
            dateOfReturnDateTimePicker.Hide();
            datOfRentDateTimePicker.Hide();
            isReturnedCheckBox.Hide();
            booksToRentComboBox.ResetText();
            var  bookToRent = booksToRentComboBox.SelectedItem as BookRent;
            var editedBookRent = new BookRent();
            editedBookRent.DateOfReturn = dateOfReturnDateTimePicker.Value;
            editedBookRent.DateOfRent = datOfRentDateTimePicker.Value;
            editedBookRent.BookId = bookToRent.BookId;
            
            editedBookRent.StudentId = SelectedStudent.StudentId;
            var getEditedBookRent = BookRentRepository.GetBookRentBookId(editedBookRent.BookId);
             
            getEditedBookRent.DateOfReturn = dateOfReturnDateTimePicker.Value;
            if (isReturnedCheckBox.Checked)
                getEditedBookRent.DateOfReturn = null;
            getEditedBookRent.DateOfRent = datOfRentDateTimePicker.Value;
            booksToRentComboBox.Items.Remove(booksToRentComboBox.SelectedItem);
           
            booksComboBox.Items.Add(getEditedBookRent);
        }

        private void BooksToRentComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
           dateOfReturnDateTimePicker.Show();
           datOfRentDateTimePicker.Show();
           isReturnedCheckBox.Show();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var studentToEdit = new Student();
            studentToEdit.BookRents = new List<BookRent>();
            studentToEdit.StudentId = SelectedStudent.StudentId;
            studentToEdit.Class = classTextBox.Text;
            studentToEdit.DateOfBirth = dateOfBirthDateTimePicker.Value;
            studentToEdit.FirstName = firstNameTextBox.Text;
            studentToEdit.LastName = lastNameTextBox.Text;
            studentToEdit.Gender = SelectedStudent.Gender;
            var list = new List<BookRent>();
            var list2 = new List<BookRent>();

            foreach (var bookRent in booksComboBox.Items)
            {
                list.Add(bookRent as BookRent);
                studentToEdit.BookRents.Add(bookRent as BookRent);
                //BookRentRepository.EditBookRent(bookRent as BookRent);
            }

            foreach (var bookRent in list)
            {
                bookRent.StudentId = SelectedStudent.StudentId;
            }
            list.ForEach(x => x.StudentId = SelectedStudent.StudentId);
            list.ForEach(x => BookRentRepository.EditBookRent(x));
            foreach (var bookRent in booksToRentComboBox.Items)
            {
                list2.Add(bookRent as BookRent);
                //BookRentRepository.RemoveBookRent(bookRent as BookRent);
            }

            booksToRentComboBox.Items.Clear();
            booksComboBox.Items.Clear();
            studentToEdit.BookRents = list;
            StudentRepository.EditStudent(studentToEdit);
        }

       
    }
}
