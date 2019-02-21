using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.AuthorsForms;
using Library.BookRentsForms;
using Library.BooksForms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.PublishersForms;
using Library.StudentsForms;

namespace Library
{
    public partial class MenuForm : Form
    {
        public StudentRepository StudentRepository { get; set; }
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository  BookRepository { get; set; }
        public AuthorRepository AuthorRepository { get; set; }
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

        private void BooksButtonClick(object sender, EventArgs e)
        {
            var bookListForm = new BookListForm(BookRentRepository, BookRepository,AuthorRepository,PublisherRepository);
            bookListForm.AddRefreshList();
            bookListForm.ShowDialog();
        }

        private void PublishersButtonClick(object sender, EventArgs e)
        {
            var publisherListForm = new PublisherListForm(PublisherRepository, BookRepository);
            publisherListForm.AddRefreshList();
            publisherListForm.ShowDialog();
        }

        private void AuthorsButtonClick(object sender, EventArgs e)
        {
            var authorsListForm = new AuthorListForm(AuthorRepository, BookRepository);
                authorsListForm.AddRefreshList();
                authorsListForm.ShowDialog();
        }
    }
}
