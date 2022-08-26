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
using Microsoft.VisualBasic;

namespace YemenLibrary
{
    public partial class Insert : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-FCSG4LA3;Initial Catalog=Library;Integrated Security=True");
       SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int v = 0;
        bool isNumber = false;


        public Insert()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ChooseInsert f = new ChooseInsert();
            this.Hide();
            f.Show();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

            BNumber_Reader_Book();
            BNumber_Reader_Copy();
            BNumber_Reader_BookAuthor();
            BNumber_Reader_BookPublisher();
            BNumber_Reader_publisherID();
            BNumber_Reader_authorID();

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }


        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (txt_name.Text == "" || txt_copy.Text==""  || txt_section.Text=="" || txt_author.Text=="" )
            {
                MessageBox.Show("YOU Must fill all inputs??");
            }
            else
            {

                // bring author,publisher IDs
                cn.Open();

                cmd = new SqlCommand("select Author_ID from Author where Name ='"+Author_Name.Text.ToString()+"'", cn);
                SqlDataReader ree = cmd.ExecuteReader();
                ree.Read();
                String AuthorID = ree["Author_ID"].ToString();
                ree.Close();
                cn.Close();


                cn.Open();
                cmd = new SqlCommand("select Publisher_ID from Publisher where Name ='" + Publisher_Name.Text.ToString() + "'", cn);
                SqlDataReader reee = cmd.ExecuteReader();
                reee.Read();
                String PublisherID = reee["Publisher_ID"].ToString();
                reee.Close();
                cn.Close();


                cn.Open();
             //   insert to book
                string book = "set identity_insert Book on; insert into Book(Book_ID,Name,Number,Language,Genre,Page,Copy_number,Section_number,Author_ID,Publisher_ID)values ('" + txt_number.Text.ToString() + "','" + txt_name.Text.ToString() + "','" + txt_number2.Text.ToString() + "','" + bunifuDropdown1.selectedValue.ToString() + "','" + txt_genre.Text.ToString() + "','" + txt_page.Text.ToString() + "','" + txt_copy.Text.ToString() + "','" + txt_section.Text.ToString() + "','" + AuthorID + "','" + PublisherID + "')";
                SqlCommand BookCom = new SqlCommand(book, cn);
                BookCom.ExecuteNonQuery();



                   cn.Close();

                   /////////// insert to bookAuthor
                   cn.Open();
                   string bookAuthor = "set identity_insert BookAuthor on; insert into BookAuthor(BookAuthor_ID,Author_ID,Book_ID)values ('" + txt_BookAuthorID.Text.ToString() + "','" + AuthorID + "','" + txt_number.Text.ToString() + "')";
                   SqlCommand BookAuthorCom = new SqlCommand(bookAuthor, cn);
                   BookAuthorCom.ExecuteNonQuery();
                   cn.Close();


                   /////////// insert to bookAuthor
                   cn.Open();
                   string BookPublisher = "set identity_insert BookPublisher on; insert into BookPublisher(BookPublisher_ID,Publisher_ID,Book_ID)values ('" + txt_BookPublisherID.Text.ToString() + "','" + PublisherID + "','" + txt_number.Text.ToString() + "')";
                   SqlCommand BookPublisherCom = new SqlCommand(BookPublisher, cn);
                   BookPublisherCom.ExecuteNonQuery();
                   cn.Close();






                // insert to Copy
                   cn.Open();

                String copyy=txt_copy.Text.ToString();
                String sectionn=txt_section.Text.ToString();

                int IntCopy=int.Parse(copyy);
                int IntSection=int.Parse(sectionn);
                int i,j;

                String CopyNumber = txt_CopyNumber.Text.ToString();
                int IntCopyNumber = int.Parse(CopyNumber);
                for ( i = 0; i<IntCopy; i++) {
                    for (j = 0; j < IntSection; j++) {
                        string input = Interaction.InputBox("Loction of the Copy "+(i+1)+" and Section "+(j+1)+" is", "Riddle", "", 800, 500);
                        int input2 = int.Parse(input);
                        string copy = "set identity_insert Copy on; insert into Copy(Copy_ID,Book_ID,Copy_number,Section_number,Location)values ('" + (IntCopyNumber) + "','" + txt_number.Text.ToString() + "','" + (i + 1).ToString() + "','" + (j + 1).ToString() + "','" + input2.ToString() + "')";
                       SqlCommand CopyCom = new SqlCommand(copy, cn);
                       CopyCom.ExecuteNonQuery();
                       IntCopyNumber++;





                    }
                }

                





               
                MessageBox.Show("insert successfully");

                txt_name.Text = "";
                txt_number2.Text = "";
                txt_genre.Text = "";
                txt_page.Text = "";
                txt_copy.Text = "";
                txt_section.Text = "";
                txt_author.Text = "";
                txt_publisher.Text = "";
                Author_Name.Text = "";
                Publisher_Name.Text = "";
                Lebal_Author.Text = "";
                Lebal_Publisher.Text = "";

                cn.Close();
                BNumber_Reader_Book();
                BNumber_Reader_Copy();
                BNumber_Reader_BookAuthor();
                BNumber_Reader_BookPublisher();
                BNumber_Reader_publisherID();
                BNumber_Reader_authorID();
                cn.Close();

                


            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_number2.Text = "";
            txt_genre.Text = "";
            txt_page.Text = "";
            txt_copy.Text = "";
            txt_section.Text = "";
            txt_author.Text = "";
            txt_publisher.Text = "";
        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void BNumber_Reader_Book() {
           cmd = new SqlCommand("select Book_ID from Book where Book_ID=(select MAX(Book_ID) from Book)", cn);
          cn.Open();
           SqlDataReader ree = cmd.ExecuteReader();
           ree.Read();
           String a = ree["Book_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
           txt_number.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }
        private void BNumber_Reader_Copy()
        {
            cmd = new SqlCommand("select Copy_ID from Copy where Copy_ID=(select MAX(Copy_ID) from Copy)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Copy_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_CopyNumber.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }

        private void BNumber_Reader_BookAuthor()
        {
            cmd = new SqlCommand("select BookAuthor_ID from BookAuthor where BookAuthor_ID=(select MAX(BookAuthor_ID) from BookAuthor)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["BookAuthor_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_BookAuthorID.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }
        private void BNumber_Reader_BookPublisher()
        {
            cmd = new SqlCommand("select BookPublisher_ID from BookPublisher where BookPublisher_ID=(select MAX(BookPublisher_ID) from BookPublisher)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["BookPublisher_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_BookPublisherID.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }
        private void BNumber_Reader_publisherID()
        {
            cmd = new SqlCommand("select Publisher_ID from Publisher where Publisher_ID=(select MAX(Publisher_ID) from Publisher)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Publisher_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_publisherID.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }
        private void BNumber_Reader_authorID()
        {
            cmd = new SqlCommand("select Author_ID from Author where Author_ID=(select MAX(Author_ID) from Author)", cn);
            cn.Open();
            SqlDataReader ree = cmd.ExecuteReader();
            ree.Read();
            String a = ree["Author_ID"].ToString();
            int ToInt = int.Parse(a);
            ToInt++;
            txt_authorID.Text = ToInt.ToString();
            ree.Close();
            cn.Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txt_section_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_author_Leave(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txt_author.Text, out v);
            cn.Open();

            if (!isNumber)
            {
                String c = "SELECT Name From Author where Name= '" + txt_author.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Author_Nme = rd["Name"].ToString();
                    Author_Name.Text = Author_Nme;
                    Lebal_Author.Text = "Author Name is: " ;
                    rd.Close();
                    cn.Close();

                }

                catch (InvalidOperationException ex)
                {

                    if (MessageBox.Show("The given Name is NOT a Author Name , You want to add it ?", "MessageBox Title", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                      //  string input = Interaction.InputBox("Name Of The Author ?", "Riddle", "", 800, 500);
                        string input = txt_author.Text.ToString();
                        string author = "set identity_insert Author on; insert into Author(Author_ID,Name)values ('" + txt_authorID.Text.ToString() + "','" + input.ToString() + "')";
                        cn.Close();
                        cn.Open();
                        SqlCommand AuthorCom = new SqlCommand(author, cn);
                        AuthorCom.ExecuteNonQuery();
                        MessageBox.Show("insert successfully");
                        txt_author.Text = input.ToString();
                        Author_Name.Text = input.ToString();
                        Lebal_Author.Text = "Author Name is: ";
                        cn.Close();
                        BNumber_Reader_authorID();
                        cn.Close();
                    }
                    else
                    {
                        cn.Close();
                        txt_author.Text = "";
                        Lebal_Author.Text = "";
                        Author_Name.Text = "";

                    } 
                }
            }

            else
            {
                String c = "SELECT Name From Author where Author_ID= '" + txt_author.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Author_Nme = rd["Name"].ToString();
                    Author_Name.Text = Author_Nme;
                    Lebal_Author.Text = "Author Name is: " ;
                    rd.Close();
                    cn.Close();

                }

                catch (InvalidOperationException ex)
                {
                    if (MessageBox.Show("The given Number is NOT a Author Number , You want to add it ?", "MessageBox Title", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        string input = Interaction.InputBox("Name Of The Author ?", "Riddle", "", 800, 500);
                        string author = "set identity_insert Author on; insert into Author(Author_ID,Name)values ('" + txt_authorID.Text.ToString() + "','" + input.ToString() + "')";
                        cn.Close();
                        cn.Open();
                        SqlCommand AuthorCom = new SqlCommand(author, cn);
                        AuthorCom.ExecuteNonQuery();
                        MessageBox.Show("insert successfully");
                        txt_author.Text = input.ToString();
                        Author_Name.Text = input.ToString();
                        Lebal_Author.Text = "Author Name is: ";
                        cn.Close();
                        BNumber_Reader_authorID();
                        cn.Close();
                    }
                    else
                    {
                        cn.Close();
                        txt_author.Text = "";
                        Lebal_Author.Text = "";
                        Author_Name.Text = "";
                    } 
                }
            } 

        }

        private void txt_publisher_Leave(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txt_publisher.Text, out v);
            cn.Open();

            if (!isNumber)
            {
                String c = "SELECT Name From Publisher where Name= '" + txt_publisher.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Publish_Nme = rd["Name"].ToString();
                    Publisher_Name.Text = Publish_Nme;
                    Lebal_Publisher.Text = "Publisher Name is: ";
                    rd.Close();
                    cn.Close();

                }

                catch (InvalidOperationException ex)
                {

                    if (MessageBox.Show("The given Name is NOT a publisher Name , You want to add it ?", "MessageBox Title", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                     //   string input = Interaction.InputBox("Name Of The Publisher ?", "Riddle", "", 800, 500);
                        string input = txt_publisher.Text.ToString();
                        string publisher = "set identity_insert Publisher on; insert into Publisher(Publisher_ID,Name)values ('" + txt_publisherID.Text.ToString() + "','" + input.ToString() + "')";
                        cn.Close();
                        cn.Open();
                        SqlCommand PublisherCom = new SqlCommand(publisher, cn);
                        PublisherCom.ExecuteNonQuery();
                        MessageBox.Show("insert successfully");
                        txt_publisher.Text = input.ToString();
                        Publisher_Name.Text = input.ToString();
                        Lebal_Publisher.Text = "Publisher Name is: ";
                        cn.Close();
                        BNumber_Reader_publisherID();
                        cn.Close();
                    }
                    else
                    {
                        cn.Close();
                        txt_publisher.Text = "";
                        Lebal_Publisher.Text = "";
                        Publisher_Name.Text = "";
                    }
                }
            }

            else
            {
                String c = "SELECT Name From Publisher where Publisher_ID= '" + txt_publisher.Text + "'";
                cmd = new SqlCommand(c, cn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    String Publisher_Nme = rd["Name"].ToString();
                    Publisher_Name.Text = Publisher_Nme;
                    Lebal_Publisher.Text = "Publisher Name is: ";
                    rd.Close();
                    cn.Close();

                }

                catch (InvalidOperationException ex)
                {
                    if (MessageBox.Show("The given number is NOT a publisher number , You want to add it ?", "MessageBox Title", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        string input = Interaction.InputBox("Name Of The Publisher ?", "Riddle", "", 800, 500);
                        string publisher = "set identity_insert Publisher on; insert into Publisher(Publisher_ID,Name)values ('" + txt_publisherID.Text.ToString() + "','" + input.ToString() + "')";
                        cn.Close();
                        cn.Open();
                        SqlCommand PublisherCom = new SqlCommand(publisher, cn);
                        PublisherCom.ExecuteNonQuery();
                        MessageBox.Show("insert successfully");
                        txt_publisher.Text = input.ToString();
                        Publisher_Name.Text = input.ToString();
                        Lebal_Publisher.Text = "Publisher Name is: ";
                        cn.Close();
                        BNumber_Reader_publisherID();
                        cn.Close();
                    }
                    else {
                        cn.Close();
                        txt_publisher.Text = "";
                        Lebal_Publisher.Text = "";
                        Publisher_Name.Text = "";
                    }
                  
                    
                }
            }



        }

        private void txt_author_Enter(object sender, EventArgs e)
        {

        }

        private void txt_author_Click(object sender, EventArgs e)
        {

        }

        private void Publisher_Name_Click(object sender, EventArgs e)
        {

        }
      
    }
}
