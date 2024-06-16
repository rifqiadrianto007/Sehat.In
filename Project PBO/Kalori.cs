using Project_PBO.App.Context;
using Project_PBO.App.dtos.responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class Kalori : Form
    {
        public class TambahKaloriResponse
        {
            public string nama_makanan { get; set; }
            public int berat { get; set; }
            public int kandungan { get; set; }
        }
        public List<TambahKaloriResponse> arrayMakanan;

        public Kalori()
        {
            InitializeComponent();
            DataTable makanan = KaloriContext.getAllMakanan();
            ListMakanan.DataSource = makanan;
            ListMakanan.DisplayMember = "nama_makanan";
            ListMakanan.ValueMember = "nama_makanan";
            arrayMakanan = new List<TambahKaloriResponse>();
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
            UsUmum umum = new UsUmum();
            umum.Show();
            this.Hide();
            umum.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        /*    string namaMakanan = ListMakanan.Text;
            int beratMakanan = Int32.Parse(textBox2.Text);
            int hasilKalori = (int)KaloriContext.countKalori(namaMakanan, beratMakanan);*/
            HitungKalori hitung = new HitungKalori();
            hitung.SetData(arrayMakanan);
            hitung.Show();
            this.Hide();
            hitung.FormClosed += (s, args) => this.Close();
        }

        private void TambahButton_Click(object sender, EventArgs e)
        {
            string namaMakanan = ListMakanan.Text;
            int beratMakanan = Int32.Parse(textBox2.Text);
            double kalori = KaloriContext.countKalori(namaMakanan, beratMakanan);

            if (Int32.TryParse(textBox2.Text, out beratMakanan))
            {
                TambahKaloriResponse tambahKaloriResponse = new TambahKaloriResponse
                {
                    nama_makanan = namaMakanan,
                    berat = beratMakanan,
                    kandungan = (int)kalori
                };

                arrayMakanan.Add(tambahKaloriResponse);

                ArrayMakanan.DataSource = null;
                ArrayMakanan.DataSource = arrayMakanan;
            }
            else
            {
                MessageBox.Show("Masukkan berat makanan yang valid.");
            }

            // Membersihkan input
            textBox2.Text = "";
            ListMakanan.Text = "";
        }
    }
}
