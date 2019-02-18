using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BookRentRepository
    {
        public BookRentRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
            
        }
        private readonly LibraryContext _libraryContext;
        public List<BookRent> GetAllBookRents()
        {
            return _libraryContext.BookRents.Include(x=>x.Student).Include(x=>x.Book).ToList();
        }

        public bool CheckDate(BookRent bookRentToCheck)
        {
            if (bookRentToCheck.DateOfReturn!=null)
            return bookRentToCheck.DateOfReturn > bookRentToCheck.DateOfRent;
            if (bookRentToCheck.DateOfReturn == null) return true;
            return false;
        }

        public bool CheckAvailableDate(List<BookRent> allBookRents, BookRent bookRentToCheck)
        {
            if (bookRentToCheck.DateOfReturn == null)
            {
                foreach (var bookRent in allBookRents)
                {
                    if (bookRentToCheck.DateOfRent > bookRent.DateOfReturn)
                        return true;
                }
            }

            
            foreach (var bookRent in allBookRents)
            {
                if ((bookRentToCheck.DateOfRent > bookRent.DateOfReturn && bookRentToCheck.DateOfReturn > bookRent.DateOfReturn )||
                    (bookRentToCheck.DateOfRent < bookRent.DateOfRent && bookRentToCheck.DateOfReturn < bookRent.DateOfRent ))
                    
                    return true;
            }

            return false;
        }
        
        public void AddBookRent(BookRent bookRentToAdd)
        {
            _libraryContext.BookRents.Add(bookRentToAdd);
            _libraryContext.SaveChanges();
        }
        public BookRent GetBookRent(int bookId,int studentId)
        {
            return _libraryContext.BookRents.Include(x => x.Book).Include(x => x.Student)
                .FirstOrDefault(x => x.BookId == bookId && x.StudentId == studentId);
        }

        public BookRent GetBookRentBookId(int bookId)
        {
            return _libraryContext.BookRents.Include(x => x.Book).FirstOrDefault(x => x.BookId == bookId);
        }
        public bool EditBookRent(BookRent bookRentToEdit)
        {
            var editedBookRent = _libraryContext.BookRents.FirstOrDefault(x => x.BookRentId==bookRentToEdit.BookRentId);
            if (editedBookRent == null) return false;
            editedBookRent.DateOfRent = bookRentToEdit.DateOfRent;
            editedBookRent.DateOfReturn = bookRentToEdit.DateOfReturn;

            _libraryContext.SaveChanges();
            return true;

        }
        public bool RemoveBookRent(int removeBookRentId)
        {
            var bookRentToRemove = _libraryContext.BookRents.FirstOrDefault(x => x.BookRentId ==removeBookRentId );
            if (bookRentToRemove == null) return false;
            _libraryContext.BookRents.Remove(bookRentToRemove);
            _libraryContext.SaveChanges();
            return true;
        }

        public bool IsRentActive(BookRent bookRentToCheck)
        {
            return bookRentToCheck.DateOfReturn == null;
        }
    }
}
