using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.Entities
{
    public class ReturnBook
    {
        public int ReturnBookId { get; set; }
        public IssueBook IssueBooks { get; set; }
        public int IssueBookId { get; set; }
        public string DateofReturn { get; set; }
    }
}