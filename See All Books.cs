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
    public partial class See_All_Books : Form
    {
        private SqlConnection DBconnection;
        public See_All_Books()
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
            DataTable Carstable = new DataTable();
            Books_Adapter.Fill(Carstable);
            AllBooksGrid.DataSource = Carstable;
            DBconnection.Close();
        }

        private void See_All_Books_Load(object sender, EventArgs e)
        {
            Grid_fill();
        }
    }
}
