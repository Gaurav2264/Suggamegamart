using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Point = System.Drawing.Point;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;


namespace Project
{
    public partial class Invoice : Form
    {

        SqlConnection Con = new SqlConnection("Data Source=Gaurav\\SQLEXPRESS;Initial Catalog=SuggaMM_DB;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public Invoice()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            sda = new SqlDataAdapter("Select * from Tbl_Product", Con);
            dt = new DataTable();
            sda.Fill(dt);
            item_dgv.DataSource = dt;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void reset()
        {
            txt_name.Text = "";
            qty.Text = "";
            mrp.Text = "";
            price.Text = "";
            txt_contact.Text = "";

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            lbluser.Text = emp_login.EmployeeName;
            lbldate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }
        int bid, rowid;
        public string itemName;

        private void item_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (item_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(item_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            string sql;
            sql = "select * from Tbl_Product where id=" + bid + "";

            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txt_name.Text = ds.Tables[0].Rows[0][1].ToString();
            mrp.Text = ds.Tables[0].Rows[0][3].ToString();
            price.Text = ds.Tables[0].Rows[0][4].ToString();
            itemName = ds.Tables[0].Rows[0][1].ToString();
            //MessageBox.Show(itemName);




        }
        private void UpdateItem()
        {
            try
            {
                string sql = "select * from Tbl_Product where Item_name='" + itemName + "'";
                int dbqty = 0;
                try
                {
                    Con.Open();
                    SqlCommand cmd2 = new SqlCommand(sql, Con);
                    SqlDataReader rd = cmd2.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            dbqty = rd.GetInt32(2);
                        }
                    }

                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Getting Quantity: " + ex.Message);
                }

                int newqty = dbqty - int.Parse(qty.Text);
                Con.Open();
                string query = "Update Tbl_Product set Qty=" + newqty + " where Id=" + rowid + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Product Updates Successfully!!");
                Con.Close();
                populate();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error4: " + ex.Message);
            }
        }
        int n = 0, grdtotal = 0, Amount;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (qty.Text == "")
            {
                MessageBox.Show("Enter Quantity!");
            }
            else
            {
                int total = Convert.ToInt32(qty.Text) * Convert.ToInt32(price.Text);
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(bill_dgv);
                dr.Cells[0].Value = n + 1;
                dr.Cells[1].Value = txt_name.Text;
                dr.Cells[2].Value = qty.Text;
                dr.Cells[3].Value = mrp.Text;
                dr.Cells[4].Value = price.Text;
                dr.Cells[5].Value = total;
                bill_dgv.Rows.Add(dr);
                grdtotal = grdtotal + total;
                Amount = grdtotal;
                lblttl.Text = "Rs." + grdtotal;
                n++;
                UpdateItem();
                reset();
            }

        }

        private void mrp_TextChanged(object sender, EventArgs e)
        {

        }

        int EId = 1;
        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_contact.Text == "")
            {
                MessageBox.Show("Please enter the Customer Contact Details!!");

            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into Bills values(" + EId + ",'" + lbluser.Text + "','" + txt_contact.Text + "','" + Amount + "',GetDate())", Con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Bill Saved Successfully!!");
                    Con.Close();
                    populate();
                    reset();
                    /*
                    //pdf generation start
                    string totalAmount = lblttl.Text;
                    Document doc = new Document();
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream("Invoice.pdf", FileMode.Create));
                        doc.Open();

                        // load the image from file
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("D:\\CIMAGE\\c#.net\\Project\\images\\logo.png");

                        // set the position of the image to the top center
                        img.Alignment = Element.ALIGN_CENTER;
                        img.ScaleToFit(200f, 200f);// Adjust the image size as needed

                         // add image to the document
                         doc.Add(img);

                        PdfPTable pdfTable = new PdfPTable(bill_dgv.ColumnCount);
                        pdfTable.DefaultCell.BorderWidth = 0;  // gridview border
                        for(int i=0; i<bill_dgv.ColumnCount;i++)
                        {
                            pdfTable.AddCell(bill_dgv.Columns[i].HeaderText);
                        }
                        // Add Data from the data gridview to pdf table
                        for(int i=0; i<bill_dgv.Rows.Count;i++)
                        {
                            for (int j = 0; j < bill_dgv.Rows.Count; j++)
                            {
                                if (bill_dgv.Rows[i].Cells[i].Value!=null)
                                {
                                    pdfTable.AddCell(bill_dgv.Rows[i].Cells[j].Value.ToString());
                                }

                            }
                        }
                        // Add the pdf table to the document
                        doc.Add(pdfTable);

                        // Add total amount label and value
                        Paragraph totalAmountParagraph = new Paragraph($"Total Amount ={totalAmount}");
                        totalAmountParagraph.Alignment = Element.ALIGN_RIGHT;
                        totalAmountParagraph.SpacingBefore = 10f; // Spacing before the paragraph
                        doc.Add(totalAmountParagraph);

                        // close the document
                        doc.Close();

                        // Get the full path of the generated pdf file
                        //string pdfFilePath = Path.Combine(Environment.CurrentDirectory, "Invoice.pdf");
                        PdfWriter.GetInstance(doc, new FileStream(@"D:\\CIMAGE\\c#.net\\Project\\images\\Invoice.pdf", FileMode.Create));
                        //open the pdf file using the default pdf viewer
                        //Process.Start(pdfFilePath);

                        //MessageBox.Show("Pdf File generated successfully");


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    //pdf generation end
                    */
                    PdfSharpCore.Pdf.PdfDocument document = new PdfSharpCore.Pdf.PdfDocument();
                    PdfSharpCore.Pdf.PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Arial", 12);
                    gfx.DrawString("Hello,Pdf!",font,XBrushes.Black,new XPoint(10,10));

                    XImage image = XImage.FromFile(@"logo.png");
                    double centerX = (page.Width.Point - image.PixelWidth * 72 / image.HorizontalResolution) / 2;
                    double topY = 10;
                    gfx.DrawImage(image, centerX, topY,image.PixelWidth*72/ image.HorizontalResolution,image.PixelHeight*72/image.HorizontalResolution);
                    document.Save("D:\\CIMAGE\\c#.net\\Project\\images\\Invoice.pdf");
                    document.Close();

                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error5: " + ex.Message);
                }
            }

            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
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

        private void lbluser_Click(object sender, EventArgs e)
        {

        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
           
        }
    }
}
