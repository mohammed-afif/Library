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
    public partial class Borrow : Form
    {


        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataReader rd;
        int v = 0;
        bool isNumber = false;


        public Borrow()
        {
            InitializeComponent();
            BNumber_Reader_LoanID();
        
        }

        private void Borrow_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Hide();
            f.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            if (txt_borrower.Text == "" || txt_booknumber.Text == "" || txt_copy.Text=="" || txt_section.Text=="")
            {
                MessageBox.Show("YOU MUST FILL THEM ALL !!");
            }
            else
            {
                 

                // Borrower name
                cn.Open();
                SqlCommand Bor = new SqlCommand("select Borrower_ID from Borrower where Name ='" + Lebal_Borr.Text.ToString() + "'", cn);
                SqlDataReader ree = Bor.ExecuteReader();
                ree.Read();
                String BorID = ree["Borrower_ID"].ToString();
                ree.Close();
                cn.Close();

                // Book name
                cn.Open();
                SqlCommand Book = new SqlCommand("select Book_ID from Book where Name ='" + Lebal_Book.Text.ToString() + "'", cn);
                SqlDataReader reee = Book.ExecuteReader();
                reee.Read();
                String BookID = reee["Book_ID"].ToString();
                reee.Close();
                cn.Close();




            cn.Open();
            
            
            using (var sqlCommand = new SqlCommand("SELECT Loan_ID FROM Loan WHERE Book_ID= '" + BookID + "' AND Copy_number = '" + txt_copy.Text + "'  AND Section_number=    '" + txt_section.Text + "'    ", cn))
            {

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Record Already Borrowed .");

                }
                else
                {
                    reader.Close();
                    using (var cmd = new SqlCommand("SELECT Copy_ID FROM Copy WHERE Book_ID= '" +BookID + "' AND Copy_number = '" + txt_copy.Text + "'  AND Section_number=    '" + txt_section.Text + "'    ", cn))
                    {
                        rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            DateTime now = DateTime.Now;
                            string Loan = "set identity_insert Loan on; insert into Loan(Loan_ID,Borrower_ID,Book_ID,Copy_number,Section_number,Due_Date,Return_Date)values ('" + txt_LoanID.Text.ToString() + "','" + BorID + "','" + BookID + "','" + txt_copy.Text.ToString() + "','" + txt_section.Text.ToString() + "','" + now + "','" + bunifuDatepicker2.Value.ToString("MM/dd/yyyy") + "')";
                            SqlCommand LoanCom = new SqlCommand(Loan, cn);
                            rd.Close();
                            LoanCom.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("insert successfully");
                            txt_borrower.Text = "";
                            txt_booknumber.Text = "";
                            txt_copy.Text = "";
                            txt_section.Text = "";
                            Lebal_Befor.Text = "";
                            Lebal_Befor2.Text = "";
                            Lebal_Borr.Text = "";
                            Lebal_Book.Text = "";

                            BNumber_Reader_LoanID();
                        }
                        else
                        {
                            MessageBox.Show("This book is Not Exists.");

                        }
                    
                    }
                }
                cn.Close();

            }
        }
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txt_borrower.Text = ""; 
            txt_booknumber.Text = ""; 
            txt_copy.Text= "";
            txt_section.Text = "";
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txt_section_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_copy_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void BNumber_Reader_LoanID()
        {
            cmd = new SqlCommand("select Loan_ID from Loan where Loan_ID=(select MAX(Loan_ID) from Loan)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Loan_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_LoanID.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }

        private void txt_borrower_Leave(object sender, EventArgs e)
        {
               isNumber = int.TryParse(txt_borrower.Text, out v);
            cn.Open();
            if (!isNumber)
            {
                String c = "SELECT Name From Borrower where Name= '" + txt_borrower.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Borrower_Nme=rd["Name"].ToString();
                    Lebal_Borr.Text = Borrower_Nme;
                    Lebal_Borr.Visible = false;
                    Lebal_Befor.Text = "Your Name is:";
                    Lebal_Befor.Visible = false;
                   // MessageBox.Show("yes you are member");
                    rd.Close();
                    cn.Close();

                }
                catch (InvalidOperationException ex) {
                    MessageBox.Show("SORRY, you are NOT a member, you must add your information first", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_borrower.Text = "";
                    cn.Close();
                }
            }


            else {
                String c = "SELECT Name From Borrower where Borrower_ID= '" + txt_borrower.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Borrower_Nme = rd["Name"].ToString();
                    Lebal_Borr.Text = Borrower_Nme;
                    Lebal_Borr.Visible = true;
                    Lebal_Befor.Text = "Your Name is:";
                    Lebal_Befor.Visible = true;
                    rd.Close();
                    cn.Close();

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("SORRY, This Borrower is NOT available", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_borrower.Text = "";
                    cn.Close();
                }
            
            }
        }

        private void txt_booknumber_Leave(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txt_booknumber.Text, out v);
            cn.Open();
            if (!isNumber)
            {
                String c = "SELECT Name From Book where Name= '" + txt_booknumber.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    string Book_Nme=rd["Name"].ToString();
                    Lebal_Book.Text = Book_Nme;
                    Lebal_Book.Visible = false;
                    Lebal_Befor2.Text = "Book Name is:";
                    Lebal_Befor2.Visible = false;
                    // MessageBox.Show("yes you are member");
                    rd.Close();
                    cn.Close();

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("SORRY, This Book is NOT available in the Library", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_booknumber.Text = "";
                    cn.Close();
                }
            }


            else
            {
                String c = "SELECT Name From Book where Book_ID= '" + txt_booknumber.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Borrower_Nme = rd["Name"].ToString();
                    Lebal_Book.Text = Borrower_Nme;
                    Lebal_Book.Visible = true;
                    Lebal_Befor2.Text = "Book Name is:";
                    Lebal_Befor2.Visible = true;
                    rd.Close();
                    cn.Close();

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("SORRY, This Book is NOT available in the Library", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_booknumber.Text = "";
                    cn.Close();
                }

            }
        }
    }
}
