using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.DAL
{
    public class BookDbContext:DbContext
    {
        public BookDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<IssueBook> IssueBooks { get; set; }
        public DbSet<ReturnBook> ReturnBooks { get; set; }

    }
}