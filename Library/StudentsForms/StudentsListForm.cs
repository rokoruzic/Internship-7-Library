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
using Library.StudentsForms;

namespace Library
{
    public partial class StudentsListForm : Form
    {
        public LibraryContext LibraryContext { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }
        public StudentsListForm(StudentRepository studentRepository, BookRentRepository bookRentRepository)
        {
            InitializeComponent();
            LibraryContext=new LibraryContext();
            StudentRepository = studentRepository;
            BookRentRepository = bookRentRepository;



        }

        public void AddRefreshList()
        {
            StudentRepository.GetAllStudents().ForEach(x=>studentsListBox.Items.Add(x));
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            var selectedStudent = studentsListBox.SelectedItem as Student;

            var studentsEditForm = new StudentsEditForm(StudentRepository) {SelectedStudent = selectedStudent};
            studentsEditForm.SetText();
            studentsEditForm.AddRefreshList();
            studentsEditForm.ShowDialog();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var studentsCreateForm = new StudentsCreateForm(StudentRepository);
            studentsCreateForm.Show();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var selectedStudent = studentsListBox.SelectedItem as Student;
            StudentRepository.RemoveStudent(selectedStudent.StudentId);
            var bookRentToDelete = BookRentRepository.GetAllBookRents()
                .FirstOrDefault(x => x.StudentId == selectedStudent.StudentId);
            if(bookRentToDelete==null) return;
            BookRentRepository.RemoveBookRent(bookRentToDelete.BookRentId);

        }

        private void ViewButtonClick(object sender, EventArgs e)
        {
            var selectedStudent = studentsListBox.SelectedItem as Student;
            var studentsDetailsForm = new StudentsDetailsForm(StudentRepository,BookRentRepository) { SelectedStudent = selectedStudent };
            studentsDetailsForm.AddRefreshList();
            studentsDetailsForm.Show();


        }
    }
}
