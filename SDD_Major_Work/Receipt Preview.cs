using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using SDD_Major_Work.Properties;

namespace SDD_Major_Work
{
    public partial class Receipt_Preview : Form
    {
        public Receipt_Preview()
        {
            InitializeComponent();
        }

        private static string BooksBorrowed;    // string of books the user is borrowing
        private const string receiptfile = "receipt.txt";
        private Font printFont;
        private StreamReader reader;

        private void Receipt_Preview_Load(object sender, EventArgs e)
        {
            BooksBorrowed = BooksBorrowing("");
            ReceiptPreviewInfo();
        }        
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            ReceiptEdit();
            Printing();
            if (reader != null) // closes reader once read
            {
                reader.Close();
            }
            
            Serialise();    // serialises updated list with statuses
            Globals.receiptPreviewClosed = true;    // printing is done and new borrow needs to be started
            this.Close();
        }        
        private void PrintTextFileHandler(object sender, PrintPageEventArgs printContent)   // graphically formats file for printing
        {
            Graphics g = printContent.Graphics;
            int count = 0;
            float leftMargin = printContent.MarginBounds.Left;  // gets left margin
            float topMargin = printContent.MarginBounds.Top;    // gets top margin
            string line = null;
            float linesPerPage = printContent.MarginBounds.Height / printFont.GetHeight(g); // calculates lines per page
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                float yPos = topMargin + (count * printFont.GetHeight(g));  // calculates y position for printing
                g.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat()); // draws text
                count++;
            }
            if (line != null)   // checks if there are more lines
            {
                printContent.HasMorePages = true;
            }
            else
            {
                printContent.HasMorePages = false;
            }
        }
        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Serialise()    // serialises list<Book> to XML file
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter writer = new StreamWriter(Globals.booksfile))
            {
                serializer.Serialize(writer, Globals.Books);
            }
        }
        private void ReceiptPreviewInfo()   // adds info onto receiptpreview (borrower name, borrowing date and due date)
        {
            LabelBorrowerName.Text = "Borrower name: " + Globals.BorrowerName;
            Globals.BorrowingTime = DateTime.Now;
            LabelBorrowingDate.Text = "Borrowing date: " + Convert.ToString(Globals.BorrowingTime);
            LabelDueDate.Text = "Due date: " + Globals.DueDate;
        }
        private string BooksBorrowing(string BookBorrowing) // combines all books being borrowed into one string
        {
            for (int i = 0; i < Globals.BookBorrowingList.Count; i++)
            {
                BookBorrowing = BookBorrowing + "\n" + Globals.BookBorrowingList[i];
            }
            return BookBorrowing;
        }
        private void ReceiptEdit()   // opens writer, edits text file contents for receipt, closes writer
        {
            StreamWriter sw = new StreamWriter(receiptfile);
            sw.WriteLine("Sample Library\n" +
                "Sample Address\n\n" +
                "BOOK RECEIPT\n\n" +
                $"Borrower name: {Globals.BorrowerName}\n" +
                $"Borrowing date: {Convert.ToString(Globals.BorrowingTime)}\n" +
                $"{BooksBorrowed}\n\n" +
                $"Due date: {Globals.DueDate}");
            sw.Close();
        }
        private void Printing() // formats file for printing, prints receipt
        {
            reader = new StreamReader(receiptfile); // reads content of file
            printFont = new Font("MS Gothic", 10);  // sets font
            PrintDocument receiptDocument = new PrintDocument();
            receiptDocument.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);  // printing formatting

            receiptDocument.Print();    // prints receipt
        }
    }
}
