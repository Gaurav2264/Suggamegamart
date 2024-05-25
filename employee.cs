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

namespace Project
{
    public partial class employee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Gaurav\\SQLEXPRESS;Initial Catalog=SuggaMM_DB;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        public employee()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            sda = new SqlDataAdapter("Select * from Tbl_Emp",con);
            dt=new DataTable();
            sda.Fill(dt);
            emp_dgv.DataSource = dt;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_age.Text == "" || txt_address.Text == "" || txt_contact.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Select the Employee To be Updated");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Tbl_Emp set Name='" +txt_name.Text+ "',Age="+txt_age.Text+",Address='"+txt_address.Text+"',Contact="+txt_contact.Text+",Password='"+txt_password.Text+"'where EmployeeId="+rowid+";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Succesfully!");
                    con.Close();
                    populate();

                    txt_name.Clear();
                    txt_age.Clear();
                    txt_address.Clear();
                    txt_contact.Clear();
                    txt_password.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


       

        

        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text==""||txt_age.Text==""||txt_address.Text==""||txt_contact.Text==""||txt_password.Text=="")
            {
                MessageBox.Show("Please fill the details Correctly!");
            }
            else
            {
                try { 
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Tbl_Emp values('" + txt_name.Text + "'," + txt_age.Text + ",'" + txt_address.Text + "'," + txt_contact.Text + ",'" + txt_password.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Succesfully!");
                    con.Close();
                    populate();

                    txt_name.Clear();
                    txt_age.Clear();
                    txt_address.Clear();
                    txt_contact.Clear();
                    txt_password.Clear();
                }
                catch(Exception ex) {
                MessageBox.Show(ex.Message);
                }
                
            }
        }
        int bid, rowid;
        private void emp_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (emp_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(emp_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            string sql;
            sql = "select * from Tbl_Emp where EmployeeId=" + bid + "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txt_name.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_age.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_address.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_contact.Text = ds.Tables[0].Rows[0][4].ToString();
            txt_password.Text = ds.Tables[0].Rows[0][5].ToString();

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (rowid==0)
            {
                MessageBox.Show("Select the Employee To be deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete From Tbl_Emp where EmployeeId=" + rowid + ";"; 
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succesfully!");
                    con.Close();
                    populate();

                    txt_name.Clear();
                    txt_age.Clear();
                    txt_address.Clear();
                    txt_contact.Clear();
                    txt_password.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Logout from the active window 
            new login().Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Logout from the active window 
            new login().Show();
            this.Hide();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new admin_dashboard().Show();
            this.Hide();
        }
    }
}
