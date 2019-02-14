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
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.StudentsForms;

namespace Library
{
    public partial class StudentsListForm : Form
    {
        public LibraryContext LibraryContext { get; set; }
        public StudentRepository StudentRepository { get; set; }

        public StudentsListForm()
        {
            InitializeComponent();
            LibraryContext=new LibraryContext();
            StudentRepository= new StudentRepository(LibraryContext);

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
    }
}
