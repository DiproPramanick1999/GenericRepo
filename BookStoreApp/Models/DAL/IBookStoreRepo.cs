using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models.DAL
{
    public interface IBookStoreRepo
    {
        #region book
        List<Book> GetBook();
        bool AddBook(Book book);
        Book GetBookById(int id);
        bool UpdateBook(Book book);
        bool DeleteBook(int id);
        #endregion
        #region Issuebook
        List<IssueBook> GetIssueBook();
        bool AddIssueBook(IssueBook book);
        IssueBook GetIssueBookById(int id);
        bool UpdateIssueBook(IssueBook book);
        bool DeleteIssueBook(int id);
        #endregion
        #region ReturnBook
        List<ReturnBook> GetReturnBook();
        ReturnBook GetReturnBookById(int id);
        bool AddReturnBook(ReturnBook returnbook);
        bool UpdateReturnBook(ReturnBook returnbook);
        bool DeleteReturnBook(int id);
        #endregion
    }
}
