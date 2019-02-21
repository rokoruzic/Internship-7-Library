using System.Collections.Generic;
using System.Linq;
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

        public bool AddPublisher(Publisher publisherToAdd)
        {
            if (publisherToAdd == null) return false;
            _libraryContext.Publishers.Add(publisherToAdd);
            _libraryContext.SaveChanges();
            return true;

        }
        public bool RemovePublisher(int publisherId)
        {
            var publisherToRemove = _libraryContext.Publishers.FirstOrDefault(x => x.PublisherId == publisherId);
            if (publisherToRemove == null) return false;
            _libraryContext.Publishers.Remove(publisherToRemove);
            _libraryContext.SaveChanges();
            return true;
        }
        public bool EditPublisher(Publisher publisherToEdit)
        {
            var editedPublisher
                = _libraryContext.Publishers.FirstOrDefault(x => x.PublisherId == publisherToEdit.PublisherId);
            if (editedPublisher == null) return false;
            editedPublisher.Name = publisherToEdit.Name;
            editedPublisher.Books = publisherToEdit.Books;
            editedPublisher.PublisherId = publisherToEdit.PublisherId;
            _libraryContext.SaveChanges();
            return true;

        }
    }
}
