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
            var bookRentOfStudent = BookRentRepository.GetAllBookRents()
                .FirstOrDefault(x => x.StudentId == SelectedStudent.StudentId);
            if (bookRentOfStudent == null) return;
            var getBookRentOfStudent = BookRentRepository.GetBookRent(bookRentOfStudent.BookId, bookRentOfStudent.StudentId);
            booksComboBox.Items.Add(getBookRentOfStudent);
           
            var availableBookRent = BookRentRepository.GetAllBookRents().FirstOrDefault((x =>
                (x.DateOfReturn != null && x.StudentId != SelectedStudent.StudentId)));
            if (availableBookRent == null) return;
            var getAvailableBookRent = BookRentRepository.GetBookRent(availableBookRent.BookId, availableBookRent.StudentId); 
            booksToRentComboBox.Items.Add(getAvailableBookRent);
           
        }

        private void RemoveRentButtonClick(object sender, EventArgs e)
        {
            booksToRentComboBox.Items.Add(booksComboBox.SelectedItem);
            booksComboBox.Items.Remove(booksComboBox.SelectedItem);
            booksComboBox.ResetText();
            
        }

       

        private void AddRentButtonClick(object sender, EventArgs e)
        {
            dateOfReturnDateTimePicker.Hide();
            datOfRentDateTimePicker.Hide();
            isReturnedCheckBox.Hide();
            booksToRentComboBox.ResetText();
            var bookToRent = new BookRent();
            bookToRent = booksToRentComboBox.SelectedItem as BookRent;
            var editedBookRent = new BookRent();
            editedBookRent.DateOfReturn = dateOfReturnDateTimePicker.Value;
            editedBookRent.DateOfRent = datOfRentDateTimePicker.Value;
            editedBookRent.BookId = bookToRent.BookId;
            
            editedBookRent.StudentId = SelectedStudent.StudentId;
            var getEditedBookRent = BookRentRepository.GetBookRent(editedBookRent.BookId, editedBookRent.StudentId);
            getEditedBookRent.DateOfReturn = dateOfReturnDateTimePicker.Value;
            getEditedBookRent.DateOfRent = datOfRentDateTimePicker.Value;
            booksToRentComboBox.Items.Remove(booksToRentComboBox.SelectedItem);
            if (isReturnedCheckBox.Checked)
            getEditedBookRent.DateOfReturn = null;
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
            studentToEdit.StudentId = SelectedStudent.StudentId;
            studentToEdit.Class = classTextBox.Text;
            studentToEdit.DateOfBirth = dateOfBirthDateTimePicker.Value;
            studentToEdit.FirstName = firstNameTextBox.Text;
            studentToEdit.LastName = lastNameTextBox.Text;
            studentToEdit.Gender = SelectedStudent.Gender;
            foreach (var bookRent in booksComboBox.Items)
            {
                BookRentRepository.EditBookRent(bookRent as BookRent);
            }

            StudentRepository.EditStudent(studentToEdit);
        }

       
    }
}
