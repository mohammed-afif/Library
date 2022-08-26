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
    public partial class Publisher : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;


        public Publisher()
        {
            InitializeComponent();
            showdata();
            BNumber_Reader();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ChooseInsert f = new ChooseInsert();
            this.Hide();
            f.Show();
        }

        public void showdata()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            adpt = new SqlDataAdapter("select * from Publisher", cn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void BNumber_Reader()
        {
            cmd = new SqlCommand("select Publisher_ID from Publisher where Publisher_ID=(select MAX(Publisher_ID) from Publisher)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Publisher_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_number.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }

        private void Publisher_Load(object sender, EventArgs e)
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

                string publisher = "set identity_insert Publisher on; insert into Publisher(Publisher_ID,Name,Address,Phone)values ('" + txt_number.Text.ToString() + "','" + txt_name.Text.ToString() + "','" + txt_address.Text.ToString() + "','" + txt_phone.Text.ToString() + "')";
                SqlCommand PublisherCom = new SqlCommand(publisher, cn);
                PublisherCom.ExecuteNonQuery();
                MessageBox.Show("insert successfully");
                txt_name.Text = "";
                txt_address.Text = "";
                txt_phone.Text = "";
                cn.Close();
                BNumber_Reader();
                showdata();
                cn.Close();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
