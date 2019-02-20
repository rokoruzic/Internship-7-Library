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
    public partial class AuthorListForm : Form
    {
        public AuthorRepository AuthorRepository { get; set; }
        public BookRepository BookRepository { get; set; }  
        public AuthorListForm(AuthorRepository authorRepository,BookRepository bookRepository)
        {
            InitializeComponent();
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
            AddRefreshList();
        }

        public void AddRefreshList()
        {
            authorListBox.Items.Clear();
            AuthorRepository.GetAllAuthors().ForEach(x=>authorListBox.Items.Add(x));
        }

        private void AuthorAddButtonClick(object sender, EventArgs e)
        {
            var authorCreateForm = new AuthorCreateForm(AuthorRepository);
            authorCreateForm.ShowDialog();
            AddRefreshList();
        }

        private void AuthorEditButtonClick(object sender, EventArgs e)
        {
            var selectedAuthor = authorListBox.SelectedItem as Author;
            if (selectedAuthor == null) return;
            var authorEditForm = new AuthorEditForm(AuthorRepository){SelectedAuthor = selectedAuthor};
            authorEditForm.SetText();
            authorEditForm.ShowDialog();
            AddRefreshList();

        }

        private void AuthorDeleteButtonClick(object sender, EventArgs e)
        {
            var selectedAuthor = authorListBox.SelectedItem as Author;
            if (selectedAuthor == null) return;
            AuthorRepository.RemoveAuthor(selectedAuthor.AuthorId);
            AddRefreshList();
        }

        private void AuthorViewDetailsClick(object sender, EventArgs e)
        {
            var selectedAuthor = authorListBox.SelectedItem as Author;
            if (selectedAuthor == null) return;
            var authorDetailsForm = new AuthorDetailsForm(AuthorRepository,BookRepository){SelectedAuthor = selectedAuthor};
            authorDetailsForm.AddRefreshList();
            authorDetailsForm.ShowDialog();
        }
    }
}
