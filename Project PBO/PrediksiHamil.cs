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
    public partial class PrediksiHamil : Form
    {
        public PrediksiHamil(DateTime lastmensdate)
        {
            InitializeComponent();
            lblhpht.Text = lastmensdate.ToShortDateString();
            lblkehamilan.Text = PrediksiKehamilan(lastmensdate).ToShortDateString();
            lblovulasi.Text = PrediksiOvulasi(lastmensdate).ToShortDateString();
            lblkelahiran.Text = PrediksiKelahiran(lastmensdate).ToShortDateString();
        }

        private DateTime PrediksiKehamilan(DateTime hariterakhirmens)
        {
            return hariterakhirmens.AddDays(7);
        }

        private DateTime PrediksiKelahiran(DateTime hariterakhirmens)
        {
            // Kalkulasi Hari Pertama Haid Terakhir (HPHT)
            int year = hariterakhirmens.Year + 1;
            int day = hariterakhirmens.Day + 7;
            int month = hariterakhirmens.Month - 3;

            if (month <= 0)
            {
                month += 12;
                year -= 1;
            }

            return new DateTime(year, month, day);
        }

        private DateTime PrediksiOvulasi(DateTime hariterakhirmens)
        {
            // Kalkulasi tanggal ovulasi (14 hari setelah tanggal terakhir menstruasi)
            return hariterakhirmens.AddDays(14);
        }

        private void PrediksiHamil_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KalenderHamil hamil = new KalenderHamil();
            hamil.Show();
            this.Hide();
            hamil.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsProfil profil = new UsProfil();
            profil.Show();
            this.Hide();
            profil.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
            artikel.FormClosed += (s, args) => this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
