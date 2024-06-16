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
    public partial class UsProfil : Form
    {
        public UsProfil()
        {
            InitializeComponent();
        }

        private void UsProfil_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Datadiri datadiri = new Datadiri();
            datadiri.Show();
            this.Hide();
            datadiri.FormClosed += (s, args) => this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsKritik kritik = new UsKritik();
            kritik.Show();
            this.Hide();
            kritik.FormClosed += (s, args) => this.Close();

        }
    }
}
