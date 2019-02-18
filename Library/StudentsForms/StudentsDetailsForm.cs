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
            var a = BookRentRepository.GetAllBookRents().Where(x => x.StudentId == SelectedStudent.StudentId).ToList();
            a.ForEach(x=>bookRentsListBox.Items.Add(x));
            var b = a.Where(x => x.DateOfReturn == null).ToList();
            if (b.Count>0 ) isRentActiveTextBox.Text = "Rent  active";
            else isRentActiveTextBox.Text = "Rent not active";

            //foreach (var bookRent in a)
            //{
            //    if (bookRent.DateOfReturn == null) isRentActiveTextBox.Text = "Rent is active";
            //}
        }

        public void SetText()
        {

        }
    }
}
