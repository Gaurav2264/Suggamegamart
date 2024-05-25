namespace Project
{
    partial class admin_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_dashboard));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            salesdgv = new DataGridView();
            bttonexport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesdgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(296, 672);
            panel1.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(54, 601);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(69, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 44;
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
            label9.Location = new System.Drawing.Point(116, 613);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 33);
            label9.TabIndex = 46;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new System.Drawing.Point(0, 405);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(296, 49);
            button2.TabIndex = 20;
            button2.Text = "Manage Products ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.BorderColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new System.Drawing.Point(0, 294);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(296, 49);
            button1.TabIndex = 20;
            button1.Text = "Employee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-13, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(306, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1468, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1503, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(29, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.IndianRed;
            label8.Location = new System.Drawing.Point(601, 36);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(555, 73);
            label8.TabIndex = 39;
            label8.Text = "SUGGA MEGA MART ";
            // 
            // salesdgv
            // 
            salesdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesdgv.BackgroundColor = SystemColors.ActiveCaption;
            salesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesdgv.GridColor = SystemColors.ActiveCaption;
            salesdgv.Location = new System.Drawing.Point(484, 154);
            salesdgv.Name = "salesdgv";
            salesdgv.RowHeadersWidth = 51;
            salesdgv.RowTemplate.Height = 29;
            salesdgv.Size = new System.Drawing.Size(789, 401);
            salesdgv.TabIndex = 40;
            // 
            // bttonexport
            // 
            bttonexport.BackColor = System.Drawing.Color.IndianRed;
            bttonexport.Location = new System.Drawing.Point(854, 577);
            bttonexport.Name = "bttonexport";
            bttonexport.Size = new System.Drawing.Size(189, 40);
            bttonexport.TabIndex = 41;
            bttonexport.Text = "Genrate Sales Report";
            bttonexport.UseVisualStyleBackColor = false;
            bttonexport.Click += bttonexport_Click;
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1550, 672);
            Controls.Add(bttonexport);
            Controls.Add(salesdgv);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_dashboard";
            Load += admin_dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label9;
        private PictureBox pictureBox5;
        private Label label8;
        private DataGridView salesdgv;
        private Button bttonexport;
    }
}