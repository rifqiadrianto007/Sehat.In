namespace Project_PBO
{
    partial class UsRegistrasi
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
            nama = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            email = new TextBox();
            password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            negara = new TextBox();
            kota = new TextBox();
            alamat = new TextBox();
            label7 = new Label();
            label8 = new Label();
            nohp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // nama
            // 
            nama.Location = new Point(517, 265);
            nama.Name = "nama";
            nama.Size = new Size(217, 27);
            nama.TabIndex = 19;
            nama.TextChanged += nama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(517, 240);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 18;
            label2.Text = "Nama Lengkap";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(841, 532);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 47);
            button1.TabIndex = 17;
            button1.Text = "Selesai";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(679, 91);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 54);
            label1.TabIndex = 16;
            label1.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_1135;
            pictureBox1.Location = new Point(-2, -28);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 848);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox3.Location = new Point(841, -85);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(242, 253);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // email
            // 
            email.Location = new Point(517, 353);
            email.Name = "email";
            email.Size = new Size(217, 27);
            email.TabIndex = 22;
            email.TextChanged += email_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(517, 440);
            password.Name = "password";
            password.Size = new Size(217, 27);
            password.TabIndex = 23;
            password.TextChanged += password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(517, 415);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 24;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(517, 328);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 25;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(787, 328);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 31;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(787, 415);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 30;
            label6.Text = "Negara";
            // 
            // negara
            // 
            negara.Location = new Point(787, 440);
            negara.Name = "negara";
            negara.Size = new Size(217, 27);
            negara.TabIndex = 29;
            negara.TextChanged += negara_TextChanged;
            // 
            // kota
            // 
            kota.Location = new Point(787, 353);
            kota.Name = "kota";
            kota.Size = new Size(217, 27);
            kota.TabIndex = 28;
            kota.TextChanged += kota_TextChanged;
            // 
            // alamat
            // 
            alamat.Location = new Point(787, 265);
            alamat.Name = "alamat";
            alamat.Size = new Size(217, 27);
            alamat.TabIndex = 27;
            alamat.TextChanged += alamat_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(787, 240);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 26;
            label7.Text = "Alamat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(517, 507);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 33;
            label8.Text = "No. HP";
            // 
            // nohp
            // 
            nohp.Location = new Point(517, 532);
            nohp.Name = "nohp";
            nohp.Size = new Size(217, 27);
            nohp.TabIndex = 32;
            nohp.TextChanged += nohp_TextChanged;
            // 
            // UsRegistrasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 680);
            Controls.Add(label8);
            Controls.Add(nohp);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(negara);
            Controls.Add(kota);
            Controls.Add(alamat);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(nama);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsRegistrasi";
            Text = "UsRegistrasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nama;
        private Label label2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox email;
        private TextBox password;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox negara;
        private TextBox kota;
        private TextBox alamat;
        private Label label7;
        private Label label8;
        private TextBox nohp;
    }
}