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
    }
}
