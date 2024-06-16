using Project_PBO.App.Context;
using System.Data;

namespace Project_PBO
{
    public partial class Faskes : Form
    {
        public Faskes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string namaKota = textBox1.Text;
            DataTable hasilPencarian = faskescontext.cariFaskes(namaKota);


            // Buat instance CariFaskes dan berikan argumen hasilPencarian
            CariFaskes cariFaskesForm = new CariFaskes(hasilPencarian);
            cariFaskesForm.Show();
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

        private void Faskes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}