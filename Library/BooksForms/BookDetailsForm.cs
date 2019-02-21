using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.BooksForms
{
    public partial class BookDetailsForm : Form
    {
        public BookRentRepository BookRentRepository { get; set; }
        public BookRepository BookRepository { get; set; }
        public Book SelectedBook { get; set; }
        public BookDetailsForm(BookRentRepository bookRentRepository,BookRepository bookRepository)
        {
            InitializeComponent();
            BookRentRepository = bookRentRepository;
            BookRepository = bookRepository;
        }

        public void SetText()
        {
            bookNameLabel.Text = SelectedBook.Print();
            bookCopiesLabel.Text =
                $@"Currently rented books of this title : {BookRentRepository.GetAllBookRents().Where(x=>x.DateOfReturn==null).Select(x => x.Book).Where(x => x.Name == SelectedBook.Name).ToList().Count}";

        }

        public void AddRefreshList()
        {
            BookRentRepository.GetAllBookRents().Where(x=>x.DateOfReturn==null).Select(x => x.Book).Where(x => x.Name == SelectedBook.Name).ToList().ForEach(x=>currentlyRentedBooksListBox.Items.Add(x.Print()));
        }
    }
}
