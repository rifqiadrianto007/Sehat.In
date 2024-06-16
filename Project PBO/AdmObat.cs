using Project_PBO.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class AdmObat : Form
    {
        private string email;
        public AdmObat()
        {
            InitializeComponent();
            DataTable penyakit = PenyakitContext.getAllPenyakit();
            listpenyakit.DataSource = penyakit;
            listpenyakit.DisplayMember = "nama_penyakit";
            listpenyakit.ValueMember = "id_penyakit";
            this.Load += new EventHandler(AdmObat_Load);
            email = Login.UserEmail;

            DataTable jenisobat = obatcontext.getJenis();
            cbjenisobat.DataSource = jenisobat;
            cbjenisobat.DisplayMember = "jenis";
            cbjenisobat.ValueMember = "id_jenis";
        }
        private void AdmObat_Load(object sender, EventArgs e)

        {
            LoadData();
            SetButtonColors(button4);
        }

        // Load data
        private void LoadData()
        {

            //menampilkan nama admin
            DataTable dt = datadiricontext.getdatadirinama(email);
            if (dt != null && dt.Rows.Count > 0)
            {
                string nama = dt.Rows[0]["nama"].ToString();
                namaadminubat.Text = nama;

                Console.WriteLine("Nama data loaded successfully.");
            }
            else
            {
                Console.WriteLine(dt == null ? "DataTable dt is null." : "No data found for datadirinama.");
            }

            //menampilkan data obat dari obatcontext
            try
            {
                obatcontext obatcontext = new obatcontext();
                DataTable obatData = obatcontext.getAll();

                if (obatData != null)
                {
                    dataGridView1.DataSource = obatData;
                    dataGridView1.Columns[0].HeaderText = "Nama Obat";
                    dataGridView1.Columns[1].HeaderText = "Fungsi";
                    dataGridView1.Columns[2].HeaderText = "Dosis";
                    dataGridView1.Columns[3].HeaderText = "Penyakit";
                    dataGridView1.Columns[4].HeaderText = "Jenis";
                }
                else
                {
                    MessageBox.Show("No data retrieved from the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void SetButtonColors(Button activeButton)
        {
            Color defaultColor = ColorTranslator.FromHtml("#F5F6F8");
            Color activeColor = ColorTranslator.FromHtml("#E13D65");

            // Loop melalui semua kontrol di form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Mengatur warna untuk setiap button
                    if (btn == activeButton)
                    {
                        btn.BackColor = activeColor;
                    }
                    else
                    {
                        btn.BackColor = defaultColor;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmArtikel artikel = new AdmArtikel();
            artikel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdmFaskes admfaskes = new AdmFaskes();
            admfaskes.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdmKritik admkritik = new AdmKritik();
            admkritik.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listpenyakit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //menambahkan data id penyakit
            listpenyakit.DisplayMember = "nama_penyakit";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //menambahkan data nama obat
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //menambah data
            try
            {
                string nama_obat = textBox1.Text;
                string fungsi = textBox5.Text;
                string dosis = textBox3.Text;
                int penyakit = Convert.ToInt32(listpenyakit.SelectedValue);
                int jenis = Convert.ToInt32(cbjenisobat.SelectedValue);

                obatcontext obatcontext = new obatcontext();
                obatcontext.insert(nama_obat, fungsi, dosis, penyakit, jenis);
                MessageBox.Show("Data berhasil ditambahkan");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding data: {ex.Message}");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //kategori dosis
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //kategori jenis
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //kategori fungsi
        }

        private void namaadminubat_Click(object sender, EventArgs e)
        {

        }
    }
}
