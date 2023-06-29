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
    public partial class Add_Book: Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }
        private void Add_Book_Load(object sender, EventArgs e)
        {
            LabelRecentAdd.AutoSize = false;
            LabelRecentAdd.Size = new System.Drawing.Size(500, 200);
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void TextBoxISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                AddBook();
            }
        }
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                AddBook();
            }
        }
        private void TextBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                AddBook();
            }
        }
        private void TextBoxGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                AddBook();
            }
        }


        private void AddBook()
        {
            if (InformationFilled() == true)    // all information has been provided
            {
                try
                {
                    long UserISBN = Convert.ToInt64(TextBoxISBN.Text); // converts to int
                    if (BookExists(UserISBN) == false)  // new book
                    {
                        Book newBook = new Book(TextBoxName.Text, TextBoxAuthor.Text, UserISBN, TextBoxGenre.Text, "Available");
                        Globals.Books.Add(newBook);
                        AfterAdd(newBook);
                    }
                }
                catch   // ISBN is not a valid integer
                {
                    MessageBox.Show("ISBN must be an integer");
                    TextBoxISBN.Clear();
                    TextBoxISBN.Focus();
                }
            }
        }   // adds a new book
        private bool InformationFilled()    // determines if all necessary information has been completed
        {
            if (String.IsNullOrWhiteSpace(TextBoxISBN.Text))
            {
                MessageBox.Show("An ISBN must be entered");
                TextBoxISBN.Focus();
            }
            else if (String.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                MessageBox.Show("A name must be entered");
                TextBoxName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(TextBoxAuthor.Text))
            {
                MessageBox.Show("An author must be entered");
                TextBoxAuthor.Focus();
            }
            else if (String.IsNullOrWhiteSpace(TextBoxGenre.Text))
            {
                MessageBox.Show("A genre must be entered");
                TextBoxGenre.Focus();
            }
            else
            {
                return true;
            }
            return false;
        }
        private bool BookExists(long InputISBN) // determines if book already exists using ISBN
        {
            foreach (Book book in Globals.Books)
            {
                if (book.ISBN == InputISBN)
                {
                    MessageBox.Show("Book already exists");
                    return true;
                }
            }
            return false;
        }
        private void AfterAdd(Book addedBook)   // resetting after successfully adding a book
        {
            LabelRecentAdd.Visible = true;
            LabelRecentAdd.Text = "Recently added:\n" +
                $"{addedBook.BookName}, {addedBook.Author}, {addedBook.ISBN} ({addedBook.Genre})";
            
            TextBoxISBN.Clear();
            TextBoxName.Clear();
            TextBoxAuthor.Clear();
            TextBoxGenre.Clear();
            TextBoxISBN.Focus();
        }
    }
}
