using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            

            Globals.Books.Add(new Book("Matilda", "Roald Dahl", 9780241558300, "Humor", Properties.Settings.Default.Book9780241558300));
            Globals.Books.Add(new Book("Charlie and the Chocolate Factory", "Roald Dahl", 9780241558324, "Humor", Properties.Settings.Default.Book9780241558324));
            Globals.Books.Add(new Book("The BFG", "Roald Dahl", 9780241558348, "Fantasy", Properties.Settings.Default.Book9780241558348));
            Globals.Books.Add(new Book("James and the Giant Peach", "Roald Dahl", 9780241558331, "Fantasy", Properties.Settings.Default.Book9780241558331));
            Globals.Books.Add(new Book("Fantastic Mr Fox", "Roald Dahl", 9780241558355, "Adventure", Properties.Settings.Default.Book9780241558355));
            Globals.Books.Add(new Book("The Twits", "Roald Dahl", 9780241578186, "Short Story", Properties.Settings.Default.Book9780241578186));
            Globals.Books.Add(new Book("George's Marvellous Medicine", "Roald Dahl", 9780241558485, "Fantasy", Properties.Settings.Default.Book9780241558485));
            Globals.Books.Add(new Book("The Magic Finger", "Roald Dahl", 9780141322681, "Short Story", Properties.Settings.Default.Book9780141322681));
            Globals.Books.Add(new Book("Revolting Rhymes", "Roald Dahl", 9780140375336, "Poetry", Properties.Settings.Default.Book9780140375336));
            Globals.Books.Add(new Book("The Enormous Crocodile", "Roald Dahl", 9780241568644, "Short Story", Properties.Settings.Default.Book9780241568644));
            Globals.Books.Add(new Book("Esio Trot", "Roald Dahl", 9780141346496, "Short Story", Properties.Settings.Default.Book9780141346496));
            Globals.Books.Add(new Book("The Giraffe and the Pelly and Me", "Roald Dahl", 9780241558508, "Short Story", Properties.Settings.Default.Book9780241558508));
            Globals.Books.Add(new Book("The Witches", "Roald Dahl", 9780241578179, "Fantasy", Properties.Settings.Default.Book9780241578179));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if any books have been borrowed
            // check if borrower info has been entered

            if (Globals.BorrowerName == null)
            {
                MessageBox.Show("No user has been selected.");
                textBox1.Select();
            }

            if (Globals.BookBorrowingList == null)
            {
                MessageBox.Show("No books have been selected.");
                textBox2.Select();
                if (Globals.BorrowerName == null)
                {
                    textBox1.Select();
                }
            }

            else
            {
                var ReceiptPreviewForm = new Receipt_Preview();
                ReceiptPreviewForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

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
                bool BookLoaned = false;
                long InputISBN = Convert.ToInt64(textBox2.Text); // converts to int

                foreach (Book book in Globals.Books)
                {
                    if (book.ISBN == InputISBN)
                    {
                        if (book.Status == "Loaned")
                        {
                            foreach (string item in Globals.BookBorrowingList)  // checks whether the book is 'loaned' because it hasn't
                            {                                                   // been returned yet or if it has already been scanned
                                if (item == book.BookName)  // book was already scanned
                                {
                                    MessageBox.Show("Book has already been scanned.");
                                    break;
                                }

                                else    // book is still loaned
                                {       
                                    BookLoaned = true;
                                    MessageBox.Show("Book is currently loaned, return the book first and try again.");
                                }
                            }
                        }
                        else
                        {
                            book.Status = "Loaned"; // changes book's status to loaned
                            listBox1.Items.Add(book.BookName);  // finds book name correlating to code and adds to listbox
                            BookExists = true;
                            Globals.BookBorrowingList.Add(book.BookName);   // adds book bame to a list for receipt
                            break;
                        }
                    }
                }

                if (BookExists == false && BookLoaned == false)
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
                
    }
}
