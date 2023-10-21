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
    public partial class Register : Form
    {
        public object Passward { get; private set; }

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passward_Input_TextChanged(object sender, EventArgs e)
        {
            Passward_Input.PasswordChar = '*';
        }

        private void ConfirmPassward_Input_TextChanged(object sender, EventArgs e)
        {
            ConfirmPassward_Input.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login_Screen LS = new Login_Screen();
            LS.Show();
            this.Hide();
        }
    }
}
