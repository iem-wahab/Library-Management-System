using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Project
{
    public partial class AdminModule : Form
    {
        public AdminModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Book add_Book = new Add_Book();
            add_Book.Show();
        }

        private void DeleteBook_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Book del_Book = new Delete_Book();
            del_Book.Show();
        }

        private void UpdateBook_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Book update_Book = new Update_Book();
            update_Book.Show();
        }

        private void SeeAllBooks_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            See_All_Books see_All_Books = new See_All_Books();
            see_All_Books.Show();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Book search_Book = new Search_Book();
            search_Book.Show();
        }

        private void SeeAllPerson_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            See_All_Users see_All_Users = new See_All_Users();
            see_All_Users.Show();
        }

        private void AvailableBooks_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Available_Books available_Books = new Available_Books();
            available_Books.Show();
        }
    }
}
