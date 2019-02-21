using System;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.AuthorsForms
{
    public partial class AuthorCreateForm : Form
    {
        public AuthorRepository AuthorRepository { get; set; }
        public AuthorCreateForm(AuthorRepository authorRepository)
        {
            InitializeComponent();
            AuthorRepository = authorRepository;
        }

        private void AddAuthorButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(authorFirstNameTextBox.Text) || string.IsNullOrEmpty(authorLastNameTextBox.Text))
            {
                var errorForm = new ErrorForm("You need to fill all boxes");
                errorForm.ShowDialog();
            }
            else
            {
                var authorToAdd = new Author
                {
                    FirstName = authorFirstNameTextBox.Text, LastName = authorLastNameTextBox.Text
                };
                AuthorRepository.AddAuthor(authorToAdd);
                Close();
            }
        }
    }
}
