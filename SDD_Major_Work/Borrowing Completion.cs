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
    public partial class Borrowing_Completion : Form
    {
        public Borrowing_Completion()
        {
            InitializeComponent();
        }

        private void Borrowing_Completion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Receipt_Preview"].Close();
            Application.OpenForms["Borrowing_Completion"].Close();
        }
    }
}
