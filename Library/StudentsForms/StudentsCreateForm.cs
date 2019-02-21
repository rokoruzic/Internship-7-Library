using System;
using System.Windows.Forms;
using Library.Data.Entities.Enums;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.StudentsForms
{
    public partial class StudentsCreateForm : Form
    {
        public StudentRepository StudentRepository { get; set; }
        public StudentsCreateForm(StudentRepository studentRepository)
        {
            InitializeComponent();
            StudentRepository = studentRepository;
            foreach (var gender in (Gender[])Enum.GetValues(typeof(Gender)))
            {
                genderComboBox.Items.Add(gender);
            }
            dateOfBirthDateTimePicker.MaxDate=DateTime.Now.AddYears(-10);
                
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(classLetterTextBox.Text)
                                                            || string.IsNullOrEmpty(lastNameTextBox.Text) ||
                                                            genderComboBox.SelectedItem == null)
            {
                var errorForm =  new ErrorForm("You need to fill all boxes.");
                errorForm.ShowDialog();
            }
            else
            {

                var studentToAdd = new Student
                {
                    Class = $"{classNumberNumUpDown.Value.ToString()}.{classLetterTextBox.Text}",
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Gender = (Gender) genderComboBox.SelectedItem,
                    DateOfBirth = dateOfBirthDateTimePicker.Value
                };
                StudentRepository.AddStudent(studentToAdd);
                Close();
            }
        }
    }
}
