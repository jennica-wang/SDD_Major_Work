using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDD_Major_Work
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }

        public Book(string Book_BookName, string Book_Author, long Book_ISBN, string Book_Genre, string Book_Status)
        {
            BookName = Book_BookName;
            Author = Book_Author;
            ISBN = Book_ISBN;
            Genre = Book_Genre;
            Status = Book_Status;
        }

        public Book()
        { }

    }
}

