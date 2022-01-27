using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public double Price{ get; set; }
    }
}