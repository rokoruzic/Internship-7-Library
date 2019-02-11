using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
   public class StudentRepository
    {
        public StudentRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        private readonly LibraryContext _libraryContext;

        public Student GetStudent(int id)
        {
            return _libraryContext.Students.Find(id);
        }
    }
}
