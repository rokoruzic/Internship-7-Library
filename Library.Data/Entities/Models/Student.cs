using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Data.Entities.Enums;
using Library.Infrastructure.Extensions;

namespace Library.Data.Entities.Models
{
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }
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
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; }
        public Gender Gender { get; set; }
        public ICollection<BookRent> BookRents { get; set; }

      
    }
}
