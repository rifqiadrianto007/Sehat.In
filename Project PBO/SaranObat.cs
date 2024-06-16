using System;
using System.Data;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class SaranObat : Form
    {
        public SaranObat()
        {
            InitializeComponent();
        }

        private void SaranObat_Load(object sender, EventArgs e)
        {
            // Panggil method untuk mengisi ComboBox saat form dimuat
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {
                // Query SQL untuk mengambil data dari tabel penyakit
                string query = "SELECT nama_penyakit FROM penyakit";

                // Eksekusi query dan dapatkan data dari database
                DataTable dataTable = Project_PBO.App.Core.dataconn.queryExecutor(query);

                // Tambahkan data ke dalam ComboBox
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBox1.Items.Add(row["nama_penyakit"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Farmasi farmasi = new Farmasi();
            farmasi.Show();
            this.Hide();
            farmasi.FormClosed += (s, args) => this.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Mendapatkan data yang dipilih dari ComboBox
            string selectedData = comboBox1.SelectedItem?.ToString();

            // Memeriksa apakah pengguna telah memilih data sebelum melanjutkan
            if (!string.IsNullOrEmpty(selectedData))
            {
                try
                {
                    // Query SQL untuk mencari ID penyakit berdasarkan nama penyakit yang dipilih
                    string idQuery = $"SELECT id_penyakit FROM penyakit WHERE nama_penyakit = '{selectedData}'";

                    // Eksekusi query untuk mendapatkan ID penyakit
                    int idPenyakit = Convert.ToInt32(Project_PBO.App.Core.dataconn.queryExecutor(idQuery).Rows[0]["id_penyakit"]);

                    // Kondisi filter untuk JenisObat
                    string filterCondition = $"o.id_penyakit = {idPenyakit}";

                    // Membuka form JenisObat dengan filter yang dipilih
                    JenisObat jenis = new JenisObat(filterCondition);
                    jenis.Show();
                    this.Hide();
                    jenis.FormClosed += (s, args) => this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data terlebih dahulu!", "Peringatan");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mendapatkan data yang dipilih dari ComboBox
            string selectedData = comboBox1.SelectedItem?.ToString();

            // Memeriksa apakah pengguna telah memilih data
            if (!string.IsNullOrEmpty(selectedData))
            {
                // Tampilkan pesan atau detail tentang penyakit yang dipilih
                MessageBox.Show($"Anda telah memilih: {selectedData}", "Informasi Penyakit");
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // Mendapatkan data yang dipilih dari ComboBox
            string selectedData = comboBox1.SelectedItem?.ToString();

            // Memeriksa apakah pengguna telah memilih data sebelum melanjutkan
            if (!string.IsNullOrEmpty(selectedData))
            {
                // Kondisi filter untuk JenisObat
                string filterCondition = $"jo.jenis = '{selectedData}'"; // Contoh kondisi filter

                // Menampilkan form JenisObat dengan filter yang dipilih
                JenisObat jenisObatForm = new JenisObat(filterCondition);
                jenisObatForm.Show();
                this.Hide();
                jenisObatForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Silakan pilih data terlebih dahulu!", "Peringatan");
            }
        }
    }
}
