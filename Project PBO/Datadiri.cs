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
    public partial class Datadiri : Form
    {
        private string email;
       

        public Datadiri()
        {
            InitializeComponent();
            email = Login.UserEmail;
            LoadUserData();
            



        }
        private void LoadUserData()
        {
            try
            {
                // Mengambil nama dan ditampilkan di Label
                DataTable dt = App.Context.datadiricontext.getdatadirinama(email);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string nama = dt.Rows[0]["nama"].ToString();
                    labelNama.Text = nama;
                    Console.WriteLine("Nama data loaded successfully.");
                }
                else
                {
                    Console.WriteLine(dt == null ? "DataTable dt is null." : "No data found for datadirinama.");
                }

                // Mengambil no telepon dan ditampilkan di Label
                DataTable dt2 = App.Context.datadiricontext.getdatadirinotelp(email);
                if (dt2 != null && dt2.Rows.Count > 0)
                {
                    string noTelepon = dt2.Rows[0]["no_telfon"].ToString();
                    labelNoHp.Text = noTelepon;
                    Console.WriteLine("No telepon data loaded successfully.");
                }
                else
                {
                    Console.WriteLine(dt2 == null ? "DataTable dt2 is null." : "No data found for datadirinotelp.");
                }

                // Mengambil alamat dan ditampilkan di Label
                DataTable dt3 = App.Context.datadiricontext.getdatadirialamat(email);
                if (dt3 != null && dt3.Rows.Count > 0)
                {
                    string alamat = dt3.Rows[0]["alamat"].ToString();
                    labelalamat.Text = alamat;
                    Console.WriteLine("Alamat data loaded successfully.");
                }
                else
                {
                    Console.WriteLine(dt3 == null ? "DataTable dt3 is null." : "No data found for datadirialamat.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading user data: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            Editdtdr edit = new Editdtdr();
            edit.Show();
            this.Hide();
            edit.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //kritik
            UsKritik kritik = new UsKritik();
            kritik.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nama
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //no hp
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //alamat
        }

        private void Datadiri_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
