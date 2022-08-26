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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void InserButton_Click(object sender, EventArgs e)
        {
            ChooseInsert f = new ChooseInsert();
            this.Hide();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Borrow f = new Borrow();
            this.Hide();
            f.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            View f = new View();
            this.Hide();
            f.Show();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Search f = new Search();
            this.Hide();
            f.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            About f = new About();
            this.Hide();
            f.Show();
        }
    }
}
