﻿using System.Collections.Generic;
using System.Linq;
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
       
        public bool AddBook(Book bookToAdd)
        {
            if (bookToAdd == null) return false;
            _libraryContext.Books.Add(bookToAdd);
            _libraryContext.SaveChanges();
            return true;
        }
        public bool EditBook(Book bookToEdit)
        {
            var editedBook
                = _libraryContext.Books.FirstOrDefault(x => x.BookId == bookToEdit.BookId);
            if (bookToEdit == null) return false;
            editedBook.Name = bookToEdit.Name;
            editedBook.Publisher = bookToEdit.Publisher;
            editedBook.Pages = bookToEdit.Pages;
            editedBook.PublisherId = bookToEdit.PublisherId;
            editedBook.Author = bookToEdit.Author;
            editedBook.Genre = bookToEdit.Genre;
            _libraryContext.SaveChanges();
            return true;

        }
        public bool RemoveBook(int bookId)
        {
            var bookToRemove = _libraryContext.Books.FirstOrDefault(x => x.BookId == bookId);
            if (bookToRemove == null) return false;
            _libraryContext.Books.Remove(bookToRemove);
            _libraryContext.SaveChanges();
            return true;
        }

    }
}
