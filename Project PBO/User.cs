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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UsProfil profil = new UsProfil();
            profil.Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UsUmum umum = new UsUmum();
            umum.Show();
            this.Hide();
            umum.FormClosed += (s, args) => this.Close();
        }// Compare this snippet from Project%20PBO/User.cs:
        // using System;
        // using System.Collections.Generic;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ibuanak iba = new Ibuanak();
            iba.Show();
            this.Hide();
            iba.FormClosed += (s, args) => this.Close();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Farmasi far = new Farmasi();
            far.Show();
            this.Hide();
            far.FormClosed += (s, args) => this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
