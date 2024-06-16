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
    public partial class AdmKritik : Form
    {
        private string email;
        public AdmKritik()
        {
            InitializeComponent();
            this.Load += new EventHandler(Admin_Load);
            email = Login.UserEmail;

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonColors(button5);
        }

        private void LoadData()
        {
            DataTable dt = datadiricontext.getdatadirinama(email);
            if (dt != null && dt.Rows.Count > 0)
            {
                string nama = dt.Rows[0]["nama"].ToString();
                namaadminkritik.Text = nama;
                Console.WriteLine("Nama data loaded successfully.");
            }
            else
            {
                Console.WriteLine(dt == null ? "DataTable dt is null." : "No data found for datadirinama.");
            }
            try
            {
                // Menampilkan data dari database ke DataGridView
                DataTable keluhan = kritikSaranContext.all();
                if (keluhan != null && keluhan.Rows.Count > 0)
                {
                    dataGridView1.DataSource = keluhan;

                    // Mengatur header kolom sesuai dengan kebutuhan
                    dataGridView1.Columns[0].HeaderText = "No"; // Nomor urut
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].HeaderText = "kritik";
                    dataGridView1.Columns[3].HeaderText = "saran";
                    dataGridView1.Columns[4].HeaderText = "Nama";

                    // Menyesuaikan kolom agar mengisi lebar DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void button4_Click(object sender, EventArgs e)
        {
            AdmObat admobat = new AdmObat();
            admobat.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void namaadminkritik_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
