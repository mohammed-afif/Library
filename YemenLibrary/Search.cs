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
    public partial class Search : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Author_Click_1(object sender, EventArgs e)
        {
            string name = "SELECT  Author.Name , Author.Description, Book.Name , BookAuthor.*  FROM BookAuthor AS BookAuthor  LEFT JOIN Author AS Author   ON BookAuthor.Author_ID =Author.Author_ID  LEFT JOIN Book AS Book   ON  BookAuthor.Book_ID= Book.Book_ID WHERE Author.Name like       '%" + txt_search.text + "%'";
            cn.Open();
            adpt = new SqlDataAdapter(name, cn);
            dt = new DataTable();
            adpt.Fill(dt);
            DG.DataSource = dt;
            cn.Close();
        }

        private void Button_Number_Click(object sender, EventArgs e)
        {
            string name = "select Number,Name,Language,Page,ISBN,Genre,Book_ID,Copy_number,Section_number,Author_ID from Book where Number like '%" + txt_search.text + "%'";
            cn.Open();
            adpt = new SqlDataAdapter(name, cn);
            dt = new DataTable();
            adpt.Fill(dt);
            DG.DataSource = dt;
            cn.Close();
        }

        private void Button_Genre_Click(object sender, EventArgs e)
        {
            string name = "select Genre,Name,Number,Language,Page,ISBN,Book_ID,Copy_number,Section_number,Author_ID from Book where Genre like '%" + txt_search.text + "%'";
            cn.Open();
            adpt = new SqlDataAdapter(name, cn);
            dt = new DataTable();
            adpt.Fill(dt);
            DG.DataSource = dt;
            cn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
                                        
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            txt_search.text = "";

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Name_Click(object sender, EventArgs e)
        {
            string name = "select Name,Number,Language,Page,ISBN,Genre,Book_ID,Copy_number,Section_number,Author_ID from Book where Name like '%"+ txt_search.text+"%'";
            cn.Open();
            adpt = new SqlDataAdapter(name, cn);
            dt = new DataTable();
            adpt.Fill(dt);
            DG.DataSource = dt;
            cn.Close();
        }

      
        

    }
}
