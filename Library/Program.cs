using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Domain.Repositories;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var context = new LibraryContext();

            var studentRepository = new StudentRepository(context);
            Console.WriteLine($"student je {studentRepository.GetStudent(1)}");
        }
    }
}
