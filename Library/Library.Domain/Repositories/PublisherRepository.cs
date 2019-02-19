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
    public class PublisherRepository
    {
        public PublisherRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        private readonly LibraryContext _libraryContext;
        public List<Publisher> GetAllPublishers()
        {
            return _libraryContext.Publishers.Include(x => x.Books).ToList();
        }
    }
}
