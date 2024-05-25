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
    public partial class Product : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=Gaurav\\SQLEXPRESS;Initial Catalog=SuggaMM_DB;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
      
        
        public Product()
        {
            InitializeComponent();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new admin_dashboard().Show();
            this.Hide();
        }
        private void populate()
        {
            sda = new SqlDataAdapter("Select * from Tbl_Product", Con);
            dt = new DataTable();
            sda.Fill(dt);
            ProductDGV.DataSource = dt;


        }
        public int quant;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtqty.Text == "" || txtmrp.Text == "" || price.Text == "" || cmbcat.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill the data properly!!");

            }
            else
            {
                try
                {
                    Con.Open();
                    quant = int.Parse(txtqty.Text);
                    String sql = "insert into Tbl_Product values('" + txtname.Text + "'," + quant + "," + txtmrp.Text + "," + price.Text + ",'" + cmbcat.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Succesfully!");
                    Con.Close();
                    populate();
                    txtname.Clear();
                    txtqty.Clear();
                    txtmrp.Clear();
                    price.Clear();
                    cmbcat.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error1: "+ex.Message);

                }
            }
        }
        int bid, rowid;
        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(ProductDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            string sql;
            sql = "select * from Tbl_Product where id=" + bid + "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtqty.Text = ds.Tables[0].Rows[0][2].ToString();
            txtmrp.Text = ds.Tables[0].Rows[0][3].ToString();
            price.Text = ds.Tables[0].Rows[0][4].ToString();
            cmbcat.SelectedText = ds.Tables[0].Rows[0][5].ToString();


        }
        

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtqty.Text == "" || txtmrp.Text == "" || price.Text == "" || cmbcat.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the product to be updated!!");

            }
            else
            {
                try
                {
                    Con.Open();
                    quant = int.Parse(txtqty.Text);
                    string query = "Update Tbl_Product set Item_name='" + txtname.Text + "',Qty=" + quant + ",MRP=" + txtmrp.Text + ", Price=" + price.Text + " ,category='" + cmbcat.SelectedItem.ToString() + "' where Id=" + rowid + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updates Successfully!!");
                    Con.Close();
                    populate();

                    txtname.Clear();
                    txtqty.Clear();
                    txtmrp.Clear();
                    price.Clear();
                    cmbcat.SelectedIndex = -1;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error2: "+ex.Message);
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (rowid == 0)
            {
                MessageBox.Show("Select the product to be deleted!!");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete From Tbl_Product where Id=" + rowid + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!");
                    Con.Close();
                    populate();

                    txtname.Clear();
                    txtqty.Clear();
                    txtmrp.Clear();
                    price.Clear();
                    cmbcat.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error3: "+ex.Message);
                }
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
