using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Enums;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.StudentsForms
{
    public partial class StudentsCreateForm : Form
    {
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }

        public StudentsCreateForm(StudentRepository studentRepository)
        {
            InitializeComponent();
            StudentRepository = studentRepository;
            foreach (var gender in (Gender[])Enum.GetValues(typeof(Gender)))
            {
                genderComboBox.Items.Add(gender);
            }

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var studentToAdd=new Student();
            studentToAdd.Class = classTextBox.Text;
            studentToAdd.FirstName = firstNameTextBox.Text;
            studentToAdd.LastName = lastNameTextBox.Text;
            studentToAdd.Gender = (Gender) genderComboBox.SelectedItem;
            studentToAdd.DateOfBirth = dateOfBirthDateTimePicker.Value;
            StudentRepository.AddStudent(studentToAdd);
        }
    }
}
