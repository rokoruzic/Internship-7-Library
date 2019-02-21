using System;
using System.Windows.Forms;
using Library.Data.Entities.Enums;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.StudentsForms
{
    public partial class StudentsEditForm : Form
    {
        public Student SelectedStudent { get; set; }
        public StudentRepository StudentRepository { get; set; }

        public StudentsEditForm(StudentRepository studentRepository)
        {
            InitializeComponent();
            StudentRepository = studentRepository;
        }

        public void SetText()
        {
            firstNameTextBox.Text = SelectedStudent.FirstName;
            lastNameTextBox.Text = SelectedStudent.LastName;

        }

        public void AddRefreshList()
        {
            foreach (var gender in (Gender[])Enum.GetValues(typeof(Gender)))
            {
                genderComboBox.Items.Add(gender);
            }
           
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(classLetterTextBox.Text)
                                                            || string.IsNullOrEmpty(lastNameTextBox.Text) ||
                                                            genderComboBox.SelectedItem == null)
            {
                var errorForm = new ErrorForm("You need to fill all boxes.");
                errorForm.ShowDialog();
            }
            else
            {
                var studentToEdit = new Student
                {
                    BookRents = SelectedStudent.BookRents,
                    StudentId = SelectedStudent.StudentId,
                    Class = $"{classNumberNumUpDown}.{classLetterTextBox}",
                    DateOfBirth = dateOfBirthDateTimePicker.Value,
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Gender = (Gender) genderComboBox.SelectedItem
                };
                StudentRepository.EditStudent(studentToEdit);
                Close();
            }
        }
       
    }
}
