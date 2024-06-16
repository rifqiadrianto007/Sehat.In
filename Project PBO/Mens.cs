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
    public partial class Mens : Form
    {
        public Mens()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsUmum umum = new UsUmum();
            umum.Show();
            this.Hide();
            umum.FormClosed += (s, args) => this.Close();
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
            DateTime tanggalan = monthCalendar1.SelectionStart;
            KalenderMens mens = new KalenderMens(tanggalan);
            mens.Show();
            this.Hide();
            mens.FormClosed += (s, args) => this.Close();
        }

        private void Mens_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
