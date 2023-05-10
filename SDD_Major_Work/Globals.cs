using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDD_Major_Work
{
    static class Globals
    {
        public static List<string> BorrowerList = new List<string>();
        public static List<string> BookList = new List<string>();
        public static List<string> BookBorrowingList = new List<string>();
        public static string BorrowerName;
        public static string DueDate;
        public static DateTime BorrowingTime;
        public static bool receiptPreviewClosed;
    }
}
