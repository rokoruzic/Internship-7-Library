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

namespace Library.AuthorsForms
{
    public partial class AuthorDetailsForm : Form
    {
        public AuthorRepository AuthorRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public Author SelectedAuthor { get; set; }  
        public AuthorDetailsForm(AuthorRepository authorRepository,BookRepository bookRepository)
        {
            InitializeComponent();
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
        }

        public void AddRefreshList()
        {
            authorNameTextBox.Text = SelectedAuthor.ToString();
            BookRepository.GetAllBooks().Where(x=>x.Author.AuthorId==SelectedAuthor.AuthorId).ToList().ForEach(x=>authorBooksListBox.Items.Add(x.PrintWithoutAuthor()));
            if (authorBooksListBox.Items.Count == 0) authorBooksListBox.Items.Add("Author has no books.");
        }
    }
}
