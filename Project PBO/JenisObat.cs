using Project_PBO.App.Context;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class JenisObat : Form
    {
        private string _filterCondition;

        public JenisObat(string filterCondition)
        {
            InitializeComponent();
            _filterCondition = filterCondition;
            this.Load += new EventHandler(Admin_Load);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData(_filterCondition); // Muat data dengan filter
        }

        private void LoadData(string filterCondition)
        {
            try
            {
                // Menampilkan data dari database ke DataGridView
                DataTable obat = obatContext.All(filterCondition);
                if (obat != null && obat.Rows.Count > 0)
                {
                    dataGridView1.DataSource = obat;

                    // Mengatur header kolom sesuai dengan kebutuhan
                    dataGridView1.Columns[0].HeaderText = "Nama Obat"; // NamaObat
                    dataGridView1.Columns[1].HeaderText = "Fungsi";    // Fungsi
                    dataGridView1.Columns[2].HeaderText = "Dosis";     // Dosis
                    dataGridView1.Columns[3].HeaderText = "Jenis Obat"; // NamaJenisObat

                    // Menyesuaikan kolom agar mengisi lebar DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang diambil dari database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
            artikel.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsProfil profil = new UsProfil();
            profil.Show();
            this.Hide();
            profil.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaranObat saran = new SaranObat();
            saran.Show();
            this.Hide();
            saran.FormClosed += (s, args) => this.Close();
        }

        private void JenisObat_Load(object sender, EventArgs e)
        {
        }
    }
}
