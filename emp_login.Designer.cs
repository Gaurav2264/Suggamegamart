namespace Project
{
    partial class emp_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            pass = new TextBox();
            btnlogin = new Button();
            label2 = new Label();
            uname = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(398, 547);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(75, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(218, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(39, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(320, 41);
            label1.TabIndex = 1;
            label1.Text = "Welcome To your POS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.HotPink;
            label4.Location = new System.Drawing.Point(508, 518);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(433, 20);
            label4.TabIndex = 4;
            label4.Text = "©️ All Rights Reserved.Managed and maintained by Gaurav 2023";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(966, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1001, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(29, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pass);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(uname);
            groupBox1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(518, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(382, 319);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee  Login ";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(89, 274);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(211, 39);
            button1.TabIndex = 3;
            button1.Text = "ADMIN Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(74, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 30);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // pass
            // 
            pass.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new System.Drawing.Point(74, 161);
            pass.Name = "pass";
            pass.Size = new System.Drawing.Size(251, 29);
            pass.TabIndex = 1;
            pass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = System.Drawing.Color.DodgerBlue;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.Location = new System.Drawing.Point(147, 208);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new System.Drawing.Size(109, 39);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Login ";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(74, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 30);
            label2.TabIndex = 6;
            label2.Text = "Username ";
            // 
            // uname
            // 
            uname.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            uname.Location = new System.Drawing.Point(74, 83);
            uname.Name = "uname";
            uname.Size = new System.Drawing.Size(251, 29);
            uname.TabIndex = 0;
            // 
            // emp_login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.IndianRed;
            ClientSize = new System.Drawing.Size(1048, 547);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "emp_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "emp_login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox pass;
        private Button btnlogin;
        private Label label2;
        private TextBox uname;
        private Button button1;
    }
}