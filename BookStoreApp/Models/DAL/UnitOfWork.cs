using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private BookDbContext _context = new BookDbContext();
        public _IAllRepository<Book> bookRepository;
        public _IAllRepository<IssueBook> issueBookRepository;
        public _IAllRepository<ReturnBook> returnBookRepository;
        public _IAllRepository<Book> BookRepository
        {
            get
            {
                if (this.bookRepository == null)
                {
                    this.bookRepository = new AllRepository<Book>(_context);
                }
                return bookRepository;
            }
        }

        public _IAllRepository<IssueBook> IssueBookRepository
        {
            get
            {
                if (issueBookRepository == null)
                {
                    this.issueBookRepository = new AllRepository<IssueBook>(_context);
                }
                return issueBookRepository;
            }
        }

        public _IAllRepository<ReturnBook> ReturnBookRepository
        {
            get
            {
                if (returnBookRepository == null)
                {
                    this.returnBookRepository = new AllRepository<ReturnBook>(_context);
                }
                return returnBookRepository;
            }
        }
    }
}