using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new emp_login().Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user, password;
            user = unamead.Text;
            password = passad.Text;
            if (user == "admin" && password == "admin")
            {
                MessageBox.Show("Login successfully");
                new admin_dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Credential Invalid!");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
