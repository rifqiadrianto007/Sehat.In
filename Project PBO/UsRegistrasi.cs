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
using Project_PBO.App.Core;


namespace Project_PBO
{
    public partial class UsRegistrasi : Form
    {

        public UsRegistrasi()
        {
            InitializeComponent();
        }


        private void nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void nohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void kota_TextChanged(object sender, EventArgs e)
        {

        }

        private void negara_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = nama.Text;
            string Pass = password.Text;
            string Email = email.Text;
            string Alamat = alamat.Text;
            string Kota = kota.Text;
            string Negara = negara.Text;
            string NoTelfonStr = nohp.Text;

            // Check if all fields are not empty
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Pass) && !string.IsNullOrEmpty(Email)
                && !string.IsNullOrEmpty(Alamat) && !string.IsNullOrEmpty(Kota) && !string.IsNullOrEmpty(Negara) && !string.IsNullOrEmpty(NoTelfonStr))
            {
                // Convert nomor telepon ke tipe long
                if (long.TryParse(NoTelfonStr, out long noTelfon))
                {
                    ProfilContext.InsertProfil(Username, Email, Pass, Alamat, Kota, Negara, noTelfon);

                    MessageBox.Show("Pendaftaran berhasil. Silakan login menggunakan informasi yang baru didaftarkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login newForm = new Login();
                    newForm.Show();
                    this.Hide();
                    newForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Nomor telepon harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap isi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

