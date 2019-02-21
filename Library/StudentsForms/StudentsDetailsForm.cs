using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.StudentsForms
{
    public partial class StudentsDetailsForm : Form
    {
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }
        public Student SelectedStudent { get; set; }
        public StudentsDetailsForm(StudentRepository studentRepository, BookRentRepository bookRentRepository)
        {
            InitializeComponent();
            StudentRepository = studentRepository;
            BookRentRepository = bookRentRepository;
        }

        public void AddRefreshList()
        {
            var bookRentsOfSelectedStudents
                = BookRentRepository.GetAllBookRents().Where(x => x.StudentId == SelectedStudent.StudentId).ToList();
            bookRentsOfSelectedStudents.ForEach(x=>bookRentsListBox.Items.Add(x));
            var notReturnedBookRentsOfSelectedStudent = bookRentsOfSelectedStudents.Where(x => x.DateOfReturn == null).ToList();
            isRentActiveLabel.Text = notReturnedBookRentsOfSelectedStudent.Count>0 ? "Rent  active" : "Rent not active";
            studentDetailsLabel.Text = SelectedStudent.Print();

        }

        private void StudentDetailsExitButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
