using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.Entities
{
    public class IssueBook
    {
        public int IssueBookId { get; set; }
        public Book Books { get; set; }
        public int BookId { get; set; }
        public string DateOfIssue { get; set; }
        public string ReturnDate { get; set; }
        public string MemberShipName { get; set; }

    }
}