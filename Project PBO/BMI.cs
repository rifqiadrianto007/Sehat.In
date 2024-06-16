using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Project_PBO
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(textBox1.Text) / 100; // Konversi tinggi ke meter
                double weight = double.Parse(textBox2.Text);
                double bmi = weight / (height * height);

                if (bmi < 18.5)
                {
                    BMIKurus kurusbmi = new BMIKurus(bmi, height, weight);
                    kurusbmi.Show();
                    this.Hide();
                    kurusbmi.FormClosed += (s, args) => this.Close();
                }

                else if (bmi < 24.9)
                {
                    BMINormal normalbmi = new BMINormal(bmi, height, weight);
                    normalbmi.Show();
                    this.Hide();
                    normalbmi.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    BMIObesitas obesbmi = new BMIObesitas(bmi, height, weight);
                    obesbmi.Show();
                    this.Hide();
                    obesbmi.FormClosed += (s, args) => this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input tidak valid: " + ex.Message);
            }
            /* Hi*//*tungBMI hitbmi = new HitungBMI();
             hitbmi.Show();*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
