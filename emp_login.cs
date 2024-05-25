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

namespace Project
{

    public partial class emp_login : Form
    {
        public emp_login()
        {
            InitializeComponent();
        }
        public static string EmployeeName = "";
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
            // new emp_dashboard().Show();
            // this.Hide();

        }
        SqlConnection Con = new SqlConnection("Data Source=Gaurav\\SQLEXPRESS;Initial Catalog=SuggaMM_DB;Integrated Security=True;");
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Tbl_Emp where Name='" + uname.Text + "' and Password='" + pass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                EmployeeName = uname.Text;
                new Invoice().Show();
                this.Hide();
                Con.Close();

            }
            else
            {
                MessageBox.Show("Wrong UserName");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
