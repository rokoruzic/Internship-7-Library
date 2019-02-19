using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
    public partial class BookRent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int BookRentId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime DateOfRent { get; set; }
        public DateTime? DateOfReturn { get; set; }

       
    }
}
