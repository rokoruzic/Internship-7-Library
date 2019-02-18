using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BookRentsForms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library
{
    public partial class MenuForm : Form
    {
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository  BookRepository { get; set; }
        public AuthorRepository AuthorRepository { get; set; }
        public AuthorBookRepository AuthorBookRepository { get; set; }
        public PublisherRepository PublisherRepository { get; set; }
        public LibraryContext LibraryContext { get; set; }
        public MenuForm()
        {
            InitializeComponent();
            LibraryContext = new LibraryContext();
            StudentRepository = new StudentRepository(LibraryContext);
            BookRepository = new BookRepository(LibraryContext);
            BookRentRepository = new BookRentRepository(LibraryContext);
            AuthorRepository = new AuthorRepository(LibraryContext);
            PublisherRepository = new PublisherRepository(LibraryContext);
            AuthorBookRepository= new AuthorBookRepository(LibraryContext);

        }

        private void StudentsButtonClick(object sender, EventArgs e)
        {
            var studentsListForm = new StudentsListForm(StudentRepository,BookRentRepository);
            studentsListForm.AddRefreshList();
            studentsListForm.ShowDialog();

        }

        private void BookRentsButtonClick(object sender, EventArgs e)
        {
            var bookRentsListForm = new BookRentsListForm(BookRentRepository, StudentRepository,BookRepository);
            bookRentsListForm.AddRefreshList();
            bookRentsListForm.ShowDialog();
        }
    }
}
