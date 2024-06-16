namespace Project_PBO
{
    partial class Kalori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalori));
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            button4 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            TambahButton = new Button();
            label5 = new Label();
            label6 = new Label();
            ListMakanan = new ComboBox();
            ArrayMakanan = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ArrayMakanan).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(599, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 100);
            panel2.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(12, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(57, 472);
            panel3.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(665, 77);
            label4.Name = "label4";
            label4.Size = new Size(237, 64);
            label4.TabIndex = 60;
            label4.Text = "Fungsi Menghitung\r\nKalori ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 77);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 59;
            label3.Text = "Menghitung Kalori";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(283, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(2, 469);
            panel5.TabIndex = 58;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(639, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 469);
            panel4.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(341, 261);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 56;
            label2.Text = "Berat Makanan (g)*";
            // 
            // button4
            // 
            button4.BackColor = Color.DeepPink;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(311, 335);
            button4.Name = "button4";
            button4.Size = new Size(123, 27);
            button4.TabIndex = 55;
            button4.Text = "JUMLAH KALORI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 201);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 54;
            label1.Text = "Masukkan Makanan";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 53;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(720, 471);
            button3.Name = "button3";
            button3.Size = new Size(114, 27);
            button3.TabIndex = 50;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(813, 15);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 49;
            button2.Text = "PROFIL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 2);
            panel1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SEHAT_IN_LOGO;
            pictureBox1.Location = new Point(-40, -73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(720, 15);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 46;
            button1.Text = "ARTIKEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7_1;
            pictureBox2.Location = new Point(353, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // TambahButton
            // 
            TambahButton.BackColor = Color.DodgerBlue;
            TambahButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TambahButton.ForeColor = Color.White;
            TambahButton.Location = new Point(470, 335);
            TambahButton.Name = "TambahButton";
            TambahButton.Size = new Size(147, 27);
            TambahButton.TabIndex = 61;
            TambahButton.Text = "TAMBAH MAKANAN";
            TambahButton.UseVisualStyleBackColor = false;
            TambahButton.Click += TambahButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 135);
            label5.Name = "label5";
            label5.Size = new Size(187, 135);
            label5.TabIndex = 62;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(665, 141);
            label6.Name = "label6";
            label6.Size = new Size(219, 315);
            label6.TabIndex = 63;
            label6.Text = resources.GetString("label6.Text");
            // 
            // ListMakanan
            // 
            ListMakanan.FormattingEnabled = true;
            ListMakanan.Location = new Point(341, 223);
            ListMakanan.Margin = new Padding(3, 2, 3, 2);
            ListMakanan.Name = "ListMakanan";
            ListMakanan.Size = new Size(243, 23);
            ListMakanan.TabIndex = 64;
            // 
            // ArrayMakanan
            // 
            ArrayMakanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArrayMakanan.Location = new Point(312, 376);
            ArrayMakanan.Margin = new Padding(3, 2, 3, 2);
            ArrayMakanan.Name = "ArrayMakanan";
            ArrayMakanan.RowHeadersWidth = 51;
            ArrayMakanan.Size = new Size(305, 122);
            ArrayMakanan.TabIndex = 65;
            // 
            // Kalori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(ArrayMakanan);
            Controls.Add(ListMakanan);
            Controls.Add(label5);
            Controls.Add(TambahButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Name = "Kalori";
            Text = "Kalori";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ArrayMakanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
        private Button button4;
        private Label label1;
        private TextBox textBox2;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button TambahButton;
        private Label label5;
        private Label label6;
        private ComboBox ListMakanan;
        private DataGridView ArrayMakanan;
    }
}