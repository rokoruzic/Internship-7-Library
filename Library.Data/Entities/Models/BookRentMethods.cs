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
