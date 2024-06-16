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
    public partial class UsUmum : Form
    {
        public UsUmum()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
            user.FormClosed += (s, args) => this.Close();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            bmi.Show();
            this.Hide();
            bmi.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Faskes faskes = new Faskes();
            faskes.Show();
            this.Hide();
            faskes.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mens mens = new Mens();
            mens.Show();
            this.Hide();
            mens.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Kalori kalori = new Kalori();
            kalori.Show();
            this.Hide();
            kalori.FormClosed += (s, args) => this.Close();
        }
    }
}
