using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDD_Major_Work
{
    public class Book
    {
        
        public string BookName;
        public string Author;
        public long ISBN;
        public string Genre;
        public string Status;

        public Book (string Book_BookName, string Book_Author, long Book_ISBN, string Book_Genre, string Book_Status)
        {
            BookName = Book_BookName;
            Author = Book_Author;
            ISBN = Book_ISBN;
            Genre = Book_Genre;
            Status = Book_Status;
        }

        public Book()
        {}

    }
}
