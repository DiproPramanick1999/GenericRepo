using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Models.DAL
{
    public interface IUnitOfWork
    {
        _IAllRepository<Book> BookRepository { get; }
        _IAllRepository<IssueBook> IssueBookRepository { get; }
        _IAllRepository<ReturnBook> ReturnBookRepository { get; }
    }
}
