using Project_PBO.App.Models;
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
    public partial class Editdtdr : Form
    {
        private string email;
        public Editdtdr()
        {
            //mengambil email user yang login
            InitializeComponent();
            email = Login.UserEmail;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


            //update data user dan menampilkan pesn berhasil dan convert tipe data no telfon menjadi numeric dan masukkan ke database4
            string nama = textBox1.Text;
            long no_telfon = Convert.ToInt64(textBox2.Text);
            string alamat = textBox3.Text;

            App.Context.datadiricontext.editdatadiri(email, nama, no_telfon, alamat);








            Datadiri data = new Datadiri();
            data.Show();
            this.Hide();
            data.FormClosed += (s, args) => this.Close();







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nama baru
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //no telp baru
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //alamat baru
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsKritik kritik = new UsKritik();
            kritik.Show();
        }
    }
}