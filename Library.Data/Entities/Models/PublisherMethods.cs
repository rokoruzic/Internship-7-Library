namespace Library.Data.Entities.Models
{
    public partial class Publisher
    {
        private string _name;
        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
