using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
    public partial class BookRent
    {
        public override string ToString()
        {
            return $"{Book} {DateOfRent:d} {DateOfReturn:d}  {Student.FirstName} {Student.LastName}";
        }
    }
}
