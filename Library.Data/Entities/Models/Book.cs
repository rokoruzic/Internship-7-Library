using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Enums;

namespace Library.Data.Entities.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public BookGenre Genre { get; set; }
        public ICollection<AuthorBook> AuthorsBooks { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookRent> BookRents { get; set; }
        public bool IsRentActive { get; set; }

    }
}
