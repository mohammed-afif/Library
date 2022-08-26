using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemenLibrary
{
    public partial class View : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;


        public View()
        {
            InitializeComponent();
            showdata();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.Show();
        }


        public void showdata() {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            adpt = new SqlDataAdapter("select * from Book", cn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }





        private void View_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_4(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
