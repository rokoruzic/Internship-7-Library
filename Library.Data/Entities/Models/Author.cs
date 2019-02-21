using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Infrastructure.Extensions;

namespace Library.Data.Entities.Models
{
    public partial class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int AuthorId { get; set; }
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value.CapitalizeFirstLetterAndRemoveMultipleWhiteSpaces();
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value.CapitalizeFirstLetterAndRemoveMultipleWhiteSpaces();
        }
        public ICollection<Book> Books { get; set; }


    }
}
