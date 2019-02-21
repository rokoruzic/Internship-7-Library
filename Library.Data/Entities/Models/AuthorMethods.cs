

namespace Library.Data.Entities.Models
{
   public partial class Author
   {
       private string _firstName;
       private string _lastName;

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
