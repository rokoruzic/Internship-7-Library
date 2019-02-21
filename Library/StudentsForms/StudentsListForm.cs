using System;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.StudentsForms
{
    public partial class StudentsListForm : Form
    {
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }

        public StudentsListForm(StudentRepository studentRepository, BookRentRepository bookRentRepository)
        {
            InitializeComponent();
            StudentRepository = studentRepository;
            BookRentRepository = bookRentRepository;
        }

        public void AddRefreshList()
        {
            studentsListBox.Items.Clear();
            StudentRepository.GetAllStudents().ForEach(x=>studentsListBox.Items.Add(x));
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedItem is Student selectedStudent)
            {
                var studentsEditForm = new StudentsEditForm(StudentRepository) {SelectedStudent = selectedStudent};
                studentsEditForm.SetText();
                studentsEditForm.AddRefreshList();
                studentsEditForm.ShowDialog();
                AddRefreshList();
            }
            else
            {
                var errorForm = new ErrorForm("You have to select student");
                errorForm.ShowDialog();
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var studentsCreateForm = new StudentsCreateForm(StudentRepository);
            studentsCreateForm.ShowDialog();
            AddRefreshList();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (!(studentsListBox.SelectedItem is Student selectedStudent))
            {
                var errorForm = new ErrorForm("You have to select student");
                errorForm.ShowDialog();
            }
            else
            StudentRepository.RemoveStudent(selectedStudent.StudentId);
            AddRefreshList();
        }

        private void ViewButtonClick(object sender, EventArgs e)
        {
            if (!(studentsListBox.SelectedItem is Student selectedStudent))
            {
                var errorForm = new ErrorForm("You have to select student");
                errorForm.ShowDialog();
            }
            else
            {
                var studentsDetailsForm = new StudentsDetailsForm(StudentRepository, BookRentRepository)
                    {SelectedStudent = selectedStudent};
                studentsDetailsForm.AddRefreshList();
                studentsDetailsForm.ShowDialog();
            }
        }
    }
}
