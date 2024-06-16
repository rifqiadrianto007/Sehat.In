using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO.App
{
    public partial class underweight : UserControl
    {
        public underweight(double tinggi, double berat, double bmi)
        {
            InitializeComponent();
            lbltinggi.Text = "Tinggi (cm): " + tinggi.ToString("0.00");
            lblberat.Text = "Berat(Kg): " + berat.ToString("0.00");
            lblbmi.Text = "Total BMI Anda: " + bmi.ToString("0.00");
        }

    }
}
