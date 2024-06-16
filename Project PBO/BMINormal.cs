using Project_PBO.App;
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
    public partial class BMINormal : Form
    {
        private double tinggi;
        private double berat;
        private double bmi;
        public BMINormal(double bmi, double tinggi, double berat)
        {
            InitializeComponent();
            this.tinggi = tinggi;
            this.berat = berat;
            this.bmi = bmi;
            label7.Text = "Total BMI Anda: " + bmi.ToString("0.00");
        }


        /*        private string GetBMICategory(double bmi)
               {
                   if (bmi < 18.5)
                       return "Underweight (Kurus)";
                   else if (bmi < 24.9)
                       return "Normal weight (Normal)";
                   else if (bmi < 29.9)
                       return "Overweight (Berat Badan Berlebih)";
                   else
                       return "Obesity (Obesitas)";
               }*/

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
            BMI bmi = new BMI();
            bmi.Show();
            this.Hide();
            bmi.FormClosed += (s, args) => this.Close();
        }
    }
}
