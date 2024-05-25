namespace Project
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_address = new TextBox();
            txt_contact = new TextBox();
            txt_password = new TextBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            emp_dgv = new DataGridView();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            lbl_logo = new Label();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)emp_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(380, 158);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 23);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(584, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 23);
            label3.TabIndex = 0;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(757, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 23);
            label4.TabIndex = 0;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(962, 158);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 23);
            label5.TabIndex = 0;
            label5.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(1146, 158);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 23);
            label6.TabIndex = 0;
            label6.Text = "Password";
            // 
            // txt_name
            // 
            txt_name.Location = new System.Drawing.Point(342, 181);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(154, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_age
            // 
            txt_age.Location = new System.Drawing.Point(538, 181);
            txt_age.Name = "txt_age";
            txt_age.Size = new System.Drawing.Size(145, 27);
            txt_age.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Location = new System.Drawing.Point(736, 181);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(148, 27);
            txt_address.TabIndex = 1;
            // 
            // txt_contact
            // 
            txt_contact.Location = new System.Drawing.Point(934, 181);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new System.Drawing.Size(157, 27);
            txt_contact.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new System.Drawing.Point(1133, 181);
            txt_password.Name = "txt_password";
            txt_password.Size = new System.Drawing.Size(138, 27);
            txt_password.TabIndex = 1;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaption;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.InfoText;
            btn_add.Location = new System.Drawing.Point(564, 267);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(106, 46);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.ActiveCaption;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Location = new System.Drawing.Point(773, 267);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(98, 46);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += button2_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveCaption;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new System.Drawing.Point(963, 267);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(104, 46);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // emp_dgv
            // 
            emp_dgv.AllowUserToAddRows = false;
            emp_dgv.AllowUserToDeleteRows = false;
            emp_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            emp_dgv.BackgroundColor = SystemColors.ActiveCaption;
            emp_dgv.BorderStyle = BorderStyle.None;
            emp_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emp_dgv.GridColor = System.Drawing.Color.IndianRed;
            emp_dgv.Location = new System.Drawing.Point(380, 334);
            emp_dgv.Name = "emp_dgv";
            emp_dgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            emp_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            emp_dgv.RowHeadersWidth = 51;
            emp_dgv.RowTemplate.Height = 29;
            emp_dgv.RowTemplate.ReadOnly = true;
            emp_dgv.Size = new System.Drawing.Size(857, 282);
            emp_dgv.TabIndex = 5;
            emp_dgv.CellContentClick += emp_dgv_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.IndianRed;
            label9.Location = new System.Drawing.Point(107, 614);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 33);
            label9.TabIndex = 48;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(41, 599);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(69, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1473, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1508, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(29, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(41, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(236, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(24, 199);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(278, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Employee ";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(359, -5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(236, 151);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // lbl_logo
            // 
            lbl_logo.AutoSize = true;
            lbl_logo.BackColor = System.Drawing.Color.Transparent;
            lbl_logo.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logo.ForeColor = System.Drawing.Color.IndianRed;
            lbl_logo.Location = new System.Drawing.Point(584, 47);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new System.Drawing.Size(427, 57);
            lbl_logo.TabIndex = 48;
            lbl_logo.Text = "SUGGA MEGA MART ";
            lbl_logo.Click += label9_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(24, 22);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(58, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // employee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1550, 672);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_logo);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(emp_dgv);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txt_password);
            Controls.Add(txt_contact);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employee";
            Load += employee_Load;
            ((System.ComponentModel.ISupportInitialize)emp_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_address;
        private TextBox txt_contact;
        private TextBox txt_password;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private DataGridView emp_dgv;
        private Label label9;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private Label lbl_logo;
        private PictureBox pictureBox6;
    }
}