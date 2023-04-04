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
    public partial class Receipt_Preview : Form
    {
        public Receipt_Preview()
        {
            InitializeComponent();
        }

        private void Receipt_Preview_Load(object sender, EventArgs e)
        {
            label2.Text = "Borrower name: " + Globals.BorrowerName;
            label3.Text = Convert.ToString(Globals.BorrowingTime);
            label4.Text = "Due date: " + Globals.DueDate;

            string BookBorrowing = "";
            for (int i = 0; i < Globals.BookBorrowingList.Count; i++)
            {
                BookBorrowing = BookBorrowing + "\n" + Globals.BookBorrowingList[i];
                label5.Text = BookBorrowing;
            }
            // ADD THING SO RECEIPT GETS LONGER IF TOO MANY BOOKS - PAST 7? BOOKS
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BorrowingCompletitionForm = new Borrowing_Completion();
            BorrowingCompletitionForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
