namespace Project
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_reset = new Button();
            btn_print = new Button();
            btn_add = new Button();
            txt_contact = new TextBox();
            price = new TextBox();
            mrp = new TextBox();
            qty = new TextBox();
            txt_name = new TextBox();
            label6 = new Label();
            txt_price = new Label();
            txt_mrp = new Label();
            txtqty = new Label();
            txt_item = new Label();
            bill_dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txt_bill = new Label();
            pictureBox4 = new PictureBox();
            lbl_logo = new Label();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            item_dgv = new DataGridView();
            label3 = new Label();
            lblttl = new Label();
            lbldate = new Label();
            lbluser = new Label();
            pictureBox1 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bill_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)item_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1207, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1242, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(29, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = SystemColors.ActiveCaption;
            btn_reset.FlatAppearance.BorderSize = 0;
            btn_reset.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reset.Location = new System.Drawing.Point(266, 338);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new System.Drawing.Size(104, 46);
            btn_reset.TabIndex = 6;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_delete_Click;
            // 
            // btn_print
            // 
            btn_print.BackColor = SystemColors.ActiveCaption;
            btn_print.FlatAppearance.BorderSize = 0;
            btn_print.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_print.Location = new System.Drawing.Point(976, 592);
            btn_print.Name = "btn_print";
            btn_print.Size = new System.Drawing.Size(98, 46);
            btn_print.TabIndex = 9;
            btn_print.Text = "Print";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaption;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.InfoText;
            btn_add.Location = new System.Drawing.Point(78, 340);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(133, 46);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add To Bill";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // txt_contact
            // 
            txt_contact.Location = new System.Drawing.Point(169, 285);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new System.Drawing.Size(138, 27);
            txt_contact.TabIndex = 4;
            // 
            // price
            // 
            price.Enabled = false;
            price.Location = new System.Drawing.Point(279, 223);
            price.Name = "price";
            price.Size = new System.Drawing.Size(157, 27);
            price.TabIndex = 3;
            // 
            // mrp
            // 
            mrp.Enabled = false;
            mrp.Location = new System.Drawing.Point(64, 223);
            mrp.Name = "mrp";
            mrp.Size = new System.Drawing.Size(158, 27);
            mrp.TabIndex = 2;
            mrp.TextChanged += mrp_TextChanged;
            // 
            // qty
            // 
            qty.Location = new System.Drawing.Point(284, 144);
            qty.Name = "qty";
            qty.Size = new System.Drawing.Size(145, 27);
            qty.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Enabled = false;
            txt_name.Location = new System.Drawing.Point(68, 144);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(154, 27);
            txt_name.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(192, 259);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(96, 23);
            label6.TabIndex = 53;
            label6.Text = "Contact ";
            label6.Click += label6_Click;
            // 
            // txt_price
            // 
            txt_price.AutoSize = true;
            txt_price.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_price.Location = new System.Drawing.Point(308, 200);
            txt_price.Name = "txt_price";
            txt_price.Size = new System.Drawing.Size(62, 23);
            txt_price.TabIndex = 54;
            txt_price.Text = "Price";
            // 
            // txt_mrp
            // 
            txt_mrp.AutoSize = true;
            txt_mrp.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_mrp.Location = new System.Drawing.Point(105, 200);
            txt_mrp.Name = "txt_mrp";
            txt_mrp.Size = new System.Drawing.Size(59, 23);
            txt_mrp.TabIndex = 55;
            txt_mrp.Text = "MRP";
            // 
            // txtqty
            // 
            txtqty.AutoSize = true;
            txtqty.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtqty.Location = new System.Drawing.Point(308, 121);
            txtqty.Name = "txtqty";
            txtqty.Size = new System.Drawing.Size(102, 23);
            txtqty.TabIndex = 56;
            txtqty.Text = "Quantity";
            // 
            // txt_item
            // 
            txt_item.AutoSize = true;
            txt_item.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_item.Location = new System.Drawing.Point(106, 121);
            txt_item.Name = "txt_item";
            txt_item.Size = new System.Drawing.Size(58, 23);
            txt_item.TabIndex = 57;
            txt_item.Text = "Item";
            // 
            // bill_dgv
            // 
            bill_dgv.AllowUserToAddRows = false;
            bill_dgv.AllowUserToDeleteRows = false;
            bill_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bill_dgv.BackgroundColor = SystemColors.ActiveCaption;
            bill_dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bill_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bill_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bill_dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            bill_dgv.GridColor = System.Drawing.Color.IndianRed;
            bill_dgv.Location = new System.Drawing.Point(785, 131);
            bill_dgv.Name = "bill_dgv";
            bill_dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            bill_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bill_dgv.RowHeadersWidth = 51;
            bill_dgv.RowTemplate.Height = 25;
            bill_dgv.RowTemplate.ReadOnly = true;
            bill_dgv.Size = new System.Drawing.Size(471, 394);
            bill_dgv.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "sr.no.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "item";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "MRP";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Total";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // txt_bill
            // 
            txt_bill.AutoSize = true;
            txt_bill.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_bill.ForeColor = System.Drawing.Color.IndianRed;
            txt_bill.Location = new System.Drawing.Point(976, 105);
            txt_bill.Name = "txt_bill";
            txt_bill.Size = new System.Drawing.Size(46, 23);
            txt_bill.TabIndex = 67;
            txt_bill.Text = "Bill";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(390, -15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(191, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // lbl_logo
            // 
            lbl_logo.AutoSize = true;
            lbl_logo.BackColor = System.Drawing.Color.Transparent;
            lbl_logo.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logo.ForeColor = System.Drawing.Color.IndianRed;
            lbl_logo.Location = new System.Drawing.Point(587, 23);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new System.Drawing.Size(427, 57);
            lbl_logo.TabIndex = 68;
            lbl_logo.Text = "SUGGA MEGA MART ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.IndianRed;
            label9.Location = new System.Drawing.Point(78, 897);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 33);
            label9.TabIndex = 71;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(12, 882);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(69, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 70;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // item_dgv
            // 
            item_dgv.AllowUserToAddRows = false;
            item_dgv.AllowUserToDeleteRows = false;
            item_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            item_dgv.BackgroundColor = SystemColors.ActiveCaption;
            item_dgv.BorderStyle = BorderStyle.None;
            item_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            item_dgv.GridColor = System.Drawing.Color.IndianRed;
            item_dgv.Location = new System.Drawing.Point(34, 457);
            item_dgv.Name = "item_dgv";
            item_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            item_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            item_dgv.RowHeadersWidth = 51;
            item_dgv.RowTemplate.Height = 29;
            item_dgv.RowTemplate.ReadOnly = true;
            item_dgv.Size = new System.Drawing.Size(471, 394);
            item_dgv.TabIndex = 7;
            item_dgv.CellContentClick += item_dgv_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.IndianRed;
            label3.Location = new System.Drawing.Point(219, 431);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 23);
            label3.TabIndex = 67;
            label3.Text = "Item List";
            // 
            // lblttl
            // 
            lblttl.AutoSize = true;
            lblttl.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblttl.ForeColor = System.Drawing.Color.IndianRed;
            lblttl.Location = new System.Drawing.Point(985, 543);
            lblttl.Name = "lblttl";
            lblttl.Size = new System.Drawing.Size(73, 28);
            lblttl.TabIndex = 67;
            lblttl.Text = "Total";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldate.Location = new System.Drawing.Point(1127, 78);
            lbldate.Name = "lbldate";
            lbldate.Size = new System.Drawing.Size(57, 28);
            lbldate.TabIndex = 72;
            lbldate.Text = "Date";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbluser.Location = new System.Drawing.Point(64, 23);
            lbluser.Name = "lbluser";
            lbluser.Size = new System.Drawing.Size(62, 31);
            lbluser.TabIndex = 73;
            lbluser.Text = "User";
            lbluser.Click += lbluser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(45, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1295, 953);
            Controls.Add(lbluser);
            Controls.Add(lbldate);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(lbl_logo);
            Controls.Add(lblttl);
            Controls.Add(label3);
            Controls.Add(txt_bill);
            Controls.Add(item_dgv);
            Controls.Add(bill_dgv);
            Controls.Add(btn_reset);
            Controls.Add(btn_print);
            Controls.Add(btn_add);
            Controls.Add(txt_contact);
            Controls.Add(price);
            Controls.Add(mrp);
            Controls.Add(qty);
            Controls.Add(txt_name);
            Controls.Add(label6);
            Controls.Add(txt_price);
            Controls.Add(txt_mrp);
            Controls.Add(txtqty);
            Controls.Add(txt_item);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bill_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)item_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btn_reset;
        private Button btn_print;
        private Button btn_add;
        private TextBox txt_contact;
        private TextBox price;
        private TextBox mrp;
        private TextBox qty;
        private TextBox txt_name;
        private Label label6;
        private Label txt_price;
        private Label txt_mrp;
        private Label txtqty;
        private Label txt_item;
        private DataGridView bill_dgv;
        private Label txt_bill;
        private PictureBox pictureBox4;
        private Label lbl_logo;
        private Label label9;
        private PictureBox pictureBox5;
        private DataGridView item_dgv;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lblttl;
        private Label lbldate;
        private Label lbluser;
        private PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}