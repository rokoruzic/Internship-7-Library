using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int AuthorId { get; set; }
        [Key, Column(Order = 1)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<AuthorBook> AuthorsBooks { get; set; }

    }
}
