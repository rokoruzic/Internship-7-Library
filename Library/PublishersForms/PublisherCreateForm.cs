using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Publisher = Library.Data.Entities.Models.Publisher;

namespace Library.PublishersForms
{
    public partial class PublisherCreateForm : Form
    {
        public PublisherRepository PublisherRepository { get; set; }
        public PublisherCreateForm(PublisherRepository publisherRepository)
        {
            InitializeComponent();
            PublisherRepository = publisherRepository;
        }

        private void PublisherAddButtonClick(object sender, EventArgs e)
        {
            var publisherToAdd = new Publisher();
            publisherToAdd.Name = publisherNameTextBox.Text;
            PublisherRepository.AddPublisher(publisherToAdd);
            Close();

        }
    }
}
