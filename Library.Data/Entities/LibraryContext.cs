using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Library.Data.Entities.Enums;

namespace Library.Data.Entities
{
    public class LibraryContext : DbContext
    {
        
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookRent> BookRents { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<AuthorBook> AuthorsBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             
            modelBuilder.Entity<AuthorBook>()
                .HasKey(bc => new { bc.BookId, bc.AuthorId });
            modelBuilder.Entity<AuthorBook>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.AuthorsBooks)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<AuthorBook>()
                .HasOne(bc => bc.Author)
                .WithMany(c => c.AuthorsBooks)
                .HasForeignKey(bc => bc.AuthorId);

          
            modelBuilder.Entity<BookRent>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookRents)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookRent>()
                .HasOne(bc => bc.Student)
                .WithMany(c => c.BookRents)
                .HasForeignKey(bc => bc.StudentId);

            //modelBuilder.Entity<Publisher>().HasData(new
            //{
            //    PublisherId = 1,
            //    Name = "Croatia"
            //});
            //modelBuilder.Entity<Book>().HasData(new
            //{
            //    BookId = 1,
            //    Name = "Milenium",
            //    Pages = 123,
            //    Genre = BookGenre.Comedy,
            //    PublisherId = 1,
            //    IsRentActive = true
            //});

            //modelBuilder.Entity<Student>().HasData(new
            //{
            //    StudentId = 1,
            //    FirstName = "Kristian",
            //    LastName = "Zolo",
            //    DateOfBirth = DateTime.Now.AddYears(-19),
            //    Class = "2.b",
            //    Gender = Gender.Male,
            //    IsRentActive = true
            //});
            //modelBuilder.Entity<Author>().HasData(new
            //{
            //    AuthorId = 1,
            //    FirstName = "Jure",
            //    LastName = "Radalj",

            //});
            //modelBuilder.Entity<AuthorBook>().HasData(new
            //{
            //    AuthorId = 1,
            //    BookId = 1,
            //});
            //modelBuilder.Entity<BookRent>().HasData(new
            //{
            //    BookId = 1,
            //    StudentId = 1,
            //    DateOfRent = new DateTime(2019 / 1 / 20)
            //});
        }
       

      
    }
}
