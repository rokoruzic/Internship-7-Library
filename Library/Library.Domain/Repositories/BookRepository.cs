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
            return _libraryContext.Books.Include(x=>x.BookRents).ToList();
        }
        public Book GetBook(int id)
        {
           
            return _libraryContext.Books.FirstOrDefault(x => x.BookId == id);
        }
        public bool Check(BookRentRepository bookRentRepository, Student selectedStudent)
        {
            if (GetBook(bookRentRepository.GetAllBookRents()
                    .FirstOrDefault(x => (x.DateOfReturn != null && x.StudentId != selectedStudent.StudentId)).BookId)==null 
                ) return false;
            return true;
        }
    }
}
