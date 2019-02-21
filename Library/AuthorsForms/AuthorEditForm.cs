using System;
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
            if (string.IsNullOrEmpty(authorFirstNameTextBox.Text) || string.IsNullOrEmpty(authorLastNameTextBox.Text))
            {
                var errorForm = new ErrorForm("You need to fill all boxes");
                errorForm.ShowDialog();
            }
            var authorToEdit = new Author
            {
                AuthorId = SelectedAuthor.AuthorId,
                FirstName = SelectedAuthor.FirstName,
                LastName = SelectedAuthor.LastName,
                Books = SelectedAuthor.Books
            };
            AuthorRepository.EditAuthor(authorToEdit);
            Close();
        }
    }
}
