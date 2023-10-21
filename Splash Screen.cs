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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Splach_Screen_Timer.Enabled = true;
            progressBar1.Increment(3);
            if(progressBar1.Value==100)
            {
                Splach_Screen_Timer.Enabled = false;
                Login_Screen LS = new Login_Screen();
                LS.Show();
                this.Hide();
            }
        }
        private void Splash_Screen_Load(object sender, EventArgs e)
        {

        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
