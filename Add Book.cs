using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Lab_Project
{
    public partial class Add_Book : Form
    {
        private SqlConnection DBconnection;
        public Add_Book()
        {
            InitializeComponent();
            DBconnection = new SqlConnection(@"Data Source=DESKTOP-OUDP3T5\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True");
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {

        }

        private void AddBook_Adminbtn_Click(object sender, EventArgs e)
        {
            if (BookTitle_Input != null && BookEdition_Input != null && BookQuantity_Input != null && BookPublisherID_Input != null)
            {
                string Book_title = BookTitle_Input.Text;
                string Book_Edition = BookEdition_Input.Text;
                int Book_Qunatity = int.Parse(BookQuantity_Input.Text);
                int Book_Publisher = int.Parse(BookPublisherID_Input.Text);
                DBconnection.Open();
                string Add_Query = "INSERT INTO BOOK VALUES (@title,@quantity,@edition,@availibity,@publisher)";
                SqlCommand Add_Command = new SqlCommand(Add_Query, DBconnection);
                Add_Command.Parameters.AddWithValue("@title", Book_title);
                Add_Command.Parameters.AddWithValue("@availibity", "True");
                Add_Command.Parameters.AddWithValue("@edition", Book_Edition);
                Add_Command.Parameters.AddWithValue("@quantity", Book_Qunatity);
                Add_Command.Parameters.AddWithValue("@publisher", Book_Publisher);
                Add_Command.ExecuteNonQuery();
                MessageBox.Show("Data has been Inserted.", "Confimation");
                DBconnection.Close();
            }
            else
            {
                MessageBox.Show("Enter Complete Input.", "Invalid Input");
            }
        }

        private void BookPublisherID_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookEdition_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookQuantity_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookTitle_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
