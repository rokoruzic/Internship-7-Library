namespace Library.Data.Entities.Models
{
    public partial class Student
    {
        private string _firstName;
        private string _lastName;
        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }

        public string Print()
        {
            return $"{FirstName} {LastName} {Class} {DateOfBirth:d} {Gender}";
        }
    }
}
