using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;

namespace Library.Domain.Repositories
{
    public class BookRentRepository
    {
        public BookRentRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        private readonly LibraryContext _libraryContext;
    }
}
