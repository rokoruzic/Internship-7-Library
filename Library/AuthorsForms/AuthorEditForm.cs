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
    public partial class AuthorEditForm : Form
    {
        public Author SelectedAuthor { get; set; }
        public AuthorRepository AuthorRepository { get; set; }
        public AuthorEditForm(AuthorRepository authorRepository)
        {
            InitializeComponent();
            AuthorRepository = authorRepository;
        }

        public void SetText()
        {
            authorFirstNameTextBox.Text = SelectedAuthor.FirstName;
            authorLastNameTextBox.Text = SelectedAuthor.LastName;
        }

        private void EditAuthorButtonClick(object sender, EventArgs e)
        {
            var authorToEdit = new Author();
            authorToEdit.AuthorId = SelectedAuthor.AuthorId;
            authorToEdit.FirstName = SelectedAuthor.FirstName;
            authorToEdit.LastName = SelectedAuthor.LastName;
            authorToEdit.Books = SelectedAuthor.Books;
            AuthorRepository.EditAuthor(authorToEdit);
            Close();
        }
    }
}
