using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library.Data.Entities;

namespace Library.Domain.Repositories
{
    public class AuthorBookRepository
    {
        public AuthorBookRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        private readonly LibraryContext _libraryContext;
    }
}
