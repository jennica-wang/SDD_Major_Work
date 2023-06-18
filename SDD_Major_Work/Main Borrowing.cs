using System;
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

        int w = Screen.PrimaryScreen.Bounds.Width;  // the screen dimensions of device
        int h = Screen.PrimaryScreen.Bounds.Height;
        
        public void Main_Borrowing_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);     // sets form size to full screen size


            dateTimePicker1.MinDate = DateTime.Now;
            Globals.BorrowingTime = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now.AddDays(14);   // sets default return date to 14 days

            Globals.BorrowerList.Add("BorrowerA");
            Globals.BorrowerList.Add("BorrowerB");
            Globals.BorrowerList.Add("BorrowerC");
            Globals.BorrowerList.Add("BorrowerD");
            Globals.BorrowerList.Add("BorrowerE");
            Globals.BorrowerList.Add("BorrowerF");
            Globals.BorrowerList.Add("BorrowerG");
            Globals.BorrowerList.Add("BorrowerH");
        }

        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if any books have been borrowed
            // check if borrower info has been entered

            if (Globals.BorrowerName == null)
            {
                MessageBox.Show("No user has been selected.");
                textBox1.Select();
            }

            else if (Globals.BookBorrowingList == null)
            {
                MessageBox.Show("No books have been selected.");
                textBox2.Select();
                if (Globals.BorrowerName == null)
                {
                    textBox1.Select();
                }
            }

            else    // proceeds to receipt if borrower and books have been selected
            {
                var ReceiptPreviewForm = new Receipt_Preview();
                ReceiptPreviewForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                try
                {
                    int Borrower_code = Convert.ToInt32(textBox1.Text); // converts to int
                    Globals.BorrowerName = Globals.BorrowerList[Borrower_code]; // finds borrower name correlating to code
                    label2.Text = "Borrower name: " + Globals.BorrowerName;
                    label3.Text = "Borrower code: " + textBox1.Text;
                    textBox2.Focus();   // selects the next textbox
                    
                    
                }
                catch   // for invalid codes or data types
                {
                    MessageBox.Show("Invalid user");
                    textBox1.Clear();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                bool BookExists = false;

                try
                {
                    long InputISBN = Convert.ToInt64(textBox2.Text); // converts to int

                    foreach (Book book in Globals.Books)
                    {
                        if (book.ISBN == InputISBN) // checks if book exists
                        {
                            if (book.Status == "Loaned")    // checks if book is loaned
                            {
                                foreach (string item in Globals.BookBorrowingList)  // checks whether the book is 'loaned' because it hasn't been returned or if it has already been scanned in this transaction
                                {
                                    if (item == book.BookName)  // book was already scanned
                                    {
                                        MessageBox.Show("Book has already been scanned.");
                                        break;
                                    }

                                    else    // book is still loaned
                                    {
                                        MessageBox.Show("Book is currently loaned, return the book first and try again.");
                                    }
                                }
                            }
                            else    // book exists
                            {
                                book.Status = "Loaned"; // changes book's status to loaned
                                listBox1.Items.Add(book.BookName);  // finds book name correlating to code and adds to listbox
                                BookExists = true;
                                Globals.BookBorrowingList.Add(book.BookName);   // adds book name to a list for receipt
                                break;
                            }
                        }
                    }

                    if (BookExists == false)    // book doesn't exist
                    {
                        MessageBox.Show("Invalid book");
                    }
                }

                catch   // input is not a number
                {
                    MessageBox.Show("Invalid book");
                }
                
                textBox2.Clear();

            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)   // once delete is pressed
            {
                string selectedBook = Convert.ToString(listBox1.SelectedItem);
                Globals.BookBorrowingList.Remove(selectedBook);
                listBox1.Items.Remove(listBox1.SelectedItem);


                foreach (Book book in Globals.Books)    // if a book is deleted, the book status is changed back to available
                {
                    if (book.BookName == selectedBook)
                    {
                        book.Status = "Available";
                    }
                }

            }
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                dateTimePicker1.Visible = false;
                textBox2.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Globals.DueDate = (dateTimePicker1.Value).ToString("d");
            label7.Text = "Due date: " + Globals.DueDate;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Globals.receiptPreviewClosed == true)
            {
                Controls.Clear();   // removes controls
                InitializeComponent();  // initialises form
                this.Location = new Point(0, 0);
                this.Size = new Size(w, h);     // sets form size to full screen size
                
                dateTimePicker1.MinDate = DateTime.Now;
                Globals.BorrowingTime = DateTime.Now;
                dateTimePicker1.Value = DateTime.Now.AddDays(14);

                // clears variables
                Globals.BookBorrowingList.Clear();
                Globals.BookBorrowingList.TrimExcess();
                Globals.BorrowerName = null;
                Globals.DueDate = null;

                Globals.receiptPreviewClosed = false;

            }
        }


        private void button3_Click(object sender, EventArgs e)  // serealizes List<Book> to an XML file
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(path, "books.xml");
            using (StreamReader reader = new StreamReader(filename))
            {
                Globals.Books = (List<Book>)serializer.Deserialize(reader);
            }
        }
    }
}
