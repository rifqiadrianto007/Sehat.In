using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_PBO.App.Context;

namespace Project_PBO
{
    public partial class CariFaskes : Form
    {
        // Menambahkan properti untuk menyimpan hasil pencarian
        private DataTable hasilPencarian;

        public CariFaskes(DataTable hasilPencarian)
        {
            InitializeComponent();

            // Inisialisasi hasil pencarian dengan nilai yang diberikan
            this.hasilPencarian = hasilPencarian;

            // Panggil metode untuk menampilkan hasil pencarian
            TampilkanHasilPencarian();
        }

        // Metode untuk menampilkan hasil pencarian di dataGridView1
        private void TampilkanHasilPencarian()
        {
            // Bind hasil pencarian ke dataGridView1
            dataGridView1.DataSource = hasilPencarian;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tidak perlu diubah
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Faskes faskes = new Faskes();
            faskes.Show();
            this.Hide();
            faskes.FormClosed += (s, args) => this.Close();
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
    }
}