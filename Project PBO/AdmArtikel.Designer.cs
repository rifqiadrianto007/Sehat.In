namespace Project_PBO
{
    partial class AdmArtikel
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
            dataGridView1 = new DataGridView();
            HapusArtikel = new DataGridViewButtonColumn();
            label2 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            namaadminartikel = new Label();
            label4 = new Label();
            listpenyakit = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HapusArtikel });
            dataGridView1.Location = new Point(252, 41);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(650, 125);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // HapusArtikel
            // 
            HapusArtikel.HeaderText = "Action";
            HapusArtikel.MinimumWidth = 6;
            HapusArtikel.Name = "HapusArtikel";
            HapusArtikel.Text = "Hapus";
            HapusArtikel.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 19;
            label2.Text = "Daftar Artikel";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 450);
            button6.Name = "button6";
            button6.Size = new Size(209, 32);
            button6.TabIndex = 16;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 370);
            button5.Name = "button5";
            button5.Size = new Size(209, 28);
            button5.TabIndex = 15;
            button5.Text = "Kritik Saran";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 326);
            button4.Name = "button4";
            button4.Size = new Size(209, 28);
            button4.TabIndex = 14;
            button4.Text = "Obat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 283);
            button3.Name = "button3";
            button3.Size = new Size(209, 28);
            button3.TabIndex = 13;
            button3.Text = "Faskes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 240);
            button2.Name = "button2";
            button2.Size = new Size(209, 28);
            button2.TabIndex = 12;
            button2.Text = "Artikel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 193);
            button1.Name = "button1";
            button1.Size = new Size(209, 27);
            button1.TabIndex = 11;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(252, 270);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 45;
            label8.Text = "Sumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(252, 220);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 42;
            label6.Text = "Judul";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 287);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 23);
            textBox2.TabIndex = 41;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 237);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 23);
            textBox1.TabIndex = 40;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 178);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 39;
            label3.Text = "Tambah Artikel";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(339, 450);
            button7.Name = "button7";
            button7.Size = new Size(146, 32);
            button7.TabIndex = 47;
            button7.Text = "Upload";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_237472;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // namaadminartikel
            // 
            namaadminartikel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namaadminartikel.Location = new Point(24, 123);
            namaadminartikel.Name = "namaadminartikel";
            namaadminartikel.Size = new Size(188, 52);
            namaadminartikel.TabIndex = 49;
            namaadminartikel.Text = "-------nama admin-------";
            namaadminartikel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(252, 325);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 50;
            label4.Text = "Penyakit";
            // 
            // listpenyakit
            // 
            listpenyakit.FormattingEnabled = true;
            listpenyakit.Location = new Point(252, 343);
            listpenyakit.Margin = new Padding(3, 2, 3, 2);
            listpenyakit.Name = "listpenyakit";
            listpenyakit.Size = new Size(308, 23);
            listpenyakit.TabIndex = 51;
            listpenyakit.SelectedIndexChanged += listpenyakit_SelectedIndexChanged;
            // 
            // AdmArtikel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(listpenyakit);
            Controls.Add(label4);
            Controls.Add(namaadminartikel);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "AdmArtikel";
            Text = "AdmArtikel";
            Load += AdmArtikel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;

        private Label label2;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button button7;
        private DataGridViewButtonColumn HapusArtikel;
        private Label namaadminartikel;
        private Label label4;
        private ComboBox listpenyakit;
    }
}