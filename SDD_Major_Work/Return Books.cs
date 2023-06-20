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
    public partial class Return_Books: Form
    {
        public Return_Books()
        {
            InitializeComponent();
        }

        void ReturnBook()
        {
            try
            {
                long InputISBN = Convert.ToInt64(textBox1.Text);    // converts to int
                bool exists = false;
                foreach (Book book in Globals.Books)
                {
                    if (book.ISBN == InputISBN) // checks if book exists
                    {
                        book.Status = "Available";
                        exists = true;
                    }
                }
                if (exists == false)    // book does not exist
                {
                    MessageBox.Show("Invalid book");
                }
            }
            catch   // input is not a valid integer
            {
                MessageBox.Show("Invalid book");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                ReturnBook();
                textBox1.Clear();
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            ReturnBook();
            textBox1.Clear();
        }
    }
}
