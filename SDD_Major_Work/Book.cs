using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDD_Major_Work
{
    internal class Book
    {
        public string BookName;
        public string Author;
        public int BookCode;
        public string Genre;
        public bool Available;

        public Book (string Book_BookName, string Book_Author, int Book_BookCode, string Book_Genre, bool Book_Available)
        {
            BookName = Book_BookName;
            Author = Book_Author;
            BookCode = Book_BookCode;
            Genre = Book_Genre;
            Available = Book_Available;
        }



    }
}
