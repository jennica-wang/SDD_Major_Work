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
    public partial class Return_Books: Form
    {
        public Return_Books()
        {
            InitializeComponent();
        }
        private void Return_Books_Load(object sender, EventArgs e)
        {
            LabelRecentReturn.AutoSize = false;
            LabelRecentReturn.Size = new System.Drawing.Size(290, 200);
        }
        private void TextBoxISBN_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxISBN.Text.Length == 13) // valid ISBN should have 13 digits
            {
                ValidateBook("display book");
            }
            else
            {
                LabelBookName.Text = "Book name:";
            }
        }
        private void TextBoxISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                ValidateBook("returning");
            }
        }
        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            ValidateBook("returning");
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Return_Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialise();
        }

        private void ValidateBook(string ValidateReason)    // if the book exists the book is returned and/or name is displayed
        {
            try
            {
                long InputISBN = Convert.ToInt64(TextBoxISBN.Text);    // converts to int
                bool exists = false;
                foreach (Book book in Globals.Books)
                {
                    if (book.ISBN == InputISBN) // checks if book exists
                    {
                        ReturningBook(book, ValidateReason);
                        if (DisplayBook(book, ValidateReason) == true)
                        {
                            return; // stops execution of remaining method
                        }
                        exists = true;
                        break;
                    }
                }
                if (exists == false)    // book does not exist
                {
                    InvalidBook();
                }
            }
            catch   // input is not a valid integer
            {
                InvalidBook();
            }
        }
        private void ReturningBook(Book book, string ValidateReason)    // changes status of book
        {
            if (ValidateReason == "returning")
            {
                book.Status = "Available";
                LabelRecentReturn.Text = "Recently returned:\n" + book.BookName;
                LabelRecentReturn.Visible = true;
                TextBoxISBN.Clear();
            }
        }
        private bool DisplayBook(Book book, string ValidateReason)  // displays name of book scanned
        {
            if (ValidateReason == "display book")
            {
                LabelBookName.Text = "Book name: " + book.BookName;
                return true;
            }
            return false;
        }
        private void InvalidBook()  // message box "Invalid book"
        {
            MessageBox.Show("Invalid book");
            TextBoxISBN.Focus();
        }
        private void Serialise()    // serialises list<Book> to XML file
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter writer = new StreamWriter(Globals.booksfile))
            {
                serializer.Serialize(writer, Globals.Books);
            }
        }
    }
}
