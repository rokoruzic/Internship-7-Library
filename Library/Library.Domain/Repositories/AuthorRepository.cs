using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class AuthorRepository
    {
        public AuthorRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        private readonly LibraryContext _libraryContext;
        public List<Author> GetAllAuthors()
        {
            return _libraryContext.Authors.Include(x => x.Books).ToList();
        }
        public bool AddAuthor(Author authorToAdd)
        {
            if (authorToAdd == null) return false;
            _libraryContext.Authors.Add(authorToAdd);
            _libraryContext.SaveChanges();
            return true;

        }
        public bool RemoveAuthor(int authorId)
        {
            var authorToRemove = _libraryContext.Authors.FirstOrDefault(x => x.AuthorId == authorId);
            if (authorToRemove == null) return false;
            _libraryContext.Authors.Remove(authorToRemove);
            _libraryContext.SaveChanges();
            return true;
        }
        public bool EditAuthor(Author authorToEdit)
        {
            var editedAuthor
                = _libraryContext.Authors.FirstOrDefault(x => x.AuthorId == authorToEdit.AuthorId);
            if (editedAuthor == null) return false;
            editedAuthor.FirstName = authorToEdit.FirstName;
            editedAuthor.LastName = authorToEdit.LastName;
            editedAuthor.Books = authorToEdit.Books;
            editedAuthor.AuthorId = authorToEdit.AuthorId;
            _libraryContext.SaveChanges();
            return true;

        }
    }
}
