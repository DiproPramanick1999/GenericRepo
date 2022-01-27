using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.DAL
{
    public class BookStoreRepo : IBookStoreRepo
    {
        private BookDbContext db = new BookDbContext();
        public bool AddBook(Book book)
        {
            db.Books.Add(book);
            return (db.SaveChanges() >= 1);
        }

        public bool AddIssueBook(IssueBook issuebook)
        {
            db.IssueBooks.Add(issuebook);
            return (db.SaveChanges() >= 1);
        }

        public bool AddReturnBook(ReturnBook returnbook)
        {
            db.ReturnBooks.Add(returnbook);
            return (db.SaveChanges() >= 1);
        }

        public bool DeleteBook(int id)
        {
            Book ib = db.Books.Find(id);
            if (ib != null)
            {
                db.Books.Remove(ib);
                return (db.SaveChanges()>=1);
            }
            return false;
        }

        public bool DeleteIssueBook(int id)
        {
            IssueBook ib = db.IssueBooks.Find(id);
            if (ib != null)
            {
                db.IssueBooks.Remove(ib);
                return (db.SaveChanges() >= 1);
            }
            return false;
        }

        public bool DeleteReturnBook(int id)
        {
            ReturnBook ib = db.ReturnBooks.Find(id);
            if (ib != null)
            {
                db.ReturnBooks.Remove(ib);
                return (db.SaveChanges() >= 1);
            }
            return false;
        }

        public List<Book> GetBook()
        {
            return db.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return db.Books.Find(id);
        }

        public List<IssueBook> GetIssueBook()
        {
            return db.IssueBooks.ToList();
        }

        public IssueBook GetIssueBookById(int id)
        {
            return db.IssueBooks.Find(id);
        }

        public List<ReturnBook> GetReturnBook()
        {
            return db.ReturnBooks.ToList();
        }

        public ReturnBook GetReturnBookById(int id)
        {
            return db.ReturnBooks.Find(id);
        }

        public bool UpdateBook(Book book)
        {
            db.Entry(book).State = System.Data.Entity.EntityState.Modified;
            return (db.SaveChanges() >= 1);
        }

        public bool UpdateIssueBook(IssueBook issuebook)
        {
            db.Entry(issuebook).State = System.Data.Entity.EntityState.Modified;
            return (db.SaveChanges() >= 1);
        }

        public bool UpdateReturnBook(ReturnBook returnbook)
        {
            db.Entry(returnbook).State = System.Data.Entity.EntityState.Modified;
            return (db.SaveChanges() >= 1);
        }
    }
}