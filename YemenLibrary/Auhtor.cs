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
    public partial class Auhtor : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;



        public Auhtor()
        {
            InitializeComponent();
            BNumber_Reader();
            showdata();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        public void showdata()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            adpt = new SqlDataAdapter("select * from Author", cn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void BNumber_Reader()
        {
            cmd = new SqlCommand("select Author_ID from Author where Author_ID=(select MAX(Author_ID) from Author)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Author_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_number.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }


        private void Auhtor_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (txt_name.Text == "")
            {
                MessageBox.Show("YOU DID NOT ENTER ANYTHING??");
            }
            else
            {
                cn.Open();

                string author = "set identity_insert Author on; insert into Author(Author_ID,Name,Country,Address,Description)values ('" + txt_number.Text.ToString() + "','" + txt_name.Text.ToString() + "','" + txt_country.Text.ToString() + "','" + txt_address.Text.ToString() + "','" + txt_description.Text.ToString() + "')";
                SqlCommand AuthorCom = new SqlCommand(author, cn);
                AuthorCom.ExecuteNonQuery();
                MessageBox.Show("insert successfully");
                txt_name.Text = "";
                txt_address.Text = "";
                txt_country.Text = "";
                txt_address.Text = "";
                txt_description.Text = "";
                cn.Close();
                BNumber_Reader();
                showdata();
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ChooseInsert f = new ChooseInsert();
            this.Hide();
            f.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_country.Text = "";
            txt_address.Text = "";
            txt_description.Text = "";
        }
    }
}
