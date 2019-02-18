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

namespace Library.BookRentsForms
{
    public partial class BookRentDetailsForm : Form
    {
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public BookRent SelectedBookRent { get; set; }

        public BookRentDetailsForm(BookRentRepository bookRentRepository,BookRepository bookRepository,StudentRepository studentRepository)
        {
            InitializeComponent();
            BookRentRepository = bookRentRepository;
            BookRepository = bookRepository;
            StudentRepository = studentRepository;
        }

        public void SetText()
        {
            bookNameLabel.Text = SelectedBookRent.Book.ToString();
            studentNameLabel.Text = SelectedBookRent.Student.ToString();
            dateOfRentLabel.Text = SelectedBookRent.DateOfRent.ToShortDateString();
            if (SelectedBookRent.DateOfReturn == null) dateOfReturnLabel.Text = "Book is still rented";
            else dateOfRentLabel.Text = SelectedBookRent.DateOfReturn.Value.ToShortDateString();
        }
    }
}
