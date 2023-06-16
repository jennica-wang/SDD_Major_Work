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

namespace SDD_Major_Work
{
    public partial class Receipt_Preview : Form
    {
        public Receipt_Preview()
        {
            InitializeComponent();
        }

        static string BookBorrowing = "";

        private void Receipt_Preview_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Globals.BookBorrowingList.Count; i++)
            {
                BookBorrowing = BookBorrowing + "\n" + Globals.BookBorrowingList[i];
            }
            label2.Text = "Borrower name: " + Globals.BorrowerName;
            label3.Text = "Borrowing date: " + Convert.ToString(Globals.BorrowingTime);
            label4.Text = "Due date: " + Globals.DueDate;
        }

        const string filename = "receipt.txt";
        static void receiptEdit()   // edits text file for receipt
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine("Jennica's Library\n" +
                "Room 212 Hornsby Girls High School, Hornsby NSW 2077\n\n" +
                "BOOK RECEIPT\n\n" +
                $"Borrower name: {Globals.BorrowerName}\n" +
                $"Borrowing date: {Convert.ToString(Globals.BorrowingTime)}\n" +
                $"{BookBorrowing}\n\n" +
                $"Due date: {Globals.DueDate}");
            sw.Close();
        }

        private Font printFont;
        private StreamReader reader;

        private void button1_Click(object sender, EventArgs e)
        {
            receiptEdit();
            reader = new StreamReader(filename);
            printFont = new Font("MS Gothic", 10);  // sets font
            PrintDocument receiptDocument = new PrintDocument();
            receiptDocument.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);  // printing formatting
            receiptDocument.Print();    // prints receipt

            Properties.Settings.Default.Save(); // saves the status of books after full borrow

            if (reader != null)
            {
                reader.Close();
            }

            Globals.receiptPreviewClosed = true;

        }
        private void PrintTextFileHandler(object sender, PrintPageEventArgs printContent)
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
            if (line != null)
            {
                printContent.HasMorePages = true;
            }
            else
            {
                printContent.HasMorePages = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Receipt_Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
