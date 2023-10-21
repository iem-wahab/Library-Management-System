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


    public partial class Delete_Book : Form
    {
        private SqlConnection DBconnection;
        public Delete_Book()
        {
            InitializeComponent();
            DBconnection = new SqlConnection(@"Data Source=DESKTOP-OUDP3T5\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True");
        }

        private void Grid_fill()
        {
            DBconnection.Open();
            string FetchBooksQuery = "SELECT* FROM BOOK";
            SqlCommand Fetchbooks = new SqlCommand(FetchBooksQuery, DBconnection);
            SqlDataAdapter Books_Adapter = new SqlDataAdapter(Fetchbooks);
            DataTable Booktable = new DataTable();
            Books_Adapter.Fill(Booktable);
            AllBooksGrid.DataSource = Booktable;
            DBconnection.Close();
        }

        private void Delete_Book_Load(object sender, EventArgs e)
        {
            Grid_fill();
        }

        private void DeleteBook_btn_Click(object sender, EventArgs e)
        {
            if (BookID != null && BookTitle_Input != null && BookEdition_Input != null && BookQuantity_Input != null && BookPublisherID_Input != null)
            {
                int Book_ID = int.Parse(BookID.Text);
                DBconnection.Open();
                string DeleteQuery = "DELETE FROM BOOK WHERE ID = @ID";
                SqlCommand Book_Deletion = new SqlCommand(DeleteQuery, DBconnection);
                Book_Deletion.Parameters.AddWithValue("@ID", Book_ID);
                Book_Deletion.ExecuteNonQuery();
                DBconnection.Close();
                MessageBox.Show("Data has been Deleted.", "Confimation");
                Grid_fill();
            }
            else
            {
                MessageBox.Show("Please Enter the ID of Book to Delete it's Data", "Invalid input");
            }

        }

        private void UpdateBook_Adminbtn_Click(object sender, EventArgs e)
        {
            if (BookID != null && BookTitle_Input != null && BookEdition_Input != null && BookQuantity_Input != null && BookPublisherID_Input != null)
            {
                int Book_ID = int.Parse(BookID.Text);
                string Book_title = BookTitle_Input.Text;
                string Book_Edition = BookEdition_Input.Text;
                int Book_Qunatity = int.Parse(BookQuantity_Input.Text);
                int Book_Publisher = int.Parse(BookPublisherID_Input.Text);
                DBconnection.Open();
                string UpdateQuery = "Update BOOK SET Title = @title, Quantity = @quantity, Edition = @edition, Availibilty = @availibity, Publisher_ID = @publisher  WHERE ID = @ID;";
                SqlCommand Update_Command = new SqlCommand(UpdateQuery, DBconnection);
                Update_Command.Parameters.AddWithValue("@title", Book_title);
                Update_Command.Parameters.AddWithValue("@ID", Book_ID);
                Update_Command.Parameters.AddWithValue("@availibity", "True");
                Update_Command.Parameters.AddWithValue("@edition", Book_Edition);
                Update_Command.Parameters.AddWithValue("@quantity", Book_Qunatity);
                Update_Command.Parameters.AddWithValue("@publisher", Book_Publisher);
                Update_Command.ExecuteNonQuery();
                MessageBox.Show("Data has been Updated.", "Confimation");
                DBconnection.Close();
                Grid_fill();
            }
        }

        private void AllBooksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AllBooksGrid.Rows[e.RowIndex];
                BookID.Text = row.Cells["ID"].Value.ToString();
                BookTitle_Input.Text = row.Cells["Title"].Value.ToString();
                BookEdition_Input.Text = row.Cells["Edition"].Value.ToString();
                BookQuantity_Input.Text = row.Cells["Quantity"].Value.ToString();
                BookPublisherID_Input.Text = row.Cells["Publisher_ID"].Value.ToString();
            }


        }

    }
}
