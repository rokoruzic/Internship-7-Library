using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Enums;

namespace Library.Data.Entities.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
        public Gender Gender { get; set; }
        public ICollection<BookRent> BookRents { get; set; }
        public bool IsRentActive { get; set; }

    }
}
