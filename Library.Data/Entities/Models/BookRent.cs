using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
    public class BookRent
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime DateOfRent { get; set; }
        public DateTime DateOfReturn { get; set; }
    }
}
