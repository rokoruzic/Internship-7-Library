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
            var authorToAdd = new Author();
            authorToAdd.FirstName = authorFirstNameTextBox.Text;
            authorToAdd.LastName = authorLastNameTextBox.Text;
            AuthorRepository.AddAuthor(authorToAdd);
            Close();
        }
    }
}
