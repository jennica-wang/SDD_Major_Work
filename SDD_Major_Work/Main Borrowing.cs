﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using SDD_Major_Work.Properties;

namespace SDD_Major_Work
{
    public partial class Main_Borrowing : Form
    {
        public Main_Borrowing()
        {
            InitializeComponent();
        }
        public void Main_Borrowing_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Globals.booksfile = Path.Combine(path, "books.xml");

            NewBorrow();
            Deserialise();
            Globals.BorrowerList.Add("BorrowerA");
            Globals.BorrowerList.Add("BorrowerB");
            Globals.BorrowerList.Add("BorrowerC");
            Globals.BorrowerList.Add("BorrowerD");
            Globals.BorrowerList.Add("BorrowerE");
            Globals.BorrowerList.Add("BorrowerF");
            Globals.BorrowerList.Add("BorrowerG");
            Globals.BorrowerList.Add("BorrowerH");
        }
        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            if (Globals.BorrowerName == null)   // check if borrower info has been entered
            {
                MessageBox.Show("No borrower has been selected");
                TextBoxBorrower.Select();
            }

            else if (Globals.BookBorrowingList.Count == 0)  // check if any books have been borrowed
            {
                MessageBox.Show("No books have been selected");
                TextBoxBook.Select();
                if (Globals.BorrowerName == null)
                {
                    TextBoxBorrower.Select();
                }
            }

            else    // proceeds to receipt if borrower and books have been selected
            {
                var ReceiptPreviewForm = new Receipt_Preview();
                ReceiptPreviewForm.Show();
            }
        }
        private void TextBoxBorrower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                try
                {
                    int Borrower_code = Convert.ToInt32(TextBoxBorrower.Text); // converts to int
                    Globals.BorrowerName = Globals.BorrowerList[Borrower_code]; // finds borrower name correlating to code
                    label2.Text = "Borrower name: " + Globals.BorrowerName;
                    label3.Text = "Borrower code: " + TextBoxBorrower.Text;
                    TextBoxBook.Focus();   // selects the next textbox                    
                }
                catch   // for invalid codes or data types
                {
                    MessageBox.Show("Invalid borrower");
                    TextBoxBorrower.Clear();
                    label2.Text = "Borrower name: ";
                    label3.Text = "Borrower code: ";
                }
            }
        }        
        private void TextBoxBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                try
                {
                    long UserISBN = Convert.ToInt64(TextBoxBook.Text); // converts to int
                    if (IdentifyBook(UserISBN) == false)    // book doesn't exist
                    {
                        MessageBox.Show("Invalid book");
                    }
                }
                catch   // input is not a valid integer
                {
                    MessageBox.Show("Invalid book");
                }
                TextBoxBook.Clear();
            }
        }
        private void ListBoxBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)   // when delete is pressed
            {
                RemoveBook();
            }
        }        
        private void ButtonChangeDate_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)   // pressing button changes visibility of datetimepicker to visible or not visible
            {
                groupBox1.Visible = true;
                DateTimePicker.Visible = false;
            }
            else if (groupBox1.Visible == true)
            {
                HideDateTimePicker();
            }
        }
        private void DateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                HideDateTimePicker();
            }
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RadioButton3Days.Checked = false;
            RadioButton1Week.Checked = false;
            RadioButton2Weeks.Checked = false;
            RadioButton4Weeks.Checked = false;
            Globals.DueDate = DateTimePicker.Value.ToString("dd/MM/yyyy");
            label7.Text = "Due date: " + Globals.DueDate;
        }        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Globals.receiptPreviewClosed == true)
            {
                Controls.Clear();   // removes controls
                InitializeComponent();  // initialises form

                NewBorrow();

                // clears variables
                Globals.BookBorrowingList.Clear();
                Globals.BookBorrowingList.TrimExcess();
                Globals.BorrowerName = null;
                
                Globals.receiptPreviewClosed = false;
            }
        }
        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deserialise();
            var ReturnBooksForm = new Return_Books();
            ReturnBooksForm.Show();
        }
        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddBookFrom = new Add_Book();
            AddBookFrom.Show();
        }
        private void RadioButton3Days_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3Days.Checked == true)
            {
                ChangeDueDate(3);
            }
        }
        private void RadioButton1Week_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1Week.Checked == true)
            {
                ChangeDueDate(7);
            }
        }
        private void RadioButton2Weeks_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2Weeks.Checked == true)
            {
                ChangeDueDate(14);
            }
        }
        private void RadioButton4Weeks_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4Weeks.Checked == true)
            {
                ChangeDueDate(28);
            }
        }
        private void ButtonCustomDate_Click(object sender, EventArgs e)
        {
            RadioButton3Days.Checked = false;
            RadioButton1Week.Checked = false;
            RadioButton2Weeks.Checked = false;
            RadioButton4Weeks.Checked = false;
            DateTimePicker.Value = DateTime.Now;
            DateTimePicker.Visible = true;
        }
        private void Main_Borrowing_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void Deserialise()  // deserealises XML file to List<Book>
        {
            if (File.Exists(Globals.booksfile) == true) // if file exists
            {
                long fileLength = new FileInfo(Globals.booksfile).Length;
                if (fileLength != 0)    // if file isn't empty
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                    using (StreamReader reader = new StreamReader(Globals.booksfile))
                    {
                        Globals.Books = (List<Book>)serializer.Deserialize(reader);
                    }
                }
            }
            else    // creates file
            {
                FileStream fs = File.Create(Globals.booksfile);
                fs.Close();
            }
        }
        private void NewBorrow()    // initial screen size and date formatting applicable for all borrows
        {
            Location = new Point(0, 0);
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);    // sets form size be full screen
            DateTimePicker.MinDate = DateTime.Now;
            DateTimePicker.Value = DateTime.Now.AddDays(14);   // sets default return date to 14 days
        }
        private bool IdentifyBook(long InputISBN)   // finds if book exists
        {
            bool exists = false;
            foreach (Book book in Globals.Books)
            {
                if (book.ISBN == InputISBN) // checks if book exists
                {
                    exists = true;
                    if (book.Status == "Loaned")    // checks if book is loaned
                    {
                        IsLoaned(book);
                    }
                    else if (book.Status == "Available")    // book is available to be borrowed
                    {
                        BorrowBook(book);
                        break;
                    }
                }
            }
            return exists;
        }
        private void IsLoaned(Book book)    // process for when a book is loaned
        {            
            if (Globals.BookBorrowingList.Count == 0)   // if list is empty, assumed book was already loaned
            {
                MessageBox.Show("Book is currently loaned, return the book first and try again");
            }
            else
            {
                LoanedReason(book);
            }
        }
        private void LoanedReason(Book book)    // checks if book is loaned because it hasn't been returned or it's already been scanned
        {
            foreach (string item in Globals.BookBorrowingList)
            {
                if (item == book.BookName)  // book was already scanned
                {
                    MessageBox.Show("Book has already been scanned");
                    break;
                }

                else    // book is still loaned
                {
                    MessageBox.Show("Book is currently loaned, return the book first and try again");
                }
            }
        }
        private void BorrowBook(Book book)  // process for borrowing book, adds book to BookBorrowingList
        {
            book.Status = "Loaned"; // changes book's status to loaned
            ListBoxBooks.Items.Add(book.BookName);  // finds book name correlating to code and adds to listbox
            Globals.BookBorrowingList.Add(book.BookName);   // adds book name to a list for receipt
        }
        private void RemoveBook()   // removes book from listbox and changes status to available
        {
            string selectedBook = Convert.ToString(ListBoxBooks.SelectedItem);
            Globals.BookBorrowingList.Remove(selectedBook);
            ListBoxBooks.Items.Remove(ListBoxBooks.SelectedItem);

            foreach (Book book in Globals.Books)    // book status is changed back to available
            {
                if (book.BookName == selectedBook)
                {
                    book.Status = "Available";
                }
            }
        }
        private void HideDateTimePicker()   // hides and focuses on textbox
        {
            groupBox1.Visible = false;
            TextBoxBook.Focus();
        }        
        private void ChangeDueDate(int days)
        {
            Globals.DueDate = DateTime.Now.AddDays(days).ToString("dd/MM/yyyy");
            label7.Text = "Due date: " + Globals.DueDate;
        }   // changes the due date depending on the data entered

        private void TextBoxBorrower_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
