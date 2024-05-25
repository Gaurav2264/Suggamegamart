namespace Project
{
    partial class Product
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ProductDGV = new DataGridView();
            label7 = new Label();
            cmbcat = new ComboBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            txtname = new TextBox();
            txtqty = new TextBox();
            txtmrp = new TextBox();
            price = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(68, 409);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 28);
            label3.TabIndex = 1;
            label3.Text = "Name";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(68, 454);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 28);
            label4.TabIndex = 1;
            label4.Text = "Quantity";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(68, 502);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 28);
            label5.TabIndex = 1;
            label5.Text = "MRP";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(67, 548);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 28);
            label6.TabIndex = 1;
            label6.Text = "Price";
            label6.Click += label1_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new System.Drawing.Point(69, 630);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(94, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new System.Drawing.Point(169, 630);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(94, 29);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new System.Drawing.Point(269, 630);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(94, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // ProductDGV
            // 
            ProductDGV.BackgroundColor = SystemColors.ActiveCaption;
            ProductDGV.BorderStyle = BorderStyle.Fixed3D;
            ProductDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.GridColor = SystemColors.ActiveCaption;
            ProductDGV.Location = new System.Drawing.Point(460, 236);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            ProductDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductDGV.RowTemplate.Height = 29;
            ProductDGV.Size = new System.Drawing.Size(1023, 525);
            ProductDGV.TabIndex = 8;
            ProductDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(67, 586);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 28);
            label7.TabIndex = 1;
            label7.Text = "Category";
            label7.Click += label1_Click;
            // 
            // cmbcat
            // 
            cmbcat.FormattingEnabled = true;
            cmbcat.Items.AddRange(new object[] { "Dairy", "HouseHold", "Kitchen", "Fruits", "Vegetables" });
            cmbcat.Location = new System.Drawing.Point(212, 586);
            cmbcat.Name = "cmbcat";
            cmbcat.Size = new System.Drawing.Size(151, 28);
            cmbcat.TabIndex = 4;
            cmbcat.Text = "SELECT CATEGORY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(69, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(272, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new Font("Segoe Script", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.IndianRed;
            label8.Location = new System.Drawing.Point(659, 126);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(417, 55);
            label8.TabIndex = 1;
            label8.Text = "SUGGA MEGA MART ";
            label8.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(769, -17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(190, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(87, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(231, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Products ";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1489, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1524, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(29, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(55, 702);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(69, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.IndianRed;
            label9.Location = new System.Drawing.Point(118, 715);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 33);
            label9.TabIndex = 22;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(24, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(58, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 48;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // txtname
            // 
            txtname.Location = new System.Drawing.Point(216, 413);
            txtname.Name = "txtname";
            txtname.Size = new System.Drawing.Size(147, 27);
            txtname.TabIndex = 0;
            // 
            // txtqty
            // 
            txtqty.Location = new System.Drawing.Point(216, 455);
            txtqty.Name = "txtqty";
            txtqty.Size = new System.Drawing.Size(147, 27);
            txtqty.TabIndex = 1;
            // 
            // txtmrp
            // 
            txtmrp.Location = new System.Drawing.Point(216, 502);
            txtmrp.Name = "txtmrp";
            txtmrp.Size = new System.Drawing.Size(147, 27);
            txtmrp.TabIndex = 2;
            // 
            // price
            // 
            price.Location = new System.Drawing.Point(216, 548);
            price.Name = "price";
            price.Size = new System.Drawing.Size(147, 27);
            price.TabIndex = 3;
            // 
            // Product
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1568, 773);
            Controls.Add(price);
            Controls.Add(txtmrp);
            Controls.Add(txtqty);
            Controls.Add(txtname);
            Controls.Add(pictureBox6);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cmbcat);
            Controls.Add(ProductDGV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox txtprice;
        private TextBox textBox5;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private DataGridView ProductDGV;
        private Label label7;
        private ComboBox cmbcat;
        private PictureBox pictureBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label9;
        private PictureBox pictureBox6;
        private TextBox txtname;
        private TextBox txtqty;
        private TextBox txtmrp;
        private TextBox price;
        //private TextBox txtprice;
    }
}