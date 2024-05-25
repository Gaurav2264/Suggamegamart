using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Project
{
    public class MyConnect
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader rd;

        public static void connect()
        {
            try
            {
                con = new SqlConnection("Data Source=Gaurav\\SQLEXPRESS;Initial Catalog=SuggaMM_DB;Integrated Security=True;");
                con.Open();
                MessageBox.Show("Connection Succes");

            }
            catch (Exception exp)
            {

                MessageBox.Show("Connection Failed" + exp.Message);
            }
        }
    }
    
}
