using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Infrastructure.Extensions;

namespace Library.Data.Entities.Models
{
    public partial class Publisher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int PublisherId { get; set; }
        public string Name
        {
            get => _name;
            set => _name = value.FirstCharToUpperAndRemoveMultipleWhiteSpaces();
        }
        public ICollection<Book> Books { get; set; }


    }
}
