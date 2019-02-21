using System;
using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
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


        public bool CheckAvailableDate(List<BookRent> allBookRents, BookRent bookRentToCheck)
        {
            int countForReturnedBooks = 0;
            int countForRentedBooks = 0;
            if (bookRentToCheck.DateOfReturn == null)
            {
                foreach (var bookRent in allBookRents)
                {
                    if (bookRentToCheck.DateOfRent > bookRent.DateOfReturn)
                        countForRentedBooks++;
                }
            }

            if (countForRentedBooks == allBookRents.Count) return true;
            
            foreach (var bookRent in allBookRents)
            {
                if ((bookRentToCheck.DateOfRent > bookRent.DateOfReturn &&
                     bookRentToCheck.DateOfReturn > bookRent.DateOfReturn) ||
                    (bookRentToCheck.DateOfRent < bookRent.DateOfRent &&
                     bookRentToCheck.DateOfReturn < bookRent.DateOfRent))
                    countForReturnedBooks++;
            }
            if (countForReturnedBooks == allBookRents.Count)
                return true;
            return false;
        }
        
        public void AddBookRent(BookRent bookRentToAdd)
        {
            _libraryContext.BookRents.Add(bookRentToAdd);
            _libraryContext.SaveChanges();
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
      
    }
}
