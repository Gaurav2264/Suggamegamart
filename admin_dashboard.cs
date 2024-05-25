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
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Project
{
    public partial class admin_dashboard : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=Gaurav\\SQLEXPRESS;Initial Catalog=SuggaMM_DB;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public admin_dashboard()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            sda = new SqlDataAdapter("Select * from Bills", Con);
            dt = new DataTable();
            sda.Fill(dt);
            salesdgv.DataSource = dt;


        }


        private void label9_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new employee().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Product().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Categories().Show();
            //this.Hide();
        }

        private void bttonexport_Click(object sender, EventArgs e)
        {
            salesdgv.SelectAll();
            DataObject copydata = salesdgv.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlsWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlsWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlsWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

