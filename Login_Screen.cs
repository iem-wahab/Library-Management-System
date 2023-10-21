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
    public partial class Login_Screen : Form
    {
        private SqlConnection LibraryDB_Connection;
        public Login_Screen()
        {
            LibraryDB_Connection = new SqlConnection(@"Data Source=DESKTOP-OUDP3T5\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True");
            InitializeComponent();
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Close_Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Passward.PasswordChar = '*';
        }

        private void SignIn_Button_Click(object sender, EventArgs e)
        {
            string user_name = User_Email.Text;
            string user_password = Passward.Text;
            LibraryDB_Connection.Open();
            string email_query = "EXEC login_user @email = '" + User_Email.Text + "', @password = '" + Passward.Text + "'";
            SqlCommand email_cmd = new SqlCommand(email_query, LibraryDB_Connection);
            SqlDataAdapter user_Adapter = new SqlDataAdapter(email_cmd);
            if (user_Adapter != null )
            {
                DataTable usertable = new DataTable();
                user_Adapter.Fill(usertable);
                if (usertable.Rows.Count == 1)
                {
                    SqlDataReader read_data = email_cmd.ExecuteReader();
                    string user_type = "";
                    while (read_data.Read())
                    {
                        user_type = read_data.GetValue(4).ToString();
                    }
                    if (user_type == "user")
                    {
                        this.Hide();
                        UserModule userModule = new UserModule();
                        userModule.Show();
                    }
                    else
                    {
                        this.Hide();
                        AdminModule adminModule = new AdminModule();
                        adminModule.Show();
                    }
                   
                    
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password", "Invalid Information");
                }
            }
            else
            {
                MessageBox.Show("Invalid Email or Password", "Invalid Information");
            }
            LibraryDB_Connection.Close();

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Register add = new Register();
            add.Show();
            this.Hide();
        }
    }
}
