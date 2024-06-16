using Project_PBO.App.dtos.responses;
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
    public partial class HitungKalori : Form
    {
        private double hasilKalori;
        private List<Kalori.TambahKaloriResponse> arrayMakanan;
        private DataGridView dataGridView;


        public HitungKalori()
        {
            InitializeComponent();
        }

        public void SetData(List<Kalori.TambahKaloriResponse> makananList)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = makananList;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Nama Makanan";
                dataGridView1.Columns[1].HeaderText = "Berat";
                dataGridView1.Columns[2].HeaderText = "Kandungan Kalori";
            }

            UpdateTotalKalori(makananList);

        }

        private void UpdateTotalKalori(List<Kalori.TambahKaloriResponse> makananList)
        {
            if (makananList != null)
            {
                double totalKalori = 0;
                foreach (var makanan in makananList)
                {
                    totalKalori += makanan.kandungan;
                }
                lblTotalKalori.Text = "Total Kalori Anda : " + totalKalori.ToString();

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
            Kalori kalori = new Kalori();
            kalori.Show();
            this.Hide();
            kalori.FormClosed += (s, args) => this.Close();
        }
    }
}
