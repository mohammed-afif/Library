using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemenLibrary
{
    public partial class ChooseInsert : Form
    {
        public ChooseInsert()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Insert f = new Insert();
            this.Hide();
            f.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Borrower f = new Borrower();
            this.Hide();
            f.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Auhtor f = new Auhtor();
            this.Hide();
            f.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Publisher f = new Publisher();
            this.Hide();
            f.Show();
        }
    }
}
