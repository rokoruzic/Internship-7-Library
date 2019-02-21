using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Data.Entities.Enums;
using Library.Infrastructure.Extensions;

namespace Library.Data.Entities.Models
{
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int BookId { get; set; }
        public string Name
        {
            get => _name;
            set => _name = value.FirstCharToUpperAndRemoveMultipleWhiteSpaces();
        }
        public int Pages { get; set; }
        public BookGenre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public ICollection<BookRent> BookRents { get; set; }


    }
}
