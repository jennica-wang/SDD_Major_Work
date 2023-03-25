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
            
        public void Main_Borrowing_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            


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
            var ReceiptPreviewForm = new Receipt_Preview();
            ReceiptPreviewForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<string> BorrowerList = new List<string>(); // make this global so it can accessed in receipt
            BorrowerList.Add("Harry Styles");
            BorrowerList.Add("Ariana Grande");
            BorrowerList.Add("Taylor Swift");
            BorrowerList.Add("Selena Gomez");
            BorrowerList.Add("Alec Benjamin");
            BorrowerList.Add("Sundial");
            BorrowerList.Add("GRAE");
            BorrowerList.Add("Vicky Shao");

            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                try
                {
                    int Borrower_code = Convert.ToInt32(textBox1.Text); // converts to int
                    label2.Text = BorrowerList[Borrower_code];  // finds borrower name correlating to code
                    label3.Text = textBox1.Text;
                    textBox2.Focus();   // selects the next textbox
                }
                catch   // for invalid codes or data types
                {
                    MessageBox.Show("Invalid user");
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<string> BookList = new List<string>(); // make this global so it can accessed in receipt
            BookList.Add("Matilda");
            BookList.Add("Charlie and the Chocolate Factory");
            BookList.Add("The BFG");
            BookList.Add("The Witches");
            BookList.Add("James and the Giant Peach");
            BookList.Add("Fantastic Mr Fox");
            BookList.Add("The Twits");
            BookList.Add("George's Marvellous Medicine");
            BookList.Add("The Magic Finger");
            BookList.Add("Revolting Rhymes");
            BookList.Add("The Enormous Crocodile");
            BookList.Add("Esio Trot");
            BookList.Add("The Giraffe and the Pelly and Me");


            if (e.KeyChar == (char)Keys.Enter)  // once enter is pressed
            {
                try
                {
                    int Book_code = Convert.ToInt32(textBox2.Text); // converts to int
                    label6.Text = BookList[Book_code];  // finds book name correlating to code
                    
                    var addedDate = DateTime.Now.Date.AddDays(14);  // gets current date time and adds 14 days
                    label7.Text = addedDate.ToString("d");  // prints only date component

                }
                catch   // for invalid codes or data types
                {
                    MessageBox.Show("Invalid book");
                }
            }
        }
    }
}
