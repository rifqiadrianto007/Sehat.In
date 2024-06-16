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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_PBO
{

    public partial class AdmFaskes : Form
    {
        private string email;
        public AdmFaskes()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdmFaskes_Load);
            email = Login.UserEmail;

        }
        private void AdmFaskes_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonColors(button3);
        }


        private void LoadData()
        {
            try
            {
                //menampilkan data dari database ke datagridview
                DataTable faskes = faskescontext.GetAllFaskes();
                if (faskes != null)
                {
                    dataGridView1.DataSource = faskes;
                    dataGridView1.Columns[0].HeaderText = "Action";
                    dataGridView1.Columns[1].HeaderText = "id_faskes";
                    dataGridView1.Columns[2].HeaderText = "nama_faskes";
                    dataGridView1.Columns[3].HeaderText = "alamat";
                    dataGridView1.Columns[4].HeaderText = "kota";
                    dataGridView1.Columns[5].HeaderText = "no_telfon";
                    dataGridView1.Columns[6].HeaderText = "website";
                    dataGridView1.Columns[7].HeaderText = "jam operasional";
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
            //nama admin
            DataTable dt = datadiricontext.getdatadirinama(email);
            if (dt != null && dt.Rows.Count > 0)
            {
                string nama = dt.Rows[0]["nama"].ToString();
                namaadminfaskes.Text = nama;
                Console.WriteLine("Nama data loaded successfully.");
            }
            else
            {
                Console.WriteLine(dt == null ? "DataTable dt is null." : "No data found for datadirinama.");
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

        private void button6_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdmObat admobat = new AdmObat();
            admobat.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AdmKritik admkritik = new AdmKritik();
            admkritik.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int idfaskes = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_faskes"].Value.ToString());

                    DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        faskescontext.delete(idfaskes);
                        MessageBox.Show("Data berhasil dihapus");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string nama = tbnama.Text;
            string alamat = tbalamat.Text;
            string kota = tbkota.Text;
            int nohp = int.Parse(tbnohp.Text);
            string website = tbwebsite.Text;
            string jamoper = tbjamoper.Text;

            if (string.IsNullOrWhiteSpace(tbnama.Text) || string.IsNullOrWhiteSpace(tbalamat.Text))
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;
            }

            try
            {
                // insert database
                faskescontext.insert(nama, alamat, kota, nohp, website, jamoper);
                MessageBox.Show("Data berhasil ditambahkan");

                // Refresh the DataGridView after inserting data
                LoadData();

                // Clear text boxes after insertion
                tbnama.Clear();
                tbalamat.Clear();
                tbjamoper.Clear();
                tbnohp.Clear();
                tbwebsite.Clear();
                tbkota.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting data: {ex.Message}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
