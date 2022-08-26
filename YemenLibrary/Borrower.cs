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
    public partial class Borrower : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;


        public Borrower()
        {
            InitializeComponent();
            BNumber_Reader();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ChooseInsert f = new ChooseInsert();
            this.Hide();
            f.Show();
        }

        private void Borrower_Load(object sender, EventArgs e)
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

                string author = "set identity_insert Borrower on; insert into Borrower(Borrower_ID,Name,Phone,Address)values ('" + txt_number.Text.ToString() + "','" + txt_name.Text.ToString() + "','" + txt_phone.Text.ToString() + "','" + txt_address.Text.ToString() + "')";
                SqlCommand AuthorCom = new SqlCommand(author, cn);
                AuthorCom.ExecuteNonQuery();
                MessageBox.Show("Your Number is " + txt_number.Text.ToString());
                txt_name.Text = "";
                txt_address.Text = "";
                txt_phone.Text = "";
                cn.Close();
                BNumber_Reader();
                cn.Close();
            }
        }

        private void BNumber_Reader()
        {
            cmd = new SqlCommand("select Borrower_ID from Borrower where Borrower_ID=(select MAX(Borrower_ID) from Borrower)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Borrower_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_number.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }
    }
}
