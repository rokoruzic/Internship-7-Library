using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
   public  class BookRepository
    {
        public BookRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        private readonly LibraryContext _libraryContext;
        public List<Book> GetAllBooks()
        {
            return _libraryContext.Books.Include(x=>x.BookRents).Include(x=>x.Author).Include(x=>x.Publisher).ToList();
        }
        public Book GetBook(int id)
        {
           
            return _libraryContext.Books.FirstOrDefault(x => x.BookId == id);
        }
        public bool AddBook(Book bookToAdd)
        {
            if (bookToAdd == null) return false;
            _libraryContext.Books.Add(bookToAdd);
            _libraryContext.SaveChanges();
            return true;
        }

    }
}
