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
            dateTimePicker1.Value = DateTime.Now.AddDays(14);

            Globals.BorrowerList.Add("Harry Styles");
            Globals.BorrowerList.Add("Ariana Grande");
            Globals.BorrowerList.Add("Taylor Swift");
            Globals.BorrowerList.Add("Selena Gomez");
            Globals.BorrowerList.Add("Alec Benjamin");
            Globals.BorrowerList.Add("Sundial");
            Globals.BorrowerList.Add("GRAE");
            Globals.BorrowerList.Add("Vicky Shao");

            Globals.BookList.Add("Matilda");
            Globals.BookList.Add("Charlie and the Chocolate Factory");
            Globals.BookList.Add("The BFG");
            Globals.BookList.Add("The Witches");
            Globals.BookList.Add("James and the Giant Peach");
            Globals.BookList.Add("Fantastic Mr Fox");
            Globals.BookList.Add("The Twits");
            Globals.BookList.Add("George's Marvellous Medicine");
            Globals.BookList.Add("The Magic Finger");
            Globals.BookList.Add("Revolting Rhymes");
            Globals.BookList.Add("The Enormous Crocodile");
            Globals.BookList.Add("Esio Trot");
            Globals.BookList.Add("The Giraffe and the Pelly and Me");

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
            // check if any books have been borrowed -> can't be empty
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
                try
                {
                    int Book_code = Convert.ToInt32(textBox2.Text); // converts to int
                    listBox1.Items.Add(Globals.BookList[Book_code]);    // finds book name correlating to code and adds to listbox
                    Globals.BookBorrowingList.Add(Globals.BookList[Book_code]);     // adds to a list for receipt

                }
                catch   // for invalid codes or data types
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
